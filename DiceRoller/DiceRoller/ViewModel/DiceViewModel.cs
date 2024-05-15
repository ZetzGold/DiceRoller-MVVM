using CommunityToolkit.Mvvm.ComponentModel;
using DiceRoller.Models;
using System.Windows.Input;

namespace DiceRoller.ViewModel
{
    public partial class DiceViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _quantidadeLados;

        [ObservableProperty]
        private int _numeroSorteado;

        public ICommand RolarDadoCommand { get; }

        public DiceViewModel()
        {
            RolarDadoCommand = new Command(RolarDado);
        }

        public void RolarDado()
        {
            Dice dice = new Dice(QuantidadeLados);
            dice.Rolar();
            NumeroSorteado = dice.NumeroSorteado;
        }
    }
}
