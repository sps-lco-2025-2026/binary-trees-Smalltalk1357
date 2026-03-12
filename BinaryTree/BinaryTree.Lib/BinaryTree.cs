namespace BinaryTree.Lib;

public class BinaryTree
{
    Node _head;
    
    public BinaryTree()
    {
        _head = null;
    }

    public BinaryTree(int v)
    {
        _head = new Node(v);
    }

    public void Add(int v)
    {
        if (_head == null)
            _head = new Node(v);
        else
            _head.Add(v);
    }
    
}

internal class Node
{
    int _value;
    Node _left;
    Node _right;

    internal Node(int v)
    {
        _value = v;
        _left = null;
        _right = null;
    }

    internal void Add(int v)
    {
        if (v < _value)
        {
            if (_left == null)
                _left = new Node(v);
            else
                _left.Add(v);
        }
        else
        {
            if (_right == null)
                _right = new Node(v);
            else
                _right.Add(v);
        }
    }
}