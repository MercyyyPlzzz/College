#include "stdafx.h"
#include "Item.h"


CItem::CItem(void)
	: m_Code(0)
	 ,m_Description("")
	, m_Price(0)
	, m_DiscountRate(0)
{
}


CItem::~CItem(void)
{
}


CItem::CItem(int code, string description)
	: m_Code(code)
	,m_Description(description)
	, m_Price(0)
	, m_DiscountRate(0)
{
}


CItem::CItem(int code, string description, double price, double discountRate)
	: m_Code(code)
	,m_Description(description)
	, m_Price(price)
	, m_DiscountRate(discountRate)
{
}


void CItem::SetPrice(double price)
{
	m_Price = price;
}


void CItem::SetDiscountRate(double discountRate)
{
	m_DiscountRate = discountRate;
}


int CItem::GetCode(void)
{
	return m_Code;
}


string CItem::GetDescription(void)
{
	return m_Description;
}


double CItem::GetPrice(void)
{
	return m_Price;
}


double CItem::GetDiscountRate(void)
{
	return m_DiscountRate;
}


bool CItem::HasCode(int searchCode)
{
	if ( m_Code == searchCode )
		return true;
	else
		return false;
}


void CItem::Display(void)
{
	cout << "\t" << setw(3) << setfill('0') <<  m_Code << setfill(' ')
		 << "\t" << setw(20) << left << m_Description 
		 << setw(8) << right << fixed << setprecision(2) << m_Price 
		 << setw(8) << right << fixed << setprecision(2) << m_DiscountRate << endl;
}


double CItem::GetDiscount(void)
{
	double discount;
	discount = m_Price * m_DiscountRate / 100;
	return discount;
}
