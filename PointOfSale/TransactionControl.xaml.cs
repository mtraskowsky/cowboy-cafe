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


        void OnPayWithCashButtonClicked(object sender, RoutedEventArgs e)
        {
            //CashDrawer drawer = new CashDrawer();
        }


        void PrintTheReceipt(Order order, string paymentType)
        {
            Order o = order;
            var sb = new StringBuilder();
            foreach (IOrderItem item in o.items)
            {
                sb.Append(item.ToString() + "\t\t");
                sb.Append(item.Price.ToString() + "\n");
            }
            // print receipt
            ReceiptPrinter printer = new ReceiptPrinter();
            printer.Print(sb.ToString());
            MessageBox.Show(sb.ToString());
        }
    }
}
