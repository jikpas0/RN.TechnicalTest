using NUnit.Framework;
using StacksAnsQueues.Stores;

namespace StacksAndQueues.Tests
{
    [TestFixture]
    public class StackTest
    {
        [TestCase(2)]
        public void PushTest(int count)
        {
            //setup
            Stack<int> stack = new Stack<int>();

            //Act
            for (int x = 0; x <= count; x++)
            {
                stack.Push(x);
            }

            //Assert            
            Assert.That(stack.GetStackCollection, Is.Not.Null);
        }

        [TestCase(2)]
        public void PopTest(int count)
        {
            //setup
            Stack<int> stack = new Stack<int>();

            //Act
            for (int x = 0; x <= count; x++)
            {
                stack.Push(x);
            }
            stack.Pop();

            //Assert            
            Assert.That(stack.GetStackCollection, Is.Not.Null);
        }

        [TestCase(2)]
        public void PeekTest(int count)
        {
            //setup
            Stack<int> stack = new Stack<int>();

            //Act
            for (int x = 0; x <= count; x++)
            {
                stack.Push(x);
            }
            var peekValue = stack.Peek();

            //Assert            
            Assert.That(peekValue, Is.Not.Null);
        }

        [TestCase(2)]
        public void TryPopTest(int count)
        {
            //setup
            Stack<int> stack = new Stack<int>();

            //Act
            for (int x = 0; x <= count; x++)
            {
                stack.Push(x);
            }
            int value;
            var isParsed = stack.TryPop(out value);

            //Assert            
            Assert.That(value, Is.Not.Null);
        }
    }
}
