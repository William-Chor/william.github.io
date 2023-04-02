public class ListQueue implements Queue {
	private LinkedList qll;

	public ListQueue() {
		qll = new LinkedList();
	}

	public int size() {
		return qll.count();
	}

	public boolean isEmpty() {
		return qll.isEmpty();
	}

	public void enqueue(Object item) throws FullListException {
		qll.addToTail(item);
	}

	public Object dequeue() throws EmptyListException {
		try {
			Object item = qll.removeFromHead();
			return item;
		} catch (EmptyListException e) {
			throw new EmptyListException();
		}
	}

	public Object front() throws EmptyListException {
		try {
			Object item = qll.removeFromHead();
			qll.addToHead(item);
			return item;
		} catch (EmptyListException e) {
			throw new EmptyListException();
		}
	}

	public Object back() throws EmptyListException {
		try {
			Object item = qll.removeFromTail();
			qll.addToTail(item);
			return item;
		} catch (EmptyListException e) {
			throw new EmptyListException();
		}
	}

	public String toString() {
		return qll.toString();
	}
}
