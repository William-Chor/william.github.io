package Factory;

import java.io.*;
import java.util.*;

import Buildee.Building;
import Command.*;

public class EditCommandFactory implements CommandFactory {
    Vector<Building> builde;
    Building b;
    Scanner input;
    Stack s;
    public static int bID;
    private int id = 0, nor = 0;

    public EditCommandFactory(Vector<Building> builde, Scanner input, Stack s) {
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

        for (int i = 0; i < builde.size(); i++) {
            if (builde.elementAt(i).getId() == bID) {
                builde.elementAt(i).printBuilding();
            }
        }
        System.out.println("\nPlease enter command: [a|d|m] \na = add room, d = delete room, m = modify room: ");
        String in = input.next();

        if (in.equals("a")) {
            return new EditAddCommand(builde, id, nor, b, input);
        } else if (in.equals("d")) {
            return new EditDeleteCommand(builde, id, nor, input);
        } else if (in.equals("m")) {
            return new EditModifyCommand(builde, id, nor, input);
        }
        return new EditModifyCommand(builde, id, nor, input);
    }
}