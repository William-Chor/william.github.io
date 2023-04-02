package Buildee;

public class House extends Building {
    private int noOfFloors;

    public House(int id, int noOfRooms, int noOfFloors) {
        super(id, noOfRooms);
        this.noOfFloors = noOfFloors;
    }

    public void setFloors(int noOfFloors) {
        this.noOfFloors = noOfFloors;
    }

    public int getFloors() {
        return noOfFloors;
    }

    public void modifyBuilding() {
        setFloors(noOfFloors);
    }

    public void printBuilding() {
        System.out.println("Building No.: " + getId() + "\nNo of Floors: " + getFloors());
        this.printRooms();
    }

    public String toString() {
        return "Building No.: " + getId() + ", No of Floors: " + getFloors();
    }
}