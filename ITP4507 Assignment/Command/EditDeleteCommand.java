package Command;

import java.io.IOException;
import java.util.*;

import Buildee.*;
import Factory.EditCommandFactory;

public class EditDeleteCommand implements Command {
    Vector<Building> builde;
    Scanner input;
    private int id, nor, buil, mRoom;

    public EditDeleteCommand(Vector<Building> builde, int id, int nor, Scanner input) {
        this.builde = builde;
        this.id = id;
        this.nor = nor;
        this.input = input;
    }

    public void execute() throws IOException {

        for (int i = 0; i < builde.size(); i++) {
            if (builde.elementAt(i).getId() == EditCommandFactory.bID) {
                if (builde.elementAt(i) instanceof Apartment) {
                    System.out.println("Room No.: ");
                    mRoom = input.nextInt();

                    System.out.println("Updated Building:");
                    ((Apartment) builde.elementAt(i)).deleteRoom(mRoom - 1);
                    ((Apartment) builde.elementAt(i)).printBuilding();
                    buil = builde.elementAt(i).getId();
                    break;
                } else if (builde.elementAt(i) instanceof House) {
                    System.out.print("Room No.: ");
                    mRoom = input.nextInt();

                    System.out.println("Updated Building:");
                    ((House) builde.elementAt(i)).deleteRoom(mRoom - 1);
                    ((House) builde.elementAt(i)).printBuilding();
                    buil = builde.elementAt(i).getId();
                    break;
                }
            }
        }
    }

    public void undo() {

    }

    public void redo() {

    }

}