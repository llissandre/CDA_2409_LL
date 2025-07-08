using ClassLibraryBankAccount;
using System.Buffers;

// -------------- //
// INSTANCIATIONS //
// -------------- //

BankAccount account1 = new BankAccount();
account1.GetHashCode();
BankAccount account2 = new BankAccount(
    "12345678", "John Doe", 1000.0m, -500.0m);
//BankAccount accountAccountNumber = new BankAccount(
//    "", "John Doe", 1000.0m, -500.0m);
//BankAccount accountOwnerName = new BankAccount(
//    "12345678", "", 1000.0m, -500.0m);
//BankAccount accountBalance = new BankAccount(
//    "12345678", "John Doe", -1000.0m, -500.0m);
//BankAccount accountAuthorizedOverdraft = new BankAccount(
//    "12345678", "John Doe", 1000.0m, 500.0m);
account2.GetHashCode();
BankAccount account3 = new BankAccount(account2);
account3.GetHashCode();


// ------------- //
// TESTS MANUELS //
// ------------- //

//account1._ownerName = "123";

account1.Credit(500);
account2.Credit(500);
//account3.Credit(-500);

account1.Debit(300);
account1.Debit(300);
account2.Debit(200);

account3.Transfer(account1, 100);
//account3.Transfer(account1, -100);

//account1.Compar(account3);

List<BankAccount> accounts = new List<BankAccount>
{
    account1,
    account2,
    account3
};

accounts.Sort(); // Utilise la méthode CompareTo de BankAccount
accounts.Sort(new ComparaisonAccountByAccountNumber()); // Utilise la méthode Compare de ComparaisonAccountByAccountNumber
