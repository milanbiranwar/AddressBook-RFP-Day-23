
// See https://aka.ms/new-console-template for more information
using AddressBook_Day_23;
using Day23AddressBook;

Console.WriteLine("Hello, World!");

//AddressBook addressBook = new AddressBook();
//addressBook.AddNewContact();
//addressBook.AddNewContact();

//AddressBook.PrintAddressBook();
//Console.WriteLine("Enter the FirstName to Edit");
//string firstName = Console.ReadLine();
//addressBook.EditContact(firstName);
//AddressBook.PrintAddressBook();


//AddressBook.PrintAddressBook();
//Console.WriteLine("Enter the FirstName to Delete");
//string firstName1 = Console.ReadLine();
//addressBook.DeleteContact(firstName1);
//AddressBook.PrintAddressBook();
//Console.ReadLine();


AddMultipleContact addressBook = new AddMultipleContact();

addressBook.AddMultipleContact1();

addressBook.AddNewContact();
addressBook.AddNewContact();

AddMultipleContact.PrintAddressBook();
Console.WriteLine("Enter the FirstName to Edit");
string firstName = Console.ReadLine();
addressBook.EditContact(firstName);
AddMultipleContact.PrintAddressBook();

AddMultipleContact.PrintAddressBook();
Console.WriteLine("Enter the FirstName to Delete");
string firstName1 = Console.ReadLine();
addressBook.DeleteContact(firstName1);
AddMultipleContact.PrintAddressBook();
Console.ReadLine();



