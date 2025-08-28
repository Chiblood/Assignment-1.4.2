/* Assignment 1.4.2
Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), StudentLname (string ), StudentGrade ( char ) and public properties for each data member. Instantiate the class and assign data to properties. Display the data back on console. */

using System;
class Student
{
    private int StudentId;
    private string StudentFname;
    private string StudentLname;
    private char StudentGrade;
    public Student(int StudentId, string StudentFirstName, string StudentLastName, char StudentGrade)
    {
        this.StudentId = StudentId;
        this.StudentFirstname = StudentFirstName;
        this.StudentLname = StudentLname;
        this.StudentGrade = StudentGrade;
    }
    public int GetStudentId()
    {
        return StudentId;
    }
    public string GetStudentFirstName()
    {
        return StudentFirstName;
    }
    public string GetStudentLastName()
    {
        return StudentLname;
    }
    public char GetStudentGrade()
    {
        return StudentGrade;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student John = new Student(1, "John", "Doe", 'A');
        Console.WriteLine("Student ID: " + John.GetStudentId());
        Console.WriteLine("Student First Name: " + John.GetStudentFname());
        Console.WriteLine("Student Last Name: " + John.GetStudentLname());
        Console.WriteLine("Student Grade: " + John.GetStudentGrade());
    }
}