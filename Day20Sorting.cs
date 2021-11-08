using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        
        var swaps = 0;
        
        for(var i = 0; i<n; i++)
        {
            for(var j = 0; j<n-1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    swaps++;
                    var temp = a[j];
                    a[j] = a[j+1];
                    a[j+1] = temp;                
                }
                
            }
            
            if(swaps == 0) 
            {
                break;
            }
        }
            
        Console.WriteLine("Array is sorted in "+swaps+" swaps.");
        Console.WriteLine("First Element: "+a[0]);
        Console.WriteLine("Last Element: "+a[a.Count-1]);
    }
}
