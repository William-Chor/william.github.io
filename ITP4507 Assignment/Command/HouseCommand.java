package Command;

import java.io.IOException;
import java.util.*;

import Buildee.*;

public class HouseCommand implements Command {
    Vector<Building> builde;
    Building b;
    Scanner input;
    private int id, nof, nor;
    private double length, width;

    public HouseCommand(Vector<Building> builde, int id, int nof, int nor, Scanner input) {
        this.builde = builde;
        this.id = id;
        this.nof = nof;
        this.nor = nor;
        this.input = input;
    }

    public void execute() throws IOException {
        b = new House(id, nor, nof);

        for (int i = 1; i <= nor; i++) {
            System.out.println("Room No. " + i + " :");
            System.out.print("Length: ");
            length = input.nextDouble();

            System.out.print("Width: ");
            width = input.nextDouble();

            b.addRoom(length, width);
        }
        System.out.println("New Building Added:");
        b.printBuilding();
        builde.add(b);
    }

    public void redo() {
        builde.add(b);
    }

    public void undo() {
        builde.remove(b);
    }
}