using CleverDevices.Answers;
using System;
using Xunit;

namespace CleverDevices.Tests
{
    public class Answer2
    {
        [Fact]
        public void StackTest()
        {
            var stack = new LinkedListStack<int>();

            //insert 1 to 10 into stack
            for(int i = 1; i<=10; i++)
            {
                stack.Push(i);
            }

            //size should be 10
            Assert.Equal(10, stack.Size());

            //pop items and assert to ensure FIFO
            for(int i=10; i>0; i--)
            {
                var value = stack.Pop();
                Assert.Equal(i, value);
            }

            //size should be 0
            Assert.Equal(0, stack.Size());

            //poping on empty stack should throw an exception
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }
    }
}
