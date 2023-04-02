package Command;

import java.io.*;

public class ExitCommand implements Command {
    public void execute() throws Exception {
        System.exit(0);
    }

    public void undo() {
    }

    public void redo() {
    }
}