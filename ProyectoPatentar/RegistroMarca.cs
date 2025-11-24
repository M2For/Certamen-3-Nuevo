using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPatentar
{
    public class RegistroMarca
    {

        public Solicitante DatosSolicitante { get; set; }

        public Identificacion DatosMarca { get; set; }

        public List<Clasificacion> ClasesDeNiza { get; set; } = new List<Clasificacion>();

        private const decimal CostoBase = 150.00m; 
        private const decimal CostoAdicionalPorClase = 50.00m;

        public decimal CalcularCostoTotal()
        {
            int numClases = ClasesDeNiza.Count;
            decimal costoTotal = CostoBase;

            if (numClases > 1)
            {
                costoTotal += (numClases - 1) * CostoAdicionalPorClase;
            }
            return costoTotal;
        }
    }
}
