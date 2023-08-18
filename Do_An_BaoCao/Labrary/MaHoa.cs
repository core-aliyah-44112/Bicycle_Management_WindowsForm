using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_BaoCao.Labrary
{
    public static class MaHoa
    {
        public static string ToMD5(string str)
        {
            MD5 mh = MD5.Create();
            byte[] input = System.Text.Encoding.Unicode.GetBytes(str);

            return Convert.ToBase64String(input);
        }
        public static string ToReset(string str)
        {

            MD5 mh = MD5.Create();
            byte[] input = Convert.FromBase64String(str);

            return Encoding.Unicode.GetString(input);
        }
        //public static string ToMD5(string str)
        //{
        //    MD5 mh = MD5.Create();
        //    byte[] input = System.Text.Encoding.ASCII.GetBytes(str);
        //    byte[] hash = mh.ComputeHash(input);
        //    StringBuilder chuoimd5 = new StringBuilder();
        //    for (int i = 0; i < hash.Length; i++)
        //    {
        //        chuoimd5.Append(hash[i].ToString("X2"));
        //    }
        //    return chuoimd5.ToString();
        //}
    }
}
