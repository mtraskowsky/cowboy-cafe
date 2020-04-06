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

        private double change;
        public double calcChange
        {
            get
            {
                if (remaining >= 0)
                {
                    return 0;
                }
                else
                {
                    change = (remaining * -1);
                    return change;
                }
            }
        }

        /*
        private string coinAndBillsAmt;
        public string coinAndBills
        {
            get
            {
                coinAndBillsAmt = ReturnChange();
                return coinAndBillsAmt;
            }
        }
        */
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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");

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
                InvokePropertyChanged("calcChange");
                //InvokePropertyChanged("coinAndBills");
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

       
        /*
        public string ReturnChange()
        {

            double AmtChangeToGive = calcChange;


            // 100s
            int numHundredsBillsForChange = (int)(AmtChangeToGive / 100); // use int division to find # bills 
            if (numHundredsBillsForChange >= Hundreds) // if # bills needed for change >= # bills in drawer
            {
                AmtChangeToGive = AmtChangeToGive - (Hundreds * 100); // subtract # bills in drawer from the change to give
                numHundredsBillsForChange = Hundreds; // take out bills in drawer and make them change for customer
                Hundreds = 0; // zero out the drawer
            }
            else // if # bills needed is in the drawer
            {
                AmtChangeToGive = AmtChangeToGive - (numHundredsBillsForChange * 100); // subtract the # bills needed from the change amount
                Hundreds = Hundreds - numHundredsBillsForChange; // subtract the # bills you took from the drawer
            }

            // 50s
            int numFiftiesBillsForChange = (int)(AmtChangeToGive / 50); // use int division to find # bills 
            if (numFiftiesBillsForChange >= Fifties) // if # bills needed for change >= # bills in drawer
            {
                AmtChangeToGive = AmtChangeToGive - (Fifties * 50); // subtract # bills in drawer from the change to give
                numFiftiesBillsForChange = Fifties; // take out bills in drawer and make them change for customer
                Fifties = 0; // zero out the drawer
            }
            else // if # bills needed is in the drawer
            {
                AmtChangeToGive = AmtChangeToGive - (numFiftiesBillsForChange * 50); // subtract the # bills needed from the change amount
                Fifties = Fifties - numFiftiesBillsForChange; // subtract the # bills you took from the drawer
            }

            // 20s
            int numTwentiesBillsForChange = (int)(AmtChangeToGive / 20); // use int division to find # bills 
            if (numTwentiesBillsForChange >= Twenties) // if # bills needed for change >= # bills in drawer
            {
                AmtChangeToGive = AmtChangeToGive - (Twenties * 20); // subtract # bills in drawer from the change to give
                numTwentiesBillsForChange = Twenties; // take out bills in drawer and make them change for customer
                Twenties = 0; // zero out the drawer
            }
            else // if # bills needed is in the drawer
            {
                AmtChangeToGive = AmtChangeToGive - (numTwentiesBillsForChange * 20); // subtract the # bills needed from the change amount
                Twenties = Twenties - numTwentiesBillsForChange; // subtract the # bills you took from the drawer
            }

            // 10s
            int numTensBillsForChange = (int)(AmtChangeToGive / 10); // use int division to find # bills 
            if (numTensBillsForChange >= Tens) // if # bills needed for change >= # bills in drawer
            {
                AmtChangeToGive = AmtChangeToGive - (Tens * 10); // subtract # bills in drawer from the change to give
                numTensBillsForChange = Tens; // take out bills in drawer and make them change for customer
                Tens = 0; // zero out the drawer
            }
            else // if # bills needed is in the drawer
            {
                AmtChangeToGive = AmtChangeToGive - (numTensBillsForChange * 10); // subtract the # bills needed from the change amount
                Tens = Tens - numTensBillsForChange; // subtract the # bills you took from the drawer
            }

            // 5s
            int numFivesBillsForChange = (int)(AmtChangeToGive / 5); // use int division to find # bills 
            if (numFivesBillsForChange >= Fives) // if # bills needed for change >= # bills in drawer
            {
                AmtChangeToGive = AmtChangeToGive - (Fives * 5); // subtract # bills in drawer from the change to give
                numFivesBillsForChange = Fives; // take out bills in drawer and make them change for customer
                Fives = 0; // zero out the drawer
            }
            else // if # bills needed is in the drawer
            {
                AmtChangeToGive = AmtChangeToGive - (numFivesBillsForChange * 5); // subtract the # bills needed from the change amount
                Fives = Fives - numFivesBillsForChange; // subtract the # bills you took from the drawer
            }

            // 2s
            int numTwosBillsForChange = (int)(AmtChangeToGive / 2); // use int division to find # bills 
            if (numTwosBillsForChange >= Twos) // if # bills needed for change >= # bills in drawer
            {
                AmtChangeToGive = AmtChangeToGive - (Twos * 2); // subtract # bills in drawer from the change to give
                numTwosBillsForChange = Twos; // take out bills in drawer and make them change for customer
                Twos = 0; // zero out the drawer
            }
            else // if # bills needed is in the drawer
            {
                AmtChangeToGive = AmtChangeToGive - (numTwosBillsForChange * 2); // subtract the # bills needed from the change amount
                Twos = Twos - numTwosBillsForChange; // subtract the # bills you took from the drawer
            }

            // 1s
            int numOnesBillsForChange = (int)(AmtChangeToGive / 1); // use int division to find # bills 
            if (numOnesBillsForChange >= Ones) // if # bills needed for change >= # bills in drawer
            {
                AmtChangeToGive = AmtChangeToGive - (Ones * 1); // subtract # bills in drawer from the change to give
                numOnesBillsForChange = Ones; // take out bills in drawer and make them change for customer
                Ones = 0; // zero out the drawer
            }
            else // if # bills needed is in the drawer
            {
                AmtChangeToGive = AmtChangeToGive - (numOnesBillsForChange * 1); // subtract the # bills needed from the change amount
                Ones = Ones - numOnesBillsForChange; // subtract the # bills you took from the drawer
            }


            StringBuilder sb = new StringBuilder();
            sb.Append("CHANGE AMT\n");
            sb.Append("\nHundreds: " + numHundredsBillsForChange);
            sb.Append("\nFifties: " + numFiftiesBillsForChange);

            return sb.ToString();
        }
        */
        
    }
}
