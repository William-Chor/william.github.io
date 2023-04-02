package Factory;

import java.util.*;
import java.io.*;

import Buildee.Building;
import Command.*;

public class ApartmentCommandFactory implements CommandFactory {
    Vector<Building> builde;
    Scanner input;
    Stack s;

    private int id, nor;
    private double mr;
    private String staff;

    public ApartmentCommandFactory(Vector<Building> builde, Scanner input, Stack s) {
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

        System.out.print("Monthly Rental: ");
        mr = input.nextDouble();

        System.out.print("Support Staff: ");
        staff = input.nextLine();

        staff = input.nextLine();

        System.out.print("Number of rooms: ");
        nor = input.nextInt();

        return new ApartmentCommand(builde, id, nor, mr, staff, input);
    }
}