```CSharp
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
}
```