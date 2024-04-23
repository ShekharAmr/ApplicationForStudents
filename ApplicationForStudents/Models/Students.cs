using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApplicationForStudents.Models
{

    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {

    }


    public class StudentMetadata
    {
        [Required]
        [Display(Name ="STUDENT_NO")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "STUDENT_NAME")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "STUDENT_DOB")]
        public Nullable<System.DateTime> DOB { get; set; }

        [Required]
        [Display(Name = "STUDENT_DOJ")]
        public Nullable<System.DateTime> DOJ { get; set; }

    }

}