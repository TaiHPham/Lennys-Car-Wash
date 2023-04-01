namespace Lenny_s_Car_Wash;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private void CalcAmount(object sender, EventArgs e)
    {
        double totalCost = 0.00;
        bool isWashSelected = false;
        bool isAddOnSelected = false;
        string selectedWash = "";
        List<string> selectedAddOns = new List<string>();

        if (rdoBasicWash.IsChecked == true)
        {
            selectedWash = "Basic Wash ($10.00)";
            totalCost = 10.00;
            isWashSelected = true;
        }
        else if(rdoPremiumWash.IsChecked == true)
        {
            selectedWash = "Premium Wash ($15.00)";
            totalCost = 15.00;
            isWashSelected = true;
        }
        else if(rdoUltraWash.IsChecked == true)
        {
            selectedWash = "Ultra Wash ($20.00)";
            totalCost = 20.00;
            isWashSelected = true;
        }

        if (isWashSelected == false)
            errorMsgLabel.Text = "Error: Please select a wash";
        else
        {
            if (chkAirFresh.IsChecked == true)
            {
                selectedAddOns.Add("• Air Freshener ($2.00)");
                totalCost += 2.00;
                isAddOnSelected = true;
            }
            if (chkWax.IsChecked == true)
            {
                selectedAddOns.Add("• Wax ($5.00)");
                totalCost += 5.00;
                isAddOnSelected = true;
            }
            if (chkShine.IsChecked == true)
            {
                selectedAddOns.Add("• Wheel Shine ($5.00)");
                totalCost += 5.00;
                isAddOnSelected = true;
            }
            if (chkVacuum.IsChecked == true)
            {
                selectedAddOns.Add("• Vacuum ($2.00)");
                totalCost += 2.00;
                isAddOnSelected = true;
            }
            if (isAddOnSelected == false)
                selectedAddOns.Add("⨯ No Add Ons were Selected");


            ReceiptPage receiptPage = new ReceiptPage(totalCost, selectedWash, selectedAddOns);
            Navigation.PushAsync(receiptPage);
        }
    }
}

