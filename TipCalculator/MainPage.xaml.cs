using TipCalculator.Models;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {

        private CuentaConsumo cuenta;
        public MainPage()
        {
            InitializeComponent();
            cuenta = new CuentaConsumo(0, 0, 0);
            this.BindingContext = cuenta;
        }

        private void OnCalcularButtonClicked(object sender, EventArgs e)
        {
            cuenta.Calcular();
        }

        private void OnLimpiarButtonClicked(object sender, EventArgs e)
        {
            cuenta.Limpiar();
        }
    }
}
