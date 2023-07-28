using System;
using Homework_eNum;

public class MyProgram{
    public static void MultOfTwoNumbers(double a, double b){
        System.Console.WriteLine(
            "{0}*{1}={2}",
            a, b, a*b
        );
    }

    public static void MultOfTwoNumbers(int a, int b){
        System.Console.WriteLine(
            "{0}*{1}={2}",
            a, b, a*b
        );
    }

    public static void Main(string[] args){

        System.Console.WriteLine("Please enter the number from 1 to 7");
        int numberOfTheDay = int.Parse(Console.ReadLine());

        var dayByTheNumber = (DayOfWeek)numberOfTheDay;
        System.Console.WriteLine(
            "number {0} day is {1}",
            numberOfTheDay, dayByTheNumber
        );
        System.Console.WriteLine();

        Status status = Status.Delivered;
        switch(status){
            case Status.Deleted:
                System.Console.WriteLine("Status: Deleted");break;
            
            case Status.Delivered:
                System.Console.WriteLine("Status: Delivered");break;

            case Status.Sent:
                System.Console.WriteLine("Status: Sent");break;
        }
        System.Console.WriteLine();

        Person person = new Person();
        person.Name = "Persons Name";
        System.Console.WriteLine("The number of persons is {0}", Person.count);
        
        System.Console.WriteLine();

        Triangle triangle = new Triangle();

        triangle.TriangleInfo(5,2);
        triangle.TriangleInfo(2,3,4);

        System.Console.WriteLine();

        MultOfTwoNumbers(2,3);
        MultOfTwoNumbers(3.9, 5.7);

        System.Console.WriteLine();

        Shape shape = new Shape(4,5);
        shape.PerimetreOfTheShape();

        Shape triangle1 = new Triangle(3,4,5);
        triangle1.PerimetreOfTheShape();

        System.Console.WriteLine();

        Person person1 = new Person("giorgi",20);
        System.Console.WriteLine(
            "Name of Person {0}\nAge of Person {1}",
            person1.Name, person1.Age
        );

        Person person2 = new Person();
        System.Console.WriteLine(
            "Name of Person {0}\nAge of Person {1}",
            person2.Name, person2.Age
        );

        System.Console.WriteLine();

        BankAccount bankAccount = new BankAccount();
        bankAccount.AccountNumber = "Ge001230002";
        bankAccount.Currency = "GEL";
        bankAccount.Amount = 150.3m;

        System.Console.WriteLine(bankAccount.AccountNumber);




    }
}