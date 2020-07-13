using System;
using System.Collections.Generic;
using System.Text;

namespace kolyaKurs.entity
{
    class Cashbox
    {
        private double cash = 0;

        public Cashbox(double cash)
        {
            this.cash = cash;
        }

        public Cashbox()
        {

        }

        public void addToCash(double cash, double tax)
        {
            double toCashbox = cash + (tax / 100) * cash;
            this.cash += toCashbox;
        }

        public double Cash => cash;
    }
}
