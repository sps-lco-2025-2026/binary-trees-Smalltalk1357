namespace BinaryTree.Lib;

public class BinaryTree
{
    Node? _head = null;
    
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
        return _head?.Contains(v) ?? false;
    }

    public int Sum()
    {
        return _head?.Sum() ?? 0;
    }

    public int Sum2()
    {
        return _head?.Sum2() ?? 0;
    }

    // easy method but not very nice
    public bool ContainsDuplicates()
    {
        string s = ToString();
        if (s != "")
        {
            string[] integers = s.Split(", ");
            if (integers.Length != new HashSet<string>(integers).Count)
                return true;
        }
        return false;
    }

    public new string ToString()
    {
        return _head?.ToString() ?? "";
    }
}

internal class Node
{
    private int _value;
    private Node? _left;
    private Node? _right;

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
    
    internal new string ToString()
    {
        string result = "";
        if (_left != null)
            result += _left.ToString() + ", ";
        result += _value;
        if (_right != null)
            result += ", " + _right.ToString();
        return result;
    }

    internal int Sum()
    {
        int result = _value;
        if (_left != null)
            result += _left.Sum();
        if (_right != null)
            result += _right.Sum();
        return result;
    }
    
    internal int Sum2() => _value + (_left?.Sum() ?? 0) + (_right?.Sum() ?? 0);
}