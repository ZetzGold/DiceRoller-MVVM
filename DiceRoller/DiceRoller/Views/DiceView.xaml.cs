using DiceRoller.Models;
using DiceRoller.ViewModel;
namespace DiceRoller.Views;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
		BindingContext = new DiceViewModel();
	}
}