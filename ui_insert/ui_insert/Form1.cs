using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_insert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            int factura = int.Parse(facturaTxt.Text);
            string condicion = condTxt.Text;
            string cliente = idTxt.Text;
            string fecha = dateTxt.Text;
            double monto = double.Parse(montoTxt.Text);
            string estado = stsTxt.Text;

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = $"insert.py {factura} \"{condicion}\" \"{cliente}\" {fecha} {monto} \"{estado}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = new Process())
                {
                    process.StartInfo = psi;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    string errorOutput = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    if (errorOutput.Length > 0)
                    {
                        MessageBox.Show("Ocurrió un error: " + errorOutput);
                    }
                    else
                    {
                        MessageBox.Show("Información guardada exitosamente.");
                        facturaTxt.Clear();
                        condTxt.Clear();
                        idTxt.Clear();
                        dateTxt.Clear();
                        montoTxt.Clear();
                        stsTxt.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
