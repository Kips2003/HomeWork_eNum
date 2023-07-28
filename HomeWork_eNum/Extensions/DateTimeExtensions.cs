namespace Homework_eNum.Extensions{
    public static class DateTimeExtensions{
        public static DateTime Min(this DateTime date1, DateTime date2){
            return (date1<date2)?date1:date2;
        }

        public static DateTime Max(this DateTime date1, DateTime date2){
            return (date1>date2)?date1:date2;
        }

        public static DateTime BeginingOfMonth(this DateTime date){
            return date.AddDays(-(date.Day-1));
        }
        
        public static DateTime EndOfMonth(this DateTime date){
            var endofmonth = DateTime.DaysInMonth(date.Year, date.Month);
            return date.AddDays(endofmonth-date.Day);
        }

        

    }
}