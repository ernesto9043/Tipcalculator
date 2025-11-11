using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipCalculator.Models;

namespace TipCalculator.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _importeDelConsumo = string.Empty;

        [ObservableProperty]
        private string _numeroDePersonas = "1";

        [ObservableProperty]
        private string _porcentajeDePropina = "10";

        [ObservableProperty]
        private string _importePropina = string.Empty;

        [ObservableProperty]
        private string _propinaPorPersona = string.Empty;

        [ObservableProperty]
        private string _importeTotalPorPersona =  string.Empty;

        [ObservableProperty]
        private string _importeTotalDelConsumo = string.Empty;

        private CuentaConsumo _cuenta;
        public MainViewModel()
        {
            _cuenta = new CuentaConsumo(0,0);
        }

        [RelayCommand]
        private void Calcular()
        {
            _cuenta.ImporteDelConsumo = Convert.ToDecimal(ImporteDelConsumo);
            _cuenta.NumeroDePersonas = Convert.ToDecimal(NumeroDePersonas);
            _cuenta.PorcentajeDePropina = Convert.ToDecimal(PorcentajeDePropina);

            ImportePropina = _cuenta.ImportePropina.ToString("C2");
            PropinaPorPersona = _cuenta.PropinaPorPersona.ToString("C2");
            ImporteTotalPorPersona = _cuenta.ImporteTotalPorPersona.ToString("C2");
            ImporteTotalDelConsumo = _cuenta.ImporteTotalDelConsumo.ToString("C2");
        }
        [RelayCommand]
        private void Limpiar()
        {
            ImporteDelConsumo = string.Empty;
            NumeroDePersonas = "1";
            PorcentajeDePropina = string.Empty;
            ImportePropina = string.Empty;
            PropinaPorPersona = string.Empty;
            ImporteTotalPorPersona = string.Empty;
            ImporteTotalDelConsumo = string.Empty;

        }
        [RelayCommand]
        private void SetPropina(string porcentaje)
        {
            PorcentajeDePropina = porcentaje;
        }
    }
}
