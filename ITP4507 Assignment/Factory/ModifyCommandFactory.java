package Factory;

import java.util.*;
import java.io.*;

import Buildee.Building;
import Command.*;

public class ModifyCommandFactory implements CommandFactory {
    Vector<Building> builde;
    Scanner input;
    Stack s;
    public static int bID;
    private int id = 0;

    public ModifyCommandFactory(Vector<Building> builde, Scanner input, Stack s) {
        this.builde = builde;
        this.input = input;
        this.s = s;
    }

    public void setBuilding(Vector<Building> builde) {
        this.builde = builde;
    }

    public Command createCommand() throws IOException {
        System.out.print("Building No.: ");
        bID = input.nextInt();
        return new ModifyCommand(builde, id, input);
    }
}