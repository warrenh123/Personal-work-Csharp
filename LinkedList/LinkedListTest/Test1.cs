using LinkedListClasses;

namespace LinkedListTest;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        MyLinkedList list1 = new MyLinkedList();
        list1.Append(5);
        Assert.AreEqual(1,list1.GetCount());
    }
}
