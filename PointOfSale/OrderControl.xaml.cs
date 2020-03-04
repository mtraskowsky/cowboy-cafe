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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// A class containing thd logic for Order Control
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();

            // creates a new data binding between OrderControl and Order
            var data = new Order();
            this.DataContext = data;

           
            // Click events for the buttons
            //ItemSelectionButton.Click += OnItemSelectionButtonClicked;
            CancelOrderButton.Click += OnCancelOrderButtonClicked;
            CompleteOrderButton.Click += OnCompleteOrderButtonClicked;
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        /// <summary>
        /// Contains the behavior after the complete order button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Contains the behavior after the complete order button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
    }
}
