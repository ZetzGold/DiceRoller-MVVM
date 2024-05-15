namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int valor = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Mudar_Selecionador(object sender, EventArgs e)
        {
            int indice = Selecionador.SelectedIndex;
            switch (indice)
            {
                case 0:
                    valor = 4; break;
                case 1:
                    valor = 6; break;
                case 2:
                    valor = 10; break;
                case 3:
                    valor = 20; break;
                case 4:
                    valor = 100; break;
                default:
                    valor = 0; break;
            }
        }

        private void Botao_Clicado(object sender, EventArgs e)
        {
            int maximo = valor + 1;
            Random aleatorio = new();
            int numeroGerado = aleatorio.Next(1, maximo);
            Numero.Text = numeroGerado.ToString();
        }
    }

}
