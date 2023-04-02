package Command;

public interface Command {
    public void execute() throws Exception;

    public void redo();

    public void undo();
}