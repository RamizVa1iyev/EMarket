using System;
using System.Windows.Forms;
using Core.Business.DependencyResolvers.Ninject;
using EMarket.Business.Abstract;
using EMarket.Entity.Concrete;
using EMarket.WindowsFormUI.Helper;
using Ninject.Modules;

namespace EMarket.WindowsFormUI
{
    public partial class UpdateProducts : Form
    {
        private readonly NinjectModule _module;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public UpdateProducts(NinjectModule module)
        {
            InitializeComponent();
            _module = module;
            _productService = InstanceFactory.GetInstance<IProductService>(_module);
            _categoryService = InstanceFactory.GetInstance<ICategoryService>(_module);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ErrorHandlingHelper.ErrorHandler(() =>
            {
                if (dgwProducts.CurrentRow != null)
                {
                    var product = new Product()
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
                    };
                    _productService.Delete(product);
                }
                MessageBox.Show(@"Product Deleted!");
                LoadProducts();
            });
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainMenu = new MainMenu(_module);
            mainMenu.ShowDialog();
            this.Close();
        }

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadSearchCategories();
            LoadAddCategories();
            LoadUpdateCategories();
        }

        private void LoadUpdateCategories()
        {
            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "Id";
        }

        private void LoadAddCategories()
        {
            cbxAddCategory.DataSource = _categoryService.GetAll();
            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "Id";
        }

        private void LoadSearchCategories()
        {
            var categories = _categoryService.GetAll();
            categories.Insert(0, new Category() { CategoryName = "All Products", Id = 0 });
            cbxSearchByCategory.DataSource = categories;
            cbxSearchByCategory.DisplayMember = "CategoryName";
            cbxSearchByCategory.ValueMember = "Id";
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }

        private void tbxSearchByName_TextChanged(object sender, EventArgs e)
        {
            string name = tbxSearchByName.Text;
            if (name != "")
            {
                dgwProducts.DataSource = _productService.GetByName(name);
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
                    dgwProducts.DataSource = _productService.GetByCategoryId(categoryId);
                }
            }
            catch
            {
                // ignored
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ErrorHandlingHelper.ErrorHandler(() =>
            {
                var product = new Product()
                {
                    CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    ProductName = tbxAddName.Text,
                    UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                    StockAmount = Convert.ToInt16(tbxAddUnitsInStock.Text)
                };
                _productService.Add(product);
                MessageBox.Show(product.ProductName+@" Added!");
                LoadProducts();
            });
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProducts.CurrentRow;
            if (row == null) return;
            cbxUpdateCategory.SelectedValue = row.Cells[1].Value;
            tbxUpdateName.Text = row.Cells[2].Value.ToString();
            tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUpdateUnitsInStock.Text = row.Cells[4].Value.ToString();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            ErrorHandlingHelper.ErrorHandler(() =>
            {
                if (dgwProducts.CurrentRow != null)
                {
                    var product = new Product()
                    {
                        Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                        ProductName =tbxUpdateName.Text,
                        CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                        StockAmount = Convert.ToInt16(tbxUpdateUnitsInStock.Text),
                        UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text)
                    };
                    _productService.Update(product);
                }

                MessageBox.Show(@"Product Updated!");
                LoadProducts();
            });
        }
    }
}
