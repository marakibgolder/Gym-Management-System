using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProgramDesign
{
    
    public partial class Product : Form
    {
        private static string connectionString = "Server=HP_VICTUS\\SQLEXPRESS;Database=GymManagementSystem;Trusted_Connection=True;";
        public Product()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM Products";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView.DataSource = dt; // Bind data to DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = txtProductName.Text;
                string productCategory = txtProductCategory.Text;
                int unitsOrdered = int.Parse(txtUnitsOrdered.Text);
                int unitsInStock = int.Parse(txtUnitsInStock.Text);
                int unitsSold = int.Parse(txtUnitsSold.Text);
                decimal sellingPrice = decimal.Parse(txtSellingPrice.Text);

                string query = "INSERT INTO Products (ProductName, ProductCategory, UnitsOrdered, UnitsInStock, UnitsSold, SellingPrice) " +
                               "VALUES (@ProductName, @ProductCategory, @UnitsOrdered, @UnitsInStock, @UnitsSold, @SellingPrice)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@ProductCategory", productCategory);
                        command.Parameters.AddWithValue("@UnitsOrdered", unitsOrdered);
                        command.Parameters.AddWithValue("@UnitsInStock", unitsInStock);
                        command.Parameters.AddWithValue("@UnitsSold", unitsSold);
                        command.Parameters.AddWithValue("@SellingPrice", sellingPrice);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product added successfully!");
                LoadData(); // Refresh the DataGridView
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = int.Parse(txtProductID.Text); // Ensure ProductID is filled
                string productName = txtProductName.Text;
                string productCategory = txtProductCategory.Text;
                int unitsOrdered = int.Parse(txtUnitsOrdered.Text);
                int unitsInStock = int.Parse(txtUnitsInStock.Text);
                int unitsSold = int.Parse(txtUnitsSold.Text);
                decimal sellingPrice = decimal.Parse(txtSellingPrice.Text);

                string query = "UPDATE Products SET ProductName = @ProductName, ProductCategory = @ProductCategory, " +
                               "UnitsOrdered = @UnitsOrdered, UnitsInStock = @UnitsInStock, UnitsSold = @UnitsSold, SellingPrice = @SellingPrice " +
                               "WHERE ProductID = @ProductID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@ProductCategory", productCategory);
                        cmd.Parameters.AddWithValue("@UnitsOrdered", unitsOrdered);
                        cmd.Parameters.AddWithValue("@UnitsInStock", unitsInStock);
                        cmd.Parameters.AddWithValue("@UnitsSold", unitsSold);
                        cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product updated successfully!");
                LoadData(); // Refresh data
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchKeyword = txtSearch.Text;

                if (string.IsNullOrWhiteSpace(searchKeyword))
                {
                    MessageBox.Show("Please enter a keyword to search.");
                    return;
                }

                string query = "SELECT * FROM Products WHERE ProductID LIKE @SearchKeyword OR ProductCategory LIKE @SearchKeyword";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    da.SelectCommand.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for products: {ex.Message}");
            }
        }

        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtProductCategory.Clear();
            txtUnitsOrdered.Clear();
            txtUnitsInStock.Clear();
            txtUnitsSold.Clear();
            txtSellingPrice.Clear();
            txtSearch.Clear();
            txtProductID.Focus();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // Populate text boxes with the data from the selected row
                txtProductID.Text = row.Cells["ProductID"].Value?.ToString();        // Replace "ProductID" with your column name
                txtProductName.Text = row.Cells["ProductName"].Value?.ToString();   // Replace "ProductName" with your column name
                txtProductCategory.Text = row.Cells["ProductCategory"].Value?.ToString(); // Replace "ProductCategory" with your column name
                txtUnitsOrdered.Text = row.Cells["UnitsOrdered"].Value?.ToString(); // Replace "UnitsOrdered" with your column name
                txtUnitsInStock.Text = row.Cells["UnitsInStock"].Value?.ToString(); // Replace "UnitsInStock" with your column name
                txtUnitsSold.Text = row.Cells["UnitsSold"].Value?.ToString();       // Replace "UnitsSold" with your column name
                txtSellingPrice.Text = row.Cells["SellingPrice"].Value?.ToString(); // Replace "SellingPrice" with your column name
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int productID = int.Parse(txtProductID.Text);

                string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Product deleted successfully!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}");
            }
        }
    }
}
