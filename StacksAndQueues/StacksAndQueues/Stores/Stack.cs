namespace StacksAnsQueues.Stores
{
    public class Stack<T> where T : new()
    {
        /*Please implement a Stack class that stores values of type int. It should implement a 
        Push(int value) method, an int Pop() method, an int Peek() method and optionally a 
        bool TryPop(out int value) method.Exactly how these work is up to you.*/

        private T[] StackCollection;
        
        public void Push(T value) {
            if (StackCollection == null)
            {
                StackCollection = new T[1];
                StackCollection[0] = value;
            }
            else
            {
                T[] resizedStackCollection = new T[StackCollection.Length + 1];
                for (int x = 0; x < StackCollection.Length; x++)
                {
                    resizedStackCollection[x] = StackCollection[x];
                }
                resizedStackCollection[StackCollection.Length] = value;
                StackCollection = resizedStackCollection;
            }
        }

        public T Pop()
        {
            var length = StackCollection.Length;
            if (StackCollection == null)
            {
                return default(T);
            }
            else
            {
                var popValue = StackCollection[length - 1];
                T[] resizedStackCollection = new T[StackCollection.Length - 1];
                for (int x = 0; x < StackCollection.Length - 1; x++)
                {
                    resizedStackCollection[x] = StackCollection[x];
                }
                StackCollection = resizedStackCollection;
                return popValue;
            }
        }

        public T Peek()
        {
            return StackCollection[StackCollection.Length - 1];
        }

        public bool TryPop(out T value)
        {
            var length = StackCollection.Length;
            if (StackCollection == null)
            {
                value = default(T);
                return false;
            }
            else
            {
                value = StackCollection[length - 1];
                T[] resizedStackCollection = new T[StackCollection.Length - 1];
                for (int x = 0; x < StackCollection.Length - 1; x++)
                {
                    resizedStackCollection[x] = StackCollection[x];
                }
                StackCollection = resizedStackCollection;
                return true;
            }
        }
        public T[] GetStackCollection()
        {
            return StackCollection;
        }
    }
}
