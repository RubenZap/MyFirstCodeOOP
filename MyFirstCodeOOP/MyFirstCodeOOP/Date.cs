using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class Date
    {
        #region fields
        public int _year;
        public int _month;
        public int _day;
        #endregion

        #region constructor
        public Date(int year, int month, int day)
    {
            this._year = validateyear(year);
            this._month = validateMonth(month);
            this._day = validateDay(day,month);

    }

       
        #endregion

        #region methods
        public override string ToString()
        {
            return $"{_year:0000}/{_month:00}/{_day:00}";
        }
        
        private int validateDay(int day, int month)
        {
            if (month == 2)
            {
                if (day>= 1 && day <= 28)
                {
                    return day;
                }
            }
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day >= 1 && day <= 31)
                {
                    return day;
                }
            }
            else
            {
                if (day >= 1 && day <= 30)
                {
                    return day;
                }
            }
                throw new DayException("the day is invalid");
             
        }

        private int validateMonth(int month) 
        {
            if(month >=1 && month <= 12) 
            {
                return month;
            }
            throw new MonthException("the month is invalid");
        }
        private int validateyear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            throw new YearException();
        }

        #endregion

    }

}
