using System;
using System.Collections.Generic;
using System.Text;
using UPSHINE.BaseModel;
using UPSHINE.DBA;
using SqlSugar;
using UPSHINE.Core;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace UPSHINE.ServerPlugin.Common
{
    public static class CmsHelper
    {
        /// <summary>
        /// 字符串特殊字符 转成 空字符
        /// 1、arr = null，默认 回车\r \r\n、换行符\n、制表符\t 转成 空字符
        /// 2、arr != null，自定义字符 转成 空字符
        /// </summary>
        /// <param name="str"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string simpleStrReplace(string str, string[] arr = null)
        {
            //str = str.Trim();
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            else
            {
                if (arr == null)
                {
                    str = str.Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", "");
                    return str;
                }
                else
                {
                    foreach (string item in arr)
                    {
                        str = str.Replace(item, "");
                    }
                    return str;
                }
            }
        }
        /// <summary>
        /// 简单判断是否是日期
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public static bool IsDate(string strDate)
        {
            try
            {
                DateTime.Parse(strDate);  //不是字符串时会出现异常
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断是否整形数字 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        //public static bool IsInt(string number) {
        //    try
        //    {
        //        int.Parse(number);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public static bool IsRateRight(decimal rate)
        {
            if ((rate > 5 && rate <= 7) || rate == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsUsdRate(decimal rate)
        {
            if (rate > 5 && rate <= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsRmbRate(decimal rate)
        {
            if ( rate == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string getUtf8(string unicodeString)
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            Byte[] encodedBytes = utf8.GetBytes(unicodeString);
            String decodedString = utf8.GetString(encodedBytes);
            return decodedString;
        }

        public static string ToStrReplace(this string str, string[] arr = null)
        {
            //str = str.Trim();
            if (arr == null)
            {
                str = str.Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", "");
                return str;
            }
            else
            {
                foreach (string item in arr)
                {
                    str = str.Replace(item, "");
                }
                return str;
            }
        }





        public static bool IsNumeric(this string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }
        public static bool IsInt(this string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*$");
        }
        public static bool IsUnsign(this string value)
        {
            return Regex.IsMatch(value, @"^\d*[.]?\d*$");
        }

        public static bool isTel(this string strInput)
        {
            return Regex.IsMatch(strInput, @"\d{3}-\d{8}|\d{4}-\d{7}");
        }

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="strbase64"></param>
        /// <param name="filepath"></param>
        /// <param name="guridFileName"></param>
        /// <returns></returns>
        public static string OperateSaveImage(string strbase64, string filepath, string guridFileName)
        {
            try
            {
                // 如果不存在就创建file文件夹
                if (!Directory.Exists(filepath))
                {
                    if (filepath != null) Directory.CreateDirectory(filepath);
                }
                filepath = filepath + @"\" + guridFileName;
                //使用正则表达式把所有类型的图片去掉前缀
                string base64img = Regex.Replace(strbase64, "data:image/.*;base64,", "");

                byte[] photoBytes = Convert.FromBase64String(base64img);

                //创建一个新文件，将指定的字节数组写入该文件，然后关闭文件。如果目标文件已存在，则将覆盖它。
                File.WriteAllBytes(filepath, photoBytes);

                return filepath.Replace(AppDomain.CurrentDomain.BaseDirectory, "");

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
