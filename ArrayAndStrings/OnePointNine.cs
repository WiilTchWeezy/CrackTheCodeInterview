namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class OnePointNine
    {

        public bool IsRotation(string s1, string s2)
        {
            if(s1.Length == s2.Length && s1.Length > 0)
            {
                string s1s1 = s1 + s1;
                return IsSubString(s1s1, s2);
            }
            return false;
        }
        public bool IsSubString(string s1, string s2)
        {
            return s1.Contains(s2);
        }
    }
}
