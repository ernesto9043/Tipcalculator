using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator.Models
{
    public class CuentaConsumo
    {
        public decimal ImporteDelConsumo {  get; set; }
        public decimal NumeroDePersonas { get; set; }
        public decimal PorcentajeDePropina { get; set; }
        public decimal ImportePropina => ImporteDelConsumo * PorcentajeDePropina / 100.0m;
        public decimal PropinaPorPersona => ImportePropina / NumeroDePersonas;
        public decimal ImporteTotalPorPersona => ImporteTotalDelConsumo / NumeroDePersonas;
        public decimal ImporteTotalDelConsumo => ImporteDelConsumo + ImportePropina;





        public CuentaConsumo(decimal importeDelConsumo, decimal porcentajeDePropina, decimal numeroDePersonas = 1)
        {
            ImporteDelConsumo = importeDelConsumo;
            PorcentajeDePropina = porcentajeDePropina;
            NumeroDePersonas = numeroDePersonas = 1;

        }      
    }
}
