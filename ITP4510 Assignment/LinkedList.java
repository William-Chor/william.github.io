class ListNode {

	private Object data; // remained cooking time; 0 means the food item already
	private ListNode next;

	public ListNode(Object o) {
		data = o;
		next = null;
	}

	public ListNode(Object o, ListNode nextNode) {
		data = o;
		next = nextNode;
	}

	public Object getData() {
		return data;
	}

	public void setData(Object o) {
		data = o;
	}

	public ListNode getNext() {
		return next;
	}

	public void setNext(ListNode next) {
		this.next = next;
	}
} // class ListNode

class EmptyListException extends RuntimeException {
	public EmptyListException() {
		super("List is empty");
	}
} // class EmptyListException

class FullListException extends RuntimeException {
	public FullListException() {
		super("Queue is full.");
	}
} // class FullListException

class LinkedList {

	private ListNode head;
	private ListNode tail;

	public LinkedList() {
		head = tail = null;
	}

	public boolean isEmpty() {
		return head == null;
	}

	public void addToHead(Object item) {
		if (isEmpty())
			head = tail = new ListNode(item);
		else
			head = new ListNode(item, head);
	}

	public void addToTail(Object item) {
		if (isEmpty())
			head = tail = new ListNode(item);
		else {
			tail.setNext(new ListNode(item));
			tail = tail.getNext();
		}
	}

	public Object removeFromHead() throws EmptyListException {
		Object item = null;
		if (isEmpty())
			throw new EmptyListException();
		item = head.getData();
		if (head == tail)
			head = tail = null;
		else
			head = head.getNext();
		return item;
	}

	public Object removeFromTail() throws EmptyListException {
		Object item = null;
		if (isEmpty())
			throw new EmptyListException();
		item = tail.getData();
		if (head == tail)
			head = tail = null;
		else {
			ListNode current = head;
			while (current.getNext() != tail)
				current = current.getNext();
			tail = current;
			current.setNext(null);
		}
		return item;
	}

	public String toString() {
		String s = "[ ";
		ListNode current = head;
		while (current != null) {
			s += current.getData() + " ";
			current = current.getNext();
		}
		return s + "]";
	}

	public int count() {

		ListNode current = head;
		int i = 0;
		while (current != null) {
			i++;
			current = current.getNext();
		}
		return i;
	}

	// ------------ new method ---------------
	public ListNode getListNodeAt(int n) {
		if (n < 0)
			return null;

		int currentPos = 0;
		ListNode current = head;
		while (currentPos < n) {
			current = current.getNext();
			currentPos++;
		}
		return current;
	}
}
// class LinkedList
