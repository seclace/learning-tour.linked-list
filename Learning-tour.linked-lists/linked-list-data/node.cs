namespace Learning_tour.linked_lists {
    class node {
        public object data { get; set; }
        public node next { get; set; }
        public node prev { get; set; }

        public node() { next = prev = null; }

        public node(object _data) {
            data = _data;
            next = prev = null;
        }

        public node(object _data, node _prev, node _next) {
            next = _next;
            prev = _prev;
            data = _data;
        }

        public node(node _node) {
            data = _node.data;
            next = _node.next;
            prev = _node.prev;
        }
    }
}
