using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    internal class DataCheck
    {
        public static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        public static bool IsString(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[^0-9!@#$%^&*()<>,.?/;:{}]*$");
            else return true;
        }
        public static bool IsString_1(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9a-zA-Z]*$");
            else return true;
        }
    }
}
