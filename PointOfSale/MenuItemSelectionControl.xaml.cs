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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
        }

        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new CowpokeChili());
            }
        }
    }
}
