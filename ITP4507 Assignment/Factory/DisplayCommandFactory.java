package Factory;

import java.util.*;
import java.io.*;

import Buildee.Building;
import Command.*;

public class DisplayCommandFactory implements CommandFactory {
    Vector<Building> builde;
    Scanner input;
    public static String bID;
    private int reNa = 0;

    public DisplayCommandFactory(Vector<Building> builde, Scanner input) {
        this.builde = builde;
        this.input = input;
    }

    public void setBuilding(Vector<Building> builde) {
        this.builde = builde;
    }

    public Command createCommand() throws IOException {
        System.out.println("Enter Building No.(* to display all):");
        bID = input.next();
        return new DisplayCommand(builde, reNa);
    }
}