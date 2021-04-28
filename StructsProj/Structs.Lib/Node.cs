using System.Collections.Generic;

namespace Structs.Lib
{
    public class Node<T>
    {
        public Node<T> LChild => _lChild;
        public Node<T> RChild => _rChild;
        private Node<T> _mother;
        private Node<T> _lChild;
        private Node<T> _rChild;
        private List<T> _value;
        private int _priority;
        
        public int Priority => _priority;
        public List<T> Value => _value;

        public Node(Node<T> mother, T value, int priority)
        {
            _mother = mother;
            _priority = priority;
            _value = new List<T> {value};
        }

        public void AddValue(T element)
        {
            _value.Add(element);
        }

        public Node()
        {
            _value = new List<T>();
        }
        
        public static void AddElement(Node<T> node, T element, int priority)
        {
            if (priority< node.Priority)
            {
                if (node._lChild==null)
                {
                    node._lChild = new Node<T>(node, element, priority);
                }
                else
                {
                    AddElement(node._lChild, element, priority);
                }

            }else if (priority > node.Priority)
            {
                if (node._rChild==null)
                {
                    node._rChild = new Node<T>(node, element, priority);
                }
                else
                {
                    AddElement(node._rChild, element, priority);
                }
            }
            else
            {
                node.AddValue(element);
            }
        }
        
        
    }
}