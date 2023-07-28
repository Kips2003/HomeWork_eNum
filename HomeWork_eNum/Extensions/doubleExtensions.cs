namespace Homework_eNum.Extensions{
    public static class doubleExtension{
        public static double ToPercent(this double d){
            return d*100;
        }

        public static double RoundDown(this double d){
            return d-(d%1);
        }

        public static decimal ToDecimal(this double d){
            return Convert.ToDecimal(d);
        }

        public static bool IsGreater(this double d, double number){
            if(d>number)return true;
            else return false;
        }

        public static bool IsLess(this double d, double number){
            if(d<number)return true;
            else return false;
        }

        
    }
}