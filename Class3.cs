using System;

namespace AssuranceUA3
{
    public class Grade
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public float Note { get; set; }

        public Grade(int studentId, int courseId, float note)
        {
            StudentId = studentId;
            CourseId = courseId;
            Note = note;
        }

        public override string ToString()
        {
            return $"Grade(Student ID: {StudentId}, Course ID: {CourseId}, Grade: {Note})";
        }
    }
}