using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;
using CowboyCafe.Data;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The CashDrawer this class uses
        /// </summary>
        CashDrawer drawer = CashPaymentDetails.cashDrawer;

        public double Total
        {
            get { return CashPaymentDetails.orderTotal; }
        }

        public uint orderNumb
        {
            get { return CashPaymentDetails.orderNum; }
        }



        public double remaining;
        public double calculateRemainingAmt
        {
            get
            {
                remaining = CashPaymentDetails.orderTotal - CustMoney;
                return remaining;
            }
        }

        private double orderTotalWithTax;
        public double OrderTotalWithTax(double orderTot)
        {
 
            orderTotalWithTax = orderTot;
            return orderTotalWithTax;
        }


        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue; // => drawer.TotalValue is identical to get { { return TotalValue; } }

        /// <summary>
        /// Keeps track of the amount of money added to the drawer during a transaction
        /// </summary>
        private double custMoney = 0;
        public double CustMoney
        {
            get { return custMoney; }
            set { custMoney = value; }
        }

        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quantity);
                    custMoney += (0.01);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                    custMoney -= (0.01);
                }
                InvokePropertyChanged("Pennies");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");
            }
        }

        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dime, quantity);
                    custMoney += (0.1);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                    custMoney -= (0.1);

                }
                InvokePropertyChanged("Dimes");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }

        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Nickel, quantity);
                    custMoney += (0.05);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                    custMoney -= (0.05);
                }
                InvokePropertyChanged("Nickels");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }

        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Quarter, quantity);
                    custMoney += (0.25);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                    custMoney -= (0.25);
                }
                InvokePropertyChanged("Quarters");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }

        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.HalfDollar, quantity);
                    custMoney += (0.5);
                }
                else { 
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                    custMoney -= (0.5);
                }
                InvokePropertyChanged("HalfDollars");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }


        public int Dollars
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dollar, quantity);
                    custMoney += (1.00);
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                    custMoney -= (1.00);
                }
                InvokePropertyChanged("Dollars");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }

        public int Ones
        {
            get => drawer.Ones;

            set
            {
                if (drawer.Ones == value || value < 0) return;
                var quantity = value - drawer.Ones;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.One, quantity);
                    custMoney += (1.00);
                }
                else
                {
                    drawer.RemoveBill(Bills.One, -quantity);
                    custMoney -= (1.00);
                }
                InvokePropertyChanged("Ones");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }

        public int Twos
        {
            get => drawer.Twos;

            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quantity = value - drawer.Twos;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Two, quantity);
                    custMoney += (2.00);
                }
                else
                {
                    drawer.RemoveBill(Bills.Two, -quantity);
                    custMoney -= (2.00);
                }
                InvokePropertyChanged("Twos");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }

        public int Fives
        {
            get => drawer.Fives;

            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Five, quantity);
                    custMoney += (5.00);
                }
                else
                {
                    drawer.RemoveBill(Bills.Five, -quantity);
                    custMoney -= (5.00);
                }
                InvokePropertyChanged("Fives");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }

        public int Tens
        {
            get => drawer.Tens;

            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Ten, quantity);
                    custMoney += (10.00);
                }
                else
                {
                    drawer.RemoveBill(Bills.Ten, -quantity);
                    custMoney -= (10.00);
                }
                InvokePropertyChanged("Tens");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }

        public int Twenties
        {
            get => drawer.Twenties;

            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Twenty, quantity);
                    custMoney += (20.00);
                }
                else
                {
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                    custMoney -= (20.00);
                }
                InvokePropertyChanged("Twenties");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }


        public int Fifties
        {
            get => drawer.Fifties;

            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Fifty, quantity);
                    custMoney += (50.00);
                }
                else
                {
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                    custMoney -= (50.00);
                }
                InvokePropertyChanged("Fifties");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }

        public int Hundreds
        {
            get => drawer.Hundreds;

            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Hundred, quantity);
                    custMoney += (100.00);
                }
                else
                {
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                    custMoney -= (100.00);
                }
                InvokePropertyChanged("Hundreds");
                InvokePropertyChanged("CustMoney");
                InvokePropertyChanged("calculateRemainingAmt");

            }
        }

        /// <summary>
        /// Helper method for triggering PropertyChanged events
        /// </summary>
        /// <param name="denomination">The property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

       

        
    }
}
