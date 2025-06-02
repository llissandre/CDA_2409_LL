using System.Xml;

namespace ClassLibraryBankAccount
{
    public class BankAccount : IComparable<BankAccount>, IComparable<Object>
    {

        /// <summary>
        /// Attributes of the BankAccount class
        /// </summary>
        private string _accountNumber;
        private string _ownerName;
        private decimal _balance;
        private decimal _authorizedOverdraft;

        /// <summary>
        /// Getters for the BankAccount class attributes
        /// </summary>
        public string AccountNumber { get => _accountNumber; }
        public string OwnerName { get => _ownerName; }
        public decimal Balance { get => _balance; }
        public decimal AuthorizedOverdraft { get => _authorizedOverdraft; }
        //public string _accountNumber { get; private set; }
        //public string _ownerName { get; private set; }
        //public decimal _balance { get; private set; }
        //public decimal _authorizedOverdraft { get; private set; }

        /// <summary>
        /// Default constructors
        /// </summary>
        //public BankAccount()
        //{
        //    _accountNumber = "00000000";
        //    _ownerName = "Unknown";
        //    _balance = 0.0m;
        //    _authorizedOverdraft = 0.0m;
        //}
        public BankAccount()
            : this("00000000", "Unknown", 0.0m, 0.0m) { }

        /// <summary>
        /// Classic constructor
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="ownerName"></param>
        /// <param name="balance"></param>
        /// <param name="authorizedOverdraft"></param>
        public BankAccount(string accountNumber, string ownerName, decimal balance, decimal authorizedOverdraft)
        {

            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                throw new ArgumentException("Account number cannot be null or empty", nameof(accountNumber));
            }

            if (string.IsNullOrWhiteSpace(ownerName))
            {
                throw new ArgumentException("Owner name cannot be null or empty", nameof(ownerName));
            }

            if (balance < 0)
            {
                throw new ArgumentException("Balance cannot be negative", nameof(balance));
            }

            if (authorizedOverdraft > 0)
            {
                throw new ArgumentException("Authorized overdraft cannot be positive", nameof(authorizedOverdraft));
            }

            _accountNumber = accountNumber;
            _ownerName = ownerName;
            _balance = balance;
            _authorizedOverdraft = authorizedOverdraft;
        }

        /// <summary>
        /// Clone constructor
        /// </summary>
        /// <param name="bankAccountToClone"></param>
        public BankAccount(BankAccount bankAccountToClone)
            : this(
                  bankAccountToClone._accountNumber,
                  bankAccountToClone._ownerName,
                  bankAccountToClone._balance,
                  bankAccountToClone._authorizedOverdraft)
        { }

        /// <summary>
        /// Credit the bank account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public void Credit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive", nameof(amount));
            }

            _balance += amount;
        }

        /// <summary>
        /// Debit the bank account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool Debit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive", nameof(amount));
            }

            if (_balance - amount <= _authorizedOverdraft)
            {
                return false; // Not enough funds
            }

            _balance -= amount;
            return true; // Debit successful
        }

        /// <summary>
        /// Transfer funds from this account to another account
        /// </summary>
        /// <param name="creditAccountNumber"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public bool Transfer(BankAccount creditAccountNumber, decimal amount)
        {
            if (creditAccountNumber == null)
            {
                throw new ArgumentNullException(nameof(creditAccountNumber), "Credit account cannot be null");
            }

            if (amount < 0)
            {
                throw new ArgumentException("Amount must be positive", nameof(amount));
            }

            if (_balance - amount >= _authorizedOverdraft)
            {
                return false; // Not enough funds
            }

            Debit(amount);
            creditAccountNumber.Credit(amount);
            return true; // Transfer successful
        }

        /// <summary>
        /// Compare the current account with another BankAccount object
        /// </summary>
        /// <param name="otherAccount"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int CompareTo(BankAccount? otherAccount)
        {
            if (otherAccount == null)
            {
                throw new ArgumentNullException(nameof(otherAccount), "Other account cannot be null");
            }

            return Balance.CompareTo(otherAccount.Balance);
        }

        /// <summary>
        /// Compare the current account with another object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Other object cannot be null");
            }

            if (obj is BankAccount otherAccount)
            {
                return Balance.CompareTo(otherAccount.Balance);
            }

            throw new ArgumentException("Object is not a BankAccount", nameof(obj));
        }

        /// <summary>
        /// Propertie ToString()
        /// La méthode toString est définie dans la classe Object; en conséquence toutes les classes C# en hérite.
        /// Lorsqu'on définit une classe, il peut être très utile de redéfinir la méthode toString afin de donner une description satisfaisante des objets de cette classe.
        /// Beaucoup de classes de l'API redéfinissent la m�thode toString.
        /// </summary>
        /// <returns>La fonction renvoie une chaîne de caractères servant à décrire l'objet concerné.</returns>
        public override string ToString()
        {
            return base.ToString() +
                " , Account Number : " + AccountNumber +
                " , Owner Name : " + OwnerName +
                " , Balance : " + Balance +
                " , Authorized Overdraft : " + AuthorizedOverdraft;
        }
    }
}
