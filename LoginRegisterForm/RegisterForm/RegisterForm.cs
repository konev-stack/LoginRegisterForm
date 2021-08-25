using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Online_Bank_with_Database
{
    public partial class RegisterForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.PasswordChar = '*';
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            ConPasswordTextBox.Text = "";
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Konev-PC\Documents\combobox.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            if (ConPasswordTextBox.Text != string.Empty || passwordTextBox.Text != string.Empty || usernameTextBox.Text != string.Empty)
            {
                if (passwordTextBox.Text == ConPasswordTextBox.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + usernameTextBox.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", usernameTextBox.Text);
                        cmd.Parameters.AddWithValue("password", passwordTextBox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void moneyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                passwordTextBox.PasswordChar = '\0';
                ConPasswordTextBox.UseSystemPasswordChar = false;
                ConPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
                ConPasswordTextBox.PasswordChar = '*';
            }
        }
    }
}