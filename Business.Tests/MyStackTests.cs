using NUnit.Framework;
using Business;
using System;

namespace Business.Tests
{
    [TestFixture]
    public class MyStackTests
    {
        [Test]
        public void Properties_WhenNew_IsEmpty()
        {
            var myStack = new MyStack<int>();
            Assert.AreEqual(0, myStack.Count);
            Assert.AreEqual(true, myStack.IsEmpty);
        }

        [Test]
        public void Peek_AfterAddingValues_ReturnsLastAdded()
        {
            var myStack = new MyStack<int>();
            myStack.Push(5);
            myStack.Push(10);
            Assert.AreEqual(10, myStack.Peek());
            Assert.AreEqual(2, myStack.Count);
        }

        [Test]
        public void Pop_AfterAddingValues_RemovesLastAdded()
        {
            var myStack = new MyStack<int>();
            myStack.Push(5);
            myStack.Push(10);
            myStack.Push(20);

            Assert.AreEqual(3, myStack.Count);
            myStack.Pop();
            Assert.AreEqual(2, myStack.Count);
            Assert.AreEqual(10, myStack.Peek());
        }

        [Test]
        public void Pop_WhenEmpty_ThrowsException() 
        {
            var myStack = new MyStack<int>();
            TestDelegate action = () => myStack.Pop();
            Assert.Throws<InvalidOperationException>(action);
        }
    }
}
