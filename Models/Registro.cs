using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC1.Models
{
    public class Registro
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Equipo { get; set; }
        public string? Division { get; set; }
        public List<string>? Generos { get; set; }
        public int Temporadas { get; set; }
        public string? Genero { get; set; }
        public decimal CostoInscripcion { get; private set; }
        public decimal Impuesto { get; private set; }
        public decimal TotalAPagar { get; private set; }


        public void CalcularCostoEImpuesto(){
            const decimal costoPorTemporada = 600;
            const decimal tasaImpuesto = 0.19M;

            if (Temporadas <= 4)
            {
                CostoInscripcion = Temporadas * costoPorTemporada;
                Impuesto = CostoInscripcion * tasaImpuesto;
                TotalAPagar = CostoInscripcion + Impuesto;
            }
            else
            {
                CostoInscripcion = 0;
                Impuesto = 0;
                TotalAPagar = 0;
            }  
        }
    }
}