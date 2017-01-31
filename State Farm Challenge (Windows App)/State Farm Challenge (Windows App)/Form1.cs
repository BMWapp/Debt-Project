using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace State_Farm_Challenge__Windows_App_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Paymentplan = 0;
        private void BtnAddLoan_Click(object sender, EventArgs e)
        {
            Loan frm = new Loan();
            frm.Show();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            View frm = new View();
            if (Paymentplan == 1)
            {
                frm.Show();
            }
            else
                MessageBox.Show("Enter a payment plan before you can continue.");
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            Plan frm = new Plan();
            frm.Show();
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            /*Info frm = new Info(); (This creates form for Info, but I think we just need a message box)
            frm.Show();*/
            /* MessageBox.Show("What is FAFSA? \n" + "FAFSA is...\n\n" +
            "Types of loans:\nThere are government and private loans." +
            " Government student loans tend not to accrue interest whilst in highschool, while private loans vary" +
            "depending on who is issuing the loan. Government loans are typically more flexible and more forgiving." +
            "\n\nWhat is APR?\nAnnual Percentage Rate, typically around 3%-6%\n\n" +
            "How do interest rates change?\nInterest rates change yearly starting July 1st"); */
            try
            {
                System.Diagnostics.Process.Start("file:///H:/PSCP/Project/Project_Info.html");
            }
            catch { }
        }

    }
    public class Loan : Form
    {
        public Loan()
        {
            Text = "Add Loan";
        }
    }
    public class View : Form
    {
        public View()
        {
            Text = "Timeline";
        }
    }
    public class Plan : Form
    {
        public Plan()
        {
            Text = "Payment Plan";
        }
    }
    /*public class Info : Form   (This creates form for Info, but I think we just need a message box)
    {
        public Info()
        {
            Text = "Information";
        }
    }*/

}
