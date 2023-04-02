public interface Queue {
    public abstract boolean isEmpty();

    public abstract int size();

    public abstract Object front() throws EmptyListException;

    public abstract Object back() throws EmptyListException;

    public abstract void enqueue(Object item) throws FullListException;

    public abstract Object dequeue() throws EmptyListException;
}