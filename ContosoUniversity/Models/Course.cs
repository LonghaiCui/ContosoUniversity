using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name="Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0,5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }
        //Vitual  keyword is used to modify a method, property, allow for it to be overridden in a derived class
        //vitual Area for diffent shapes (square, circle..)
        //It allows the Entity Framework to create a proxy around the virtual property 
        //so that the property can support lazy loading(Navigation properties) and 
        //more efficient change tracking(scalar properties).
        public virtual Department Department { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}