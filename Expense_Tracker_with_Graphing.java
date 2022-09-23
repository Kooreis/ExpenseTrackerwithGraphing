Here is a simple console application for an expense tracker in Java. Please note that this application does not include graphing functionality as it is not feasible to create graphs in a console application. 

```java
import java.util.*;

class Expense {
    String name;
    double amount;

    public Expense(String name, double amount) {
        this.name = name;
        this.amount = amount;
    }
}

public class Main {
    static List<Expense> expenses = new ArrayList<>();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.println("1. Add Expense");
            System.out.println("2. View Expenses");
            System.out.println("3. Exit");
            int choice = scanner.nextInt();
            scanner.nextLine();
            switch (choice) {
                case 1:
                    addExpense(scanner);
                    break;
                case 2:
                    viewExpenses();
                    break;
                case 3:
                    System.exit(0);
                default:
                    System.out.println("Invalid choice");
            }
        }
    }

    static void addExpense(Scanner scanner) {
        System.out.println("Enter expense name:");
        String name = scanner.nextLine();
        System.out.println("Enter expense amount:");
        double amount = scanner.nextDouble();
        scanner.nextLine();
        expenses.add(new Expense(name, amount));
    }

    static void viewExpenses() {
        double total = 0;
        for (Expense expense : expenses) {
            System.out.println("Name: " + expense.name + ", Amount: " + expense.amount);
            total += expense.amount;
        }
        System.out.println("Total expenses: " + total);
    }
}
```

This application allows the user to add expenses by entering the name and amount of the expense. The user can also view all the expenses they have added and the total amount of their expenses. The application continues to run until the user chooses to exit.