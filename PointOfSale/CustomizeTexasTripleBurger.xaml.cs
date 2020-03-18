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
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeTexasTripleBurger.xaml
    /// </summary>
    public partial class CustomizeTexasTripleBurger : UserControl
    {
        /// <summary>
        /// a way for the user to interact with the order and customize their extras
        /// </summary>
        public CustomizeTexasTripleBurger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// a method which will find the ancestor when an event has been changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventChanged(object sender, RoutedEventArgs e)
        {
            var ancestor = this.FindAncestor<OrderControl>();
            if (ancestor is OrderControl)
            {
                ancestor.propChanged();
            }
            var screen = new MenuItemSelectionControl();
            ancestor.SwapScreen(screen);
        }
    }
}
