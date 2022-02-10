using System;
using System.Windows.Forms;
using static OnlineBank.Accounts;

namespace OnlineBank
{
public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
        _everydayAcct = new Everyday();
        _investmentAcct = new Investment();
        _omniAcct = new Omni();
    }

    

    // declare all the accounts

    private Everyday _everydayAcct;

    private Investment _investmentAcct;

    private Omni _omniAcct;


    // to hold active account based on radio button selection

    private Accounts _accounts;



    private void buttonSubmit_Click(object sender, EventArgs e)
    {
      



    }

    // Display Balance
    private void DisplayBalance(Accounts account)
    {
        textBoxDisplayBalance.Text = $"{account.AccountType}{account.Balance:$#,##0.00}";
    }

    // Deposit Amount
    private void DepositAmount(Accounts account)
    {

       

    }

    // Withdraw Amount
    private void WithdrawAmount(Accounts account)
    {
       
    }


    // Display Everyday
    private void DisplayDetails(Everyday account)
    {

        listBoxTransactions.Items.Add("Everyday Account");
        listBoxTransactions.Items.Add("Balance:" + account.Balance);
        listBoxTransactions.Items.Add("Deposit: " + account.Deposits);
        listBoxTransactions.Items.Add("Withdrawal:" + account.Withdrawals);
    }


    // Display Investment
    private void DisplayInvestment(Investment account)
    {

        listBoxTransactions.Items.Add("Investment Account");
        listBoxTransactions.Items.Add("Balance: " + account.Balance);
        listBoxTransactions.Items.Add("Deposit: " + account.Deposits);
        listBoxTransactions.Items.Add("Withdrawal:" + account.Withdrawals);
        listBoxTransactions.Items.Add("Interest Rate: " + account.InterestRate + "%");
        listBoxTransactions.Items.Add("Overdraft $0.00");
        listBoxTransactions.Items.Add("Fee: " +account.Fees);
    }


    // Display Omni
    private void DisplayOmni(Omni account)
    {

        listBoxTransactions.Items.Add("Omni Account");
        listBoxTransactions.Items.Add("Balance: " + account.Balance);
        listBoxTransactions.Items.Add("Deposit: " + account.Deposits);
        listBoxTransactions.Items.Add("Withdrawal:" + account.Withdrawals);
        listBoxTransactions.Items.Add("Interest Rate: " + account.InterestRate + "%");
        listBoxTransactions.Items.Add("Overdraft $100.00");
        listBoxTransactions.Items.Add("Fee: " + account.Fees);
    }


    // Shows account transaction details in list box
    private void button1_Click(object sender, EventArgs e)
    {
        if(radioButtonEveryday.Checked){
            
            // Display everyday details
        }
        if (radioButtonInvestment.Checked)
        {
            // Display investment detials
        }
        if (radioButtonOmni.Checked)
        {
            // Display Omni detials
        }
    }




    private void textBoxDispkayBalance_TextChanged(object sender, EventArgs e)
    {
        
    }


    // Clear Data
    private void buttonClear_Click(object sender, EventArgs e)
    {
        radioButtonEveryday.Checked = false;
        radioButtonInvestment.Checked = false;
        radioButtonOmni.Checked = false;
        textBoxDeposit.Clear();
        textBoxWithdraw.Clear();
        textBoxDispkayBalance.Clear();
        if (radioButtonEveryday.Checked)
        {
            _accounts = _everydayAcct;
        }
        if (radioButtonInvestment.Checked)
        {
            _accounts = _investmentAcct;
        }
        if (radioButtonOmni.Checked)
        {
            _accounts = _omniAcct;
        }
    }
  }
}
