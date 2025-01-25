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
    public partial class TrainingSession : Form
    {
        private static string connectionString = "Server=HP_VICTUS\\SQLEXPRESS;Database=GymManagementSystem;Trusted_Connection=True;";
        public TrainingSession()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM TrainingSessions";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView.DataSource = dt; // Bind data to DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sessionName = txtSessionName.Text;
                decimal price = decimal.Parse(txtPrice.Text); 
                string category = txtCategory.Text;
                int trainerID = int.Parse(txtTrainerID.Text); 
                string trainerName = txtTrainerName.Text;
                DateTime dateAndTime = dateTimePicker.Value;

                string conflictCheckQuery = "SELECT COUNT(*) FROM TrainingSessions WHERE TrainerID = @TrainerID AND DateAndTime = @DateAndTime";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand conflictCommand = new SqlCommand(conflictCheckQuery, connection))
                    {
                        conflictCommand.Parameters.AddWithValue("@TrainerID", trainerID);
                        conflictCommand.Parameters.AddWithValue("@DateAndTime", dateAndTime);

                        connection.Open();
                        int conflictCount = (int)conflictCommand.ExecuteScalar();

                        if (conflictCount > 0)
                        {
                            MessageBox.Show("The trainer is already scheduled for another session at the same time. Please choose a different time.");
                            return;
                        }
                    }

                    string query = "INSERT INTO TrainingSessions (SessionName, Price, Category, TrainerID, TrainerName, DateAndTime) " +
                                   "VALUES (@SessionName, @Price, @Category, @TrainerID, @TrainerName, @DateAndTime)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SessionName", sessionName);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@TrainerID", trainerID);
                        command.Parameters.AddWithValue("@TrainerName", trainerName);
                        command.Parameters.AddWithValue("@DateAndTime", dateAndTime);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Training session added successfully!");
                LoadData(); // Refresh data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int trainingSessionID = int.Parse(txtTrainingSessionID.Text); // Ensure TrainingSessionID is filled
                string sessionName = txtSessionName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                string category = txtCategory.Text;
                int trainerID = int.Parse(txtTrainerID.Text);
                string trainerName = txtTrainerName.Text;
                DateTime dateAndTime = dateTimePicker.Value; // Get the selected date and time

                string query = "UPDATE TrainingSessions SET SessionName = @SessionName, Price = @Price, Category = @Category, " +
                               "TrainerID = @TrainerID, TrainerName = @TrainerName, DateAndTime = @DateAndTime " +
                               "WHERE TrainingSessionID = @TrainingSessionID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TrainingSessionID", trainingSessionID);
                        cmd.Parameters.AddWithValue("@SessionName", sessionName);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@TrainerID", trainerID);
                        cmd.Parameters.AddWithValue("@TrainerName", trainerName);
                        cmd.Parameters.AddWithValue("@DateAndTime", dateAndTime);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Training session updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Please check if the TrainingSessionID exists.");
                        }
                    }
                }

                LoadData(); // Refresh data
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int trainingSessionID = int.Parse(txtTrainingSessionID.Text); // Ensure TrainingSessionID is filled

                string query = "DELETE FROM TrainingSessions WHERE TrainingSessionID = @TrainingSessionID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TrainingSessionID", trainingSessionID);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Training session deleted successfully!");
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
                string searchKeyword = txtSearch.Text;  // Get search keyword from a textbox

                if (string.IsNullOrWhiteSpace(searchKeyword))
                {
                    MessageBox.Show("Please enter a keyword to search.");
                    return;
                }

                string query = "SELECT * FROM TrainingSessions WHERE SessionName LIKE @SearchKeyword OR Category LIKE @SearchKeyword";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@SearchKeyword", "%" + searchKeyword + "%");
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView.DataSource = dt; // Bind search results to DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnClearTrainingSessionFields_Click(object sender, EventArgs e)
        {
            txtTrainingSessionID.Clear();
            txtSessionName.Clear();
            txtPrice.Clear();
            txtCategory.Clear();
            txtTrainerID.Clear();
            txtTrainerName.Clear();
            dateTimePicker.Value = DateTime.Now; // Reset to the current date and time

            // Optionally, set focus to the first field
            txtSessionName.Focus();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // Hide current form
                ManagerMain mainForm = new ManagerMain();
                mainForm.Show(); // Open the main form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            try
            {
                this.Hide(); // Hide current form
                ReceptionistMain mainForm = new ReceptionistMain();
                mainForm.Show(); // Open the main form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                    txtTrainingSessionID.Text = row.Cells["TrainingSessionID"].Value.ToString();
                    txtSessionName.Text = row.Cells["SessionName"].Value.ToString();
                    txtPrice.Text = row.Cells["Price"].Value.ToString();
                    txtCategory.Text = row.Cells["Category"].Value.ToString();
                    txtTrainerID.Text = row.Cells["TrainerID"].Value.ToString();
                    txtTrainerName.Text = row.Cells["TrainerName"].Value.ToString();
                    dateTimePicker.Value = Convert.ToDateTime(row.Cells["DateAndTime"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
