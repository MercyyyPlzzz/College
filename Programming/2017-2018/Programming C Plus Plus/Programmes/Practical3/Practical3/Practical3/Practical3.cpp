// Practical3.cpp : Defines the entry point for the console application.
//Mckinley Magale - K00220137

#include "stdafx.h"

using namespace std;
int pal(char[], int size);
bool isPrime(int p, int n);
int main()
{
	char str[20];
	cout << "\nEnter a string : ";
	cin.getline(str, 20);
	cout << ((pal(str, strlen(str) + 1)) ? "Returned a 1 so this is" : "Returned a 0 so this is not") << " a Palindrome string." << endl;
	
	int p,n;
	cout << "Enter a positive integer: ";
	cin >> p;
	n = p - 1;
	isPrime(p,n);
	
    return 0;
}
int pal(char str[], int size)
{
	if (str[0] != str[size - 2])
	{
		return 0;
	}
	else if (strlen(str) <= 1)
	{
		return 1;
	}
	else return pal(str + 1, size - 2);
}

bool isPrime(int p, int n)
{
	if (n <= 1)
	{
		cout << p << " is a prime." << endl;
		return true;
	}
	else if (p%n == 0)
	{
		int l = p / n;
		cout << p << " is not a prime." << endl;
		return false;
	}
	else
	{
		isPrime(p, n - 1);
	}
}


