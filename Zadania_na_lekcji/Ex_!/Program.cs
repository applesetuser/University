using System;
using System.IO;

namespace Ex__
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = File.ReadAllText("./data.txt"); // Load
            Console.WriteLine(text); // Display
            File.WriteAllText("./output.csv", text); // Save
           
            string[] lines = File.ReadAllLines("./data.txt");

            double[] I = new double[lines.Length];
            double[] V = new double[lines.Length];
            double[] P = new double[lines.Length];
            string[] x = new string[3];

            
            for(int i = 1; i < lines.Length; i++)
            {
                x = lines[i].Split(",");
                I[i] = double.Parse(x[0].Replace(".", ","));
                V[i] = double.Parse(x[1].Replace(".", ","));
                P[i] =  Math.Round((I[i] * V[i]), 3);
               
            ;}
            

            string output = "";

            for(int i = 1; i < lines.Length; i++)
            output += I[i] + ";" + V[i] + ";" + P[i] + "\r\n";

            output = output.Replace(",", ".");
            output = output.Replace(";", ",");

            File.WriteAllText("./output.csv", output);

        }
    }
}
