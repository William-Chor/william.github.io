import java.io.*;
import java.util.*;

public class FoodCafe {
	static Scanner sc = new Scanner(System.in); // Static scanner input
	static ListQueue productionLine = new ListQueue();// The cooking queue
	static FoodItem fi; // Call FoodItem to use this class function
	static Random rnd = new Random(5);
	static int currentTime = 0;
	static int customer = 0;
	static int order;
	static int simulationTime;
	static int ordered = 0;
	static ArrayList<Integer> compare = new ArrayList<Integer>(); // Create ArrayList

	public static void main(String args[]) {
		boolean checkMinInput = true;
		System.out.println("------------ SETUP SIMULATION ENVIRONMENT-------------");
		while (checkMinInput) {
			System.out.print("Input simulation length (min):");
			try {
				simulationTime = sc.nextInt(); // User enter the number to loop the simulation time
				if (simulationTime > 0) { // If >0 call checkOrderItem method
					checkOrderItem();
					checkMinInput = false;
				}

				if (simulationTime == 0) { // If =0 call randomSeed method
					randomSeed();
					checkMinInput = false;
				}
			} catch (InputMismatchException e) { // If user enter is not Integer will throw
				System.out.println("Worng Input!"); // this output until is Integer
				sc.next();
			}
		}

		System.out.println("\n----------------- END OF SIMULATION ------------------");
		System.out.println("Total minute simulated: " + simulationTime + " minutes");
		System.out.println("Number of customer served: " + checkCustomer() + " customer(s)");
		System.out.println("Item ordered during the simulation: " + ordered);
		System.out.println("Outstanding item at the end of simulation: " + productionLine.size());
		System.out.println("------------------------------------------------------");
	} // Finish the loop will print summary

	public static int checkOrderIsZero() { // check input 0 will do
		try {
			fi = (FoodItem) productionLine.front(); // Take queue the first item
			fi.reduceCookTime(); // and reduce the cooking time
			if (fi.getRemainCookTime() <= 0) { // check if the first food the cooking time is finish=0
				productionLine.dequeue(); // is = 0, take the first item out with the queue
			}
		} catch (EmptyListException e) {
		}

		currentTime++; // count the loop it is loop time
		System.out.println("------------------------------------------------------");
		System.out.println("After " + currentTime + " minute(s):");
		System.out.println("Cooking queue# " + productionLine);
		System.out.println("======================================================");
		// Every min break one time
		return currentTime;
	} // Method checkOrderIsZero

	public static int checkCustomer() { // ArrayList check number of customer
		for (int i = 0; i < compare.size(); i++) { // loop to check
			if (compare.get(i) == 0 && i > 0) // If in ArrayList is 0 and not is the first
				if (compare.get(i - 1) >= 1 && compare.get(i - 1) <= 4) // and check the 0 fornt is not 1-4
					customer++; // mean add one customer
		}
		return customer;
	}// Method checkCustomer

	public static void checkOrderItem() { // check user input
		System.out.println("----------------- START SIMULATION -------------------");
		while (currentTime < simulationTime) {
			System.out.print("Order item [1-coffee,2-Soft Drink, 3-Hot Dog, 4-French fries, 0-Finsih]:");
			try {
				order = sc.nextInt(); // User enter what item is ordered
				compare.add(order); // Add the value to ArrayList
				if (order < 0 || order > 4) // Check user enter the number not over 4 and less than 0
					throw new InvalidRangeInputException();
				if (order == 1) { // Enter 1 add the name:Coffee and cooking time:1 to queue
					productionLine.enqueue(new FoodItem("Coffee", 1));
					ordered++;
				} else if (order == 2) { // Soft Drink since is 0 min, so did not adds to queue.
					ordered++;
				} else if (order == 3) { // Enter 0 add the name:Hot Dog and cooking time:2 to queue
					productionLine.enqueue(new FoodItem("Hot Dog", 2));
					ordered++;
				} else if (order == 4) { // Enter 1 add the name:French fries and cooking time:3 to queue
					productionLine.enqueue(new FoodItem("French fries", 3));
					ordered++;
				} else if (order == 0) { // Enter 0 mean after 1 min
					checkOrderIsZero(); // Call method, reduce main method workload
				}

			} catch (InvalidRangeInputException e) {
				System.out.println("Invalid choice!"); // catch the exception and print
			} catch (InputMismatchException e) { // If user enter is not Integer will throw
				System.out.println("Worng Input!"); // this output until is Integer
				sc.next();
			}
		}
	} // Method checkOrderItem

	public static void randomSeed() { // random input to simulation check the program
		System.out.print("Input seed number:");
		long seed = sc.nextLong(); // User enter the seed number
		rnd.setSeed(seed); // save at the function Random
		simulationTime = 4; // Max simulation time is 4
		System.out.println("Max simulation time (min) is " + simulationTime);

		System.out.println("----------------- START SIMULATION -------------------");
		while (currentTime < simulationTime) {
			for (int i = 0; i < 100; i++) { // Us random loop the input
				order = rnd.nextInt(5);
			}
			System.out.print("Order item [1-coffee,2-Soft Drink, 3-Hot Dog, 4-French fries, 0-Finsih]:");
			try {
				System.out.println(order);// Us random to input
				compare.add(order); // Add the value to ArrayList
				if (order < 0 || order > 4) // Check user enter the number not over 4 and less than 0
					throw new InvalidRangeInputException();
				if (order == 1) { // Enter 1 add the name:Coffee and cooking time:1 to queue
					productionLine.enqueue(new FoodItem("Coffee", 1));
					ordered++;
				} else if (order == 2) { // Soft Drink since is 0 min, so did not adds to queue.
					ordered++;
				} else if (order == 3) { // Enter 0 add the name:Hot Dog and cooking time:2 to queue
					productionLine.enqueue(new FoodItem("Hot Dog", 2));
					ordered++;
				} else if (order == 4) { // Enter 1 add the name:French fries and cooking time:3 to queue
					productionLine.enqueue(new FoodItem("French fries", 3));
					ordered++;
				} else if (order == 0) { // Enter 0 mean after 1 min
					checkOrderIsZero(); // Call method, reduce main method workload
				}

			} catch (InvalidRangeInputException e) {
				System.out.println("Invalid choice!"); // catch the exception and print
			} catch (InputMismatchException e) { // If user enter is not Integer will throw
				System.out.println("Worng Input!"); // this output until is Integer
				sc.next();
			}
		}
	}
} // Method randomSeed

class InvalidRangeInputException extends RuntimeException {
	public InvalidRangeInputException() {
		super("Invalid choice!");
	}
}
// Class InvalidRangeInputException