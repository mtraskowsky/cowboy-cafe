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
            ItemSelectionButton.Click += OnItemSelectionButtonClicked;
            CancelOrderButton.Click += OnCancelOrderButtonClicked;
            CompleteOrderButton.Click += OnCompleteOrderButtonClicked;
        }

        /// <summary>
        /// A method which will swap the screen displayed to the user between the menu items and item customization
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        /// <summary>
        /// when the user is done customizing their order, this will take them back to the menu item selection screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            var screen = new MenuItemSelectionControl();
            SwapScreen(screen);
        }

        /// <summary>
        /// Contains the behavior after the complete order button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                //this.DataContext = new Order();
                var transaction = new TransactionControl();
                SwapScreen(transaction);
            }
        }

        /// <summary>
        /// Contains the behavior after the complete order button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            var screen = new MenuItemSelectionControl();
            SwapScreen(screen);
        }

        /// <summary>
        /// Keeps track of property changed for the contents of the order
        /// </summary>
        public void propChanged()
        {
            if (DataContext is Order data)
            {
                //notify change
                data.notifyPropChanged();
                // then go to Order class
            }
        }


    }
}
