using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dianond.CSharpExtensionMethod
{
    public static class StringExtension
    {
        /// <summary>
        /// 检查字符串是否为空
        /// </summary>
        /// <param name="s">参数可以是null</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        /// <summary>
        /// 计算字符串的 MD5 哈希。若字符串为空，则返回空，否则返回计算结果。
        /// </summary>
        /// <param name="str"></param>
        public static string ComputeMD5Hash(this string str)
        {
            string hash = str;

            if (str != null)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] data = Encoding.ASCII.GetBytes(str);
                data = md5.ComputeHash(data);
                hash = data.Aggregate("", (current, t) => current + t.ToString("x2"));
            }

            return hash;
        }

        /// <summary>
        /// 检查字符串是否被正则匹配
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static bool IsMatch(this string s, string pattern)
        {
            if (s == null)
                return false;
            return Regex.IsMatch(s, pattern);
        }

        /// <summary>
        /// 输出匹配正则的第一项
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static string Match(this string s, string pattern)
        {
            if (s == null)
                return "";
            return Regex.Match(s, pattern).Value;
        }
    }
}
