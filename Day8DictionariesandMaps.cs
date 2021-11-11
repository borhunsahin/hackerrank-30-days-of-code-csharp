using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        int n = Convert.ToInt32(Console.ReadLine());
        
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        
        for(var i=0; i<n; i++)
        {
            string[] person = Console.ReadLine().Split();
            phonebook.Add(person[0],person[1]);
        }
        
        string input = Console.ReadLine();
        while(input != null)
        {
            if(phonebook.ContainsKey(input)==true)
            {
                Console.WriteLine(input+"="+phonebook[input]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
                        
            input = Console.ReadLine();
        }   

        
    }
}
