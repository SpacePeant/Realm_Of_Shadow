using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealmOfShadow
{
    public partial class Login : Form
    {
        public MySqlConnection MySqlConnection;
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            //MySqlConnection = new MySqlConnection("server = localhost; uid = root; pwd = ; database = alp_penjualantiketkonser");
            //MySqlConnection.Open();
        }
        private void btn_Play_Click(object sender, EventArgs e)
        {
            MainHub mainHub = new MainHub();
            mainHub.Show();
            this.Hide();
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {

        }
    }
}
