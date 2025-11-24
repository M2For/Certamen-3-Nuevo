
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPatentar
{
    public class Solicitante
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Rut { get; set; }
        public string Email { get; set; }
        public long Telefono { get; set; }

        public string TipoPersona { get; set; }
        public string Domicilio { get; set; }

        public Solicitante(string nombre, string rut, string email, long telefono, string tipo, string domicilio)
        {
            Nombre = nombre;
            Rut = rut;
            Email = email;
            Telefono = telefono;
            TipoPersona = tipo;
            Domicilio = domicilio;
        }

        public string ATexto()
        {
            return $"{Nombre},{Rut},{Email},{Telefono},{TipoPersona},{Domicilio}";
        }

        public static Solicitante DesdeTexto(string linea)
        {
            var partes = linea.Split(',');
            if (partes.Length >= 6)
            {
                return new Solicitante(
                    partes[0],
                    partes[1],
                    partes[2],
                    long.Parse(partes[3]),
                    partes[4],
                    partes[5]
                );
            }
            return null;
        }
    }
}
