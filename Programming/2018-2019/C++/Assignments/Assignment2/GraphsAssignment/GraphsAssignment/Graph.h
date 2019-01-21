#pragma once
using namespace std;
template <class VertexType>
struct ItemType
{
	bool operator<(ItemType otherItem);
	bool operator==(ItemType otherItem);
	bool operator<=(ItemType otherItem);
	VertexType fromVertex;
	VertexType toVertex;
	int distance;
};
template <class T>
struct NodeType
{
	T info;
	NodeType* next;
};

template <class T>
class QueType
{
public:
	QueType();
	void Enqueue(T newItem);
	void Dequeue(T& item);
private:
	NodeType<T>* qFront;
	NodeType<T>*qRear;
};

template <class VertexType>
class GraphType
{
public:
	
	GraphType();//Constructor, default(50 vertices)
	GraphType(int maxV);
	~GraphType(); //Destructor

	void MakeEmpty();
	bool IsEmpty() const;
	bool IsFull() const;
	void AddVertex(VertexType);
	void AddEdge(VertexType, VertexType, int);
	int WeightIs(VertexType, VertexType);
	void GetToVertices(VertexType, QueType<VertexType>&);
	void ClearMarks();
	void MarkVertex(VertexType);
	bool IsMarked(VertexType) const;

private:

	int numVertices;
	int maxVertices;
	VertexType* vertices;
	int edges[50][50];
	bool* marks;//marks[i] is a mark for vertices[i]

};

template <class T>
QueType<T>::QueType()
{
	qFront = NUll;
	qRear = NULL;
}

template <class T>
void QueType<T>::Enqueue(T newItem)
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

template <class T>
void QueType<T>::Dequeue(T& item)
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
		edges[numVertices][index] = NULL_EDGE;
		edges[index][numVertices] = NULL_EDGE;
	}
	numVertices++;
}

template <class VertexType>
int IndexIs(VertexType *vertices, VertexType vertex)
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
	col = IndexIs(vertices, toVertex);
	edges[row][col] = weight;
}

template <class VertexType>
int GraphType<VertexType>::WeightIs(VertexType fromVertex, VertexType toVertex)
{
	int row;
	int column;
	row = IndexIs(vertices, fromVertex);
	col = IndexIs(vertices, toVertex);
	return edges[row][col];
}

template <class VertexType>
void GraphType<VertexType>::GetToVertices(VertexType vertex, QueType<VertexType>& adjvertexQ)
{
	int fromIndex;
	int toIndex;

	fromIndex = IndexIs(vertices, vertex);
	for (toIndex = 0; toIndex < numVertices; toIndex++)
	{
		if (edges[fromIndex][toIndex] != NULL_EDGE)
		{
			adjvertexQ.Enqueue(vertices[toIndex]);
		}
	}
}

template <class VertexType>
void BreadthFirstSearch(GraphType<VertexType> graph, VertexType startVertex, VertexType endVertex)
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

template <class VertexType>
void ShortestPath(GraphType<VertexType> graph, VertexType startVertex)
{
	ItemType item;
	int minDistance;
	PQType<ItemType> pq(10);
	QueType<VertexType> vertexQ;
	VertexType vertex;
	int count = 0;
	graph.ClearMarks();
	item.fromVertex = startVertex;
	item.toVertex = startVertex;
	item.distance = 0;
	pq.Enqueue(item);
	cout << "Last Vertex Destination Distance" << endl;
	cout << "_____________________" << endl;

	do
	{
		pq.Dequeue(item);
		if (!graph.IsMarked(item.toVertex))
		{
			graph.MarkVertex(item.toVertex);
			cout << item.fromVertex;
			cout << " ";
			cout << item.toVertex;
			cout << " " << item.distance << endl;
			item.fromVertex = item.toVertex;
			minDistance = item.distance;
			graph.GetToVertices(item.fromVertex, vertexQ);
			while (!vertexQ.IsEmpty()) 
			{
				vertexQ.Dequeue(vertex);
				if (!graph.IsMarked(vertex))
				{
					item.toVertex = vertex;
					item.distance = (++count);
					pq.Enqueue(item);
				}
			}
		}
	} while (!pq.IsEmpty());
}