package Factory;

import java.util.*;
import java.io.*;

import Buildee.Building;
import Command.*;

public class HouseCommandFactory implements CommandFactory {
    Vector<Building> builde;
    Scanner input;
    Stack s;
    private int id, nof, nor;

    public HouseCommandFactory(Vector<Building> builde, Scanner input, Stack s) {
        this.builde = builde;
        this.input = input;
        this.s = s;
    }

    public void setBuilding(Vector<Building> builde) {
        this.builde = builde;
    }

    public Command createCommand() throws IOException {
        System.out.print("Building NO.: ");
        id = input.nextInt();

        System.out.print("No. of Floors: ");
        nof = input.nextInt();

        System.out.print("Number of rooms: ");
        nor = input.nextInt();

        return new HouseCommand(builde, id, nof, nor, input);
    }
}