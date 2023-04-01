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

    /*public ReceiptPage(List<string> selectedItems, double totalPrice)
    {
        InitializeComponent();

        // Add the selected items to the list view
        foreach (string item in selectedItems)
        {
            listView.Items.Add(item);
        }

        // Display the total price
        return totalPriceLabel.Text = $"Total Price: {totalPrice:C}";
    }

    private async void OnGenerateReceiptClicked(object sender, EventArgs e)
    {
        // Get the selected items and their prices
        List<string> selectedItems = new List<string>();
        List<decimal> selectedPrices = new List<decimal>();

        if (rdoBasicWash.IsChecked)
        {
            selectedItems.Add((string)rdoBasicWash.Content);
            selectedPrices.Add(10.00m);
        }
        if (rdoPremiumWash.IsChecked)
        {
            selectedItems.Add((string)rdoPremiumWash.Content);
            selectedPrices.Add(15.00m);
        }
        if (rdoUltraWash.IsChecked)
        {
            selectedItems.Add((string)rdoUltraWash.Content);
            selectedPrices.Add(20.00m);
        }

        // Calculate the total price
        decimal totalPrice = selectedPrices.Sum();

        // Navigate to the receipt page and pass the selected items and total price as parameters
        await Navigation.PushAsync(new ReceiptPage(selectedItems, totalPrice));
    }*/

}

