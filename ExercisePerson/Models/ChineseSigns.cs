using System;
using System.Globalization;

namespace ExercisePerson.Models
{
    public class ChineseSigns
    {
        public string get_ChineseZodiac(DateTime date)
        {
            EastAsianLunisolarCalendar cc = new ChineseLunisolarCalendar();
            var sexagenarianYear = cc.GetSexagenaryYear(date);
            var terrestrialBranch = cc.GetTerrestrialBranch(sexagenarianYear);

            // string[] years = "rat,ox,tiger,hare,dragon,snake,horse,sheep,monkey,fowl,dog,pig".Split(',');
            // string[] years = "Rat,Ox,Tiger,Rabbit,Dragon,Snake,Horse,Goat,Monkey,Rooster,Dog,Pig".Split(',');
            // string[] years = new string[]{ "rat", "ox", "tiger", "hare", "dragon", "snake", "horse", "sheep", "monkey", "fowl", "dog", "pig" };
            string[] years = new string[] { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };

            return years[terrestrialBranch - 1];
        } // End Function get_ChineseZodiac
    }
}