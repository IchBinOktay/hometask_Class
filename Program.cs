
//public static class Program
//{
//    public static void Main(String[] args)
//{
//Animal Steve = new Animal("Steve", "parakeet", 6, "green");
//Console.WriteLine(Steve.GetInfo());
//Building building = new Building($"mall", 250, 2000, "genclik");
//Console.WriteLine(building.GetInfo());
//int[] homeworkGrades = { 99, 95, 95 };
//int[] projectGrades = { 95, 95, 99 };
//int[] quizGrades = { 95, 100, 97 };
//bool[] continuity = { true, true, true, true, true };
//Student student = new Student("Oktay", "Babayev", 17, homeworkGrades, projectGrades, quizGrades, 95, continuity);

//Console.WriteLine($"telebe ve ortalamasi:  {student.FirstName} {student.LastName}: {student.TotalScore} {student.OverallGrade}");

//Gun assaultRifle = new Gun("StG-44", 30, 30, 120, "assault");
//assaultRifle.Fire();
//assaultRifle.Reload();
//assaultRifle.DisplayStatus();

//Console.WriteLine();

//Gun sniperRifle = new Gun("Mosin–Nagant", 5, 5, 20, "sniper");
//sniperRifle.Fire();
//sniperRifle.Reload();
//sniperRifle.DisplayStatus();

//}

//}






//public class Animal
//{
//    string name;
//    string breed;
//    int age;
//    string color;
//    public Animal(string name, string breed,
//                  int age, string color)
//    {
//        this.name = name;
//        this.breed = breed;
//        this.age = age;
//        this.color = color;
//    }
//    public string GetInfo()
//    {
//        return ($"name: {name}   breed: {breed}    age: {age}    color: {color}");
//    }
//}





//public class Building
//{
//    public string name;
//    int height;
//    int area;
//    string adress;
//    int size;

//    public Building(string name, int height,
//                  int area, string adress)
//    {
//        this.name = name;
//        this.height = height;
//        this.area = area;
//        this.adress = adress;
//        this.size = GetSize();
//    }
//    public int GetSize()
//    {
//        int size = height * area;
//        return size;
//    }
//    public string GetInfo()
//    {
//        return ($"name: {name}    height: {height}   area: {area}    adress: {adress}   size: {size}");
//    }
//}





//public class Student
//{
//    public string FirstName;
//    public string LastName;
//    public int Age;
//    public int[] HomeworkGrades;
//    public int[] ProjectGrades;
//    public int[] QuizGrades;
//    public int FinalGrade;
//    public bool[] Continuity;

//    public string OverallGrade;
//    public int TotalScore;

//    public Student(string firstName, string lastName, int age, int[] homeworkGrades, int[] projectGrades, int[] quizGrades, int finalGrade, bool[] continuity)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//        Age = age;
//        HomeworkGrades = homeworkGrades;
//        ProjectGrades = projectGrades;
//        QuizGrades = quizGrades;
//        FinalGrade = finalGrade;
//        Continuity = continuity;

//        CalculateScores();
//    }

//    private void CalculateScores()
//    {
//        int totalGrade = CalculateTotalGrade();
//        TotalScore = totalGrade;

//        if (TotalScore >= 95)
//        {
//            OverallGrade = "HighHonour";
//        }
//        else if (TotalScore >= 85)
//        {
//            OverallGrade = "Honour";
//        }
//        else if (TotalScore >= 65)
//        {
//            OverallGrade = "Normal";
//        }
//        else
//        {
//            OverallGrade = "Fail";
//        }
//    }

//    private int CalculateTotalGrade()
//    {
//        int homeworkAvg = CalculateAverage(HomeworkGrades) * 2 / 10;
//        int projectAvg = CalculateAverage(ProjectGrades) * 2 / 10;
//        int quizAvg = CalculateAverage(QuizGrades) * 2 / 10;
//        int continuityScore = CalculateContinuityScore() / 10;
//        int finalGradeScore = FinalGrade * 3 / 10;

//        return homeworkAvg + projectAvg + quizAvg + continuityScore + finalGradeScore;
//    }

//    private int CalculateAverage(int[] grades)
//    {
//        if (grades.Length == 0)
//            return 0;

//        int total = 0;
//        foreach (var grade in grades)
//        {
//            total += grade;
//        }
//        return total / grades.Length;
//    }

//    private int CalculateContinuityScore()
//    {
//        int attended = 0;
//        foreach (var continuity in Continuity)
//        {
//            if (continuity)
//                attended++;
//        }
//        return attended * 10 / Continuity.Length;
//    }
//}



//public class Gun
//{
//    public string Name;
//    public int MaxCapacity;
//    public int CurrentBullet;
//    public int TotalBullet;
//    public string Type;

//    public Gun(string name, int maxCapacity, int currentBullet, int totalBullet, string type)
//    {
//        Name = name;
//        MaxCapacity = maxCapacity;

//        if (currentBullet > MaxCapacity)
//        {
//            Console.WriteLine("Current bullet cannot exceed max capacity.");
//            return;
//        }

//        CurrentBullet = currentBullet;
//        TotalBullet = totalBullet;
//        Type = type;
//    }

//    public void Fire()
//    {
//        if (Type == "assault")
//        {
//            Console.WriteLine("Firing all bullets.");
//            CurrentBullet = 0;
//        }
//        else if (Type == "sniper")
//        {
//            Console.WriteLine("Firing one bullet.");
//            if (CurrentBullet > 0)
//                CurrentBullet--;
//            else
//                Console.WriteLine("No bullet left to fire.");
//        }
//    }

//    public void Reload()
//    {
//        int Reload = MaxCapacity - CurrentBullet;
//        if (Reload <= TotalBullet)
//        {
//            Console.WriteLine($"Reloading {Reload} bullets.");
//            CurrentBullet += Reload;
//            TotalBullet -= Reload;
//        }
//        else
//        {
//            Console.WriteLine("Not enough bullets to reload.");
//        }
//    }

//    public void DisplayStatus()
//    {
//        Console.WriteLine($"Gun Name: {Name}");
//        Console.WriteLine($"Current Bullet: {CurrentBullet}");
//        Console.WriteLine($"Total Bullet: {TotalBullet}");
//        Console.WriteLine($"Type: {Type}");
//    }
//}





//public class Calculator
//{
//    public int Add(int num1, int num2)
//    { return num1 + num2; }

//    public int Subtract(int num1, int num2)
//    { return num1 - num2; }

//    public int Multiply(int num1, int num2)
//    { return num1 * num2; }

//    public double Divide(int num1, int num2)
//    {
//        if (num2 == 0)
//        {
//            Console.WriteLine("Error: Division by zero.");
//            return 0;
//        }
//        return (double)num1 / num2;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculator calculator = new Calculator();
//        int num1, num2;
//        string operation;
//        bool validInput;

//        do
//        {
//            Console.WriteLine("Enter first number:");
//            validInput = int.TryParse(Console.ReadLine(), out num1);
//        } while (!validInput);

//        do
//        {
//            Console.WriteLine("Enter second number:");
//            validInput = int.TryParse(Console.ReadLine(), out num2);
//        } while (!validInput);

//        do
//        {
//            Console.WriteLine("Enter the operation (+, -, *, /):");
//            operation = Console.ReadLine();
//        } while (operation != "+" && operation != "-" && operation != "*" && operation != "/");

//        double result = 0;

//        switch (operation)
//        {
//            case "+":
//                result = calculator.Add(num1, num2);
//                break;
//            case "-":
//                result = calculator.Subtract(num1, num2);
//                break;
//            case "*":
//                result = calculator.Multiply(num1, num2);
//                break;
//            case "/":
//                result = calculator.Divide(num1, num2);
//                break;
//        }

//        Console.WriteLine($"Result: {result}");
//    }
//}
