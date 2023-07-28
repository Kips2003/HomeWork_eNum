using System.Text;

namespace Homework_eNum.Extensions{
    public static class stringExtensions{
        public static bool isNumber(this string str){
            if(!int.TryParse(str,out int num))return false;
            else return true;
        }

        public static bool isDate(this string str){
            if(DateTime.TryParse(str, out DateTime date))return true;
            else return false;
        }

        public static string[] ToWords(this string str){
            string[] result = new string[6];
            StringBuilder st = new StringBuilder();
            int IndexOfTheWords = 0;
            
            for(int i  = 0; i < str.Length;i++){
                if(str[i] != ' '){
                    st.Append(str[i]);
                }
                else if(str[i] == ' '){
                    string s = st.ToString();
                    result[IndexOfTheWords] = s;
                    IndexOfTheWords++;
                    st.Clear();
                }
            } 
            return result;
        }

        

        
    }
}