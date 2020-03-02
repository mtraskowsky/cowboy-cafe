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
        public OrderControl()
        {
            InitializeComponent();

            var data = new Order();
            this.DataContext = data;

            //cancel button
            //complete button


            // Click events for the entrees
            //AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            //AddCowpokeChiliButton.Click += AddCowpokeChiliToSummaryControl;
            /*
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
         */

            void AddCowpokeChiliToSummaryControl(object sender, RoutedEventArgs e)
            {
                data.Add(new CowpokeChili());
            }




            //ENTREES
            /// <summary>
            /// adds cowpoke chili to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
            {
                //OrderListView.Items.Add(new CowpokeChili());
            }

            /// <summary>
            /// adds rustlers ribs to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
            {
                //OrderListView.Items.Add(new RustlersRibs());
            }

            /// <summary>
            /// adds pecos pulled pork to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
            {
                //OrderListView.Items.Add(new PecosPulledPork());
            }

            /// <summary>
            /// adds trail burger to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
            {
                //OrderListView.Items.Add(new TrailBurger());
            }

            /// <summary>
            /// adds dakota double burger to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
            {
                //OrderListView.Items.Add(new DakotaDoubleBurger());
            }

            /// <summary>
            /// adds texas triple burger to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
            {
                //OrderListView.Items.Add(new TexasTripleBurger());
            }

            /// <summary>
            /// adds angry chicken to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
            {
                //OrderListView.Items.Add(new AngryChicken());
            }

            //SIDES
            /// <summary>
            /// adds chili cheese fries to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
            {
                //OrderListView.Items.Add(new ChiliCheeseFries());
            }

            /// <summary>
            /// adds corn dodgers to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
            {
                //   OrderListView.Items.Add(new CornDodgers());
            }

            /// <summary>
            /// adds pan de campo to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
            {
                // OrderListView.Items.Add(new PanDeCampo());
            }

            /// <summary>
            /// adds baked beans to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
            {
                //OrderListView.Items.Add(new BakedBeans());
            }


            //DRINKS
            /// <summary>
            /// adds jerked soda to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
            {
                //OrderListView.Items.Add(new JerkedSoda());
            }

            /// <summary>
            /// adds texas tea to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
            {
                //    OrderListView.Items.Add(new TexasTea());
            }

            /// <summary>
            /// adds cowboy coffee to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
            {
                //  OrderListView.Items.Add(new CowboyCoffee());
            }

            /// <summary>
            /// adds water to order column
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
            {
                //OrderListView.Items.Add(new Water());
            }
        }
    }
}
