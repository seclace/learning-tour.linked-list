namespace Learning_tour.linked_lists
{
    class LinkedList
    {
        node beginNode;
        node endNode;

        public int count { get; private set; }

        public node this[int i]
        {
            get { return getNodeByIndex(i); }
        }

        public LinkedList()
        {
            count = 0;
        }

        public node getNodeByIndex(int index)
        {
            node n = beginNode;
            while (index-- > 0)
            {
                if (n.getNextNode() == null) break;
                else n = n.getNextNode();
            }
            return n;
        }

        public node getFirstNode()
        {
            return beginNode;
        }

        public node getLastNode()
        {
            return endNode;
        }

        public void addNode(object input)
        {
            if (beginNode == null) {
                beginNode = new node(input);
                endNode = beginNode;
            }
            else
            {
                node tmp = new node(input);
                endNode.setNextNode(tmp);
                tmp.setPrevNode(endNode);
                endNode = tmp;
            }
            count++;
        }

        public void addNodeByIndex(object input, int index)
        {
            node n = getNodeByIndex(index), 
                nPrev = n.getPrevNode();
            node newNode = new node(input);
            nPrev.setNextNode(newNode);
            n.setPrevNode(newNode);
            newNode.setPrevAndNextNodes(nPrev, n);
            count++;
        }

        public void removeNodeByIndex(int index)
        {
            node n = getNodeByIndex(index),
                nPrev = n.getPrevNode(),
                nNext = n.getNextNode();
            if (nPrev != null) nPrev.setNextNode(nNext);
            if (nNext != null) nNext.setPrevNode(nPrev);
            if (index == 0) beginNode = nNext;
            else if (index == count) endNode = nPrev;
            count = count > 0 ? count - 1 : 0;
        }
    }
}
