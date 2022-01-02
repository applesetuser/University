using System;
using System.IO;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("./data.csv");

            double[] I = new double[lines.Length];
            double[] V = new double[lines.Length];
            string[] temp = new string[2];

            
            for(int i = 0; i < lines.Length; i++)
            {
            temp = lines[i].Split(",");
            I[i] = double.Parse(temp[0].Replace(".", ","));
            V[i] = double.Parse(temp[1].Replace(".", ","));
            }

            string output = "";

            for(int i = 0; i < lines.Length; i++)
            output += I[i] + ";" + V[i] + "\r\n";

            output = output.Replace(",", ".");
            output = output.Replace(";", ",");

            File.WriteAllText("./output.csv", output);
        }
    }
}
