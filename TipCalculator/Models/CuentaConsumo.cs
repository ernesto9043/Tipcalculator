using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator.Models
{
    public class CuentaConsumo : INotifyPropertyChanged
    {
        private decimal _importeConsumo;
        private decimal _numerodePersonas;
        private decimal _porcentajeDePropina;
        private decimal _importePropina;
        private decimal _propinaPorPersona;
        private decimal _totalPorPersona;
        private decimal _importeTotal;

        public event PropertyChangedEventHandler? PropertyChanged;

        public decimal ImporteDelConsumo
        {
            get => _importeConsumo;
            set
            {
                if (_importeConsumo != value)
                {
                    _importeConsumo = value;
                }
                OnPropertyChanged(nameof(ImporteDelConsumo));
            }

        }

        public decimal NumerodePersonas
        {
            get => _numerodePersonas;
            set
            {
                if (_numerodePersonas != value)
                {
                    _numerodePersonas = value;
                }
                OnPropertyChanged(nameof(NumerodePersonas));
            }
        }

        public decimal PorcentajeDePropina
        {
            get => _porcentajeDePropina;
            set
            {
                if (_porcentajeDePropina != value)
                {
                    _porcentajeDePropina = value;
                }
                OnPropertyChanged(nameof(PorcentajeDePropina));
            }
        }

        public decimal ImportePropina
        {
            get => _importePropina;
            set
            {
                if (_importePropina != value)
                {
                    _importePropina = value;
                }
                OnPropertyChanged(nameof(ImportePropina));
            }
        }

        public decimal PropinaPorPersona
        {
            get => _propinaPorPersona;
            set
            {
                if (_propinaPorPersona != value)
                {
                    _propinaPorPersona = value;
                }
                OnPropertyChanged(nameof(PropinaPorPersona));
            }
        }

        public decimal TotalPorPersona
        {
            get => _totalPorPersona;
            set
            {
                if (_totalPorPersona != value)
                {
                    _totalPorPersona = value;
                }
                OnPropertyChanged(nameof(TotalPorPersona));
            }
        }

        public decimal ImporteTotal
        {
            get => _importeTotal;
            set
            {
                if (_importeTotal != value)
                {
                    _importeTotal = value;
                }
                OnPropertyChanged(nameof(ImporteTotal));
            }

        }



        public CuentaConsumo(decimal importeDelConsumo, decimal numerodePersonas, decimal porcentajeDePropina)
        {
            _importeConsumo = importeDelConsumo;
            _numerodePersonas = numerodePersonas = 1;
            _porcentajeDePropina = porcentajeDePropina;

        }

        public void Calcular()
        {
            ImportePropina = ImporteDelConsumo * PorcentajeDePropina / 100.0m;
            PropinaPorPersona = ImportePropina / NumerodePersonas;
            ImporteTotal = ImporteDelConsumo + ImportePropina;
            TotalPorPersona = ImporteTotal / PropinaPorPersona;

        }

        public void Limpiar()
        {
            ImportePropina = 0;
            PropinaPorPersona = 0;
            ImporteTotal = 0;
            TotalPorPersona = 0;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
