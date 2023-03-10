using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace TP1ProbabilidadYEstadistica
{
    public partial class Grafico : Form
    {
        List<double> listaDatos = new List<double>();
        List<double> listaDatosFrecuencia = new List<double>();

        public Grafico(List<double> lista, List<double> frecuencia)
        {
            InitializeComponent();
            listaDatos = lista;
            listaDatosFrecuencia = frecuencia;


                            
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
     

            chart_GraficoTabla.Titles.Add("Tabla Estadistica -- X = Datos -- Y = Frecuencia");

           
            int tempContador = 1;
            for (int i = 0; i < listaDatos.Count; i++)
            {
                
                //Titulos
                if (listaDatosFrecuencia[i] != 0)
                {
                    Series serie = chart_GraficoTabla.Series.Add(tempContador.ToString() + "° Dato");
                    tempContador++;

                    // cantidades barras

                    serie.Label = listaDatosFrecuencia[i].ToString();
                    serie.Points.AddY(listaDatosFrecuencia[i]);
                    
                }
            }

                
            

            
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool m = false;
        int mx, my;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            m = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            m = true; mx = e.X; my = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == true)
            {
                this.SetDesktopLocation(MousePosition.X - mx - 165, MousePosition.Y - my);
            }
        }

        
    }   
}
