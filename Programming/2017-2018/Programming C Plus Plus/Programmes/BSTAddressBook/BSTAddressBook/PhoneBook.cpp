#include "stdafx.h"
#include "PhoneBook.h"


PhoneBook::PhoneBook()
{
}


PhoneBook::~PhoneBook()
{
}

PhoneBook::PhoneBook(string fname, string sname, string phoneNum)
{
	firstName = fname;
	lastName = sname;
	phoneNumber = phoneNum;
}

bool PhoneBook::operator>(PhoneBook input)
{
	if (lastName.compare(input.lastName) == 0)
	{
		if (firstName.compare(input.firstName) > 0)
		{
			return true;
		}
	}
	if (lastName.compare(input.lastName) > 0)
	{
		return true;
	}
	return false;
}
bool PhoneBook::operator==(string input)
{
	int length = input.length();
	string name = lastName;
	if (name.substr(0, length).compare(input) == 0)
	{
		return true;
	}
	return false;
}
bool PhoneBook::operator==(PhoneBook input)
{
	return (firstName == input.firstName && lastName == input.lastName && phoneNumber == input.phoneNumber);
}
bool PhoneBook::operator<(PhoneBook input)
{
	if (lastName.compare(input.lastName) == 0)
	{
		if (firstName.compare(input.firstName) < 0)
		{
			return true;
		}
	}
	if (lastName.compare(input.lastName) < 0)
	{
		return true;
	}
	return false;

}
ostream& operator << (ostream& ostream, PhoneBook& input)
{

	ostream << setw(20) << input.GetlastName() << setw(20) << input.GetfirstName() << setw(20) << input.GetphoneNumber() << endl;
	return ostream;
}
string PhoneBook::GetfirstName()
{
	return firstName;
}
string PhoneBook::GetlastName()
{
	return lastName;
}
string PhoneBook::GetphoneNumber()
{
	return phoneNumber;
}
