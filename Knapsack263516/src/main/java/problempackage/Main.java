package problempackage;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Podaj ilość rodzajów przedmiotów:");
        int n = scanner.nextInt();
        System.out.println("Podaj ziarno:");
        int seed = scanner.nextInt();
        System.out.println("Podaj pojemność plecaka:");
        int capacity = scanner.nextInt();

        int lowerBound = 1; // dolny zakres
        int upperBound = 10; // górny zakres

        Problem problem = new Problem(n, seed, lowerBound, upperBound);
        System.out.println(problem);

        Result result = problem.solve(capacity);
        System.out.println("--------------------");
        System.out.println(result);


        scanner.close();
    }
}
