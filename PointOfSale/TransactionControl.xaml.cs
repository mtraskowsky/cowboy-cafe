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
        }
/*
        /// <summary>
        /// A method which will swap the screen displayed to the user
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            TransactionDetails.Child = element;
        }
        */

        void OnCancelTransactionClicked(object sender, RoutedEventArgs e)
        {
            /*
            Order ord = (Order)DataContext;

            if (ord != null)
            {
                foreach (IOrderItem item in ord.items)
                {
                    ord.Remove(item);
                }
            }
            */
            
            var orderInfo = this.FindAncestor<OrderControl>();

            this.DataContext = new Order();
            //orderc.DataContext = new Order();
            var sum = new OrderSummaryControl();
            //orderInfo.SwapOrderSum(sum);
            var screen = new MenuItemSelectionControl();
            orderInfo.SwapScreen(screen);
            OrderControl child = new OrderControl();
           
        }
    }
}
