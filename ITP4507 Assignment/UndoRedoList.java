import java.util.*;

import Buildee.*;
import Command.*;
import Factory.*;

public class UndoRedoList {
    ArrayList<Object> undoList;
    ArrayList<Object> redoList;

    Vector _undoList;
    Vector _redoList;

    ArrayList<String> rList = new ArrayList<String>();
    ArrayList<String> uList = new ArrayList<String>();

    public UndoRedoList() {
        undoList = new ArrayList<>();
        redoList = new ArrayList<>();
    }

    public UndoRedoList(ArrayList<Object> undoList, ArrayList<Object> redoList) {
        this.redoList = redoList;
        this.undoList = undoList;
    }

    public void undo() {
        Object lastList = undoList.remove(undoList.size() - 1);
        if (lastList instanceof Command) {
            Command com = (Command) lastList;
            rList.add(com.toString());
            uList.remove(com.toString());
            com.undo();
        }
    }

    public void redo() {
        System.out.println("redo");

    }
}