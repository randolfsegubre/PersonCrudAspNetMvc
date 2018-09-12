using System;

namespace ExercisePerson.Models
{
    public class Sun
    {
        public String SunSign(DateTime _birthdate)
        {
            switch ((int)_birthdate.Month)
            {
                case 1:
                    ;
                    if (_birthdate.Day <= 20)
                    {
                        return "Capricorn";
                    }
                    else
                    {
                        return "Aquarius";
                    }
                    break;

                case 2:
                    if (_birthdate.Day <= 19)
                    {
                        return "Aquarius";
                    }
                    else
                    {
                        return "Pisces";
                    }
                    break;

                case 3:
                    if (_birthdate.Day <= 20)
                    {
                        return "Pisces";
                    }
                    else
                    {
                        return "Aries";
                    }
                    break;

                case 4:
                    if (_birthdate.Day <= 20)
                    {
                        return "Aries";
                    }
                    else
                    {
                        return "Taurus";
                    }
                    break;

                case 5:
                    if (_birthdate.Day <= 21)
                    {
                        return "Taurus";
                    }
                    else
                    {
                        return "Gemini";
                    }
                    break;

                case 6:
                    if (_birthdate.Day <= 22)
                    {
                        return "Gemini";
                    }
                    else
                    {
                        return "Cancer";
                    }
                    break;

                case 7:
                    if (_birthdate.Day <= 22)
                    {
                        return "Cancer";
                    }
                    else
                    {
                        return "Leo";
                    }
                    break;

                case 8:
                    if (_birthdate.Day <= 23)
                    {
                        return "Leo";
                    }
                    else
                    {
                        return "Virgo";
                    }
                    break;

                case 9:
                    if (_birthdate.Day <= 23)
                    {
                        return "Virgo";
                    }
                    else
                    {
                        return "Libra";
                    }
                    break;

                case 10:
                    if (_birthdate.Day <= 23)
                    {
                        return "Libra";
                    }
                    else
                    {
                        return "Scorpio";
                    }
                    break;

                case 11:
                    if (_birthdate.Day <= 22)
                    {
                        return "Scorpio";
                    }
                    else
                    {
                        return "Sagittarius";
                    }
                    break;

                case 12:
                    if (_birthdate.Day <= 21)
                    {
                        return "Sagittarius";
                    }
                    else
                    {
                        return "Capricorn";
                    }
                    break;

                default:
                    return "Your sun sign was not found! Please try again!";
                    break;
            }
        }
    }
}