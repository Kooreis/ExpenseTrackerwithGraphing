```python
import matplotlib.pyplot as plt
from datetime import datetime

class Expense:
    def __init__(self, name, amount, date):
        self.name = name
        self.amount = amount
        self.date = date

class ExpenseTracker:
    def __init__(self):
        self.expenses = []

    def add_expense(self, name, amount):
        date = datetime.now().strftime("%Y-%m-%d")
        self.expenses.append(Expense(name, amount, date))

    def get_total_expense(self):
        return sum(expense.amount for expense in self.expenses)

    def get_expenses_by_date(self):
        expenses_by_date = {}
        for expense in self.expenses:
            if expense.date not in expenses_by_date:
                expenses_by_date[expense.date] = 0
            expenses_by_date[expense.date] += expense.amount
        return expenses_by_date

    def plot_expenses(self):
        expenses_by_date = self.get_expenses_by_date()
        dates = list(expenses_by_date.keys())
        amounts = list(expenses_by_date.values())
        plt.plot(dates, amounts)
        plt.show()

def main():
    tracker = ExpenseTracker()
    while True:
        print("1. Add expense")
        print("2. Get total expense")
        print("3. Plot expenses")
        print("4. Exit")
        choice = int(input("Enter your choice: "))
        if choice == 1:
            name = input("Enter expense name: ")
            amount = float(input("Enter expense amount: "))
            tracker.add_expense(name, amount)
        elif choice == 2:
            print("Total expense: ", tracker.get_total_expense())
        elif choice == 3:
            tracker.plot_expenses()
        elif choice == 4:
            break

if __name__ == "__main__":
    main()
```