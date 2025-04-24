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
        if (decimal.TryParse(txtBill.Text, out decimal bill))
            {
            Bill = bill;
            CalculateTotall();
            }
        else
            {
            Bill = 0;
            }
        }


    private void Button_Clicked(object sender, EventArgs e)
        {
        sldTip.Value = 10;
            
        }


    private void btn15_Clicked(object sender, EventArgs e)
        {
        sldTip.Value = 15;
        }

    private void btn20_Clicked(object sender, EventArgs e)
        {
        sldTip.Value = 20;
        }
    private void sldTip_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        CalculateTotall();
        }
    private void btnMinus_Clicked(object sender, EventArgs e)
        {
        if (NoOfPerson > 1)
            {
            NoOfPerson--;
            lblNoPerson.Text = NoOfPerson.ToString();
            CalculateTotall();
            }
        }

    private void btnPluse_Clicked(object sender, EventArgs e)
        {
        NoOfPerson++;
        lblNoPerson.Text = NoOfPerson.ToString();
        CalculateTotall();
        }

    private void CalculateTotall()
        {
        if (Bill <= 0 || NoOfPerson <= 0)
            return;

        decimal tipAmount = Bill * Tip / 100m;
        decimal subtotal = Bill + tipAmount;
        decimal totalPerPerson = subtotal / NoOfPerson;

        lblSubtotal.Text = $"${Bill:F2}";
        lblTipbyPerson.Text = $"${(tipAmount / NoOfPerson):F2}";
        lblTotal.Text = $"${totalPerPerson:F2}";
        }

    }
