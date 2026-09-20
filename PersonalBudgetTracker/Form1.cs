namespace PersonalBudgetTracker
{
    public partial class Form1 : Form
    {
        private decimal balance = 0;
        public Form1()
        {
            InitializeComponent();

            cmbType.Items.Add("Income");
            cmbType.Items.Add("Expense");
            cmbType.SelectedIndex= 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {  
if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Enter a valid amount");
                return;
            }
Transaction t = new Transaction();
            t.Description = txtAmount.Text;
            t.Amount = amount;
            t.Type = cmbType.Text;
            lstTransactions.Items.Add(
                t.Description + "-" + t.Type + "-$" + t.Amount
                );
            if (t.Type == "Income")
            {
                balance += t.Amount;
            }
            else if (t.Type == "Expense")
            {
                balance += t.Amount;
            }
            lblBalance.Text = "Balance:$" + balance;
        }
    }
}
