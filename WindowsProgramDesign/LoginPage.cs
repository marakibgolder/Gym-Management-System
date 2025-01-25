using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProgramDesign
{
    public partial class Home : Form
    {
        private static string connectionString = "Server=HP_VICTUS\\SQLEXPRESS;Database=GymManagementSystem;Trusted_Connection=True;";
        SqlConnection connection = new SqlConnection(connectionString); 
        private bool isPasswordVisible = false;

        public Home()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateUser(username, password))
            {
                string role = GetUserRole(username);
                if (role == "Manager")
                {
                    // Redirect to Manager Dashboard
                    ManagerMain managerForm = new ManagerMain();
                    managerForm.Show();
                    this.Hide();
                }
                else if (role == "Receptionist")
                {
                    // Redirect to Receptionist Dashboard
                    ReceptionistMain receptionistForm = new ReceptionistMain();
                    receptionistForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();


        }

        private bool ValidateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Password FROM Users WHERE Username = @Username AND Status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string storedPassword = result.ToString();
                        // Compare the plain text password
                        if (password == storedPassword)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private string GetUserRole(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Role FROM Users WHERE Username = @Username AND Status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    return cmd.ExecuteScalar()?.ToString();
                }
     
            }
        }


        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            // If the password should be visible
            if (isPasswordVisible)
            {
                txtPassword.PasswordChar = '\0';  // Show password (no masking)
                btnShowPassword.Text = "Hide Password";  // Change button text to "Hide Password"
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShowPassword.Text = "Show Password";
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog(); // Open the Forgot Password form
        }

        private void cbox_rememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_rememberMe.Checked)
            {
                // Save the user credentials for future logins
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save(); // Persist the settings
                MessageBox.Show("Your login credentials will be remembered.", "Remember Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Clear the stored credentials
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Username = string.Empty;
                Properties.Settings.Default.Password = string.Empty;
                Properties.Settings.Default.Save(); // Persist the settings
                MessageBox.Show("Your login credentials will not be remembered.", "Remember Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
