using System;
using System.Data.SqlClient;
using Online_Bank_with_Database.Forms;
using System.Windows.Forms;

namespace Online_Bank_with_Database
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Konev-PC\Documents\combobox.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.PasswordChar = '*';
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != string.Empty || usernameTextBox.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + usernameTextBox.Text + "' and password='" + passwordTextBox.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    MainForm form = new MainForm();
                    form.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }
    }
}
