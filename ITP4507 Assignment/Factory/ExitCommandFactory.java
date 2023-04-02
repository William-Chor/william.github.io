package Factory;

import java.util.*;
import java.io.*;

import Buildee.*;
import Command.*;

public class ExitCommandFactory implements CommandFactory {
    Vector<Building> builde;

    public ExitCommandFactory(Vector<Building> builde) {
        this.builde = builde;
    }

    public ExitCommandFactory() {
    }

    public void setBuilding(Vector<Building> builde) {
        this.builde = builde;
    }

    public Command createCommand() throws IOException {
        return new ExitCommand();
    }
}
