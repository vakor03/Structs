using System;

namespace Structs.Lib
{
    public class Deque<T>
    {
        private static int _startedLength = 10;

        public static int StartedLength
        {
            get => _startedLength;

            set
            {
                if (value > 0)
                {
                    _startedLength = value;
                }
                else
                {
                    _startedLength = Math.Abs(value);
                }
            }
        }

        private T[] _array;
        private int _startIndex;
        private int _lastIndex;

        public Deque()
        {
            _array = new T[10];
            _startIndex = 5;
            _lastIndex = 5;
        }

        public void AddToEnd(T item)
        {
            if (_lastIndex == _array.Length - 1)
            {
                EnlargeEnd();
            }

            _array[++_lastIndex] = item;
        }

        private void EnlargeEnd()
        {
            T[] newArray = new T[_array.Length + (_lastIndex - _startIndex)];
            for (int i = _startIndex + 1; i <= _lastIndex; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        private void EnlargeStart()
        {
            int amountOfEl = (_lastIndex - _startIndex);
            T[] newArray = new T[_array.Length + amountOfEl];
            for (int i = _startIndex + 1; i <= _lastIndex; i++)
            {
                newArray[i + amountOfEl] = _array[i];
            }

            _startIndex += amountOfEl;
            _lastIndex += amountOfEl;
            _array = newArray;
        }

        public void AddToStart(T item)
        {
            if (_startIndex == -1)
            {
                EnlargeStart();
            }

            _array[_startIndex--] = item;
        }

        public T PickFromStart()
        {
            return _array[++_startIndex];
        }

        public T PickFromEnd()
        {
            return _array[_lastIndex--];
        }
    }
}