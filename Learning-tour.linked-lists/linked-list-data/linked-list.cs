namespace Learning_tour.linked_lists {
    class LinkedList {
        node beginNode;
        node endNode;

        public int count { get; private set; }

        public node this[int i] {
            get { return get(i); }
        }

        public LinkedList() {
            count = 0;
        }

        public node get(int index) {
            node n = beginNode;
            while (index-- > 0) {
                if (n.next == null) break;
                else n = n.next;
            }
            return n;
        }

        public node getFirstNode() {
            return beginNode;
        }

        public node getLastNode() {
            return endNode;
        }

        public void add(object input) {
            if (beginNode == null) {
                beginNode = new node(input);
                endNode = beginNode;
            } else {
                node tmp = new node(input);
                endNode.next = tmp;
                tmp.prev = endNode;
                endNode = tmp;
            }
            count++;
        }

        public void add(object input, int index) {
            node n = get(index),
                nPrev = n.prev;
            node newNode = new node(input);
            nPrev.next = newNode;
            n.prev = newNode;
            newNode.prev = nPrev;
            newNode.next = n;
            count++;
        }

        public void remove(int index) {
            node n = get(index);
            node nPrev = n.prev;
            node nNext = n.next;
            if (nPrev != null) nPrev.next = nNext;
            if (nNext != null) nNext.prev = nPrev;
            if (index == 0) beginNode = nNext;
            else if (index == count) endNode = nPrev;
            count = count > 0 ? count - 1 : 0;
        }
    }
}
