using System;
using RandLib;
Rand random = new Rand();
Console.WriteLine("Input how many random numbers is generate: ");
int count_num = Convert.ToInt32(Console.ReadLine());
random.Numbers(count_num);
Console.WriteLine("Input length random string is generate: ");
int count_str = Convert.ToInt32(Console.ReadLine());
random.Strings(count_str);
