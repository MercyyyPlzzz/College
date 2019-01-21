// GraphsAssignment.cpp : This file contains the 'main' function. Program execution begins and ends there.
//K00220137 Mckinley Magale Software Dev 3rd Year

#include "pch.h"
#include <iostream>
#include <string>
#include <iomanip>
#include <fstream>
#include "Graph.h"
#include "Destination.h"

using namespace std;

GraphType<Destination> destination;
void addFlight(GraphType<Destination> &destination);
void flightSched(GraphType<Destination> &destination);
void printAll(GraphType<Destination> &destination);
void search();
void deleteFlight(GraphType<Destination> &destination);
bool quitFlag = false;

int main()
{
	int input;
	do
	{
		cout << "\n\t\t||United States Travel Search||";
		cout << "\n\t1.)	Add New Flight";
		cout << "\n\t2.)	Flight Schedule";
		cout << "\n\t3.)	Delete Flight";
		cout << "\n\t4.)	Search Flight";
		cout << "\n\t5.)	Exit";
		cout << "\n\n\tEnter a number from the list : ";
		cin >> input;

		switch (input)
		{
		case 1:
			addFlight(destination);
			break;
		case 2:
			printAll(destination);
			break;
		case 3:
			deleteFlight(destination);
			break;
		case 4:
			search();
			break;
		case 5:
			quitFlag = true;
			break;
		default:
			cout << "\n\tInvalid Input";
		}
	} while (!quitFlag);
	return 0;
}

void addFlight(GraphType<Destination> &destination)
{
	string place1;
	string place2;
	int distance;
	cout << "\n\tEnter Departure Location : ";
	cin >> place1;

	Destination newEntry2(place1);
	destination.AddVertex(place1);

	cout << "\n\tEnter Arrival Location : ";
	cin >> place2;

	Destination newEntry2(place2);
	destination.AddVertex(place2);

	cout << "\n\tEnter Distance : ";
	cin >> distance;

	Destination newWeight(distance);
	destination.AddEdge(place1,place2,distance);
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
