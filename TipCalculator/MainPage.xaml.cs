namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {       

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalcularButtonClicked(object sender, EventArgs e)
        {
            decimal importeConsumo = Convert.ToDecimal(ConsumoEntry.Text);
            decimal npersonas = Convert.ToDecimal(PersonasEntry.Text);
            decimal propina = Convert.ToDecimal(PropinasEntry.Text);

            decimal importedelapropina = ((importeConsumo * propina) / 100);
            decimal importetotal = importedelapropina + importeConsumo;
            decimal propinaporpersona = importedelapropina / npersonas;
            decimal totalporpersona = propinaporpersona / npersonas;

            PropinaLabel.Text = importedelapropina.ToString();
            TotalLabel.Text = importetotal.ToString();
            PersonaLabel.Text = propinaporpersona.ToString();
            PersonaTotalLabel.Text = importetotal.ToString();

        }

        private void OnLimpiarButtonClicked(object sender, EventArgs e)
        {
            PropinaLabel.Text = string.Empty;
            TotalLabel.Text = string.Empty;
            PersonaLabel.Text = string.Empty;
            PersonaTotalLabel.Text = string.Empty;

            ConsumoEntry.Text = string.Empty;
            PersonasEntry.Text = string.Empty;
            PropinasEntry.Text = string.Empty;
        }
    }
}
