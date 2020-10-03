using System;
using System.Collections.Generic;

namespace Open_Lab_06._01
{
    public class Challenge
    {
        public string MysteryFunc(string str)
        {
            string ret = "";

            List<string> pismena = new List<string>();
            List<int> nasobitel = new List<int>();

            for (int i = 0; i < str.Length; i += 2)
                pismena.Add(str.ToCharArray()[i].ToString());

            for (int i = 1; i < str.Length; i += 2)
                nasobitel.Add(int.Parse(str.ToCharArray()[i].ToString()));

            for (int i = 0; i < pismena.Count; i++)
            {
                for (int y = 0; y < nasobitel[i]; y++)
                    ret += pismena[i];
            }
            return ret;
        }
    }
}
