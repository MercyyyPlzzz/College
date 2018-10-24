#pragma once
using namespace std;
class CItem
{
public:
	CItem(void);
	~CItem(void);
private:
	int m_Code;
	string m_Description;
	double m_Price;
	double m_DiscountRate;
public:
	CItem(int code, string description);
	CItem(int code, string description, double price, double discountRate);
	void SetPrice(double price);
	void SetDiscountRate(double discountRate);
	int GetCode(void);
	string GetDescription(void);
	double GetPrice(void);
	double GetDiscountRate(void);
	bool HasCode(int searchCode);
	void Display(void);
	double GetDiscount(void);
};
