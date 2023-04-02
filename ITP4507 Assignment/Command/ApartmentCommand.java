package Command;

import java.io.IOException;
import java.util.*;

import Buildee.*;

public class ApartmentCommand implements Command {
    Vector builde;
    Building b;
    Scanner input;
    private int id, nor;
    private double mr, length, width;
    private String staff;

    public ApartmentCommand(Vector builde, int id, int nor, double mr,
            String staff, Scanner input) {
        this.builde = builde;
        this.id = id;
        this.mr = mr;
        this.staff = staff;
        this.nor = nor;
        this.input = input;
    }

    public void execute() throws IOException {
        b = new Apartment(id, nor, mr, staff);

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

    public void undo() {
    }

    public void redo() {
    }
}