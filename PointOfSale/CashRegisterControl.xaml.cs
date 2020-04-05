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
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        public CashRegisterControl()
        {
            InitializeComponent();
            CashRegisterModelView crmv = new CashRegisterModelView();
            this.DataContext = crmv;

            ReturnToTransactionButton.Click += OnReturnToTransactionButtonClicked;
        }

        void OnReturnToTransactionButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderInfo = this.FindAncestor<OrderControl>();
            var transaction = new TransactionControl();
            orderInfo.SwapOrderSum(transaction);
        }
    }
}
