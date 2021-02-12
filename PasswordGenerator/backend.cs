using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{

    class backend
    {
        
        Random rnd = new Random();



        public char[] charArray = ("abcdefghijklmnopqrstuvwxyz" + "1234567890" + "@%+/\'!#$^?:.(){}[]-_,").ToCharArray();
        public char[] charArray1 = ("abcdefghijklmnopqrstuvwxyz" + "1234567890").ToCharArray();
        public char[] charArray2 = ("abcdefghijklmnopqrstuvwxyz" + "@%+/\'!#$^?:.(){}[]-_,").ToCharArray();
        public char[] charArray3 = "abcdefghijklmnopqrstuvwxyz".ToCharArray();







        public string GeneratePassword(int type, int length)
        {
            charArray = charArray.OrderBy(x => rnd.Next()).ToArray();
            charArray1 = charArray1.OrderBy(x => rnd.Next()).ToArray();
            charArray2 = charArray2.OrderBy(x => rnd.Next()).ToArray();
            charArray3 = charArray3.OrderBy(x => rnd.Next()).ToArray();

            StringBuilder password = new StringBuilder("", charArray.Length);
            StringBuilder password1 = new StringBuilder("", charArray1.Length);
            StringBuilder password2 = new StringBuilder("", charArray2.Length);
            StringBuilder password3 = new StringBuilder("", charArray3.Length);

            switch (type)
            {
                case 0:                    
                    for(int i = 0; i < length; i++)
                    {                        
                        password.Insert(i, "" + charArray[rnd.Next(charArray.Length)]);                   
                    }
                    return password.ToString();

                case 1:
                    for (int i = 0; i < length; i++)
                    {
                        password1.Insert(i, "" + charArray1[rnd.Next(charArray1.Length)]);                     
                    }
                    return password1.ToString();

                case 2:
                    for (int i = 0; i < length; i++)
                    {
                        password2.Insert(i, "" + charArray2[rnd.Next(charArray2.Length)]);
                    }
                    return password2.ToString();
                
                case 3:
                    for (int i = 0; i < length; i++)
                    {
                        password3.Insert(i, "" + charArray3[rnd.Next(charArray3.Length)]);
                    }
                    return password3.ToString();
                
                default:
                    return "";
            }
        }
    }
}
