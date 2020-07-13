using kolyaKurs.AppForm;
using kolyaKurs.entity;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace kolyaKurs.Service
{
    class CashboxService
    {
        Cashbox cashbox = new Cashbox();
        

        public void addCash(string label, double price, double tax)
        {
            double toCashbox = price + (tax / 100) * price;
            cashbox.addToCash(price, tax);
            CashboxForm form = new CashboxForm(label, toCashbox);
            form.ShowDialog();
        }

        

        public double Cash => cashbox.Cash;
    }
}
