
namespace EMarket.WindowsFormUI
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwBuyProducts = new System.Windows.Forms.DataGridView();
            this.btnBuy = new System.Windows.Forms.Button();
            this.dgwCart = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.tbxSearchByName = new System.Windows.Forms.TextBox();
            this.lblSearchByCategory = new System.Windows.Forms.Label();
            this.cbxSearchByCategory = new System.Windows.Forms.ComboBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnDeleteOne = new System.Windows.Forms.Button();
            this.nudProductCount = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnUpdateProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBuyProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBuyProducts
            // 
            this.dgwBuyProducts.AllowUserToResizeColumns = false;
            this.dgwBuyProducts.AllowUserToResizeRows = false;
            this.dgwBuyProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBuyProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBuyProducts.Location = new System.Drawing.Point(75, 91);
            this.dgwBuyProducts.Name = "dgwBuyProducts";
            this.dgwBuyProducts.Size = new System.Drawing.Size(772, 167);
            this.dgwBuyProducts.TabIndex = 0;
            this.dgwBuyProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBuyProducts_CellClick);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(744, 264);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(103, 33);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // dgwCart
            // 
            this.dgwCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCart.Location = new System.Drawing.Point(75, 312);
            this.dgwCart.Name = "dgwCart";
            this.dgwCart.Size = new System.Drawing.Size(772, 155);
            this.dgwCart.TabIndex = 2;
            this.dgwCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCart_CellClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(70, 483);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(153, 26);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Amount :";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(229, 483);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(54, 26);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "0.00";
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByName.Location = new System.Drawing.Point(566, 9);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(113, 17);
            this.lblSearchByName.TabIndex = 5;
            this.lblSearchByName.Text = "Search by Name";
            // 
            // tbxSearchByName
            // 
            this.tbxSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchByName.Location = new System.Drawing.Point(726, 9);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(121, 23);
            this.tbxSearchByName.TabIndex = 6;
            this.tbxSearchByName.TextChanged += new System.EventHandler(this.tbxSearchByName_TextChanged);
            // 
            // lblSearchByCategory
            // 
            this.lblSearchByCategory.AutoSize = true;
            this.lblSearchByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByCategory.Location = new System.Drawing.Point(566, 47);
            this.lblSearchByCategory.Name = "lblSearchByCategory";
            this.lblSearchByCategory.Size = new System.Drawing.Size(133, 17);
            this.lblSearchByCategory.TabIndex = 7;
            this.lblSearchByCategory.Text = "Search by Category";
            // 
            // cbxSearchByCategory
            // 
            this.cbxSearchByCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchByCategory.FormattingEnabled = true;
            this.cbxSearchByCategory.Location = new System.Drawing.Point(726, 47);
            this.cbxSearchByCategory.Name = "cbxSearchByCategory";
            this.cbxSearchByCategory.Size = new System.Drawing.Size(121, 24);
            this.cbxSearchByCategory.TabIndex = 8;
            this.cbxSearchByCategory.SelectedIndexChanged += new System.EventHandler(this.cbxSearchByCategory_SelectedIndexChanged);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Location = new System.Drawing.Point(853, 351);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(103, 33);
            this.btnDeleteAll.TabIndex = 9;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOne.Location = new System.Drawing.Point(853, 312);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(103, 33);
            this.btnDeleteOne.TabIndex = 10;
            this.btnDeleteOne.Text = "Delete One";
            this.btnDeleteOne.UseVisualStyleBackColor = true;
            this.btnDeleteOne.Click += new System.EventHandler(this.btnDeleteOne_Click);
            // 
            // nudProductCount
            // 
            this.nudProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProductCount.Location = new System.Drawing.Point(659, 268);
            this.nudProductCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProductCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProductCount.Name = "nudProductCount";
            this.nudProductCount.Size = new System.Drawing.Size(63, 26);
            this.nudProductCount.TabIndex = 11;
            this.nudProductCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudProductCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(853, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 33);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(853, 434);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(103, 33);
            this.btnFinish.TabIndex = 13;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnUpdateProducts
            // 
            this.btnUpdateProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProducts.Location = new System.Drawing.Point(853, 91);
            this.btnUpdateProducts.Name = "btnUpdateProducts";
            this.btnUpdateProducts.Size = new System.Drawing.Size(103, 53);
            this.btnUpdateProducts.TabIndex = 14;
            this.btnUpdateProducts.Text = "Update Products";
            this.btnUpdateProducts.UseVisualStyleBackColor = true;
            this.btnUpdateProducts.Click += new System.EventHandler(this.btnUpdateProducts_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 528);
            this.Controls.Add(this.btnUpdateProducts);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.nudProductCount);
            this.Controls.Add(this.btnDeleteOne);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.cbxSearchByCategory);
            this.Controls.Add(this.lblSearchByCategory);
            this.Controls.Add(this.tbxSearchByName);
            this.Controls.Add(this.lblSearchByName);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgwCart);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.dgwBuyProducts);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBuyProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBuyProducts;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView dgwCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.TextBox tbxSearchByName;
        private System.Windows.Forms.Label lblSearchByCategory;
        private System.Windows.Forms.ComboBox cbxSearchByCategory;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnDeleteOne;
        private System.Windows.Forms.NumericUpDown nudProductCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnUpdateProducts;
    }
}

