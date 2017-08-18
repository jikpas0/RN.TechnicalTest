namespace StacksAnsQueues.Stores
{
    public class Queue<T> where T: new()
    {
        /*Please implement a Queue class that stores values of type int. It should 
         * implement an Enqueue(int value) method, an int Dequeue() method, an int 
         * Peek() method and optionally(if you feel you have time) a bool 
         * TryDequeue(out int value) method.*/

        private T[] QueueCollection;
        
        public void Enqueue(T value)
        {
            if (QueueCollection == null)
            {
                QueueCollection = new T[1];
                QueueCollection[0] = value;
            }
            else
            {
                T[] resizedQueueCollection = new T[QueueCollection.Length + 1];
                for (int x = 0; x < QueueCollection.Length; x++)
                {
                    resizedQueueCollection[x] = QueueCollection[x];
                }
                resizedQueueCollection[QueueCollection.Length] = value;
                QueueCollection = resizedQueueCollection;
            }
        }

        public T Dequeue()
        {
            var length = QueueCollection.Length;
            if (QueueCollection == null)
            {
                return default(T);
            }
            else
            {
                var dequeueValue = QueueCollection[length - 1];
                T[] resizedQueueCollection = new T[QueueCollection.Length - 1];
                for (int x = 1; x < QueueCollection.Length; x++)
                {
                    resizedQueueCollection[x - 1] = QueueCollection[x];
                }
                QueueCollection = resizedQueueCollection;
                return dequeueValue;
            }
        }

        public T Peek()
        {
            return QueueCollection[0];            
        }

        public bool TryDequeue(out T value)
        {
            var length = QueueCollection.Length;
            if (QueueCollection == null)
            {
                value = default(T);
                return false;
            }
            else
            {
                value = QueueCollection[0];
                T[] resizedQueueCollection = new T[QueueCollection.Length - 1];
                for (int x = 1; x < QueueCollection.Length; x++)
                {
                    resizedQueueCollection[x - 1] = QueueCollection[x];
                }
                QueueCollection = resizedQueueCollection;
                return true;
            }
        }
        public T[] GetQueueCollection() {
            return QueueCollection;
        }
    }
}
