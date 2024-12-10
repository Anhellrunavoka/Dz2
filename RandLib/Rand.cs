using System;
namespace RandLib
{
    public class Rand
    {
        public void Numbers(int num) {
            Random rand=new Random();
            for (int i = 0; i < num; i++)
            {
                int rannum = rand.Next(0, 1000);
                Console.WriteLine("Random number is " + rannum);
            }
        }
        public void Strings(int length)
        {
            Random rand = new Random();
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#№%:;^&?/|*(){}[].<,>";
            string ryadok ="";
            for (int i = 0; i < length; i++) { 
                int rn=rand.Next(0, symbols.Length);
                ryadok += symbols[rn];
            }
            Console.WriteLine("Random string is " + ryadok);
        }
    }
}
