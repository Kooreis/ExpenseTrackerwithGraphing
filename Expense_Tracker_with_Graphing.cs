Here is a simple console application for an expense tracker. Please note that this application does not include graphing functionality as console applications are text-based and do not support graphical interfaces. 

```CSharp
using System;
using System.Collections.Generic;

public class Expense
{
    public string Description { get; set; }
    public decimal Amount { get; set; }
}

public class Program
{
    static List<Expense> expenses = new List<Expense>();

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expenses");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddExpense();
                    break;
                case "2":
                    ViewExpenses();
                    break;
                case "3":
                    return;
            }
        }
    }

    static void AddExpense()
    {
        Console.Write("Enter expense description: ");
        var description = Console.ReadLine();

        Console.Write("Enter expense amount: ");
        var amount = decimal.Parse(Console.ReadLine());

        expenses.Add(new Expense { Description = description, Amount = amount });
    }

    static void ViewExpenses()
    {
        decimal total = 0;
        foreach (var expense in expenses)
        {
            Console.WriteLine($"Description: {expense.Description}, Amount: {expense.Amount}");
            total += expense.Amount;
        }

        Console.WriteLine($"Total Expenses: {total}");
    }
}
```

This application allows the user to add expenses with a description and amount, view all added expenses, and exit the application. The total amount of all expenses is also displayed when viewing expenses.