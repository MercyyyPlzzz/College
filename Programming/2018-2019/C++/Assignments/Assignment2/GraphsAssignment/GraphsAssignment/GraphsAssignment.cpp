// GraphsAssignment.cpp : This file contains the 'main' function. Program execution begins and ends there.
//K00220137 Mckinley Magale Software Dev 3rd Year

#include "pch.h"
#include "Graph.h"
#include "Queue.h"

using namespace std;

template <class VertexType>
GraphType<VertexType>::GraphType()
{
	numVertices = 0;
	maxVertices = 50;
	vertices = new VertexType[50];
	marks = new bool[50];
}

template <class VertexType>
GraphType<VertexType>::GraphType(int maxV)
{
	numVertices = 0;
	maxVertices = maxV;
	vertices = new VertexType[maxV];
	marks = new bool[maxV];
}

template <class VertexType>
GraphType<VertexType>::~GraphType()
{
	delete[] vertices;
	delete[] marks;
}

template <class VertexType>
void GraphType<VertexType>::AddVertex(VertexType vertex)
{
	vertices[numVertices] = vertex;
	for (int index = 0; index < numVertices; index++)
	{
		edges[numVertices][index] = NULL;
		edges[index][numVertices] = NULL;
	}
	numVertices++;
}

template <class VertexType>
int IndexIs(VertexType * vertices, VertexType vertex)
{
	int index = 0;
	while (!(vertex == vertices[index]))
	{
		index++;
	}
	return index;
}

template <class VertexType>
void GraphType<VertexType>::AddEdge(VertexType fromVertex, VertexType toVertex, int weight)
{
	int row;
	int column;
	row = IndexIs(vertices, fromVertex);
	column = IndexIs(vertices, toVertex);
	edges[row][column] = weight;
}

template <class VertexType>
int GraphType<VertexType>::WeightIs(VertexType fromVertex, VertexType toVertex)
{
	int row;
	int column;
	row = IndexIs(vertices, fromVertex);
	column = IndexIs(vertices, toVertex);
	return edges[row][column];
}

template <class VertexType>
void GraphType<VertexType>::MakeEmpty()
{
	numVertices = 0;
}

template <class VertexType>
bool GraphType<VertexType>::IsEmpty() const
{
	if (numVertices == 0)
		return true;
	else
		return false;
}

template <class VertexType>
bool GraphType<VertexType>::IsFull() const
{
	if (numVertices == maxVertices)
		return true;
	else
		return false;
}

template <class VertexType>
void GraphType<VertexType>::ClearMarks()
{
	for (int i = 0; i < maxVertices; i++)
		marks[i] = false;
}

template <class VertexType>
void GraphType<VertexType>::MarkVertex(VertexType vertex)
{
	int ix = IndexIs(vertices,vertex);
	marks[ix] = true;
}

template <class VertexType>
bool GraphType<VertexType>::IsMarked(VertexType vertex) const
{
	int index = IndexIs(vertices,vertex);
	if (marks[index] == true)
		return true;
	else
		return false;
}


template <class VertexType>
void GraphType<VertexType>::GetToVertices(VertexType vertex, QueType<VertexType>& adjvertexQ)
{
	int fromIndex;
	int toIndex;

	fromIndex = IndexIs(vertices, vertex);
	for (toIndex = 0; toIndex < numVertices; toIndex++)
	{
		if (edges[fromIndex][toIndex] != NULL)
		{
			adjvertexQ.Enqueue(vertices[toIndex]);
		}
	}
}

template <class VertexType>
void GraphType<VertexType>::print()
{
	ClearMarks();
	for (int i = 0; i < numVertices; i++)
	{
		for (int j = 0; j < numVertices; j++)
		{
			if (edges[i][j] > 0)
			{
				cout <<"\t"<< *(vertices + i) << " to " << *(vertices + j) << "\t" << WeightIs(*(vertices + i), *(vertices + j)) << endl;
			}
		}
	}
}

template<class VertexType>
bool GraphType<VertexType>::IsEdge(VertexType fromVertex, VertexType toVertex)
{
	int fromIndex;
	int toIndex;

	toIndex = IndexIs(vertices ,toVertex);
	fromIndex = IndexIs(vertices, fromVertex);

	if (edges[fromIndex][toIndex] != NULL)
	{
		return 1;
	}
	else
	{
		return 0;
	}
}

template <class VertexType>
void GraphType<VertexType>::BreadthFirstSearch(GraphType<VertexType> graph, VertexType startVertex, VertexType endVertex)
{
	QueType<VertexType> queue;
	QueType<VertexType> vertexQ;
	bool found = false;
	VertexType vertex;
	VertexType item;

	graph.ClearMarks();
	queue.Enqueue(startVertex);

	do
	{
		queue.Dequeue(vertex);
		if (vertex == endVertex)
		{
			cout << vertex;
			found = true;
		}
		else
		{
			if (!graph.IsMarked(vertex))
			{
				graph.MarkVertex(vertex);
				cout << vertex;
				graph.GetToVertices(vertex, vertexQ);
				while (!vertexQ.IsEmpty())
				{
					vertexQ.Dequeue(item);
					if (!graph.IsMarked(item))
					{
						queue.Enqueue(item);
					}
				}
			}
		}
	} while (!queue.IsEmpty() && !found);
	if (!found)
	{
		cout << "Path not found." << endl;
	}
}

//template <class VertexType>
//void ShortestPath(GraphType<VertexType> graph, VertexType startVertex)
//{
//	ItemType item;
//	int minDistance;
//	PQType<ItemType> pq(10);
//	QueType<VertexType> vertexQ;
//	VertexType vertex;
//	int count = 0;
//	graph.ClearMarks();
//	item.fromVertex = startVertex;
//	item.toVertex = startVertex;
//	item.distance = 0;
//	pq.Enqueue(item);
//	cout << "Last Vertex Destination Distance" << endl;
//	cout << "_____________________" << endl;
//
//	do
//	{
//		pq.Dequeue(item);
//		if (!graph.IsMarked(item.toVertex))
//		{
//			graph.MarkVertex(item.toVertex);
//			cout << item.fromVertex;
//			cout << " ";
//			cout << item.toVertex;
//			cout << " " << item.distance << endl;
//			item.fromVertex = item.toVertex;
//			minDistance = item.distance;
//			graph.GetToVertices(item.fromVertex, vertexQ);
//			while (!vertexQ.IsEmpty())
//			{
//				vertexQ.Dequeue(vertex);
//				if (!graph.IsMarked(vertex))
//				{
//					item.toVertex = vertex;
//					item.distance = (++count);
//					pq.Enqueue(item);
//				}
//			}
//		}
//	} while (!pq.IsEmpty());
//}

void addFlight();
void searchFlight();
void printFlight();
void deleteFlight();
bool quitFlag = false;
GraphType<string> flight = GraphType<string>();
using namespace std;
int main()
{
	flight.AddVertex("Atlanta");
	flight.AddVertex("Austin");
	flight.AddVertex("Chicago");
	flight.AddVertex("Dallas");
	flight.AddVertex("Denver");
	flight.AddVertex("Houston");
	flight.AddVertex("Washington");

	flight.AddEdge("Atlanta", "Houston", 800);
	flight.AddEdge("Atlanta", "Washington", 600);

	flight.AddEdge("Austin", "Dallas", 200);
	flight.AddEdge("Austin", "Houston", 160);

	flight.AddEdge("Chicago", "Denver", 1000);

	flight.AddEdge("Dallas", "Austin", 200);
	flight.AddEdge("Dallas", "Chicago", 900);
	flight.AddEdge("Dallas", "Denver", 780);

	flight.AddEdge("Denver", "Atlanta", 1400);
	flight.AddEdge("Denver", "Chicago", 1000);

	flight.AddEdge("Houston", "Atlanta", 800);

	flight.AddEdge("Washington", "Atlanta", 600);
	flight.AddEdge("Washington", "Dallas", 1300);

	int input;
	do
	{
		cout << "\n\t\t --Gairport Station--\n\n";
		cout << "\t1. Add Flight\n";
		cout << "\t2. Print Flight\n";
		cout << "\t3. Delete Flight\n";
		cout << "\t4. Search Flight\n";
		cout << "\t5. Exit Programe\n\n";
		cout << "\n\n\t Enter Option : ";
		cin >> input;

		switch (input)
		{
		case 1:
			addFlight();
			break;
		case 2:
			printFlight();
			break;
		case 3:
			deleteFlight();
			break;
		case 4:
			searchFlight();
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

void addFlight()
{
	string place1;
	string place2;
	int distance;
	cout << "\n\tEnter Departure Location : ";
	cin >> place1;

	cout << "\n\tEnter Arrival Location : ";
	cin >> place2;

	cout << "\n\tEnter Distance : ";
	cin >> distance;

	flight.AddVertex(place1);
	flight.AddVertex(place2);
	flight.AddEdge(place1, place2, distance);
}

void searchFlight()
{
	if (flight.IsEmpty())
	{
		cout << "\n\tFlight Schedule is not implemented" << endl;
		cin.get();
	}
	else
	{
		string place1, place2;
		cout << "\n\tEnter a Departing Airport Location : ";
		cin >> place1;
		cout << "\n\tEnter an Arrival Airport Location : ";
		cin >> place2;

		cout << "\n\tYour flight will be " << endl;
		flight.BreadthFirstSearch(flight,place1,place2);
	}
	
}

void deleteFlight()
{
	string place1, place2;

	cout << "\n\tEnter a Departing Airport Location : ";
	cin >> place1;
	cout << "\n\tEnter an Arrival Airport Location : ";
	cin >> place2;
	if (flight.IsEdge(place1, place2) == true)
	{
		flight.AddEdge(place1, place2, NULL);
		cout << "\n\tFlight Deleted \n" << endl;
	}
}

void printFlight()
{
	cout << "\t-- Flight Schedule --\n\n";
	flight.print();
}