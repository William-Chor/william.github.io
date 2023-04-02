package Buildee;

public class Apartment extends Building {
    private double monthlyRental;
    private String supporStaff;

    public Apartment(int id, int noOfRooms, double monthlyRental, String supporStaff) {
        super(id, noOfRooms);
        this.monthlyRental = monthlyRental;
        this.supporStaff = supporStaff;
    }

    public void setMonthlyRental(double monthlyRental) {
        this.monthlyRental = monthlyRental;
    }

    public double getMonthlyRental() {
        return monthlyRental;
    }

    public void setSupportStaff(String supporStaff) {
        this.supporStaff = supporStaff;
    }

    public String getSupportStaff() {
        return supporStaff;
    }

    public void modifyBuilding() {
        setMonthlyRental(monthlyRental);
        setSupportStaff(supporStaff);
    }

    public void printBuilding() {
        System.out.println("Building No.: " + getId() + "\nSupport Staff: " + getSupportStaff() + "\nMonthly Rental: "
                + getMonthlyRental());
        this.printRooms();
    }

    public String toString() {
        return "Building No.: " + getId() + ", Support Staff: " + getSupportStaff() + ", Monthly Rental: "
                + getMonthlyRental();
    }
}