namespace CSharpEgitimKampi501
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProductTotalCount = new System.Windows.Forms.Label();
            this.lblMostExpensiveProduct = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLeastExpensiveProduct = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(96, 36);
            this.txtProductId.Multiline = true;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 20);
            this.txtProductId.TabIndex = 1;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(96, 180);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(100, 35);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(221, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 302);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(96, 62);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Adı:";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(96, 115);
            this.txtProductStock.Multiline = true;
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(100, 20);
            this.txtProductStock.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stok:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(96, 89);
            this.txtProductPrice.Multiline = true;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 20);
            this.txtProductPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat:";
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Location = new System.Drawing.Point(96, 141);
            this.txtProductCategory.Multiline = true;
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(100, 20);
            this.txtProductCategory.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategori:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(96, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(96, 303);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(96, 262);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(91, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Toplam Kitap Sayısı:";
            // 
            // lblProductTotalCount
            // 
            this.lblProductTotalCount.AutoSize = true;
            this.lblProductTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductTotalCount.ForeColor = System.Drawing.Color.Yellow;
            this.lblProductTotalCount.Location = new System.Drawing.Point(305, 381);
            this.lblProductTotalCount.Name = "lblProductTotalCount";
            this.lblProductTotalCount.Size = new System.Drawing.Size(24, 25);
            this.lblProductTotalCount.TabIndex = 16;
            this.lblProductTotalCount.Text = "0";
            // 
            // lblMostExpensiveProduct
            // 
            this.lblMostExpensiveProduct.AutoSize = true;
            this.lblMostExpensiveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMostExpensiveProduct.ForeColor = System.Drawing.Color.Yellow;
            this.lblMostExpensiveProduct.Location = new System.Drawing.Point(305, 415);
            this.lblMostExpensiveProduct.Name = "lblMostExpensiveProduct";
            this.lblMostExpensiveProduct.Size = new System.Drawing.Size(24, 25);
            this.lblMostExpensiveProduct.TabIndex = 18;
            this.lblMostExpensiveProduct.Text = "0";
            this.lblMostExpensiveProduct.Click += new System.EventHandler(this.lblMostExpensiveProduct_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(134, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "En Pahalı Kitap:";
            // 
            // lblLeastExpensiveProduct
            // 
            this.lblLeastExpensiveProduct.AutoSize = true;
            this.lblLeastExpensiveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLeastExpensiveProduct.ForeColor = System.Drawing.Color.Yellow;
            this.lblLeastExpensiveProduct.Location = new System.Drawing.Point(305, 450);
            this.lblLeastExpensiveProduct.Name = "lblLeastExpensiveProduct";
            this.lblLeastExpensiveProduct.Size = new System.Drawing.Size(24, 25);
            this.lblLeastExpensiveProduct.TabIndex = 20;
            this.lblLeastExpensiveProduct.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(145, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "En Ucuz Kitap:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1053, 519);
            this.Controls.Add(this.lblLeastExpensiveProduct);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMostExpensiveProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblProductTotalCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProductTotalCount;
        private System.Windows.Forms.Label lblMostExpensiveProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLeastExpensiveProduct;
        private System.Windows.Forms.Label label9;
    }
}

