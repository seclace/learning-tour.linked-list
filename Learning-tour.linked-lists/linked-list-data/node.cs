namespace Learning_tour.linked_lists
{
    class node
    {
        public object data { get; set; }
        node next = null;
        node prev = null;

        public node() { }

        public node(object _data)
        {
            data = _data;
        }

        public node(object _data, node _prev, node _next)
        {
            next = _next;
            prev = _prev;
            data = _data;
        }

        public node(node _node)
        {
            data = _node.data;
            next = _node.next;
            prev = _node.prev;
        }

        public void setNextNode(node input)
        {
            next = input;
        }
        public void setPrevNode(node input)
        {
            prev = input;
        }

        public void setPrevAndNextNodes(node _prev, node _next)
        {
            setPrevNode(_prev);
            setNextNode(_next);
        }

        public node getNextNode()
        {
            return next;
        }
        public node getPrevNode()
        {
            return prev;
        }
    }
}
