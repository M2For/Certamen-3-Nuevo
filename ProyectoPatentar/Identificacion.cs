using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPatentar
{
    public class Identificacion
    {
        public string NombreMarca { get; set; }
        public string TipoMarca { get; set; }
        public string DescripcionLogo { get; set; }
        public string Traduccion { get; set; }

        public Identificacion() { }

        public Identificacion(string nombreMarca, string tipoMarca, string descripcionLogo, string traduccion)
        {
            NombreMarca = nombreMarca;
            TipoMarca = tipoMarca;
            DescripcionLogo = descripcionLogo;
            Traduccion = traduccion;
        }

        public string ATexto()
        {
            return $"{NombreMarca}|{TipoMarca}|{DescripcionLogo}|{Traduccion}";
        }

        public static Identificacion DesdeTexto(string linea)
        {
            var partes = linea.Split('|');
            if (partes.Length >= 4)
            {
                return new Identificacion(
                    partes[0], 
                    partes[1], 
                    partes[2], 
                    partes[3]  
                );
            }
            return null;
        }
    }
}
