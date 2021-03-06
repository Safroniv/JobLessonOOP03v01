using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLessonOOP03v01Part01
{
    class Program
    {

            static void Main()
            {
                BankAccount mybankAccount0 = new BankAccount();
                mybankAccount0.Print();
                BankAccount mybankAccount1 = new BankAccount(50000.99m);
                mybankAccount1.Print();
                BankAccount mybankAccount2 = new BankAccount(TypeBankAccount.Debet);
                mybankAccount2.Print();
                BankAccount mybankAccount3 = new BankAccount(999_999.99m, TypeBankAccount.Credit);
                mybankAccount3.Print();

                mybankAccount1.WithdrawFormBankAccount();
                mybankAccount1.Print();
                mybankAccount1.PutOnBankAccount();
                mybankAccount1.Print();

                Console.ReadLine();
            }
        
    }
}
