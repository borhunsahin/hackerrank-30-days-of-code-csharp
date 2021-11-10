using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
               
        int T = Convert.ToInt32(Console.ReadLine());

        for(var i = 0; i<T; i++)
        {          
            string S = Console.ReadLine();
            int counter = 2;
            
            string even = "";
            string odd = "";
            
            foreach(var ch in S)
            {
                if(counter%2==0)
                {
                    even += ch;
                }
                else
                {
                    odd += ch;
                }
                
                counter++;
            }
            
            Console.WriteLine(even+" "+odd);

       
        } 
    }
}
