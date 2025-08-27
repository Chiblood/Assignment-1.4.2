/* Assignment 1.4.2
Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), StudentLname (string ), StudentGrade ( char ) and public properties for each data member. Instantiate the class and assign data to properties. Display the data back on console. */
using System;
class Student
{
    private int StudentId;
    private string StudentFname;
    private string StudentLname;
    private char StudentGrade;
    public Student(int StudentId, string StudentFname, string StudentLname, char StudentGrade)
    {
        this.StudentId = StudentId;
        this.StudentFname = StudentFname;
        this.StudentLname = StudentLname;
        this.StudentGrade = StudentGrade;
    }
    public int GetStudentId()
    {
        return StudentId;
    }
    public string GetStudentFname()
    {
        return StudentFname;
    }
    public string GetStudentLname()
    {
        return StudentLname;
    }
    public char GetStudentGrade()
    {
        return StudentGrade;
    }
}