class ExpenseTracker:
    def __init__(self):
        self.expenses = []

    def add_expense(self, name, amount):
        date = datetime.now().strftime("%Y-%m-%d")
        self.expenses.append(Expense(name, amount, date))