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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        private OrderControl orderControl;

        /// <summary>
        /// A user control containing buttons for entrees, sides, and drinks
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            // Click events for the entrees
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;

            // Click events for the sides
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;

            // Click events for the drinks
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
        }



        /// <summary>
        /// adds the item to the order and opens the customization screen for the user to make selections
        /// </summary>
        /// <param name="item">The IOrder Item to add</param>
        /// <param name="screen">The customization screen (or null for none)</param>
        void AddItemandOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            // we need to have an Order to add this item to
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext expected to be an Order instance");

            // not all orderitems needs to be customized
            if (screen != null)
            {
                // we needd to ahve an ordercontrol acenstor to load the customziation screen
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("an acenstor of OrderControl");

                // add the item to the customization screen and launch it
                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
        }




        /// <summary>
        /// adds cowpoke chili to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                var item = new CowpokeChili();
                var screen = new CustomizeCowpokeChili();
                screen.DataContext = item;
                data.Add(item);
                //orderControl.SwapScreen(screen);
                AddItemandOpenCustomizationScreen(item, screen);
            }
        }
        
       

        /// <summary>
        /// adds rustlers ribs to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                //data.Add(new RustlersRibs());
                //orderControl.SwapScreen(new CustomizeRustlersRibs());


                var item = new RustlersRibs();
                var screen = new CustomizeRustlersRibs();
                screen.DataContext = item;
                data.Add(item);
                //orderControl.SwapScreen(screen);
                AddItemandOpenCustomizationScreen(item, screen);        
            }
        }

        /// <summary>
        /// adds pecos pulled pork to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                //data.Add(new PecosPulledPork());
                //orderControl.SwapScreen(new CustomizePecosPulledPork());

                var item = new PecosPulledPork();
                var screen = new CustomizePecosPulledPork();
                screen.DataContext = item;
                data.Add(item);
                //orderControl.SwapScreen(screen);
                AddItemandOpenCustomizationScreen(item, screen);
            }
        }

        /// <summary>
        /// adds trail burger to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                //data.Add(new TrailBurger());

                var item = new TrailBurger();
                var screen = new CustomizeTrailBurger();
                screen.DataContext = item;
                data.Add(item);
                //orderControl.SwapScreen(screen);
                AddItemandOpenCustomizationScreen(item, screen);
            }
        }

        /// <summary>
        /// adds dakota double burger to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                //data.Add(new DakotaDoubleBurger());

                var item = new DakotaDoubleBurger();
                var screen = new CustomizeDakotaDoubleBurger();
                screen.DataContext = item;
                data.Add(item);
                //orderControl.SwapScreen(screen);
                AddItemandOpenCustomizationScreen(item, screen);
            }
        }

        /// <summary>
        /// adds texas triple burger to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                //data.Add(new TexasTripleBurger());
                var item = new TexasTripleBurger();
                var screen = new CustomizeTexasTripleBurger();
                screen.DataContext = item;
                data.Add(item);
                //orderControl.SwapScreen(screen);
                AddItemandOpenCustomizationScreen(item, screen);
            }
        }

        /// <summary>
        /// adds angry chicken to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                //data.Add(new AngryChicken());
                var item = new AngryChicken();
                var screen = new CustomizeAngryChicken();
                screen.DataContext = item;
                data.Add(item);
                //orderControl.SwapScreen(screen);
                AddItemandOpenCustomizationScreen(item, screen);
            }
        }




        //SIDES
        /// <summary>
        /// adds chili cheese fries to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// adds corn dodgers to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// adds pan de campo to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// adds baked beans to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new BakedBeans());
            }
        }


        //DRINKS
        /// <summary>
        /// adds jerked soda to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new JerkedSoda());
            }
        }

        /// <summary>
        /// adds texas tea to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new TexasTea());
            }
        }

        /// <summary>
        /// adds cowboy coffee to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// adds water to ordersummary control and order column on mainwindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new Water());
            }
        }
    }
}
