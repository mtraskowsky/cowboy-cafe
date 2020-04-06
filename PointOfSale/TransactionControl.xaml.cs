using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CowboyCafe.Extensions;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();

            var orderInfo = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                this.DataContext = orderInfo;
            }

            CancelTransactionButton.Click += OnCancelTransactionClicked;
            PayWithCreditButton.Click += OnPayWithCreditButtonClicked;
            PayWithCashButton.Click += OnPayWithCashButtonClicked;
        }


        /// <summary>
        /// This method creates a new Order and swaps the screen to a new OrderControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelTransactionClicked(object sender, RoutedEventArgs e)
        {         
            var orderInfo = this.FindAncestor<OrderControl>();
            OrderControl o = new OrderControl();
            orderInfo.SwapOrderSum(o);
        }

        /// <summary>
        /// When customer pays with credit, processes credit card.
        /// If processing is successful, prints the receipt and processes the payment, else the cashier is
        /// given the option to select pay with Cash or Credit or Cancel Transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPayWithCreditButtonClicked(object sender, RoutedEventArgs e)
        {
            string cred = "Credit";
            // process transaction using instance of the CardTerminal class
            CardTerminal cardTerm = new CardTerminal();
            Order o = (Order)DataContext;
            // cardterminal class had one method - ProcessTransaction(amount to charge as double)
            // process transaction process card swiped and returns a resultcode enum value 
            ResultCode result = cardTerm.ProcessTransaction(o.TotalWithTax);
            // result code is "Success" or "InsufficientFunds" "CancelledCard" "ReadError" "UnknownError"
            // if result is success you should finish order by printing receipt and return to ordering screen with new order object
            if (result == ResultCode.Success)
            {
                MessageBox.Show("Payment was a " + result.ToString() + "!");
                PrintTheReceipt(o, cred);
                var orderInfo = this.FindAncestor<OrderControl>();
                OrderControl oc = new OrderControl();
                orderInfo.SwapOrderSum(oc);
            }
            // if result is any error, inform user and display transaction screen s ocashier can attempt a different payment method
            else
            {
                MessageBox.Show("There was an error of type: " + result.ToString());
            }
        }

        /// <summary>
        /// When customer pays with cash, generates cash register UI and controls the amounts in the cashdrawer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPayWithCashButtonClicked(object sender, RoutedEventArgs e)
        {
            string cash = "Cash";

            Order o = (Order)DataContext;

            var orderInfo = this.FindAncestor<OrderControl>(); 

            CashRegisterControl crc = new CashRegisterControl();

            CashPaymentDetails.orderTotal = o.TotalWithTax;
            CashPaymentDetails.orderNum = o.OrderNumber;

            CashRegisterModelView cashreg = new CashRegisterModelView();
            crc.DataContext = cashreg;

            orderInfo.SwapOrderSum(crc); // swaps whole screen to cash register 
            
            PrintTheReceipt(o, cash);
        }

        /// <summary>
        /// Method which prints the receipt to file to PointOfSale/bin/Debug/netcoreapp3.1/receipt and 
        /// also displays the receipt in a messagebox.
        /// </summary>
        /// <param name="order">The order info</param>
        /// <param name="paymentType">The type of customer payment (cash or credit)</param>
        void PrintTheReceipt(Order order, string paymentType)
        {
            Order o = order;
            var sb = new StringBuilder();
            sb.Append("\n*******************************************\n");
            sb.Append("Date and Time: " + DateTime.Now.ToString() + "\n");
            sb.Append("Order No: " + o.OrderNumber + "\n" + "\n");
            
            foreach (IOrderItem item in o.items)
            {
                sb.Append(item.ToString());
                
                int numSpaces = 35 - item.ToString().Length; 
                for (int i = 0; i < numSpaces; i++)
                {
                    sb.Append(".");
                }

                sb.AppendFormat("${0:C}\n", item.Price.ToString());

                foreach(string si in item.SpecialInstructions)
                {
                    sb.Append("\t" + si + "\n");
                }
            }

            sb.Append("\nPayment method: " + paymentType + "\n");
            sb.AppendFormat("Order subtotal: {0:C}\n", o.Subtotal);
            sb.AppendFormat("Total (16% tax): {0:C}\n", o.TotalWithTax);
            sb.Append("\n*******************************************\n");

            // print receipt
            ReceiptPrinter printer = new ReceiptPrinter();
            printer.Print(sb.ToString());
            MessageBox.Show(sb.ToString());

        }
    }
}
