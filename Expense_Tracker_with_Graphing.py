import matplotlib.pyplot as plt
from datetime import datetime

class Expense:
    def __init__(self, name, amount, date):
        self.name = name
        self.amount = amount
        self.date = date