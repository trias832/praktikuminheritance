using System;
namespace Tugasinheritance
{
    class program{
	static void Main(string[]args)
    {
	Person person= new Person("Mike",20);
	person.GetNameAndAge();
	
	Teacher teacher = new Teacher("Thomas",35,"190302","Math");
	teacher.GetNameAndAge();
	
	Student student = new Student("Sara", 19,"10506" , "sara123@amikom.ac.id");
	student.GetNameAndAge();
	
	Console.ReadKey();
	}
    }
	
public class Person
{
	public string Name {get; set;}
	public int Age{get; set;}
	public Person(string name="", int age=0)
	{
		Name=name;
		Age=age;
	}
	public void GetNameAndAge()
	{
	Console.WriteLine("The  person has name : {0} and age : {1}",Name,Age);
	}
}

public class Teacher : Person
{
	public string TeacherId{get; set;}
	public string Subject{get; set;}
	public Teacher(string name,int age,string teacherId="",string subject="")
	{
		Name = name;
		Age = age;
		TeacherId = teacherId;
		Subject = subject;
	}
}

public class Student : Person
{
	public string StudentId{get; set;}
	public string Email{get; set;}
	public Student(string name,int age,string studentId="",string email="")
	{
		Name = name;
		Age = age;
		StudentId = studentId;
		Email = email;
	}
}
}
