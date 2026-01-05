using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=EMIRHAN\\SQLEXPRESS;initial Catalog=EgitimKampi501Db; integrated security=true;");

        private async void label1_Click(object sender, EventArgs e)
        {
        }

        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "Select * From TblProduct";
            var values = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;
        }

        // Change the signature of btnAdd_Click to match the expected EventHandler delegate
        private async void btnAdd_Click(object sender, EventArgs e)
        {

            string query = "insert into TblProduct (ProductName, ProductStock, ProductPrice, ProductCategory) values (@productName, @productStock, @productPrice, @productCategory)";

            var parametres = new DynamicParameters();

            parametres.Add("@productName", txtProductName.Text);

            parametres.Add("@productStock", txtProductStock.Text);

            parametres.Add("@productPrice", txtProductPrice.Text);

            parametres.Add("@productCategory", txtProductCategory.Text);

            await connection.ExecuteAsync(query, parametres);

            MessageBox.Show("Ürün eklendi.");

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete From TblProduct where ProductId=@productId";
            var parametres = new DynamicParameters();
            parametres.Add("@productId", txtProductId.Text);
            await connection.ExecuteAsync(query, parametres);
            MessageBox.Show("Ürün silindi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update TblProduct Set ProductName=@productName, ProductStock=@productStock, ProductPrice=@productPrice, ProductCategory=@productCategory where ProductId=@productId";
            var parametres = new DynamicParameters();
            parametres.Add("@productId", txtProductId.Text);
            parametres.Add("@productName", txtProductName.Text);
            parametres.Add("@productStock", txtProductStock.Text);
            parametres.Add("@productPrice", txtProductPrice.Text);
            parametres.Add("@productCategory", txtProductCategory.Text);
            connection.ExecuteAsync(query, parametres);
            MessageBox.Show("Ürün güncellendi.");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query = "Select Count(*) From TblProduct";
            var productTotalCount = await connection.QueryAsync<int>(query);
            lblProductTotalCount.Text = productTotalCount.AsList()[0].ToString();

            string query2 = "Select ProductName from TblProduct Where ProductPrice= (Select Max(ProductPrice) From TblProduct)";
            var mostExpensiveProduct = await connection.QueryAsync<string>(query2);
            lblMostExpensiveProduct.Text = mostExpensiveProduct.AsList()[0];

            string query3 = "Select ProductName from TblProduct Where ProductPrice= (Select Min(ProductPrice) From TblProduct)";
            var leastExpensiveProduct = await connection.QueryAsync<string>(query3);
            lblLeastExpensiveProduct.Text = leastExpensiveProduct.AsList()[0];
        }

        private void lblMostExpensiveProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
