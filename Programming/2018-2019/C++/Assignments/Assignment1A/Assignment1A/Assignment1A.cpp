// Assignment1A.cpp : Defines the entry point for the console application.
// Assignment 1A Mckinley Magale K00220137

#include "stdafx.h"
#include "AVLTree.h"
#include "NameList.h"
using namespace std;

TreeType<NameList> nameList;
void clearList(TreeType<NameList> &nameList);
void addNew(TreeType<NameList> &nameList);
void printAll(TreeType<NameList> &nameList);
void search();
void deleteEntry(TreeType<NameList> &nameList);
bool quitFlag = false;
int main()
{
	int input;
	do
	{
		cout << "\n\t\t||AVL TREE||";
		cout << "\n\t1.)	   Clear List";
		cout << "\n\t2.)	Add To Tree";
		cout << "\n\t3.)	Print All From Tree";
		cout << "\n\t4.)	Delete Entry";
		cout << "\n\t5.)	Search Letter";
		cout << "\n\t6.)	Exit";
		cout << "\n\n\tEnter a number from the list : ";
		cin >> input;

		switch (input)
		{
		case 1:
			clearList(nameList);
			break;
		case 2:
			addNew(nameList);
			break;
		case 3:
			printAll(nameList);
			break;
		case 4:
			deleteEntry(nameList);
			break;
		case 5:
			search();
			break;
		case 6:
			quitFlag = true;
			break;
		default:
			cout << "\n\tInvalid Input";
		}
	} while (!quitFlag);
    return 0;
}

void clearList(TreeType<NameList> &nameList)
{
	if (!nameList.IsEmpty())
	{
		cout << "\n\tName List has been cleared" << endl;
		nameList.MakeEmpty();
	}
	else 
	{
		cout << "\n\tName List is already empty" << endl;
	}
	cin.get();
}

void addNew(TreeType<NameList> &nameList)
{
	string lName;
	cout << "\n\tEnter letter : ";
	cin >> lName;

	NameList newEntry(lName);
	nameList.InsertItem(newEntry);
}

void printAll(TreeType<NameList> &nameList)
{
	cout << "\n\tData in the List : \n";
	nameList.PrintInOrder();
}

void search(TreeType<NameList>&nameList)
{
	if (nameList.IsEmpty())
	{
		cout << "\n\tLetter List is empty" << endl;
		cin.get();
	}
	else
	{
		string letter;
		cout << "\n\tEnter letter : ";
		cin >> letter;
		vector<NameList> list;
		nameList.HasA(letter, list);
		//for each(NameList input in list)
		//{
			//cout << "\n" << input;
		//}
	}
}

void deleteEntry(TreeType<NameList> &nameList)
{
	if (nameList.IsEmpty())
	{
		cout << "\n\tList is empty" << endl;
	}
	else
	{
		string letter;
		cout << "\n\tTo Cancel press 0, else enter a letter to be deleted : ";
		cin >> letter;
		if (letter != "0")
		{
			/*NameList DeleteItem(letter);
			nameList.DeleteItem(letter);*/
			NameList newEntry(letter);
			bool found;
			nameList.RetrieveItem(newEntry, found);
			if (found)
			{
				nameList.DeleteItem(newEntry);
				cout << "\n\tLetter Deleted" << endl;
			}
			else
			{
				cout << "\n\tLetter Not Found" << endl;
			}
		}
	}
}

void search()
{
	if (nameList.IsEmpty())
	{
		cout << "\n\tList is empty" << endl;
	}
	else
	{
		string letter;
		cout << "\n\tTo Cancel press 0, else enter a letter to be searched : ";
		cin >> letter;
		if (letter != "0")
		{
			NameList newEntry(letter);
			bool found;
			nameList.RetrieveItem(newEntry, found);
			if (found)
			{
				cout << "\n\tLetter Found" << endl;
			}
			else
			{
				cout << "\n\tLetter Not Found" << endl;
			}
		}
	}
}