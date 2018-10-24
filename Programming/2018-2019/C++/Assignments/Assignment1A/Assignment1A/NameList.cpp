#include "stdafx.h"
#include "NameList.h"


NameList::NameList()
{
}


NameList::~NameList()
{
}

NameList::NameList( string lName)
{
	lastName = lName;
}
 
bool NameList::operator>(NameList input)
{
	if (lastName.compare(input.lastName) > 0)
	{
		return true;
	}
	return false;
}

bool NameList::operator==(string input)
{
	int length = input.length();
	string name = lastName;
	if (name.substr(0, length).compare(input) == 0)
	{
		return true;
	}
	return false;
}

bool NameList::operator==(NameList input)
{
	return ( lastName == input.lastName);
}

bool NameList::operator<(NameList input)
{
	if (lastName.compare(input.lastName) < 0)
	{
		return true;
	}
	return false;
}

ostream &operator<<(ostream &ostream, NameList &input)
{
	ostream  << setw(20) << input.GetlastName() << endl;
	return ostream;
}


string NameList::GetlastName()
{
	return lastName;
}
