namespace Lenny_s_Car_Wash;

public partial class MainPage : ContentPage
{
	int totalCost = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	void SelectWashChoice(object sender, EventArgs e)
	{
		if(rdoBasicWash.IsChecked)
		{
			totalCost += 10;
		}
		else if(rdoPremiumWash.IsChecked)
		{
			totalCost += 15;
		}
		else if(rdoUltraWash.IsChecked)
		{
			totalCost += 20;
		}
		else
		{
			Console.WriteLine("No options were picked for type of wash!");
		}

		if()
		{
			totalCost += 5;
		}

	}
}

