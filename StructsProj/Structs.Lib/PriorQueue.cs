using System.Collections.Generic;

namespace Structs.Lib
{
    public class PriorQueue<T>
    {
        private Node<T> _root;

        public PriorQueue()
        {
        }

        public PriorQueue(T element, int priority)
        {
            _root = new Node<T>(null, element, priority);
        }

        public void AddElement(T element, int priority)
        {
            if (_root == null)
            {
                _root = new Node<T>(null, element, priority);
            }
            else
            {
                Node<T>.AddElement(_root, element, priority);
            }
        }

        public List<T> GetByPriority(int priority)
        {
            return GetByPriority(priority, _root);
        }
        private List<T> GetByPriority(int priority, Node<T> currentNode)
        {
            if (currentNode != null)
            {
                if (priority < currentNode.Priority)
                {
                    return GetByPriority(priority, currentNode.LChild);
                }

                if (priority > currentNode.Priority)
                {
                    return GetByPriority(priority, currentNode.RChild);
                }

                return currentNode.Value;
            }

            return null;
        }
    }
}