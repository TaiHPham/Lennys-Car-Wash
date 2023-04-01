using System.Security;

namespace Lenny_s_Car_Wash;

public partial class ReceiptPage : ContentPage
{
	public ReceiptPage(double totalCost, string selectedWash, List<string> selectedAddOns)
	{
		InitializeComponent();

        // Output to Text labels
        totalCostLabel.Text = "Total Cost: $" + totalCost.ToString("0.00###");
        selectedWashLabel.Text = "Wash Selected: " + selectedWash;

        string addOnsText = "";
        foreach (string addOn in selectedAddOns)
        {
            addOnsText += addOn + "\n";
        }
        selectedAddOnsStack.Text = addOnsText;
    }

    private void CreateNewOrder(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}