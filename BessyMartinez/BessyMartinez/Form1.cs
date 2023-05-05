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

namespace BessyMartinez
{
    public partial class FormularioInteres : Form
    {
        public FormularioInteres()
        {
            InitializeComponent();
        }

        private void capitalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            double capital;
            if (Double.TryParse(capitalTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out capital))
            {
                DateTime fecha = fechaDepositoDateTimePicker.Value;
                double tasaInteresMensual = 0.015;
                double interesGanado;

                // Limpiar el contenido del ListBox
                resultadosListBox.Items.Clear();

                for (int mes = 1; mes <= 12; mes++)
                {
                    interesGanado = capital * tasaInteresMensual * mes;
                    resultadosListBox.Items.Add(string.Format("{0} - {1:C}", fecha.AddMonths(mes).ToString("MMMM"), interesGanado));
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido en el campo de capital", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
