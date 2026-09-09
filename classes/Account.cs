using System;
using System.Collections.Generic;
using System.Text;

namespace task8
{
    internal struct Account
    {
        private int AccountId;
        private string AccountHolder;
        private double Balance;

        public int Id
        {
            get { return AccountId; }
            set { AccountId = value; }
        }

        public string Holder
        {
            get { return AccountHolder; }
            set { AccountHolder = value; }
        }

        public double AccountBalance
        {
            get { return Balance; }
            set { Balance = value; }
        }
    }
}
