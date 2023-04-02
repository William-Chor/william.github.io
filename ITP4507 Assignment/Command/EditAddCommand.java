package Command;

import java.io.IOException;
import java.util.*;

import Buildee.*;
import Factory.EditCommandFactory;

public class EditAddCommand implements Command {
    Vector<Building> builde;
    Building b;
    Building sRoom;
    Scanner input;
    private int buil, id, nor, index;
    private double length, width;

    public EditAddCommand(Vector<Building> builde, int id, int nor, Building b, Scanner input) {
        this.builde = builde;
        this.id = id;
        this.nor = nor;
        this.b = b;
        this.input = input;
    }

    public void execute() throws IOException {
        for (int i = 0; i < builde.size(); i++) {
            if (builde.elementAt(i).getId() == EditCommandFactory.bID) {
                if (builde.elementAt(i) instanceof Apartment) {
                    System.out.print("Lenght: ");
                    length = input.nextInt();

                    System.out.print("Width: ");
                    width = input.nextInt();

                    ((Apartment) builde.elementAt(i)).addRoom(length, width);

                    System.out.println("Updated Building:");
                    ((Apartment) builde.elementAt(i)).printBuilding();
                    buil = builde.elementAt(i).getId();
                    index = builde.elementAt(i).getRoomQty();
                    sRoom = builde.elementAt(i);
                    break;
                } else if (builde.elementAt(i) instanceof House) {
                    System.out.print("Lenght: ");
                    length = input.nextInt();

                    System.out.print("Width: ");
                    width = input.nextInt();

                    ((House) builde.elementAt(i)).addRoom(length, width);

                    System.out.println("Updated Building:");
                    ((House) builde.elementAt(i)).printBuilding();
                    buil = builde.elementAt(i).getId();
                    index = builde.elementAt(i).getRoomQty();
                    sRoom = builde.elementAt(i);
                    break;
                }
            }
        }

    }

    public void undo() {
        builde.remove(sRoom);
    }

    public void redo() {
        builde.add(sRoom);
    }

    public String toString() {
        return "Add Room: Building No.: " + buil + ", Room No. " + index + ", Length: " + length + ", Width: "
                + width;
    }
}