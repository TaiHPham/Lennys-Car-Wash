namespace Lenny_s_Car_Wash;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        submitBtn1.Clicked += CalcAmount;
    }

    private void CalcAmount(object sender, EventArgs e)
    {
        double totalCost = 0.00;
        bool isWashSelected = false;
        string error = "Please select a wash";

        if (rdoBasicWash.IsChecked == true)
        {
            totalCost = 10.00;
            isWashSelected = true;
        }
        else if(rdoPremiumWash.IsChecked == true)
        {
            totalCost = 15.00;
            isWashSelected = true;
        }
        else if(rdoUltraWash.IsChecked == true)
        {
            totalCost = 20.00;
            isWashSelected = true;
        }

        if (isWashSelected == false)
            DisplayAlert("Error: ", error, "OK");
        else
        {
            if (chkAirFresh.IsChecked == true)
                totalCost += 2.00;
            if (chkWax.IsChecked == true)
                totalCost += 5.00;
            if (chkShine.IsChecked == true)
                totalCost += 5.00;
            if (chkVacuum.IsChecked == true)
                totalCost += 2.00;

            ReceiptPage receiptPage = new ReceiptPage(totalCost);
            Navigation.PushAsync(receiptPage);
        }
    }
}

