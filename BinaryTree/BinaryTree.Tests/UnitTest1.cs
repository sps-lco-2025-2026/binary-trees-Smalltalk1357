using System.Diagnostics;
using BinaryTree.Lib;

namespace BinaryTree.Tests;


public sealed class Tests
{
    public void TestEmpty()
    {
        var tree = new Lib.BinaryTree();
        Assert.AreEqual(tree.Head, null);
    }
}