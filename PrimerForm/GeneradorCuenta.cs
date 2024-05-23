using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PrimerForm
{
    class GeneradorCuenta
    {
        // Poder agregar mi cuenta y las substituciones para generar el numero que el Ing pide como asistencia
        private String NumeroDeCuenta = "";
        // private String[] Substituir = [];
        // private String[] Por = [];
        private List<String> Substituir = [];
        private List<String> Por = [];

        // Metodo 
        public GeneradorCuenta() { }
        public GeneradorCuenta(String numeroDeCuenta) {
            this.NumeroDeCuenta = numeroDeCuenta;
        }

        public void setNumeroCuenta(string numeroDeCuenta) {
            // Validaciones
            this.NumeroDeCuenta = numeroDeCuenta;
        }

        public void agregarSubstitucion(String substituir, String por)
        {
            this.Substituir.Add(substituir);
            this.Por.Add(por);
        }

        public String getSubstituciones() {
            String tmpSubstituciones = "";
            for (int i = 0; i < this.Substituir.Count; i++)
            {
                tmpSubstituciones += this.Substituir[i] + " => " + this.Por[i] + Environment.NewLine;
            }
            return tmpSubstituciones;
        }

      
        public string obtenerNuevaCuenta()
        {
            string tmpNumeroCuenta = this.NumeroDeCuenta;
            for (int i = 0; i < this.Substituir.Count; i++)
            {
                tmpNumeroCuenta = tmpNumeroCuenta.Replace(this.Substituir[i], this.Por[i]);
            }
            return tmpNumeroCuenta;
        }
        public string obtenerNuevaCuenta(Boolean invertir)
        {
            String tmpNumeroCuenta = this.obtenerNuevaCuenta();
            if ( invertir == true)
            {
                return this.reverse(tmpNumeroCuenta);
            } else {
                return tmpNumeroCuenta;
            }
        }

        private string reverse(String str)
        {
            char[] reverserStrArray = str.ToCharArray();
            Array.Reverse(reverserStrArray);
            return new String(reverserStrArray);
        }

    }
}
