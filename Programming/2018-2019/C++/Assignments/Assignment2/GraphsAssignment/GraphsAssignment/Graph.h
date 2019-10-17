#pragma once

#include "Queue.h"
#include "pch.cpp"
using namespace std;

template <class VertexType>
class GraphType
{
	
public:
	GraphType();//Constructor, default(50 vertices)
	GraphType(int maxV);
	~GraphType(); //Destructor

	bool IsEdge(VertexType fromVertex, VertexType toVertex);
	void print();
	void MakeEmpty();
	bool IsEmpty() const;
	bool IsFull() const;
	void AddVertex(VertexType vertex);
	void AddEdge(VertexType fromVertex, VertexType toVertex, int);
	int WeightIs(VertexType fromVertex, VertexType toVertex);
	void GetToVertices(VertexType vertex, QueType<VertexType>& adjvertexQ);
	void ClearMarks();
	void MarkVertex(VertexType vertex);
	bool IsMarked(VertexType vertex) const;
	void BreadthFirstSearch(GraphType<VertexType> graph, VertexType startVertex, VertexType endVertex);
private:
	int numVertices;
	int maxVertices;
	VertexType* vertices;
	int edges[50][50];
	bool* marks;//marks[i] is a mark for vertices[i]
};

