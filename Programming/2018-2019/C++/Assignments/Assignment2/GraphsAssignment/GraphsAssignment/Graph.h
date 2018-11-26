#pragma once
using namespace std;

class GraphType
{
public:
	GraphType();//Constructor(50 vertices by default)
	GraphType(int maxV);//Parameterized constructor, maxV <=50
	~GraphType();//Destuctor
	
	void MakeEmpty();
	bool IsEmpty() const;
	bool IsFull() const;
	void AddVertex(VertexType);
	void AddEdge(VertexType, VertexType, int);
};