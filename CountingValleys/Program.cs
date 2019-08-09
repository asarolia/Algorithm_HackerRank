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

class Program {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {

        // Char array to split the string 
        char[] stepArray =  new Char[n];
        int seaLevel = 0;
        int seaLevelPrev = 0;
        int valley = 0;
        int mountain = 0;
    
    // Add constraint on N
    if(n >= 2 && n <= 1000000)
    {
        stepArray = s.ToCharArray();
        foreach(char step in stepArray )
        {
            //validate if step is only D/U
            if(step == 'D' || step == 'U')
            {
                if(seaLevel == 0)
                {
                 //   Console.WriteLine("Sea Level: "+seaLevel);
                 //   Console.WriteLine("Prev Sea Level when levelled: "+seaLevelPrev);
                   
                    
                    if (seaLevelPrev > seaLevel)
                    {
                        mountain++;
                    }
                    if (seaLevelPrev < seaLevel)
                    {
                        valley++;
                    }
                }

                seaLevelPrev = seaLevel;
              //  Console.WriteLine("Prev Sea Level: "+seaLevelPrev);

                if(step == 'D')
                {
                    seaLevel = seaLevel - 1;

                }
                if(step == 'U')
                {
                    seaLevel = seaLevel + 1;
                }

            }else
            {
                return 0;
            }
        }
         if(seaLevel == 0)
                {
                    //Console.WriteLine("Sea Level: "+seaLevel);
                  //  Console.WriteLine("Prev Sea Level when levelled: "+seaLevelPrev);
                   
                    
                    if (seaLevelPrev > seaLevel)
                    {
                        mountain++;
                    }
                    if (seaLevelPrev < seaLevel)
                    {
                        valley++;
                    }
                }
      return valley;

    }else
    {
        return 0;
    }


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
