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
		Bill = decimal.Parse(txtBill.Text);
		CalculateTotall();

        
		}
	private void CalculateTotall()
		{

		}

    private void sldTip_ValueChanged(object sender, ValueChangedEventArgs e)
        {
		Tip = (int)sldTip.Value;
		lblTip.Text = $"Tip: {Tip}%";
		CalculateTotall(); 
        }

    private void Button_Clicked(object sender, EventArgs e)
        {
        if (sender is Button btn)
            {
            if (int.TryParse(btn.Text.Replace("%", ""), out int percentage))
                {
                Console.WriteLine(percentage);
                sldTip.Value = percentage;
                }
            else
                {
                sldTip.Value = 0;
                }
            }
        }




    }

