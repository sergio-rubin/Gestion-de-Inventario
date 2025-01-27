using System.Data;
using System.Data.SqlClient;

namespace GDI
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=PC-ZG\\SQLEXPRESS;Initial Catalog=gestion_de_inventario;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            String user = usuario_tb.Text;
            String pass = contra_tb.Text;

            try
            {
                connection.Open();

                String query = "SELECT * FROM login WHERE username = @user AND password = @pass";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    this.Hide();
                    menu f2 = new menu();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}