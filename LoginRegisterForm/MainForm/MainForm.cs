using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Online_Bank_with_Database.Forms
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Konev-PC\Documents\combobox.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        ArrayList moneyList = new ArrayList();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select username from LoginTable";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    metroComboBox1.Items.Add(dr["username"].ToString());
                    
                }
            }
            catch
            {

            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroLabel3.Visible = true;
            chosenUsernameTextBox.Visible = true;
            chosenUsernameTextBox.ReadOnly = true;
            chosenUsernameTextBox.Text = metroComboBox1.SelectedItem.ToString();
        }


    }
}
