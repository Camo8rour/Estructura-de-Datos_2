using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2_AireTour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegi_Click(object sender, EventArgs e)
        {
            if (textBoxContra.Text != "")
            {

                if (textBoxContra.Text == "123")
                {
                    this.Hide();
                    airetour aire = new airetour();
                    aire.ShowDialog();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta");
                    textBoxContra.Text = "";
                    textBoxContra.Focus();
                }

            }
            else
            {
                MessageBox.Show("Por favor digite la contraseña");
                textBoxContra.Focus();
            }
        }
    }
}
