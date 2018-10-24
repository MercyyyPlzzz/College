#pragma once
using namespace std;
class PhoneBook
{
public:
	PhoneBook();
	~PhoneBook();
private:
	string firstName;
	string lastName;
	string phoneNumber;
public:
	PhoneBook(string fname, string sname, string phoneNum);
	bool operator>(PhoneBook input);
	bool operator==(string input);
	bool operator==(PhoneBook input);
	bool operator<(PhoneBook input);
	friend ostream& operator<<(ostream& ostream, PhoneBook&);
	string GetfirstName();
	string GetlastName();
	string GetphoneNumber();
};

