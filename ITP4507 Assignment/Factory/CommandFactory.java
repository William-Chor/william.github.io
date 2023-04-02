package Factory;

import java.util.*;

import Buildee.Building;
import Command.Command;

import java.io.*;

public interface CommandFactory {
    public Command createCommand() throws IOException;

    public void setBuilding(Vector<Building> builde);
}