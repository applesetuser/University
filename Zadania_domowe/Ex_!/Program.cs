using System;
using System.IO;

namespace Ex__
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("./data.txt");

            double[] W = new double[lines.Length];
            double[] P = new double[lines.Length];
            double[] t = new double[lines.Length];
            double[] I = new double[lines.Length];
            double[] V = new double[lines.Length];
            string[] temp = new string[2];

            for(int i = 0; i < lines.Length; i++)
            {
            temp = lines[i].Split(",");
            I[i] = double.Parse(temp[0].Replace(".", ","));
            V[i] = double.Parse(temp[1].Replace(".", ","));
            P[i] = Math.Round(I[i] * V[i], 3);
            t[i] = (i);
            if (i < lines.Length - 1)
                W[i] = Math.Round((P[i] + P[i + 1]) / 2, 3);
            }

            string output = "t[us] ; I[A] ; V[V] ; P[W] ; W[J] \r\n";

            for(int i = 0; i < lines.Length; i++)
            output += t[i] + "[us] ;" + I[i] + ";" + V[i] + ";" + P[i] + ";" + W[i] + "\r\n";

            output = output.Replace(",", ".");
            output = output.Replace(";", ",");

            File.WriteAllText("./output.csv", output);

        }
    }
}
