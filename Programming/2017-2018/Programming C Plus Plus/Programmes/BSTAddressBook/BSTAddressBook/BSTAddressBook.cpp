// BSTAddressBook.cpp : Defines the entry point for the console application.
// Practical 6 Mckinley Magale K00220137.

#include "stdafx.h"
#include "BinarySearchTree.h"
#include "PhoneBook.h"
using namespace std;
TreeType<PhoneBook> phoneBook;
void ClearAddressBook(TreeType<PhoneBook>& phoneBook);
void AddNewEntry(TreeType <PhoneBook>& phoneBook);
void RemoveEntry();
void SearchBookByLetter(TreeType<PhoneBook>& phoneBook);
void SearchBookBySurname();
bool quitFlag = false;
int main()
{
	int option;
	do
	{
		cout << "\n\t\t||Address Book Interface||";
		cout << "\n\n\t1.)	Clear Address Book";
		cout << "\n\t2.)	Add New Entry";
		cout << "\n\t3.)	Remove Entry";
		cout << "\n\t4.)	Search Address Book (Letter)";
		cout << "\n\t5.)	Search Address Book (Surname)";
		cout << "\n\t6.)	Exit";
		cout << "\n\n\tEnter a number : ";
		cin >> option;

		switch (option)
		{
		case 1:
		{
			ClearAddressBook(phoneBook);
			break;
		}
		case 2:
		{
			AddNewEntry(phoneBook);
			break;
		}
		case 3:
		{
			RemoveEntry();
			break;
		}
		case 4:
		{
			SearchBookByLetter(phoneBook);
			break;
		}
		case 5:
		{
			SearchBookBySurname();
			break;
		}
		case 6:
		{
			quitFlag = true;
			break;
		}
		default:
		{
			cout << "\n\tInvalid Input";
		}
		}
	} while (!quitFlag);
    return 0;
}

void ClearAddressBook(TreeType<PhoneBook>& phoneBook)
{
	if (!phoneBook.IsEmpty())
	{
		cout << "\n\tAddress Phone Book has been cleared"<<endl;
		phoneBook.MakeEmpty();
	}
	else
	{
		cout << "\n\tAddress Phone Book is already empty"<<endl;
	}
	cin.get();
}

void AddNewEntry(TreeType <PhoneBook>& phoneBook)
{
	string fname, sname, phoneNum;
	cout << "\n\tEnter your FirstName : ";
	cin >> fname;
	cout << "\n\tEnter your SurName : ";
	cin >> sname;
	cout << "\n\tEnter your PhoneNumber : ";
	cin >> phoneNum;
	PhoneBook NewEntry(fname, sname, phoneNum);
	phoneBook.InsertItem(NewEntry);
}

void RemoveEntry()
{
	if (phoneBook.IsEmpty())
	{
		cout << "\n\tAddress Phone Book is empty"<<endl;
	}
	else
	{
		string fname, sname;
		cout << "\n\tTo Cancel press 0, else enter your FirstName : ";
		cin >> fname;
		if (fname != "0")
		{
			cout << "\tEnter your Surname : ";
			cin >> sname;
			PhoneBook NewEntry(fname, sname, "");
			bool found;
			phoneBook.RetrieveItem(NewEntry, found);
			if (found)
			{
				phoneBook.DeleteItem(NewEntry);
				cout << "\n\tContact Deleted"<<endl;
			}
			else
			{
				cout << "\n\tContact Not Found"<<endl;
			}
		}
	}
}

void SearchBookByLetter(TreeType<PhoneBook>& phoneBook)
{
	if (phoneBook.IsEmpty())
	{
		cout << "\n\tPhone Book is empty"<<endl;
		cin.get();
	}
	else
	{
		string letter;
		cout << "\n\tEnter the first letter of the SurName : ";
		cin >> letter;
		cout << endl << setw(20) << "SurName" << setw(20) << "FirstName" << setw(20) << "Phone Num.";
		vector<PhoneBook> list;
		phoneBook.HasA(letter, list);
		for each(PhoneBook ANSWER in list)
		{
			cout << "\n" << ANSWER;
		}
	}
}

void SearchBookBySurname()
{
	if (phoneBook.IsEmpty())
	{
		cout << "\n\tAddress Phone Book is empty"<<endl;
	}
	else
	{
		string sname;
		cout << "\n\tEnter Surname : ";
		cin >> sname;
		cout << endl << setw(20) << "SurName" << setw(20) << "FirstName" << setw(20) << "Phone Num.";
		vector<PhoneBook> list;
		phoneBook.HasA(sname, list);
		for each(PhoneBook input in list)
		{
			cout <<"\n"<< input;
		}
	}
}
