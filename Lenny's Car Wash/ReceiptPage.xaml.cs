/*
 * Program Author: Tai Pham
 * Assignment: Program 3 - Lenny's Car Wash
 * 
 * Description:
 * Lenny's Car Wash is an interface that allows users to select a car wash package and add-ons, 
 * and generates a receipt with the selected options and total cost.
 */
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