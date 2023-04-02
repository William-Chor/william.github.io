import java.io.IOException;
import java.util.*;
import Buildee.*;
import Command.*;
import Factory.*;

public class Main {
    public static Scanner input = new Scanner(System.in);

    public static void main(String[] args) {
        Vector builde = new Vector();
        Stack undos = new Stack<>(); // for undo
        Stack redos = new Stack<>(); // for redo

        Command com;

        HashMap<String, CommandFactory> addBuilde = new HashMap<>();
        addBuilde.put("a", new ApartmentCommandFactory(builde, input, undos));
        addBuilde.put("h", new HouseCommandFactory(builde, input, undos));

        HashMap<String, CommandFactory> normal = new HashMap<>();
        normal.put("d", new DisplayCommandFactory(builde, input));
        normal.put("m", new ModifyCommandFactory(builde, input, undos));
        normal.put("e", new EditCommandFactory(builde, input, undos));
        normal.put("x", new ExitCommandFactory());

        UndoRedoList UnReList = new UndoRedoList();

        String command;
        while (true) {
            System.out.println("Building Management System (BMS)");
            System.out.println("Please enter command: [a|d|m|e|u|r|l|x]");
            System.out.println(
                    "a = add builidng, d = display buildings, m = modify building, e = edit rooms \nu = undo, r = redo, l = list undo/redo, x = exit system");
            command = input.next();

            try {
                if (command.equals("a")) {
                    System.out.println("Enter Building Type (a=Apartment/h=House):");
                    command = input.next();
                    com = addBuilde.get(command).createCommand();
                    com.execute();
                }
                com = normal.get(command).createCommand();
                com.execute();
            } catch (Exception e) {
                System.out.println(e.getMessage());
            }
        }
    }
}