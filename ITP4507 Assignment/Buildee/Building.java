package Buildee;

import java.util.*;

public abstract class Building {
    private int id;
    private ArrayList<Room> rooms;

    public Building(int id, int noOfRooms) {
        this.id = id;
        this.rooms = new ArrayList<Room>(noOfRooms);
    }

    public int getId() {
        return id;
    }

    public ArrayList<Room> getRooms() {
        return rooms;
    }

    public Room addRoom(double length, double width) {
        Room room = new Room(length, width);
        rooms.add(room);
        return room;
        // return null;
    }

    public void modifyRoom(int roomNo, double length, double width) {
        Room mfRoom = new Room(length, width);
        rooms.set(roomNo, mfRoom);
    }

    public void deleteRoom(int roomNo) {
        rooms.remove(roomNo);
    }

    public void printRooms() {
        for (Room room : rooms) {
            System.out.println("Room No.: " + (rooms.indexOf(room) + 1) + ", Length: " + room.getLength() + ", Width: "
                    + room.getWidth());
        }
    }

    public int getRoomQty() {
        return rooms.size();
    }

    public abstract void modifyBuilding();

    public abstract void printBuilding();
}