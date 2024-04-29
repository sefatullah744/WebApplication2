using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        public string StudentName { get; set; }
        public string Address { get; set; }
        [ForeignKey("Faculty")]
        public int FacultyID { get; set; }
        [ValidateNever]
        public virtual Faculty Faculty { get; set; }
    }
}
