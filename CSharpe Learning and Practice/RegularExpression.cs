using System.Text.RegularExpressions;

namespace CSharpe_Learning_and_Practice
{
    /*
     * Quantifiers
       The most important quantifiers are *?+.
     * : * => Matches the preceding character zero or more times.   Ex-> a*b = b,ab,aab,aaab,aaaaab,,,a^nb
     * : + => Matches the preceding character 1 or more times. Ex-> a+b = ab,aaab,aaab,a^nb
     * : ? => Matches the preceding char zero or one time.   Ex-> a?b = ab, b
     * Special characters
     * Many special characters are available for regex building. Here are some of the more usual ones.
     * : ^ => It is used to match the beginning of a string. Ex-> ^India = India is my country.
     * : $ => It is used to match the end of a string. Ex-> India$ = I am from India.
     * : (Dot) => Matches any character only once. Ex-> Y.D(length 3) = YaD, YoD,YsD, YRD, YYD, Y@D,
     * : \d => It is used to match a digit character. Ex-> [0-9]=\d 
     * : \D => It is used to match any non-digit character. [^0-9]
     * : \w => It is used to match an alphanumeric character plus "_". Ex-> A to Z, 0 to 9, a to z, _
     * : \W => It is used to match any non-word character. Ex-> "." In "ID B1.5"
     * : \s => Matches white space characters. Ex-> \w\s => "C " in "IC 14A .12"
     * : \S => Matches a non-white space character. Ex-> \s|s => "_ "  in "Imp__str"
     * : \n =>Matches a newline character.
     * Character classe
       You can group characters by putting them between square brackets.This way, 
       any character in the class will match one character in the input.
       : [ ] => It is used to match a range of characters.  Ex-> [abc] = Match any a, b and c
       [a-z] =  Match any character a to z  (Ascii order)
       [^abc] = A caret ^ at the beginning indicates "not". Match any thing other than abc
       S[aei]t = Sat, Set, Sit
     * Grouping and alternatives
       It's often necessary to group things together with parentheses ( and ).
       : ()=> It is used to group expressions.
       Ex=> (cd)+  => true {cd, cdcd} false {ccdd}
       (ss | dd) + => true {ss, ddss} false {sdsd} -> { '|' this tell that any alternative}
       : {} =>It is used to match the preceding character for a specified number of times.
       : i) {n}=> Matches the previous element exactly n times.
         Ex-> ",\d{4}" -> ",1664" in "1,1664.5"
       : ii) {n,m} =>Matches the previous element at least n times, but no more than m times.
         Ex-> "\d{4,6}"  => "1664" in "166489" {can be use for mobile number validation}

       
    */

    public enum Validate
    {
        MOBILE = 0,
        EMAIL = 1
    }
    public class RegularExpression
    {

        protected string ValidMobileNumber;
        protected string ValidEmail;
        public RegularExpression()
        {
            ValidMobileNumber = @"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}";
            ValidEmail = @"^([a-z]*\d*[a-z]*\d*.*)+@[a-z]+.[a-z]+";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ValidateRegEx(Validate validate, string value)
        {
            string exp = validate == Validate.EMAIL ? ValidEmail : ValidMobileNumber;
            Regex regex = new Regex(exp);
            return regex.IsMatch(value);
        }
    }
}
