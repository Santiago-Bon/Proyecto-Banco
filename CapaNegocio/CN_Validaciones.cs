using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class CN_Validaciones
    {
        //Solo Números


        public void SoloNum(KeyPressEventArgs P)
        {
            if (Char.IsDigit(P.KeyChar)) // Busca si el Char del evento es un numero.
            {
                P.Handled = false; // Si es un numero, permite la digitacion.
            }
            else if (Char.IsControl(P.KeyChar)) // Busca si el char es un control.
            {
                P.Handled = false; // Si es un control, permite la digitacion.
            }
            else
            {
                P.Handled = true; // Si el Char es una letra, no permite la digitacion.
                MessageBox.Show("Error, solo numeros");
            }
        }


        //Solo Letras


        public void SoloLetras(KeyPressEventArgs P)
        {
            if (Char.IsLetter(P.KeyChar)) // Busca si el Char del evento es una letra
            {
                P.Handled = false; // Si es una letra, permite la digitacion.
            }
            else if (Char.IsControl(P.KeyChar)) // Busca si el char es un control.
            {
                P.Handled = false; // Si es un control, permite la digitacion.
            }
            else
            {
                P.Handled = true; // Si el Char es un numero, no permite la digitacion.
                MessageBox.Show("Error, solo letras");
            }
        }
    }
}
