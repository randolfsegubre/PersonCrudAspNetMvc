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

        public Person(string firstName, string lastName, string email)
        {
            Id = 0;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            Id = 0;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public string SunSign => new Sun().SunSign(DateOfBirth);

        public string Horoscope => new ChineseSigns().get_ChineseZodiac(DateOfBirth);
    }
}