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
    public partial class MainHub : Form
    {
        int step = 10;
        int testing = 10;
        public MainHub()
        {
            InitializeComponent();
            
        }

        private void MainHub_Load(object sender, EventArgs e)
        {
            Controls.Add(pb_UserCharacter);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(OnKeyDown);

            try
            {
               
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.W: 
                    pb_UserCharacter.Top -= step;
                    break;
                case Keys.S: 
                    pb_UserCharacter.Top += step;
                    break;
                case Keys.A: 
                    pb_UserCharacter.Left -= step;
                    break;
                case Keys.D:
                    pb_UserCharacter.Left += step;
                    break;
            }
        }

    }
}
