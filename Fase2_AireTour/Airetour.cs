using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2_AireTour
{
    public partial class airetour : Form
    {
        Vuelo vlo;
        CultureInfo cul = new CultureInfo("es-CO");

        public airetour()
        {
            InitializeComponent();
            vlo = new Vuelo();
        }

        private void buttonRegi_Click(object sender, EventArgs e)
        {
            if (valiDatos() == true)
            {
                vlo.id = Convert.ToInt64(textBoxId.Text);
                vlo.name = textBoxName.Text;
                switch (comboBoxEst.SelectedIndex)
                {
                    case 0:
                        vlo.est = 1;
                        break;
                    case 1:
                        vlo.est = 2;
                        break;
                    case 2:
                        vlo.est = 3;
                        break;
                    case 3:
                        vlo.est = 4;
                        break;
                    case 4:
                        vlo.est = 5;
                        break;
                    case 5:
                        vlo.est = 6;
                        break;
                }

                if (radioButton1.Checked)
                {
                    vlo.des = "Bogotá";
                }
                else if (radioButton2.Checked)
                {
                    vlo.des = "Medellín";
                }
                else if (radioButton3.Checked)
                {
                    vlo.des = "Florencia";
                }
                else if (radioButton4.Checked)
                {
                    vlo.des = "Pitalito";
                }

                if (radioButtonA.Checked)
                {
                    vlo.cla = Vuelo.Cla.A;
                }
                else if (radioButtonB.Checked)
                {
                    vlo.cla = Vuelo.Cla.B;
                }
                else if (radioButtonC.Checked)
                {
                    vlo.cla = Vuelo.Cla.C;
                }

                switch (comboBoxDia.SelectedIndex)
                {
                    case 0:
                        vlo.dia = Vuelo.Dia.Lunes;
                        break;
                    case 1:
                        vlo.dia = Vuelo.Dia.Martes;
                        break;
                    case 2:
                        vlo.dia = Vuelo.Dia.Miercoles;
                        break;
                    case 3:
                        vlo.dia = Vuelo.Dia.Jueves;
                        break;
                    case 4:
                        vlo.dia = Vuelo.Dia.Viernes;
                        break;
                    case 5:
                        vlo.dia = Vuelo.Dia.Sabado;
                        break;
                    case 6:
                        vlo.dia = Vuelo.Dia.Domingo;
                        break;
                }

                if (radioButtonF.Checked)
                {
                    vlo.gen = Vuelo.Gen.Femenino;
                }
                else if (radioButtonM.Checked)
                {
                    vlo.gen = Vuelo.Gen.Masculino;
                }
            }

            textBoxTiq.Text = vlo.getValBruto().ToString("C", cul);

        }

        private bool valiDatos()
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Por favor, digite el número de identificación.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxId.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Por favor, digite el nombre.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return false;
            }

            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Por favor, elija el destino del vuelo.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupBoxDes.Focus();
                return false;
            }

            if (!radioButtonA.Checked && !radioButtonB.Checked && !radioButtonC.Checked)
            {
                MessageBox.Show("Por favor, elija la clase del vuelo.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupBoxCla.Focus();
                return false;
            }

            if (!radioButtonM.Checked && !radioButtonF.Checked)
            {
                MessageBox.Show("Por favor, elija el tipo de género.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                groupBoxGen.Focus();
                return false;
            }

            if (comboBoxDia.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, escoja el día del vuelo.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxDia.Focus();
                return false;
            }

            if (comboBoxEst.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, escoja el estrato.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxEst.Focus();
                return false;
            }

            return true;
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            Reporte rep = new Reporte();

            if (valiDatos() == true)
            {
                rep.labelId.Text = vlo.id.ToString();
                rep.labelName.Text = vlo.name;
                rep.labelGen.Text = vlo.gen.ToString();
                rep.labelDes.Text = vlo.des;
                rep.labelEst.Text = vlo.est.ToString();
                rep.labelDia.Text = vlo.dia.ToString();
                rep.labelCos.Text = vlo.getValBruto().ToString("C", cul);
                rep.labelDesc.Text = vlo.getValDes().ToString("C", cul);
                rep.labelTiq.Text = vlo.getValTotal().ToString("C", cul);
                this.Hide();

                rep.ShowDialog();
            }
        }

        private void buttonSal_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("Esta seguro que desea salir", "Salir De Aire Tour", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonRegre_Click(object sender, EventArgs e)
        {
        }
    }
}
