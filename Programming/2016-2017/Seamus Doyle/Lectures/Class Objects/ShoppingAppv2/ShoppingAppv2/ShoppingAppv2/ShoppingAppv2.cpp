// ShoppingAppv2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Item.h"


//DATABASE FILE ACCESS FUNCTIONS
void LoadItemsFromDatabase(void);
void SaveItemsToDatabase(void);

//FUNCTION PROTOTYPES FOR USER INTERFACE
int ShowMenu(void);
//AND CALLBACKS
void DoInitializePriceList(void);
void DoDisplayFullPriceList(void);
void DoAddItemToList(void);
void DoSetItemPrice(void);
void DoSetItemDiscountRate(void);
void DoDisplayItem(void);
void DoOrderCost(void);
void DoQuit(void);


//GLOBAL COLLECTION AND DATA
CItem  itemList[50];
int numItemsInList = 0;

bool quitFlag = false;

int _tmain(int argc, _TCHAR* argv[])
{
	LoadItemsFromDatabase();
	
	
		//DISPLAY USER INTERFACE
		int option;
		do
		{
				option = ShowMenu();
				switch (option)
				{
				case 0:
						DoInitializePriceList();
						break;
				case 1:
						DoDisplayFullPriceList();
						break;
				case 2:
						DoAddItemToList();
						break;
				case 3:
						DoSetItemPrice();
						break;
				case 4:
						DoSetItemDiscountRate();
						break;
				case 5:
						DoDisplayItem();
						break;
				case 6:
						DoOrderCost();
						break;
				case 9:
						DoQuit();
						break;
				default :
						cout << "invalid option\n";
				}
		} while (!quitFlag);

		SaveItemsToDatabase();


	return 0;
}


//FUNCTION DEFINITIONS

void LoadItemsFromDatabase(void)
{
	//LOAD list FROM DATABASE FILE
	ifstream infile("ListInfo.dat");
	if (!infile)
	{
			cout << "database file ListInfo.dat does not exist\n";
			cout << "You should initialize the list or Quit\n";
	}
	else
	{
			string description;
			int code;
			double price,discountRate;

			infile >> numItemsInList;
				
			for ( int i = 0; i < numItemsInList; i++ )
			{
				infile >> code >> description >> price >> discountRate;
				CItem  item(code , description , price , discountRate);
				itemList[i] = item;
			}
	}
}


void SaveItemsToDatabase(void)
{
	//SAVE list TO DATABASE FILE
	if ( numItemsInList == 0 )
		return;
	ofstream outfile("ListInfo.dat");
	outfile << numItemsInList << endl;

	for ( int i = 0; i < numItemsInList; i++ )
	{
			outfile << itemList[i].GetCode() << "  "
							<< itemList[i].GetDescription() << "  "
							<< itemList[i].GetPrice() << "  "
							<< itemList[i].GetDiscountRate() << endl;
	}

	outfile.close();
}



int ShowMenu(void)
{
		int option;
		cout << "\n\n\n";
		cout << "\t0.	InitializePriceList\n";
		cout << "\t1.	Display Full Price List\n";
		cout << "\t2.	Add Item to List\n";
		cout << "\t3.	Set Item Price\n";
		cout << "\t4.	Set Item Discount Rate\n";
		cout << "\t5.	Display Item\n";
		cout << "\t6.	Order Cost\n";
		cout << "\t9.	Quit\n";
		cout << "\t\tEnter option : ";
		cin >> option;
		cout << endl << endl;
		return option;
}


void DoInitializePriceList(void)
{
	if ( numItemsInList > 0 )
	{
		cout << "A list already exists!! Enter Y if you want it deleted ?\n";
		char response;
		cin >> response;
		if ( response != 'Y' )
			return;
	}
	numItemsInList = 0;

	int code;
	string description;
	double price, discountRate;
	cout << "To initialize the list you must enter item details\n";
	cout << "Enter in the item code (enter -1 to terminate): ";
	cin >> code;
	while ( code != -1 )
	{
		cout << "Enter description, price and discount rate : ";
		cin >> description >> price >> discountRate;
		CItem item(code, description, price, discountRate);
		itemList[numItemsInList] = item;
		numItemsInList++;
		cout << "Enter in the item code (enter -1 to terminate): ";
		cin >> code;
	}
}



void DoDisplayFullPriceList(void)
{
	cout << "\t\t\t Price List\n";
	for ( int i = 0; i < numItemsInList; i++ )
	{
		itemList[i].Display();
	}

		
}




void DoAddItemToList(void)
{
	int code;
	string description;
	cout << "Enter code and description for the item : ";
	cin >> code >> description;
	CItem item(code, description);

	double price, discountRate;
	cout << "Enter a price and discount rate (enter zeros if not available) :";
	cin >> price >> discountRate;
	if ( price > 0 )
		item.SetPrice(price);
	if ( discountRate > 0 )
		item.SetDiscountRate(discountRate);

	itemList[numItemsInList] = item;
	numItemsInList++;

		
}



//allow user to enter item code and price
//search the collection for the matching item
//and set its price
void DoSetItemPrice(void)
{
	int code;
	double price;
	cout << "\n\nPlease enter in the item code: ";
	cin >> code;
	cout << "\n\nPlease enter in the item price: ";
	cin >> price;

	
		for ( int i = 0; i < numItemsInList; i++ )
		{
			if (itemList[i].HasCode(code) == true)
			{			
				//Reset the item's price
				itemList[i].SetPrice(price);
			}
			
		}

}



//allow user to enter item code and discount rate
//search the collection for the matching item
//and set its discount rate
void DoSetItemDiscountRate(void)
{
	int code;
	double discountRate;
	cout << "\n\nPlease enter in the item code: ";
	cin >> code;
	cout << "\n\nPlease enter in the discount rate for the item: ";
	cin >> discountRate;

	
		for ( int i = 0; i < numItemsInList; i++ )
		{
			if (itemList[i].HasCode(code) == true)
			{
				//Reset the item's discount rate
				itemList[i].SetDiscountRate(discountRate);

			}
			
		}
}



//allow the user to enter an item code
//search the collection for a matching item 
//and display all item details
void DoDisplayItem(void)
{
	int code;
	cout << "\n\nPlease enter in the item code: ";
	cin >> code;
	
		for ( int i = 0; i < numItemsInList; i++ )
		{
			if (itemList[i].HasCode(code) == true)
			{
				//Display details for that item
				itemList[i].Display();

			}
			
		}

}



//allow the user to enter item code and quantity
//ask if customer is to be given a discount
//calculate the cost of the order (including discount if applicable)
//display the cost
void DoOrderCost(void)
{
	int code, quantity;
	string response;
	double discountRate, cost = 0;

	cout << "\n\nPlease enter in the item code: ";
	cin >> code;

	cout << "\nPlease enter in the quantity: ";
	cin >> quantity;

	for ( int i = 0; i < numItemsInList; i++ )
	{
			if (itemList[i].HasCode(code) == true)
			{
				cout << "\nIs customer to be given a discount: (Y/N) ";
				cin >> response;
				if (response == "Y")
					cost = quantity * (itemList[i].GetPrice() - itemList[i].GetDiscount());
				else
					cost = quantity * itemList[i].GetPrice();
					
			}

	}

	//Output the cost of the order
				cout << "\nCost of order " << " is "
					<< cost << " euro" << endl;		
}



void DoQuit(void)
{
	quitFlag = true;;
}

