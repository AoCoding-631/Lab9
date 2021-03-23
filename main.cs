using System;

class MainClass {
  public static void Main (string[] args) {

   Console.WriteLine ("Object Oriented Programming - Employee");


    Employee unknown = new Employee();//constructor with no parameters
    unknown.firstname="unknown";
    unknown.lastname="unknown";
    unknown.id="unknown";    
    unknown.age=0;
    unknown.employmentstatus="active";

    Employee John = new Employee("John","Smith", 1234, 45);//constructor with parameters
    Employee.Intro();
    Console.WriteLine("My age is " + Employee.age);
    Employee.age = 45;
    

  }
  }
