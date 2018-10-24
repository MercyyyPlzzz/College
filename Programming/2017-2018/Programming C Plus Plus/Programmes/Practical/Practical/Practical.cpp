// Practical.cpp : Defines the entry point for the console application.
//Met Office -K00220137	Mckinley Magale

#include "stdafx.h"

using namespace std;
//FUNCTION PROTOTYPES
void Quit(void);
int ShowMenu(void);
void OnDuty(void);
void WetDays(void);
void SunnyDays(void);
void AvgRain(void);
void HottestDay(void);
void ShortestSun(void);
//STRUCTS INITIALIZED
struct Date
{
	int day, month, yrs;
};
struct Weather
{
	Date date;
	string name;
	double hrs, rain, temp;
};
//ARRAY FORMATION
Date date[30];
Weather list[30];
//BOOLEAN VARIABLE FOR END
bool quitFlag = false;

int main()
{
	ifstream infile("weather.txt");
	if (!infile)
		cout << "\t\tList has not been established.\n\n";
	else
	{
		int day, month, yrs;
		string name;
		double hrs, rain, temp;
		
		for (int i = 0; i < 30; i++)
		{
			infile >> day >> month >> yrs >> name >> hrs >> rain >> temp;
			//ESTABLISHING DATES
			date[i].day = day;
			date[i].month = month;
			date[i].yrs = yrs;
			//ESTABLISHING WEATHER RECORDS
			list[i].date = date[i];
			list[i].name = name;
			list[i].hrs = hrs;
			list[i].rain = rain;
			list[i].temp = temp;
		}
	}

	int opt;
	do
	{
		opt = ShowMenu();
		switch (opt)
		{
		case 1:
			OnDuty();
			break;
		case 2:
			WetDays();
			break;
		case 3:
			SunnyDays();
			break;
		case 4:
			AvgRain();
			break;
		case 5:
			HottestDay();
			break;
		case 6:
			ShortestSun();
			break;
		case 7:
			Quit();
			break;
		default:
			cout << "\n\tInvalid Option";
			break;
		}
	} while (opt != 7);
    return 0;
}
void Quit(void)
{
	quitFlag = true;
}

int ShowMenu(void)
{
	int opt;
	cout << "\t\tMet Office Programme\n\n";
	cout << "\t1.)	On Duty\n";
	cout << "\t2.)	Wet Days\n";
	cout << "\t3.)	Sunny Days\n";
	cout << "\t4.)	Avg Rainfall\n";
	cout << "\t5.)	Hottest Day\n";
	cout << "\t6.)	Shortest Sunshine\n";
	cout << "\t7.)	Exit Programme\n";
	cout << "\n\n\t\tEnter a number : ";
	cin >> opt;
	return opt;
}

void OnDuty(void)
{
	string input;
	cout << "\n\n\t\tOn Duty";
	cout << "\n\tEnter a name : ";
	cin >> input;
	cout << "\n\tThis Staff has worked during these dates : ";
	for(int i = 0; i < 30; i++)
	{
		if (list[i].name == input)
		{
			cout << "\n\n\t" << date[i].day << " . " << date[i].month << " . " << date[i].yrs << "\n\n";
		}
	}
}

void WetDays(void)
{
	int days = 0;
	cout << "\n\n\t\tWet Days";
	cout << "\n\tThese are all the Wet Days : ";
	for (int i = 0; i < 30; i++)
	{
		if (list[i].rain >= 4)
		{
			cout << "\n\n\t" << date[i].day << " . " << date[i].month << " . " << date[i].yrs << "\n\n";
		}
	}
}

void SunnyDays()
{
	cout << "\n\n\t\tSunny Days";
	cout << "\n\tThese are all the Sunny Days : ";
	for (int i = 0; i < 30; i++)
	{
		if (list[i].hrs >= 5)
		{
			cout << "\n\n\t" << date[i].day << " . " << date[i].month << " . " << date[i].yrs << "\n\n";
		}
	}
}

void AvgRain(void)
{
	int one, two;
	double avg;
	double total = 0;
	double counter = 0;
	cout << "\n\n\t\tAverage RainFall";
	cout << "\n\tEnter a day : ";
	cin >> one;
	cout << "\n\tEnter a second day : ";
	cin >> two;
	for (int i = 0; i < 30; i++)
	{
		if (date[i].day == one)
		{
			one = i;
		}
	}
	for (int j = 0; j < 30; j++)
	{
		if (date[j].day == two)
		{
			two = j;
		}
	}
	while (one <= two)
	{
		total += list[one].rain;
		one++;
		counter++;
	}
	avg = total / counter;
	cout << "\n\n\t The average rain between " << date[one].day << " . " << date[one].month << " . " << date[one].yrs << " AND " << date[two].day << " . " << date[two].month << " . " << date[two].yrs << " : " << avg << "\n\n";
}

void HottestDay(void)
{
	int day = 0;
	double temper = 0;
	cout << "\n\n\t\tHottest Day";
	for (int i = 0; i < 30; i++)
	{
		if (list[i].temp > temper)
		{
			temper = list[i].temp;
			day = i;
		}
	}
	cout << "\n\n\tThe Hottest Day :";
	cout << "\n\n\t" << date[day].day << " . " << date[day].month << " . " << date[day].yrs << "\n\n";
}

void ShortestSun(void)
{
	int day = 0;
	double FullDayHrs = 24;
	cout << "\n\n\t\tShortest Sunshine Days";
	for (int i = 0; i < 30; i++)
	{
		if (list[i].hrs < FullDayHrs)
		{
			FullDayHrs = list[i].hrs;
			day = i;
		}
	}
	cout << "\n\n\tThe least Sunny Day :";
	cout << "\n\n\t" << date[day].day << " . " << date[day].month << " . " << date[day].yrs << "\n\n";
}