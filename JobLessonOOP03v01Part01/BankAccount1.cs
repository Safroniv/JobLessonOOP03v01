using System;

namespace JobLessonOOP02v06Part05
{
    class BankAccount
    {
        private int _numberBankAccount;
        private decimal _ballanceBankAccount;
        private TypeBankAccount _typeBankAccount;
        private decimal _sumWithdrawFormBankAccount=55000;
        private decimal _sumPutOnBankAccount = 55000;
        private static int _generateNumberBankAccount=0000_0000_1000_0000;
        public static int GenerateNumberBankAccount(){return _generateNumberBankAccount++;}
        public int NumberBankAccount{get{ return _numberBankAccount; } }
        public decimal BallanceBankAccount { get { return _ballanceBankAccount; } }       
        public TypeBankAccount TypeBankAccount { get { return _typeBankAccount; } }
        public decimal SumWithdrawFormBankAccount 
        {
            get { return _sumWithdrawFormBankAccount; }
            set { _sumWithdrawFormBankAccount = value; }
        }
        public decimal SumPutOnBankAccount
        {
            get { return _sumWithdrawFormBankAccount; }
            set { _sumWithdrawFormBankAccount = value; }
        }
        public void WithdrawFormBankAccount ()
        {
            if (NumberBankAccount==_numberBankAccount)
            {
                if(_sumWithdrawFormBankAccount> _ballanceBankAccount)
                {
                    PrintWithdrowError();
                }
                if (_sumWithdrawFormBankAccount <= _ballanceBankAccount)
                {
                    _ballanceBankAccount = _ballanceBankAccount - _sumWithdrawFormBankAccount;
                    PrintWithdrowSucsess();
                }
            }
        }
        public void PutOnBankAccount()
        {
            if (NumberBankAccount == _numberBankAccount)
            {
                    _ballanceBankAccount = _ballanceBankAccount + _sumPutOnBankAccount;
                    PrintPutOn();                
            }
        }

        public BankAccount() : this(100, TypeBankAccount.Current) { }
        public BankAccount(decimal ballanceBankAccount) : this(ballanceBankAccount, TypeBankAccount.Budget) { }
        public BankAccount(TypeBankAccount typeBankAccount) : this(2000, typeBankAccount) { }
        public BankAccount (decimal ballanceBankAccount, TypeBankAccount typeBankAccount)
        {
            _numberBankAccount = GenerateNumberBankAccount();
            _ballanceBankAccount = ballanceBankAccount;
            _typeBankAccount = typeBankAccount;            
        }
        public void Print()
        {
            Console.WriteLine(
                $"Банковский счёт пользователя: # {NumberBankAccount} " + "\n" +
                $"Количество средств на счёте пользователя: {BallanceBankAccount } " + "\n" +
                $"Тип счёта: {TypeBankAccount}" + "\n" +
                $"======================================================== ");            
        }
        public void PrintWithdrowError()
        {
            Console.WriteLine(
                        $"Невозможно снять данную сумму со счёта № {NumberBankAccount}. " + "\n" +
                        $"Сумма {SumWithdrawFormBankAccount} первышает балланс {BallanceBankAccount}" + "\n" +
                        $"======================================================== ");
        }
        public void PrintWithdrowSucsess()
        {
            Console.WriteLine(
                        $"Сумма {SumWithdrawFormBankAccount} снята со счёта № {NumberBankAccount}. " + "\n" +
                        $"Текущий балланс на счёте № {NumberBankAccount} составляет - {BallanceBankAccount}" + "\n"+
                        $"======================================================== ");
        }
        public void PrintPutOn()
        {
            Console.WriteLine(
                        $"Сумма {SumWithdrawFormBankAccount} пополнена на счёт № {NumberBankAccount}. " + "\n" +
                        $"Текущий балланс на счёте № {NumberBankAccount} составляет - {BallanceBankAccount}" + "\n" +
                        $"======================================================== ");
        }
    }
}
