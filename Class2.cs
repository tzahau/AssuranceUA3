using System;

namespace AssuranceUA3
{

    public class Course
    {
        public int CourseId { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }

        public Course(int courseId, string code, string title)
        {
            CourseId = courseId;
            Code = code;
            Title = title;
        }

        public override string ToString()
        {
            return $"Course(ID: {CourseId}, Code: {Code}, Title: {Title})";
        }
    }

}