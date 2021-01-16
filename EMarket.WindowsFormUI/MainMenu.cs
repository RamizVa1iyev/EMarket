using System;
using System.Globalization;
using System.Windows.Forms;
using Core.Business.DependencyResolvers.Ninject;
using EMarket.Business.Abstract;
using EMarket.Business.Messages;
using EMarket.Entity.Concrete;
using EMarket.Entity.Domain_Models;
using EMarket.WindowsFormUI.Helper;
using Ninject.Modules;

namespace EMarket.WindowsFormUI
{
    public partial class MainMenu : Form
    {
        private readonly NinjectModule _module;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly ICartService _cartService;
        private readonly Cart _cart;
        private Product _product;
        private Product _cartProduct;
        public MainMenu(NinjectModule module)
        {
            _module = module;
            _productService = InstanceFactory.GetInstance<IProductService>(_module);
            _cartService = InstanceFactory.GetInstance<ICartService>(_module);
            _categoryService = InstanceFactory.GetInstance<ICategoryService>(_module);
            _cart = new Cart();
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = _categoryService.GetAll();
            categories.Insert(0, new Category() { CategoryName = "All Products", Id = 0 });
            cbxSearchByCategory.DataSource = categories;
            cbxSearchByCategory.DisplayMember = "CategoryName";
            cbxSearchByCategory.ValueMember = "Id";
        }

        private void LoadProducts()
        {
            dgwBuyProducts.DataSource = _productService.GetAll();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            short quantity = Convert.ToInt16(nudProductCount.Value);
            if (_product != null)
            {
                ErrorHandlingHelper.ErrorHandler(() => _cartService.AddToCart(quantity, _product, _cart));
                LoadCart(_cart);
                LoadTotalPrice(_cart);
            }
            else
            {
                MessageBox.Show(@"Please select the product");
            }
        }

        private void LoadTotalPrice(Cart cart)
        {
            lblTotalAmount.Text = cart.TotalPrice.ToString(CultureInfo.InvariantCulture);
        }

        private void LoadCart(Cart cart)
        {
            dgwCart.DataSource = CartHelper.Converter(cart);
        }

        private void dgwBuyProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwBuyProducts.CurrentRow;
            if (row == null) return;
            _product = new Product()
            {
                Id = Convert.ToInt32(row.Cells[0].Value),
                CategoryId = Convert.ToInt32(row.Cells[1].Value),
                ProductName = row.Cells[2].Value.ToString(),
                UnitPrice = Convert.ToDecimal(row.Cells[3].Value),
                StockAmount = Convert.ToInt16(row.Cells[4].Value)
            };
        }

        private void tbxSearchByName_TextChanged(object sender, EventArgs e)
        {
            string name = tbxSearchByName.Text;
            if (!string.IsNullOrEmpty(name))
            {
                dgwBuyProducts.DataSource = _productService.GetByName(name);
            }
            else
            {
                LoadProducts();
            }
        }

        private void cbxSearchByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int categoryId = Convert.ToInt32(cbxSearchByCategory.SelectedValue);
                if (categoryId == 0)
                {
                    LoadProducts();
                }
                else
                {
                    dgwBuyProducts.DataSource = _productService.GetByCategoryId(Convert.ToInt32(categoryId));
                }
            }
            catch
            {
                // ignored
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (_cartProduct != null)
            {
                _cartService.DeleteFromCart(_cartProduct, _cart);
                LoadCart(_cart);
                LoadTotalPrice(_cart);
            }
            else
            {
                MessageBox.Show(@"Please select the product");
            }

        }

        private void dgwCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwCart.CurrentRow == null) return;
            _cartProduct = new Product()
            {
                Id = Convert.ToInt32(dgwCart.CurrentRow.Cells[0].Value)
            };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure?", @"Clearing Cart", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _cartService.Clear(_cart);
                LoadCart(_cart);
                LoadTotalPrice(_cart);
            }
        }

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            if (_cartProduct != null)
            {
                _cartService.DeleteOneFromCart(_cartProduct, _cart);
                LoadCart(_cart);
                LoadTotalPrice(_cart);
            }
            else
            {
                MessageBox.Show(ErrorMessages.NullProductMessage);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            _cartService.Sell(_cart);
            _cartService.Clear(_cart);
            LoadProducts();
            LoadCart(_cart);
            LoadTotalPrice(_cart);
            MessageBox.Show(@"Thanks for choosing us");
        }

        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            var updateProducts = new UpdateProducts(_module);
            updateProducts.ShowDialog();
            this.Close();
        }
    }
}
