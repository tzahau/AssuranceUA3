using System;

namespace AssuranceUA3
{
    public class Student {
	{
    public int StudentId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }

    public Student(int studentId, string lastName, string firstName)
    {
        StudentId = studentId;
        LastName = lastName;
        FirstName = firstName;
    }

    public override string ToString()
    {
        return $"Student(ID: {StudentId}, Name: {FirstName} {LastName})";
    }
}
}