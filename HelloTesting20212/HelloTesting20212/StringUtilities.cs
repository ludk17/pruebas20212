﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTesting20212
{
    public class StringUtilities
    {
        private List<String> palabras;
        public StringUtilities() {
            this.palabras = new List<string>();
        }

        public void AddPalabra(string palabra)
        {
            palabras.Add(palabra);
        }

        public List<string> GetPalabras()
        {
            return this.palabras;
        }

        public void SortPalabras()
        {
            palabras.Sort();
        }


        public bool EsPalindrome(string word) {
            word = word.ToLower();
            var wordChar = word.Replace(" ", "");
            wordChar = wordChar.Replace("á", "a");
            wordChar = wordChar.Replace("é", "e");
            wordChar = wordChar.Replace("í", "i");
            wordChar = wordChar.Replace("ó", "o");
            wordChar = wordChar.Replace("ú", "u");
            wordChar = wordChar.Replace("ç", "c");
            var invertido = new string(wordChar.ToCharArray().Reverse().ToArray());
            return wordChar == invertido;
        }

        public string ConvertArrayToString(string[] arr)
        {
            return string.Join(" ", arr);
        }


        public int SumString(string numbers)
        {
            if (numbers == "")
                return 0;

            return numbers.Split(',').Select(o => int.Parse(o)).Sum();
        }

        public bool SonAnagrama(string data1, string data2)
        {
            var a = new String(data1.ToCharArray().OrderBy(o => o).ToArray());
            var b = new String(data2.ToCharArray().OrderBy(o => o).ToArray());
            return a == b;
        }
    }
}
