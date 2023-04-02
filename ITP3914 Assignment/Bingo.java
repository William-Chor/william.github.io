import java.util.*;
public class Bingo {
    public static void main (String[] agrs) {
        Scanner input = new Scanner(System.in);
        int num;

        int repeat [] = new int [26];
        

        // First time to print the bingo table
        // Record the number of player1
        System.out.println();
        System.out.println("Player1's Card:");
        String [][] player1 = { {"24", "2", "8", "1", "25"},
                                {"12", "16", "7", "17", "15"}, 
                                {"5", "6", "20", "19", "13"}, 
                                {"14", "23", "22", "4", "3"}, 
                                {"10", "18", "11", "21", "9"} };
        // Print the player1 all the record
        for (int rows = 0; rows < 5; rows++) {
            for (int columns = 0; columns < 5; columns++) {
                System.out.printf("%4s",player1[rows][columns]);
            }
            System.out.println();
        }
        
        // Record the number of player2
        System.out.println();
        System.out.println("Player2's Card:");
        String [][] player2 = { {"24", "21", "17", "15", "6"},
                                {"10", "3", "8", "18", "20"},
                                {"14", "7", "16", "12", "5"},
                                {"25", "23", "13", "19", "11"},
                                {"22", "4", "9", "1", "2"} };
        // Print the player2 all the record
        for (int rows = 0; rows < 5; rows++) {
            for (int columns = 0; columns < 5; columns++) {
                System.out.printf("%4s",player2[rows][columns]);
            }
            System.out.println();
        }
        System.out.println();

        while (true) {
            System.out.print("Game Host call (0 to exit): ");
            num = input.nextInt();
            while (true) {
                // Check user enter number (Between 1 to 25)
                if (num > 25 || num < 0) {
                System.out.println("The number nust be between 1 to 25, please call again!");
                System.out.print("Game Host call (0 to exit): ");
                num = input.nextInt(); 
                } else {
                    break;
                }
            }
            
            // Enter 0 to exit the game
            if (num == 0) {
                break;
            }

            // Convert the corresponding number entered by the user to XX
            String str = String.valueOf(num);
            for (int rows = 0; rows < 5; rows++) {
                for (int columns = 0; columns < 5; columns++) {
                    if (player1[rows][columns].equals(str)) {
                        player1[rows][columns] = "XX";
                    }
                    if (player2[rows][columns].equals(str)) {
                        player2[rows][columns] = "XX";
                    } 
                }
            }
  
            // Enter a number and Loop Player1's Card once 
            System.out.println();
            System.out.println("Player1's Card:");
            for (int rows = 0; rows < 5; rows++) {
                for (int columns = 0; columns < 5; columns++) {
                    System.out.printf("%4s",player1[rows][columns]);
                }
                System.out.println();
            }
            // Enter a number and Loop Player2's Card once 
            System.out.println();
            System.out.println("Player2's Card:");
            for (int rows = 0; rows < 5; rows++) {
                for (int columns = 0; columns < 5; columns++) {
                    System.out.printf("%4s",player2[rows][columns]);
                }
                System.out.println();
            }
            System.out.println();
            
            // Check Player1 and Player2 is it Bingo!
            while (true) {
                // Slash-left to right to Bingo
                if ((player1[0][0].equals("XX")) && (player1[1][1].equals("XX")) && (player1[2][2].equals("XX")) && (player1[3][3].equals("XX")) && (player1[4][4].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[0][0].equals("XX")) && (player2[1][1].equals("XX")) && (player2[2][2].equals("XX")) && (player2[3][3].equals("XX")) && (player2[4][4].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                // Slash-right to left to Bingo
                if ((player1[0][4].equals("XX")) && (player1[1][3].equals("XX")) && (player1[2][2].equals("XX")) && (player1[3][1].equals("XX")) && (player1[4][0].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[0][4].equals("XX")) && (player2[1][3].equals("XX")) && (player2[2][2].equals("XX")) && (player2[3][1].equals("XX")) && (player2[4][0].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                // Straighten to Bingo
                if ((player1[0][0].equals("XX")) && (player1[1][0].equals("XX")) && (player1[2][0].equals("XX")) && (player1[3][0].equals("XX")) && (player1[4][0].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[0][0].equals("XX")) && (player2[1][0].equals("XX")) && (player2[2][0].equals("XX")) && (player2[3][0].equals("XX")) && (player2[4][0].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                if ((player1[0][1].equals("XX")) && (player1[1][1].equals("XX")) && (player1[2][1].equals("XX")) && (player1[3][1].equals("XX")) && (player1[4][1].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[0][1].equals("XX")) && (player2[1][1].equals("XX")) && (player2[2][1].equals("XX")) && (player2[3][1].equals("XX")) && (player2[4][1].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                if ((player1[0][2].equals("XX")) && (player1[1][2].equals("XX")) && (player1[2][2].equals("XX")) && (player1[3][2].equals("XX")) && (player1[4][2].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[0][2].equals("XX")) && (player2[1][2].equals("XX")) && (player2[2][2].equals("XX")) && (player2[3][2].equals("XX")) && (player2[4][2].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                if ((player1[0][3].equals("XX")) && (player1[1][3].equals("XX")) && (player1[2][3].equals("XX")) && (player1[3][3].equals("XX")) && (player1[4][3].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[0][3].equals("XX")) && (player2[1][3].equals("XX")) && (player2[2][3].equals("XX")) && (player2[3][3].equals("XX")) && (player2[4][3].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                if ((player1[0][4].equals("XX")) && (player1[1][4].equals("XX")) && (player1[2][4].equals("XX")) && (player1[3][4].equals("XX")) && (player1[4][4].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[0][4].equals("XX")) && (player2[1][4].equals("XX")) && (player2[2][4].equals("XX")) && (player2[3][4].equals("XX")) && (player2[4][4].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                // Horizontal to Bingo
                if ((player1[0][0].equals("XX")) && (player1[0][1].equals("XX")) && (player1[0][2].equals("XX")) && (player1[0][3].equals("XX")) && (player1[0][4].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[0][0].equals("XX")) && (player2[0][1].equals("XX")) && (player2[0][2].equals("XX")) && (player2[0][3].equals("XX")) && (player2[0][4].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                if ((player1[1][0].equals("XX")) && (player1[1][1].equals("XX")) && (player1[1][2].equals("XX")) && (player1[1][3].equals("XX")) && (player1[1][4].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[1][0].equals("XX")) && (player2[1][1].equals("XX")) && (player2[1][2].equals("XX")) && (player2[1][3].equals("XX")) && (player2[1][4].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                if ((player1[2][0].equals("XX")) && (player1[2][1].equals("XX")) && (player1[2][2].equals("XX")) && (player1[2][3].equals("XX")) && (player1[2][4].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[2][0].equals("XX")) && (player2[2][1].equals("XX")) && (player2[2][2].equals("XX")) && (player2[2][3].equals("XX")) && (player2[2][4].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                if ((player1[3][0].equals("XX")) && (player1[3][1].equals("XX")) && (player1[3][2].equals("XX")) && (player1[3][3].equals("XX")) && (player1[3][4].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[3][0].equals("XX")) && (player2[3][1].equals("XX")) && (player2[3][2].equals("XX")) && (player2[3][3].equals("XX")) && (player2[3][4].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                if ((player1[4][0].equals("XX")) && (player1[4][1].equals("XX")) && (player1[4][2].equals("XX")) && (player1[4][3].equals("XX")) && (player1[4][4].equals("XX"))) {
                    System.out.println("Player1 Bingo!");
                }
                if ((player2[4][0].equals("XX")) && (player2[4][1].equals("XX")) && (player2[4][2].equals("XX")) && (player2[4][3].equals("XX")) && (player2[4][4].equals("XX"))) {
                    System.out.println("Player2 Bingo!");
                }
                break;
            }
        } 
    }
}