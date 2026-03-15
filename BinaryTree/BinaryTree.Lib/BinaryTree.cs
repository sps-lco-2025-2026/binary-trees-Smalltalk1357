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

    public bool Contains(int v)
    {
        if (_head == null)
            return false;
        return _head.Contains(v);
    }

    public int Sum()
    {
        if (_head == null)
            return 0;
        return _head.Sum();
    }

    public int Sum2()
    {
        return _head?.Sum2() ?? 0;
    }

    public new string ToString()
    {
        return _head?.ToString() ?? "";
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

    internal bool Contains(int v)
    {
        if (v == _value)
            return true;
        if (v < _value)
            return _left?.Contains(v) ?? false;
        return _right?.Contains(v) ?? false;
    }
    
    public new string ToString()
    {
        string result = "";
        if (_left != null)
            result += _left.ToString() + ", ";
        result += _value;
        if (_right != null)
            result += ", " + _right.ToString();
        return result;
    }

    public int Sum()
    {
        int result = _value;
        if (_left != null)
            result += _left.Sum();
        if (_right != null)
            result += _right.Sum();
        return result;
    }
    
    public int Sum2() => _value + (_left?.Sum() ?? 0) + (_right?.Sum() ?? 0);
}