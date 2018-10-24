#pragma once
using namespace std;
class NameList
{
public:
	NameList();
	~NameList();
private:
	string lastName;
public:
	NameList( string lastName);
	bool operator>(NameList input);
	bool operator==(string input);
	bool operator==(NameList input);
	bool operator<(NameList input);
	friend ostream &operator<<(ostream &ostream, NameList&);

	string GetlastName();
};

