#include "GraphsAssignment.cpp"
#include "Destination.h"

Destination::Destination() {}

Destination::~Destination() {}

Destination::Destination(string place)
{
	Place = place;
}

Destination::Destination(int distance)
{
	Distance = distance;
}

bool Destination::operator>(Destination input)
{
	if (Place.compare(input.Place) > 0)
	{
		return true;
	}
	return false;
}

bool Destination::operator==(string input)
{
	int length = input.length();
	string location = Place;
	if (location.substr(0, length).compare(input) == 0)
	{
		return true;
	}
	return false;
}

bool Destination::operator==(Destination input)
{
	return (Place == input.Place);
}

bool Destination::operator<(Destination input)
{
	if (Place.compare(input.Place) < 0)
	{
		return true;
	}
	return false;
}

ostream &operator<<(ostream &ostream, Destination &input)
{
	ostream << setw(20) << input.GetPlace() << endl;
	return ostream;
}

string Destination::GetPlace()
{
	return Place;
}

int Destination::GetDistance()
{
	return Distance;
}