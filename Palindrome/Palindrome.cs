using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
   public class Palindrome
    {
        
        public bool IsPalindrone(string userinput)
        {
            try
            {
                string msg = userinput;
                char[] chArray = msg.ToCharArray();
                int length = chArray.Length;

                for (int i = 0; i < length / 2; i++)
                {
                    if (chArray[i] != chArray[length - i - 1])
                        return false;
                }

                return true;
            }

            catch(Exception ex)
            {
                throw Exception;
            }
            finally
            {
                return false;
            }
         
            }
        }

    }

