using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string PlainText = "7777";

        byte[] PlainData = Encoding.UTF8.GetBytes(PlainText);
        byte[] result = (new SHA512Managed()).ComputeHash(PlainData);

        Console.Write("PlainData = ");
        for (int iTemp = 0; iTemp < PlainData.Length; ++iTemp)
        {
            Console.Write("{0:X2} ", PlainData[iTemp]);
        }
        Console.WriteLine();

        Console.Write("CyperText = ");
        for (int iTemp = 0; iTemp < result.Length; ++iTemp)
        {
            Console.Write("{0:X2} ", result[iTemp]);
        }
        Console.WriteLine();


    }
}