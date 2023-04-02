package Command;

import java.io.IOException;
import java.util.Vector;

import Buildee.Building;
import Factory.DisplayCommandFactory;

public class DisplayCommand implements Command {
    Vector<Building> builde;
    Building b;
    private int id;

    public DisplayCommand(Vector<Building> builde, int id) {
        this.builde = builde;
        this.id = id;
    }

    public void execute() throws IOException {
        if (DisplayCommandFactory.bID.equals("*")) {
            for (int i = 0; i < builde.size(); i++) {
                System.out.println(builde.elementAt(i).toString());
            }
        } else {
            int sID = Integer.parseInt(DisplayCommandFactory.bID);
            for (int i = 0; i < builde.size(); i++) {
                if (builde.elementAt(i).getId() == sID) {
                    builde.elementAt(i).printBuilding();
                }
            }
        }
    }

    public void undo() {

    }

    public void redo() {

    }
}