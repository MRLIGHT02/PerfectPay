namespace PerfectPay;

public partial class MainPage : ContentPage
{
	
	public decimal Bill { get; set; }
	public int Tip { get; set; }
	public int NoOfPerson { get; set; } = 1;

	public MainPage()
	{
		InitializeComponent();
	}

    private void txtBill_Completed(object sender, EventArgs e)
        {

        }
    }

