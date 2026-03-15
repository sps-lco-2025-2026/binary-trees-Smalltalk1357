namespace BinaryTree.Tests;
using BinaryTree.Lib;

[TestClass]
public sealed class BinaryTreeTests
{
    [TestMethod]
    public void TestToString()
    {
        var tree = new BinaryTree();
        Assert.AreEqual("", tree.ToString());

        var tree2 = new BinaryTree(1);
        Assert.AreEqual("1", tree2.ToString());
    }
    
    [TestMethod]
    public void TestAdd()
    {
        var tree = new BinaryTree();
        tree.Add(3);
        tree.Add(2);
        tree.Add(1);
        Assert.AreEqual("1, 2, 3", tree.ToString());
    }

    [TestMethod]
    public void TestContains()
    {
        var tree = new BinaryTree(1);
        tree.Add(2);
        tree.Add(3);
        Assert.IsTrue(tree.Contains(2));
        Assert.IsFalse(tree.Contains(4));       
    }
    
    [TestMethod]
    public void TestSum()
    {
        var tree = new BinaryTree(0);
        Assert.AreEqual(0, tree.Sum());
        
        tree.Add(1);
        tree.Add(2);
        Assert.AreEqual(3, tree.Sum());
    }
    
    [TestMethod]
    public void TestSum2()
    {
        var tree = new BinaryTree(0);
        Assert.AreEqual(0, tree.Sum2());
        
        tree.Add(1);
        tree.Add(2);
        Assert.AreEqual(3, tree.Sum2());
    }
    
    [TestMethod]
    public void TestContainsDuplicates()
    {
        var tree = new BinaryTree(1);
        tree.Add(2);
        tree.Add(3);
        Assert.IsFalse(tree.ContainsDuplicates());
        
        tree.Add(2);
        Assert.IsTrue(tree.ContainsDuplicates());
    }
}