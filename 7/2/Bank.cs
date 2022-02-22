using System;
namespace Bank{
   class BankCust
    {
        public int accountno;
        public string custname;
        public double bankbalance;
        public BankCust(int accno,string Custname,double bankb)
        {
            this.accountno = accno;
            this.custname=Custname;
            this.bankbalance=bankb;
        }
    }
    public delegate void BalanceChecking(double n);
}