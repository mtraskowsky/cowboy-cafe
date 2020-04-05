using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe;
using CashRegister;

namespace PointOfSale
{
    public static class CashPaymentDetails
    {
        public static CashDrawer cashDrawer = new CashDrawer();

        public static ReceiptPrinter receiptPrinter = new ReceiptPrinter();

        public static double orderTotal { get; set; }

        public static uint orderNum { get; set; }

        public static string receipt { get; set; }
    }
}
