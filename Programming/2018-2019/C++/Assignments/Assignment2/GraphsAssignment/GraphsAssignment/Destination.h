#pragma once
#include "GraphsAssignment.cpp"
using namespace std;
class Destination
{
public:
	Destination();
	~Destination();
private:
	string Place;
	int Distance;
public:
	Destination(string place);
	Destination(int distance);
	bool operator>(Destination input);
	bool operator==(string input);
	bool operator==(Destination input);
	bool operator<(Destination input);
	friend ostream &operator<<(ostream &ostream, Destination&);

	string GetPlace();
	int GetDistance();
};