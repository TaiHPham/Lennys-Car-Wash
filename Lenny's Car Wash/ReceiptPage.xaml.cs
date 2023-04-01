namespace Lenny_s_Car_Wash;

public partial class ReceiptPage : ContentPage
{
	public ReceiptPage(double totalCost)
	{
		InitializeComponent();

        totalCostLabel.Text = "Total Cost: $" + totalCost.ToString("0.00###");
    }
}