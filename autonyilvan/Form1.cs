using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace autonyilvan
{
    public partial class Nyito : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public Nyito()
        {
            InitializeComponent();
        }

        private void Nyito_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "autok";
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                // terv szerint
                conn.Open();
                cmd=conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                // váratlan hiba
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
                throw;
            }
            finally
            {
                //hiba és terv szerinti esetén is lefut
                conn.Close();
            }
            Autok_list_update();
        }
        /*
         * public void autok_list_update
         */
        private void Autok_list_update()
        {
            autoklista.Items.Clear();
            cmd.CommandText="SELECT `id`,`rendszám`,`üzembehelyezve`,`szín` FROM `autok` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    auto uj = new auto(dr.GetInt32("id"), dr.GetString("rendszám"), dr.GetInt32("üzembehelyezve"), dr.GetString("szín"));
                    autoklista.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void ujautofel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rendszamtxt.Text))
            {
                MessageBox.Show("adjon meg rendszámot");
                rendszamtxt.Focus();
                return;
            }
            if (evnum.Value>DateTime.Now.Year)
            {
                MessageBox.Show("Érvénytelen évjárat");
                evnum.Value=DateTime.Now.Year;
                evnum.Focus();
                return;
            }
            if (string.IsNullOrEmpty(szintxt.Text))
            {
                MessageBox.Show("Nem adott meg színt");
                szintxt.Focus();
                return;
            }
            // Kiirjuk az adatbázisba
            cmd.CommandText = "INSERT INTO `autok` (`id`, `rendszám`, `üzembehelyezve`, `szín`) VALUES (NULL, @rendszam, @ev, @szin)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@rendszam", rendszamtxt.Text);
            cmd.Parameters.AddWithValue("@ev", evnum.Value.ToString());
            cmd.Parameters.AddWithValue("@szin", szintxt.Text);
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Sikeresen rögzitettük az adatait");
                    idtxt.Text = "";
                    rendszamtxt.Text = "";
                    evnum.Value = evnum.Minimum;
                    szintxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Sikertelen a rögzités");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            Autok_list_update();

        }
    }
}
