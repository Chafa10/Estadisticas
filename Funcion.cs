using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP1ProbabilidadYEstadistica
{
    public class Funcion
    {
        public static void NumerosSolo(KeyPressEventArgs T)
        {
            if (Char.IsDigit(T.KeyChar))
            {
                T.Handled = false;
            }
            
            else if (Char.IsControl(T.KeyChar))
            {
                T.Handled = false;
            }
            else
            {
                T.Handled = true;
                MessageBox.Show("Solo introducir numeros", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        
       

        
       
    }
}
