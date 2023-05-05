using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BessyMartinez
{
    public partial class FormularioNumeros : Form
    {
        public FormularioNumeros()
        {
            InitializeComponent();
        }

        private void mostrarButton_Click(object sender, EventArgs e)
        {
            // Mostrar números del 1 al 100
            for (int i = 1; i <= 100; i++)
            {
                // Verificar si es múltiplo de 3, de 5 o de ambos
                if (i % 3 == 0 && i % 5 == 0)
                {
                    resultadosListBox.Items.Add($"{i}: Juan Matute");
                }
                else if (i % 3 == 0)
                {
                    resultadosListBox.Items.Add($"{i}: Juan");
                }
                else if (i % 5 == 0)
                {
                    resultadosListBox.Items.Add($"{i}: Matute");
                }
                else
                {
                    resultadosListBox.Items.Add(i);
                }
            }
        }

        private void FormularioNumeros_Load(object sender, EventArgs e)
        {

        }
    }
}
