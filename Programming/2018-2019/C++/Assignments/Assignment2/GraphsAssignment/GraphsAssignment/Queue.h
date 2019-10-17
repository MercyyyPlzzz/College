#pragma once
#include "pch.h"
using namespace std;

class FullQueue
{};

class EmptyQueue
{};

template <class ItemType>
struct NodeType;

template <class T>
struct NodeType
{
	T info;
	NodeType<T>* next;
};

template <class T>
class QueType
{
public:
	QueType();
	~QueType();
	void MakeEmpty();
	void Enqueue(T newItem);
	void Dequeue(T& item);
	bool IsEmpty() const;
	bool IsFull() const;
private:
	NodeType<T>* qFront;
	NodeType<T>*qRear;
};

template <class T>
QueType<T>::QueType()
{
	qFront = NULL;
	qRear = NULL;
}

template <class T>
QueType<T>::~QueType()
// Class destructor.
{
	MakeEmpty();
}

template <class T>
bool QueType<T>::IsEmpty() const
{
	return (qFront == NULL);
}

template <class T>
bool QueType<T> :: IsFull() const
{
	//Returns true if there is no room for another T on store
	NodeType<T>* location;
	try
	{
		location = new NodeType<T>;
		delete location;
		return false;
	}
	catch (bad_alloc exception)
	{
		return true;
	}
}

template <class T>
void QueType<T>::MakeEmpty()
// Post: Queue is empty; all elements have been
// deallocated.
{
	NodeType<T>* tempPtr;

	while (qFront != NULL)
	{
		tempPtr = qFront;
		qFront = qFront->next;
		delete tempPtr;
	}
	qRear = NULL;
}

template <class T>
void QueType<T>::Enqueue(T newItem)
{
	if (IsFull())
	{
		throw FullQueue();
	}
	else
	{
		NodeType<T>* newNode;
		newNode = new NodeType<T>;
		newNode->info = newItem;
		newNode->next = NULL;
		if (qRear == NULL)
		{
			qFront = newNode;
		}
		else
		{
			qRear->next = newNode;
		}
		qRear = newNode;
	}
}

template <class T>
void QueType<T>::Dequeue(T& item)
{
	if (IsEmpty())
	{
		throw EmptyQueue();
	}
	else
	{
		NodeType<T>* tempPtr;
		tempPtr = qFront;
		item = qFront->info;
		qFront = qFront->next;
		if (qFront == NULL)
		{
			qRear = NULL;
		}
		delete tempPtr;
	}
}