class Program
{
    static void Init()
    {
        Console.WriteLine("Welcome to our salary and CPF calculator.");
        Console.WriteLine("Please answer the following questions.");
    }

    static void Calc()
    {
        double salary, remSalary, cpf;
        int age;

        Console.Write("Enter your salary (in SGD) > ");
        salary = Convert.ToDouble(Console.ReadLine()); // Use ReadLine() to read the entire line

        Console.Write("Enter your age as of this year > ");
        // Use int.TryParse for robust error handling
        while (!int.TryParse(Console.ReadLine(), out age)) 
        {
            Console.WriteLine("Invalid input. Please enter a valid age using numbers.");
        }

        if (age >= 18 && age < 55)
        {
            cpf = salary * 0.37;
            remSalary = salary * 0.80;
        }
        else if (age >= 55 && age < 60)
        {
            cpf = salary * 0.325;
            remSalary = salary * 0.83;
        }
        else if (age >= 60 && age < 65)
        {
            cpf = salary * 0.235;
            remSalary = salary * 0.885;
        }
        else if (age >= 65 && age < 70)
        {
            cpf = salary * 0.165;
            remSalary = salary * 0.925;
        }
        else if (age >= 70)
        {
            cpf = salary * 0.125;
            remSalary = salary * 0.95;
        }
        else // Handle invalid age (less than 18)
        {
            Console.WriteLine("Invalid age. Age must be 18 or older.");
            return; // Exit the Calc() method
        }

        string output = String.Format("Your remaining salary is {0:C} and your CPF is {1:C}", remSalary, cpf);
        Console.WriteLine(output);
    }

    static void Main(string[] args)
    {
        Init();
        Calc();
    }
}