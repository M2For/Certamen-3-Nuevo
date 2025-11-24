using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPatentar
{
    public class Clasificacion
    {
        public int ClaseNumero { get; set; }
        public string Descripcion { get; set; }

        public Clasificacion() { }

        public Clasificacion(int claseNumero, string descripcion)
        {
            ClaseNumero = claseNumero;
            Descripcion = descripcion;
        }

        public string ATexto()
        {
            return $"{ClaseNumero}|{Descripcion}";
        }

        public static Clasificacion DesdeTexto(string linea)
        {
            var partes = linea.Split('|');

            if (partes.Length >= 2 && int.TryParse(partes[0], out int claseNum))
            {
                return new Clasificacion(
                    claseNum,
                    partes[1]
                );
            }
            return null;
        }
    }
}
