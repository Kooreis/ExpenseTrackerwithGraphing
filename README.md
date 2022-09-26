# Python Documentation

# Expense Tracker

This Python script is a simple console-based expense tracker. It allows users to add expenses, view the total expense, and plot the expenses over time.

## Libraries Used

- `matplotlib.pyplot`: This library is used for creating static, animated, and interactive visualizations in Python. In this script, it is used to plot the expenses over time.
- `datetime`: This module supplies classes for manipulating dates and times. Here, it is used to get the current date when an expense is added.

## Classes

- `Expense`: This class represents an individual expense. It has three attributes: `name` (the name of the expense), `amount` (the amount of the expense), and `date` (the date the expense was added).

- `ExpenseTracker`: This class is used to track multiple expenses. It has methods to add an expense, get the total expense, get expenses by date, and plot the expenses.

## Methods

- `add_expense(self, name, amount)`: This method is used to add an expense to the tracker. It takes two parameters: `name` (the name of the expense) and `amount` (the amount of the expense).

- `get_total_expense(self)`: This method returns the total expense by summing up the amount of all expenses in the tracker.

- `get_expenses_by_date(self)`: This method returns a dictionary where the keys are dates and the values are the total expenses for that date.

- `plot_expenses(self)`: This method plots the expenses over time using matplotlib.

## Main Function

The `main()` function is the entry point of the script. It creates an instance of `ExpenseTracker` and enters a loop where the user can choose to add an expense, get the total expense, plot the expenses, or exit the program.

---

# C# Documentation

# Expense Tracker Console Application

This is a simple console application written in C# that allows users to track their expenses. The application provides functionality to add expenses with a description and amount, view all added expenses, and exit the application. When viewing expenses, the total amount of all expenses is also displayed.

## Code Explanation

The application is built using the .NET Core framework and is written in C#. It does not require any additional libraries or dependencies.

### `System` Namespace

The `System` namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.

### `System.Collections.Generic` Namespace

The `System.Collections.Generic` namespace contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.

### `Expense` Class

The `Expense` class is a simple data model that represents an expense. It has two properties: `Description` and `Amount`.

### `Program` Class

The `Program` class is the main class of the application. It contains a `List<Expense>` to store all the expenses, and the `Main` method which is the entry point of the application.

The `Main` method presents a menu to the user with three options: Add Expense, View Expenses, and Exit. Depending on the user's input, it calls the appropriate method.

The `AddExpense` method prompts the user to enter the description and amount of the expense, creates a new `Expense` object with these values, and adds it to the list of expenses.

The `ViewExpenses` method iterates over the list of expenses, displaying the description and amount of each expense. It also calculates and displays the total amount of all expenses.

## Usage

To run the application, you need to have .NET Core installed on your machine. Then, navigate to the directory containing the `Program.cs` file in a terminal and run the command `dotnet run`.

---

# Java Documentation

# Java Expense Tracker Console Application

This repository contains a simple console application for tracking expenses, written in Java. The application allows users to add expenses by entering the name and amount of the expense. Users can also view all the expenses they have added and the total amount of their expenses. The application continues to run until the user chooses to exit.

## Script Explanation

The script is divided into two classes: `Expense` and `Main`.

### Expense Class

The `Expense` class is a simple data class that holds information about an expense. It has two fields: `name` and `amount`, which represent the name and the amount of the expense respectively.

### Main Class

The `Main` class is where the application logic resides. It contains a list of `Expense` objects and methods for adding expenses to the list and viewing the expenses in the list.

## Imported Libraries

The script imports two libraries:

1. `java.util.*`: This library is a part of Java's core library and is used for various utility functions. In this script, it is used for handling user input (`Scanner`) and storing the list of expenses (`ArrayList`).

2. `java.lang.*`: This library is also a part of Java's core library and is automatically imported in every Java program. It provides fundamental classes that are necessary for designing a Java application. In this script, it is used for handling system-level operations like exiting the application (`System.exit(0)`).

## Usage

To use the application, simply run the `Main` class. You will be presented with a menu with three options:

1. Add Expense: This option allows you to add a new expense. You will be asked to enter the name and the amount of the expense.

2. View Expenses: This option allows you to view all the expenses you have added along with the total amount of the expenses.

3. Exit: This option allows you to exit the application.

## Conclusion

This is a simple console application for tracking expenses. It is not meant to be a full-featured expense tracking application, but it serves as a good starting point for anyone looking to learn Java or build a simple console application.

---
