using System;
using System.Collections.Generic;
using System.Text;

namespace GalGOT.Domain.Util
{
    public class GalGoTUtil
    {
        public static string GetArrayInString(string[] array)
        {
            string title = "";
            if (array == null)
                return title;
            foreach (string item in array)
            {
                title += item;
                if (item != array.GetValue(array.Length - 1).ToString())
                    title += ", ";
            }
            return title;
        }

    }
}
