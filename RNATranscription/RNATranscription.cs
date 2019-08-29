using System;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string ans="";
            Dictionary<char, char> rna = new Dictionary<char, char>();

            rna.Add('G', 'C');
            rna.Add('C', 'G');
            rna.Add('T', 'A');
            rna.Add('A', 'U');

            for (int i=0;i<nucleotide.Length;i++)
            {
                ans = ans + rna[nucleotide[i]];
            }
            return ans;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
