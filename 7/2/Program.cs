using System;
using Bank;
namespace BankSys
{
    class BankM
    {    
        public static void checkBalance(double balance)
        {
            if( balance < 0 )
            Console.Write("YOU ARE OVERDRAWN");
            else if(balance < 10)
            Console.Write("YOUR ACCOUNT BALANCE IS VERY LOW");
            else if(balance < 100) 
            Console.Write("WATCH YOUR SPENDING CAREFULLY");
            else
            Console.Write("YOU HAVE OVER $100 IN YOUR ACCOUNT"); 
        } 
        static void Main()
        {          
            BalanceChecking checking = checkBalance;
            BankCust b1= new BankCust(001,"JOHN",-1);
            Console.Write($"\nWELCOME TO MIDAS BANK,{b1.custname} | ");
            checking(b1.bankbalance);
            Console.WriteLine($" : [BALANCE = ${b1.bankbalance}]");

            BankCust b2= new BankCust(002,"TONY",7);
            Console.Write($"\nWELCOME TO MIDAS BANK,{b2.custname} | ");
            checking(b2.bankbalance);
            Console.WriteLine($" : [BALANCE = ${b2.bankbalance}]");

            BankCust b3= new BankCust(003,"JACK",88);
            Console.Write($"\nWELCOME TO MIDAS BANK,{b3.custname} | ");
            checking(b3.bankbalance);
            Console.WriteLine($" : [BALANCE = ${b3.bankbalance}]");

            BankCust b4= new BankCust(004,"EREN",1000);
            Console.Write($"\nWELCOME TO MIDAS BANK,{b4.custname} | ");
            checking(b4.bankbalance);
             Console.WriteLine($" : [BALANCE = ${b4.bankbalance}]");
        }
    }
}