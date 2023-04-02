package Command;

import java.io.IOException;
import java.util.*;

import Buildee.*;
import Factory.ModifyCommandFactory;

public class ModifyCommand implements Command {
    Vector<Building> builde;
    Scanner input;
    private int id, nof, mmr;
    private String mStaff;

    public ModifyCommand(Vector<Building> builde, int id, Scanner input) {
        this.builde = builde;
        this.id = id;
        this.input = input;
    }

    public void execute() throws IOException {
        for (int i = 0; i < builde.size(); i++) {
            if (builde.elementAt(i).getId() == ModifyCommandFactory.bID) {
                System.out.println(builde.elementAt(i).toString());
                if (builde.elementAt(i) instanceof Apartment) {
                    System.out.print("Modify Monthly Rental: ");
                    mmr = input.nextInt();

                    System.out.print("Modify Support Staff: ");
                    mStaff = input.nextLine();
                    mStaff = input.nextLine();

                    ((Apartment) builde.elementAt(i)).setMonthlyRental(mmr);
                    ((Apartment) builde.elementAt(i)).setSupportStaff(mStaff);
                    ((Apartment) builde.elementAt(i)).modifyBuilding();

                    System.out.println("Building is modified:");
                    System.out.println(builde.elementAt(i).toString());
                } else if (builde.elementAt(i) instanceof House) {
                    System.out.print("No. of Floors: ");
                    nof = input.nextInt();

                    ((House) builde.elementAt(i)).setFloors(nof);
                    ((House) builde.elementAt(i)).modifyBuilding();

                    System.out.println("Building is modified:");
                    System.out.println(builde.elementAt(i).toString());
                }
            }
        }
    }

    public void undo() {
    }

    public void redo() {
    }
}