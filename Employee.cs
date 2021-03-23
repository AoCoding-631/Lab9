using System;

class Employee {

//attributes/feilds
  private string firstname;
  private string lastname;
  private string id;
  private string address;
  private string phonenumber;
  private string title;
  private string employmentstatus;

  private int age;
  private double yearlysalary;

//constructor
public Employee()
{
  firstname = "unknown";
  lastname = "unknown";
  id = "unknown";
  age = 0;
  employmentstatus = "active";
  Console.WriteLine("A new employee has been hired!");
}

//constructor with parameters
public Employee(string firstname, string lastname , string id, int age)
{
  firstname = "John";
  lastname = "Smith";
  id = 1234;
  age = 45;
  employmentstatus = "active";
  
}
  }