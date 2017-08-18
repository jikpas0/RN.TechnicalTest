using NUnit.Framework;
using StacksAnsQueues.Stores;

namespace StacksAndQueues.Tests
{
    [TestFixture]
    public class QueueTest
    {
        [TestCase(2)]
        public void EnqueueTest(int count)
        {
            //setup
            Queue<int> queue = new Queue<int>();

            //Act
            for (int x = 0; x <= count; x++)
            {
                queue.Enqueue(x);
            }            

            //Assert
            Assert.That(queue.GetQueueCollection, Is.Not.Null);
        }

        [TestCase(2)]
        public void DequeueTest(int count)
        {
            //setup
            Queue<int> queue = new Queue<int>();

            //Act
            for (int x = 0; x <= count; x++)
            {
                queue.Enqueue(x);
            }
            queue.Dequeue();

            //Assert
            Assert.That(queue.GetQueueCollection, Is.Not.Null);
        }

        [TestCase(2)]
        public void PeekTest(int count)
        {
            //setup
            Queue<int> queue = new Queue<int>();

            //Act
            for (int x = 0; x <= count; x++)
            {
                queue.Enqueue(x);
            }
            var peekValue = queue.Peek();

            //Assert
            Assert.That(peekValue, Is.Not.Null);
        }

        [TestCase(2)]
        public void TryDequeueTest(int count)
        {
            //setup
            Queue<int> queue = new Queue<int>();

            //Act
            for (int x = 0; x <= count; x++)
            {
                queue.Enqueue(x);
            }
            int value;
            var isParsed = queue.TryDequeue(out value);

            //Assert
            Assert.That(queue.GetQueueCollection, Is.Not.Null);
        }
    }
}
