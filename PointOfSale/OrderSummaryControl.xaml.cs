﻿using System;
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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();



        }

       //  if (DataContext is Order data)
         //   {
          //      data.Add();
           //     ItemToAdd.Text = "";
           // }

    //AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;

    public void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {

        }

    }
}
