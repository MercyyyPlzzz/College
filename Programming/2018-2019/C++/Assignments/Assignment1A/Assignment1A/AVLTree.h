#pragma once
using namespace std;

typedef enum { LH, EH, RH } BalFactor;
template <class T>
struct TreeNode
{
	T info;
	TreeNode<T> *left;
	TreeNode<T> *right;
	BalFactor bf;
};

template <class T>
class TreeType
{
public:
	TreeType();
	~TreeType();
	
	void operator=(const TreeType<T>& originalTree);
	void MakeEmpty();
	bool IsEmpty() const;
	bool IsFull() const;
	int NumberOfNodes();				
	void RetrieveItem(T& item, bool& found);  
	void InsertItem(T item);
	void PrintTree(ofstream& outfile);
	void Display();
	void HasA(string Surname, vector<T>& list);
	//Additional Helper Functions
	void PrintInOrder();
	//AVL TREE FUNCTIONS :
	void RotateLeft(TreeNode<T>* & tree);
	void RotateRight(TreeNode<T>* & tree);
	void RightBalance(TreeNode<T> *& tree, bool& taller);
	void LeftBalance(TreeNode<T> *& tree, bool &taller);
	void DeleteItem(T item);
	void DeleteNode(TreeNode <T> * & tree, bool & shorter);
	void GetPredecessor(TreeNode<T> * tree, T & data);
	void DelRightBalance(TreeNode<T> *& tree, bool & shorter);
	void DelLeftBalance(TreeNode<T> *& tree, bool & shorter);

private:
	TreeNode<T>* root;
	void PrintInOrderPrivate(TreeNode<T> *tree);
	int CountNodes(TreeNode<T>* tree);
	void Retrieve(TreeNode<T>* tree, T& item, bool& found);
	void Insert(TreeNode<T>*& tree, T item, bool& taller);
	void Print(TreeNode<T>* tree, ofstream& outfile);
	void Destroy(TreeNode<T>* tree);
	void Search(TreeNode<T>* tree, vector<T>& list, string substr);
	void Show(TreeNode<T>* tree);
	void Delete(TreeNode<T>*& tree, T item, bool & shorter);
};


template <class T>
void TreeType<T> ::Delete(TreeNode<T>*& tree, T item, bool & shorter)
{
	if (tree != NULL)
	{
		if (item < tree->info)
		{
			Delete(tree->left, item, shorter);
			// Look in left subtree.
			if (shorter)
				switch (tree->bf)
				{
				case LH: tree->bf = EH; break;
				case EH: tree->bf = RH; shorter = false;
					break;
				case RH: DelRightBalance(tree, shorter);
				} // END SWITCH	
		}
		else if (item > tree->info)
		{
			Delete(tree->right, item, shorter);
			// Look in right subtree.
			if (shorter)
				switch (tree->bf)
				{
				case LH: DelLeftBalance(tree, shorter);
				break;				case EH: tree->bf = LH; shorter = false; 							break;
				case RH: tree->bf = EH; break;
				} // END SWITCH
		}
		else
			DeleteNode(tree, shorter);
		// Node found; call DeleteNode.
	} // END if (tree != NULL)
	else
	{
		cout << "\nNOTE: " << item
			<< " not in the tree so cannot be deleted.";
	}
}

template <class T>
void TreeType<T> ::DeleteItem(T item)
// Calls recursive function Delete to delete item from tree.
{
	bool shorter;
	Delete(root, item, shorter);
}

template<class T>
void TreeType<T>::DeleteNode(TreeNode<T>*& tree, bool & shorter)
{
	T data;	TreeNode <T> * tempPtr;
	tempPtr = tree;
	if (tree->left == NULL)
	{
		tree = tree->right;
		delete tempPtr;
		shorter = true;
	}
	else if (tree->right == NULL)
	{
		tree = tree->left;
		delete tempPtr;
		shorter = true;
	}
	else
	{
		GetPredecessor(tree, data);
		tree->info = data;
		Delete(tree->left, data, shorter);
		// Delete the predecessor node
		if (shorter)
			switch (tree->bf)
			{
			case LH: tree->bf = EH; break;
			case EH: tree->bf = RH; shorter = false;
				break;
			case RH: DelRightBalance(tree, shorter);
			}
	}

}

template<class T>
void TreeType<T>::GetPredecessor(TreeNode<T>* tree, T & data)
{
	tree = tree->left;
	while (tree->right != NULL)
		tree = tree->right;
	data = tree->info;
}

template<class T>
void TreeType<T>::DelRightBalance(TreeNode<T>*& tree, bool & shorter)
{
	TreeNode<T> * rs = tree->right;
	TreeNode<T> * ls;
	switch (rs->bf)
	{
	case RH:	tree->bf = rs->bf = EH;
		RotateLeft(tree);
		shorter = true; break;
	case EH:	tree->bf = RH;
		rs->bf = LH;
		RotateLeft(tree);
		shorter = false; break;
	case LH:	ls = rs->left;
		switch (ls->bf)
		{
		case RH:	tree->bf = LH;
			rs->bf = EH; break;
		case EH:	tree->bf = rs->bf = EH;
			break;
		case LH:	tree->bf = EH;
			rs->bf = RH; break;
		} // END SWITCH

		ls->bf = EH;
		RotateRight(tree->right);
		RotateLeft(tree);
		shorter = true;
	}

}

template<class T>
void TreeType<T>::DelLeftBalance(TreeNode<T>*& tree, bool & shorter)
{
	TreeNode<T> * ls = tree->left;
	TreeNode<T> * rs;
	switch (ls->bf)
	{
	case LH:	tree->bf = ls->bf = EH;
		RotateRight(tree);
		shorter = true; break;
	case EH:	tree->bf = LH;
		ls->bf = RH;
		RotateRight(tree);
		shorter = false; break;
	case RH:	rs = ls->right;
		switch (rs->bf)
		{
		case LH:	tree->bf = RH;
			ls->bf = EH; break;
		case EH:	tree->bf = ls->bf = EH;
			break;
		case RH:	tree->bf = EH;
			ls->bf = LH; break;
		} // END SWITCH
		rs->bf = EH;
		RotateLeft(tree->left);
		RotateRight(tree);
		shorter = true;
	}

}


template <class T>
void TreeType<T>::Search(TreeNode<T>* tree, vector<T>& list, string subs)
{
	if (tree != nullptr)
	{
		Search(tree->left, list, subs);
		if (tree->info == subs)
			list.push_back(tree->info);
		Search(tree->right, list, subs);
	}
}
template <class T>
void TreeType<T>::HasA(string surname, vector<T>& list)
{
	list.clear();
	Search(root, list, surname);
}

template<class T>
void TreeType<T>::RotateLeft(TreeNode<T>*& tree)
{
	TreeNode<T> *rs;
	if (tree == NULL)
	{
		cerr << "It is impossible to rotate an empty tree in RotateLeft" << endl;
	}
	else if (tree->right == NULL)
	{
		cerr << "It is impossible to make an empty subtree the root in RotateLeft" << endl;
	}
	else
	{
		rs = tree->right;
		tree->right = rs->left;
		rs->left = tree;
		tree = rs;
	}
}

template<class T>
void TreeType<T>::RotateRight(TreeNode<T>*& tree)
{
	TreeNode<T> *ls;
	if (tree == NULL)
	{
		cerr << "It is impossible to rotate an empty tree in RotateRight"
			<< endl;
	}
	else if (tree->left == NULL)
	{
		cerr << "It is impossible to make an empty subtree the root in RotateRight" << endl;
	}
	else
	{
		ls = tree->left;
		tree->left = ls->right;
		ls->right = tree;
		tree = ls;
	}
}

template<class T>
void TreeType<T>::RightBalance(TreeNode<T>*& tree, bool & taller)
{
	TreeNode<T> *rs = tree->right;
	TreeNode<T> *ls;

	switch (rs->bf)
	{
	case RH: 
		tree->bf = rs->bf = EH;
		RotateLeft(tree);
		taller = false;
		break;
	case EH:
		cerr << "Tree already balanced" << endl;
		break;
	case LH:
		ls = rs->left;
		switch (ls->bf)
		{
		case RH:
			tree->bf = LH;
			rs->bf = EH;
			break;
		case EH:
			tree->bf = rs->bf = EH;
			break;
		case LH:
			tree->bf = EH;
			rs->bf = RH;
			break;
		}
		ls->bf = EH;
		RotateRight(tree->right);
		RotateLeft(tree);
		taller = false;
	}
}

template <class T>
void TreeType<T>:: LeftBalance(TreeNode<T>* &tree, bool &taller)
{
	TreeNode<T>* ls = tree->left;
	TreeNode<T>* rs;
	switch (ls->bf)
	{
	case LH:
		tree->bf = ls->bf = EH;
		RotateRight(tree);
		taller = false;
		break;
	case EH:
		cerr << "Tree already balanced" << endl;
		break;
	case RH:
		rs = ls->right;
		switch (rs->bf)
		{
		case LH:
			tree->bf = RH;
			ls->bf = EH;
			break;
		case EH:
			tree->bf = ls->bf = EH;
			break;
		case RH:
			tree->bf = EH;
			ls->bf = LH;
			break;
		}
		rs->bf = EH;
		RotateLeft(tree->left);
		RotateRight(tree);
		taller = false;
	}
}

template <class T>
TreeType<T>::TreeType()
{
	root = nullptr;
}

template <class T>
void TreeType<T>::Display()
{
	Show(root);
}

template <class T>
void TreeType<T>::PrintInOrder()
{
	PrintInOrderPrivate(root);
}

template <class T>
void TreeType<T>::PrintInOrderPrivate(TreeNode<T> *tree)
{
	TreeNode<T>* left = tree->left;
	TreeNode<T>* right = tree->right;
	if (root != NULL)
	{
		string bf = "";
		switch (tree->bf)
		{
		case 0: bf = "LH";
			break;
		case 1:bf = "EH";
			break;
		case 2:bf = "RH";
			break;
		}
		if (left != NULL)
		{
			PrintInOrderPrivate(left);
		}
		if (right != NULL)
		{
			PrintInOrderPrivate(tree->right);
		}
		if (left != NULL)
		{
			cout << "\nParent Node =\t" << tree->info << "Left =\t" << left->info;
		}
		else
		{
			cout <<"\nParent Node =\t"<< tree->info;
			cout << "Left = NULL\t";
		}		
		if (right != NULL)
		{
			cout << "Right =\t" << right->info;
			cout << "Bal F =\t" << bf << endl;
		}
		else
		{
			cout << "Right = NULL\t" << "Bal F =" << bf << endl;
		}
	}
	else
	{
		cout << "\nTree is Empty\n";
	}
	/*if (root != NULL)
	{
		if (tree->left != NULL)
		{
			PrintInOrderPrivate(tree->left);
		}
		string bf="";
		switch (tree->bf)
		{
		case 0: bf = "LH";
			break;
		case 1:bf = "EH";
			break;
		case 2:bf = "RH";
			break;
		}
		if (tree->left != NULL)
		{
			cout << tree->info << " " << "Left = " << left->info << "BalF = " << bf << endl;
		}
		else
		{
			cout << "Left = NULL"<<endl;
		}
		if (tree->right != NULL)
		{
			cout << tree->info << " " << " Right = " << right->info<< " BalF = "<<bf<<endl;
		}
		else
		{
			cout << " Right = NULL" << endl;
		}
		if (tree->right != NULL)
		{
			PrintInOrderPrivate(tree->right);
		}
	}
	else
	{
		cout << "\nTree is Empty\n";
	}*/
}

template <class T>
void TreeType<T>::Show(TreeNode<T>* tree)
{
	if (tree != nullptr)
	{
		Show(tree->left);
		cout << tree->info;
		Show(tree->right);
	}
}
template <class T>
TreeType<T>::~TreeType()
{
	Destroy(root);
}

template <class T>
void TreeType<T>::MakeEmpty()
{
	Destroy(root);
	root = nullptr;
}
template <class T>
void TreeType<T>::Destroy(TreeNode<T>* tree)
{
	if (tree != nullptr)
	{
		Destroy(tree->left);
		Destroy(tree->right);
		delete tree;
	}
}

template <class T>
bool TreeType<T>::IsFull() const
{
	if (root == NULL)
		return true;
	if (root->left == NULL && root->right == NULL)
		return true;
	if ((root->left) && (root->right))
		return (isFull(root->left) && isFull(root->right));

	return false;
}
template <class T>
bool TreeType<T>::IsEmpty() const
{
	return root == nullptr;
}

template <class T>
void TreeType<T>::PrintTree(ofstream& outfile)
{
	Print(root, outfile);
}

template <class T>
void TreeType<T>::Print(TreeNode<T>* tree, ofstream& outfile)
{
	if (tree != NULL)
	{
		Print(tree->left, outfile);
		outfile << tree->info;
		Print(tree->right, outfile);
	}

}

template <class T>
void TreeType<T>::InsertItem(T item)
{
	bool taller = false;
	Insert(root, item, taller);
}

template <class T>
void TreeType<T>::Insert(TreeNode<T>*& tree, T item, bool& taller)
{
	if (tree == NULL)
	{
		tree = new TreeNode<T>;
		tree->left = NULL;
		tree->right = NULL;
		tree->info = item;
		tree->bf = EH;
		taller = true;
	}
	else if (item == tree->info)
	{
		cerr << "Duplicate key is not allowed in AVL tree." << endl;
	}
	else if (item < tree->info)
	{
		Insert(tree->left, item, taller);
		if (taller)
		{
			switch (tree->bf)
			{
				case LH: 
				{
					LeftBalance(tree, taller);
					break;
				}
				case EH:
				{
					tree->bf = LH;
					break;
				}
				case RH:
				{
					tree->bf = EH;
					taller = false;
					break;
				}
			}
		}
	}
	else if (item > tree->info)
	{
		Insert(tree->right, item, taller);
		if (taller)
		{
			switch (tree->bf)
			{
			case RH:
			{
				RightBalance(tree, taller);
				break;
			}
			case EH: 
			{
				tree->bf = RH;
				break;
			}
			case LH:
			{
				tree->bf = EH;
				taller = false;
				break;
			}
			}
		}
	}
}

template <class T>
int TreeType<T>::NumberOfNodes()
{
	return CountNodes(root);
}

template <class T>
int TreeType<T>::CountNodes(TreeNode<T>* tree)
{
	if (tree == nullptr)
		return 0;
	else
		return CountNodes(tree->left) + CountNodes(tree->right) + 1;
}

template <class T>
void TreeType<T>::RetrieveItem(T& item, bool& found)
{
	Retrieve(root, item, found);
}
template <class T>
void TreeType<T>::Retrieve(TreeNode<T>* tree, T& item, bool& found)
{
	if (tree == nullptr)
		found = false;
	else if (item < tree->info)
		Retrieve(tree->left, item, found);
	else if (item > tree->info)
		Retrieve(tree->right, item, found);
	else
	{
		found = true;
		item = tree->info;
	}
}

