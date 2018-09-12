using System;
using System.ComponentModel.DataAnnotations;

namespace ExercisePerson.Models
{
    public class Person
    {
        public Person()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
            Email = "";
            DateOfBirth = DateTime.Now;
        }

        public Person(string _firstName, string _lastName, string _email)
        {
            Id = 0;
            FirstName = _firstName;
            LastName = _lastName;
            Email = _email;
        }

        public Person(string _firstName, string _lastName, DateTime _dateOfBirth)
        {
            Id = 0;
            FirstName = _firstName;
            LastName = _lastName;
            DateOfBirth = _dateOfBirth;
        }

        public int Id { get; set; }

        [Required]
        public String FirstName { get; set; }

        [Required]
        public String LastName { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public String SunSign { get { return new Sun().SunSign(DateOfBirth); } }

        public String Horo { get { return new ChineseSigns().get_ChineseZodiac(DateOfBirth); } }
    }
}