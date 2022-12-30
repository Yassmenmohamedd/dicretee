using System;
using System.Linq;
 
namespace Task
{
              public static class Program
              {
                            public static void Main()
                            {
               Console.WriteLine("enter starting number:");
               int startNum =int.parse(console.Readline());
                                   Console.Writeline("enter ending number:");
                         int endNum =int.parse(console.Readline());
                         console.Writeline("these are the numbers between {0} and {1}",startNum,endNum);
                         
                         for(int i =startNum;i <= endNum; i++)
                         {
                                int counter = 0;
                                for (int j = 2; j<= i/2 ; j++)
                               {
                                     if (i%j ==0)
                                     {
                                                    counter++;
                                                    break;
                                                    
                                     }
                               }
                               if (counter== 0 && i !=1)
                               {
                               Console.WriteLine("{0}", i);
                                            
                               }
                         }
                            }
              }
              
}