using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TP1ProbabilidadYEstadistica
{
    public partial class Estadistica : Form
    {
        public Estadistica()
        {
            InitializeComponent();
        }


        

        private void btn_AgregarDato_Click(object sender, EventArgs e)
        {
          
            if (rdb_Agrupados.Checked == true)
            {
                int validar = 0;
                try
                {
                    Convert.ToInt32(txt_Frecuencia.Text);
                    validar = 1;
                    if (Convert.ToInt32(txt_Frecuencia.Text) == 0)
                    {
                        MessageBox.Show("No se permite el valor 0 en la frecuencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validar = 0;
                    }
                    else if (validar == 1)
                    {
                        AgregarDatoAgrupado();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Tiene que ingresar un valor en la frecuencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
               
                    
               

            }
            else if (rdb_Desagrupados.Checked == true)
            {
                
                    AgregarDatoDesagrupado();  
                
                       
               
            }                      
        }

        //Calculo total 
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            DialogResult iniciarPrograma = MessageBox.Show("Si acepta no podra ingresar mas datos en la tabla", "INICIAR CALCULOS", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (iniciarPrograma == DialogResult.OK)
            {
                txt_Datos.Enabled = false;
                txt_Frecuencia.Enabled = false;
                btn_AgregarDato.Enabled = false;
                btn_Calcular.Enabled = false;

                if (rdb_Agrupados.Checked == true)
                {
                    dgv_Datos.Sort(dgv_Datos.Columns[0], ListSortDirection.Ascending);

                    Calcular();
                    graficoDatos();
                }                
                else
                {
                    SacoValoresUnicosYTablaDesagrupados();
                 
                    Calcular();
                    graficoDatos();
                }              
            }
            btn_Calcular.Enabled = false;
            btn_HacerGrafico.Enabled = true;
            rdb_Agrupados.Enabled = false;
                        
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ValidarDatos(object sender, KeyPressEventArgs e)
        {
            Funcion.NumerosSolo(e);
        }       
        private void rdb_Agrupados_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Agrupados.Checked == true)
            {
                txt_Frecuencia.Visible = true;
                label3.Visible = true;
                          
                txt_Datos.Select();
            }
        }      
        private void ValidarDato2(object sender, KeyPressEventArgs e)
        {
            Funcion.NumerosSolo(e);
        }

        private void btn_HacerGrafico_Click(object sender, EventArgs e)
        {
            Grafico grafico = new Grafico(Variables.listaDatosGrafico, Variables.listaFrecuenciaGrafico);
            grafico.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Datos.Select();
        }

        private void btn_AgregarDesagrupado_Click_1(object sender, EventArgs e)
        {
            AgregarDatoDesagrupado();
        }
        private void validarDato3(object sender, KeyPressEventArgs e)
        {
            Funcion.NumerosSolo(e);
        }        
        private void AgregarDatoAgrupado()
        {
            if (txt_Datos.Text == "" || txt_Frecuencia.Text == "")
            {
                MessageBox.Show("Error al ingresar los datos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else
            {
                btn_Calcular.Enabled = true;
                rdb_Agrupados.Enabled = false;
                rdb_Desagrupados.Enabled = false;
                Variables.listaDatos.Add(Convert.ToInt32(txt_Datos.Text.Trim()));
                Variables.listaFrecuencia.Add(Convert.ToInt32(txt_Frecuencia.Text.Trim()));
                
                int tempValidar = 0;
                int validoDato = 0;
                for (int i = 0; i < Variables.listaDatos.Count; i++)
                {
                    
                    for (int j = 0; j < Variables.listaDatos.Count; j++)
                    {

                        if (Variables.listaDatos[i] == Variables.listaDatos[j])
                        {
                            tempValidar++;
                            if (tempValidar >= 2)
                            {
                                MessageBox.Show("Ese dato ya esta ingresado","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                double borrarDato = Variables.listaDatos.Count();
                               
                                Variables.listaDatos.RemoveAt(Convert.ToInt32(borrarDato)-1);

                                double borrarFrecuencia = Variables.listaFrecuencia.Count();
                                Variables.listaFrecuencia.RemoveAt(Convert.ToInt32(borrarFrecuencia)-1);
                                validoDato = 1;
                                
                            }
                        }

                    }
                    tempValidar = 0;
                }
                
                txt_Datos.Clear();
                txt_Frecuencia.Clear();
                txt_Datos.Focus();
                if (validoDato == 0)
                {
                    Variables.listaDatosFinal = Variables.listaDatos;
                    Variables.listaFrecuenciaFinal = Variables.listaFrecuencia;
                    dgv_Datos.Rows.Add(1);

                    for (int i = 0; i < Variables.listaDatos.Count; i++)
                    {
                        dgv_Datos[0, i].Value = Variables.listaDatos[i];
                        dgv_Datos[1, i].Value = Variables.listaFrecuencia[i];
                    }
                }
                

            }

        }
        
        private void TablaYDatosYFrecuenciaAgrupados()
        {
            dgv_Datos.Rows.Clear();
            foreach (double dato in Variables.listaDatos)
            {
                dgv_Datos.Rows.Add();
            }

            
            dgv_Datos.ClearSelection();

            for (int i = 0; i < Variables.listaDatos.Count; i++)
            {
                dgv_Datos.Rows[i].Cells[0].Value = Variables.listaDatos[i];

                dgv_Datos.Rows[i].Cells[1].Value = Variables.listaFrecuencia[i];
            }                       
        }
          
        //Funcion principal
        private void Calcular()
        {
            dgv_Datos.Sort(dgv_Datos.Columns[0], ListSortDirection.Ascending);

            //Frecuencia acumulada
            for (int i = 0; i < dgv_Datos.Rows.Count; i++)
            {                
                Variables.sumaFrecuencia += Convert.ToInt32(dgv_Datos.Rows[i].Cells[1].Value);
                dgv_Datos.Rows[i].Cells[2].Value = Variables.sumaFrecuencia;
            }
            lbl_TotalFrecuencia.Text = Variables.sumaFrecuencia.ToString();
            //X.F
            for (int i = 0; i < dgv_Datos.Rows.Count; i++)
            {
                Variables.multiplicacion = Convert.ToInt32(dgv_Datos.Rows[i].Cells[0].Value) * Convert.ToInt32(dgv_Datos.Rows[i].Cells[1].Value);
                dgv_Datos.Rows[i].Cells[3].Value = Variables.multiplicacion;
                Variables.promedio += Variables.multiplicacion;
            }

            lbl_TotalXPorF.Text = Variables.promedio.ToString();

            //Promedio
            
            Variables.promedio = Variables.promedio / Variables.sumaFrecuencia;
            lbl_Promedio.Text = Math.Round(Variables.promedio, 4).ToString();

            //Variancia
            for (int i = 0; i < dgv_Datos.Rows.Count; i++)
            {
                Variables.variancia = Math.Pow(Convert.ToInt32(dgv_Datos.Rows[i].Cells[0].Value) - Variables.promedio, 2) * Convert.ToInt32(dgv_Datos.Rows[i].Cells[1].Value);
                Variables.totalVariancia = Variables.totalVariancia + Variables.variancia;
                dgv_Datos.Rows[i].Cells[4].Value = Math.Round(Variables.variancia, 4);
            }
            Variables.varianciaFinal = Variables.totalVariancia / Variables.sumaFrecuencia;
            lbl_Variancia.Text = Math.Round(Variables.varianciaFinal, 3).ToString();

            //desvio standard
            Variables.desvioStanard = Math.Sqrt(Variables.varianciaFinal);
            lbl_DesvioStandard.Text = Math.Round(Variables.desvioStanard, 3).ToString();


            //CV
            Variables.coeficienteVariacion = Variables.desvioStanard / Variables.promedio;
            lbl_CoeficienteVariacion.Text = Math.Round(Variables.coeficienteVariacion, 4).ToString();


            //mediana
            Variables.mediana = Convert.ToInt32(dgv_Datos.Rows[(dgv_Datos.RowCount / 2)].Cells[0].Value);
            lbl_Mediana.Text = Variables.mediana.ToString();

            ////moda
            for (int i = 0; i < dgv_Datos.Rows.Count; i++)
            {
                if (Variables.frecuenciaMaxima < Convert.ToInt32(dgv_Datos.Rows[i].Cells[1].Value))
                {
                    Variables.frecuenciaMaxima = Convert.ToInt32(dgv_Datos.Rows[i].Cells[1].Value);
                    Variables.valorFrecuenciaMaxima = Convert.ToInt32(dgv_Datos.Rows[i].Cells[0].Value);
                }
            }

            lbl_Moda.Text = Variables.valorFrecuenciaMaxima.ToString();

            

            
        }
  
        private void AgregarDatoDesagrupado()
        {
            if (txt_Datos.Text == "")
            {
                MessageBox.Show("Error al ingresar los datos");
                btn_Calcular.Enabled = false;
            }

            else
            {
                btn_Calcular.Enabled = true;
                Variables.listaDatos.Add(Convert.ToInt32(txt_Datos.Text.Trim()));
                txt_Datos.Clear();
                txt_Datos.Select();
                
                rdb_Agrupados.Enabled = false;
                rdb_Desagrupados.Enabled = false;


                dgv_Datos.Rows.Add(1);

                for (int i = 0; i < Variables.listaDatos.Count; i++)
                {
                    dgv_Datos.Rows[i].Cells[0].Value = Variables.listaDatos[i];
                }
            }
            

        }

        private void graficoDatos()
        {
            //datos para el grafico
            for (int i = 0; i < dgv_Datos.Rows.Count; i++)
            {
                double tempDato = 0;
                double tempFrecuencia = 0;
                tempDato = Convert.ToDouble(dgv_Datos.Rows[i].Cells[0].Value);
                Variables.listaDatosGrafico.Add(tempDato);
                tempFrecuencia = Convert.ToDouble(dgv_Datos.Rows[i].Cells[1].Value);
                Variables.listaFrecuenciaGrafico.Add(tempFrecuencia);
            }
        }
       
        //esta bien
        private void SacoValoresUnicosYTablaDesagrupados()
        {
            //saco los datos unicos para agregar las filas necesarias
            dgv_Datos.Rows.Clear();
            Variables.valoresLista = Variables.listaDatos.Distinct().ToList();

            foreach (double dato in Variables.valoresLista)
            {
                dgv_Datos.Rows.Add();
            }

            dgv_Datos.ClearSelection();

            //  ingreso los datos a la tabla y saco las frecuencias
            int tempFrecuencia = 0;

            for (int i = 0; i < Variables.valoresLista.Count; i++)
            {
                for (int j = 0; j < Variables.listaDatos.Count; j++)
                {
                    if (Variables.valoresLista[i] == Variables.listaDatos[j])
                    {
                        tempFrecuencia++;
                    }

                    dgv_Datos[0, i].Value = Variables.valoresLista[i];
                    dgv_Datos[1, i].Value = tempFrecuencia;
                }
                Variables.listaFrecuenciaDesagrupada.Add(tempFrecuencia);
                tempFrecuencia = 0;
            }
        }        
        bool m = false;
        int mx, my;
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            m = true; mx = e.X; my = e.Y;
        }

        private void panelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == true)
            {
                this.SetDesktopLocation(MousePosition.X - mx - 0, MousePosition.Y - my);
            }
        }

        private void panelSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            m = false;
        }

       

        private void rdb_Desagrupados_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Desagrupados.Checked == true)
            {
                txt_Frecuencia.Visible = false;
                label3.Visible = false;
                txt_Datos.Select();
            }
        }

       
    }
}
