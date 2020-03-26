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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows the user to go back and change previously added items on the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="s"></param>
        void ChangeOrder(object sender, SelectionChangedEventArgs s)
        {
            
            var ancestor = this.FindAncestor<OrderControl>();
            if (ancestor is OrderControl)
            {
                ancestor.propChanged();
            }

            // curItem is the item that is selected by the user
            string curItem = OrderSumControlListView.SelectedItem.ToString();
            if (curItem != null)
            {
                //Entrees
                if (curItem == "Angry Chicken")
                {
                    var screen = new CustomizeAngryChicken();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;

                }

                if (curItem == "Cowpoke Chili")
                {
                    var screen = new CustomizeCowpokeChili();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;

                }

                if (curItem == "Dakota Double Burger")
                {
                    var screen = new CustomizeDakotaDoubleBurger();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;

                }

                if (curItem == "Pecos Pulled Pork")
                {
                    var screen = new CustomizePecosPulledPork();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;

                }

                if (curItem == "Rustlers Ribs")
                {
                    var screen = new CustomizeRustlersRibs();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;

                }

                if (curItem == "Texas Triple Burger")
                {
                    var screen = new CustomizeTexasTripleBurger();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;

                }

                if (curItem == "Trail Burger")
                {
                    var screen = new CustomizeTrailBurger();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;

                }

                // Sides
                if (curItem.Contains("Baked Beans"))
                {
                    var screen = new CustomizeBakedBeans();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;
                }

                if (curItem.Contains("Chili Cheese Fries"))
                {
                    var screen = new CustomizeChiliCheeseFries();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;
                }

                if (curItem.Contains("Corn Dodgers"))
                {
                    var screen = new CustomizeCornDodgers();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;
                }

                if (curItem.Contains("Pan de Campo"))
                {
                    var screen = new CustomizePanDeCampo();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;
                }


                // Drinks
                if (curItem.Contains("Cowboy Coffee"))
                {
                    var screen = new CustomizeCowboyCoffee();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;
                }

                if (curItem.Contains("Jerked Soda"))
                {
                    var screen = new CustomizeJerkedSoda();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;
                }

                if (curItem.Contains("Tea"))
                {
                    var screen = new CustomizeTexasTea();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;
                }

                if (curItem.Contains("Water"))
                {
                    var screen = new CustomizeWater();
                    ancestor.SwapScreen(screen);
                    screen.DataContext = OrderSumControlListView.SelectedItem;
                }
            }
        }
    }
}
