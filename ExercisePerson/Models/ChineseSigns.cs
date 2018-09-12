using System;
using System.Globalization;

namespace ExercisePerson.Models
{
    public class ChineseSigns
    {
        public string get_ChineseZodiac(DateTime date)
        {
            EastAsianLunisolarCalendar cc = new ChineseLunisolarCalendar();
            int sexagenaryYear = cc.GetSexagenaryYear(date);
            int terrestrialBranch = cc.GetTerrestrialBranch(sexagenaryYear);

            // string[] years = "rat,ox,tiger,hare,dragon,snake,horse,sheep,monkey,fowl,dog,pig".Split(',');
            // string[] years = "Rat,Ox,Tiger,Rabbit,Dragon,Snake,Horse,Goat,Monkey,Rooster,Dog,Pig".Split(',');
            // string[] years = new string[]{ "rat", "ox", "tiger", "hare", "dragon", "snake", "horse", "sheep", "monkey", "fowl", "dog", "pig" };
            string[] years = new string[] { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };

            return years[terrestrialBranch - 1];
        } // End Function get_ChineseZodiac
    }
}