using Guia9._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia9._1
{
    public partial class Form1 : Form
    {
        FiscalizadorVtv fisca = new FiscalizadorVtv();
        FormVer ver = new FormVer();
        public Form1()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            FormEvaluacion evaluacion = new FormEvaluacion();
            try
            {
                ver = new FormVer();
                string nombre = tbNombre.Text;
                int dni = Convert.ToInt32(tbDni.Text);
                string patente = tbPatente.Text;
                DateTime fecha = dateTimePicker1.Value;
                string correo = tbCorreo.Text;
                Propietario pro = new Propietario(dni, nombre, correo);
                VTV actual = fisca.AgregarVTV(patente, pro, fecha);
                for (int i=0; i < actual.CantidadEvaluaciones; i++)
                {
                    Evaluacion ahora = actual[i];
                    if(ahora is EvaluacionParametrica)
                    {
                        evaluacion.gbSimple.Enabled = false;
                        evaluacion.gbParametrica.Enabled = true;
                        EvaluacionParametrica ev = (EvaluacionParametrica)actual[i];
                        evaluacion.tbNombre.Text = ev.Nombre;
                        evaluacion.tbDescripcion.Text = ev.Descripcion;
                        evaluacion.tbMinimo.Text = ev.ValorMinimo.ToString();
                        evaluacion.tbMaximo.Text = ev.ValorMaximo.ToString();
                        evaluacion.lbUnidad.Text = ev.Unidad;
                        if (evaluacion.ShowDialog() == DialogResult.OK)
                        {
                            ev.ValorMedido = double.Parse(evaluacion.tbMedido.Text);
                            evaluacion.tbMedido.Clear();
                        }
                    }
                    else
                    {
                        evaluacion.gbParametrica.Enabled = false;
                        evaluacion.gbSimple.Enabled = true;
                        EvaluacionSimple ev = (EvaluacionSimple)actual[i];
                        evaluacion.tbNombre.Text = ev.Nombre;
                        evaluacion.tbDescripcion.Text = ev.Descripcion;
                        if (evaluacion.ShowDialog() == DialogResult.OK)
                        {
                            ev.HaVerificado = evaluacion.cbFuncionamiento.Checked;
                        }
                    }

                }

                foreach (string j in actual.EmitirComprobante())
                {
                    ver.tbVer.Text += $"{j}\r\n";
                }
                ver.tbVer.Text += $"\r\n\r\n";
                ver.ShowDialog();
                btnVer.Enabled = true;
            }
            catch(Idni ee)
            {
                MessageBox.Show(ee.Message);
            }
            catch(Iemail z)
            {
                MessageBox.Show(z.Message);
            }
            catch(Ipatente pa)
            {
                MessageBox.Show(pa.Message);
            }
            catch
            {
                MessageBox.Show("Excepcion desconocida");
            }
            finally
            {
                tbNombre.Clear();
                tbDni.Clear();
                tbCorreo.Clear();
                tbPatente.Clear();
                dateTimePicker1.DataBindings.Clear();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ver.tbVer.Clear();
            for(int i=0; i<fisca.CantidadVTVs; i++)
            {
                VTV actual = fisca[i];
                ver.tbVer.Text += $"{actual.ToString()}\r\n";
            }
            ver.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ver.tbVer.Clear();
            string patente = tbPatente.Text;
            List<VTV> actual = fisca.VerVTVPorPatente(patente);
            foreach(VTV j in actual )
            {
                ver.tbVer.Text += $"{j.ToString()}\r\n";
            }
           
            ver.ShowDialog();
        }
    }
}
