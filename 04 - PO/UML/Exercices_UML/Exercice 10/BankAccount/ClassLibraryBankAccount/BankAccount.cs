namespace ClassLibraryBankAccount
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _ownerName;
        private decimal _balance;
        private decimal _authorizedOverdraft;

        //public BankAccount()
        //{
        //    _accountNumber = "00000000";
        //    _ownerName = "Unknown";
        //    _balance = 0.0m;
        //    _authorizedOverdraft = 0.0m;
        //}
        public BankAccount()
            : this("00000000", "Unknown", 0.0m, 0.0m) { }


        public BankAccount(string accountNumber, string ownerName, decimal balance, decimal authorizedOverdraft)
        {
            _accountNumber = accountNumber;
            _ownerName = ownerName;
            _balance = balance;
            _authorizedOverdraft = authorizedOverdraft;
        }
    }
}
