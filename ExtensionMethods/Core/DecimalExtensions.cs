using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class DecimalExtensions
    {
        /// <summary>
        /// 转为金额两位小数
        /// </summary>
        public static Decimal ToMoney(this Decimal @this)
        {
            return Math.Round(@this, 2);
        }

        #region Math
        /// <summary>
        /// 返回绝对值
        /// </summary>
        public static Decimal Abs(this Decimal value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        /// 返回大于此值的最小整数
        /// </summary>
        public static Decimal Ceiling(this Decimal d)
        {
            return Math.Ceiling(d);
        }

        /// <summary>
        /// 返回小于此值的最大整数
        /// </summary>
        public static Decimal Floor(this Decimal d)
        {
            return Math.Floor(d);
        }

        /// <summary>
        /// 获取最大值
        /// </summary>
        public static Decimal Max(this Decimal val1, Decimal val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>
        /// 获取最小值
        /// </summary>
        public static Decimal Min(this Decimal val1, Decimal val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        /// 四舍五入
        /// </summary>
        public static Decimal Round(this Decimal d)
        {
            return Math.Round(d);
        }

        /// <summary>
        /// 按小数位四舍五入
        /// </summary>
        public static Decimal Round(this Decimal d, Int32 decimals)
        {
            return Math.Round(d, decimals);
        }

        /// <summary>
        /// 按舍入类型获取值
        /// </summary>
        /// <param name="d">值</param>
        /// <param name="mode">舍入类型</param>
        public static Decimal Round(this Decimal d, MidpointRounding mode)
        {
            return Math.Round(d, mode);
        }

        /// <summary>
        /// 按舍入类型小数位获取值
        /// </summary>
        /// <param name="d">值</param>
        /// <param name="decimals">小数位数</param>
        /// <param name="mode">舍入类型</param>
        public static Decimal Round(this Decimal d, Int32 decimals, MidpointRounding mode)
        {
            return Math.Round(d, decimals, mode);
        }             

        /// <summary>
        /// 获取指定小数的整数部分
        /// </summary>
        public static Decimal Truncate(this Decimal d)
        {
            return Math.Truncate(d);
        }
        #endregion

        /// <summary>
        /// 值是否在区间内
        /// </summary>
        public static bool Between(this Decimal @this, Decimal minValue, Decimal maxValue)
        {
            return minValue.CompareTo(@this) == -1 && @this.CompareTo(maxValue) == -1;
        }
        
        #region Decimal Method
        /// <summary>
        /// 两数相除
        /// </summary>
        public static Decimal Divide(this Decimal d1, Decimal d2)
        {
            return Decimal.Divide(d1, d2);
        }

        /// <summary>
        /// 转换为其等效的二进制表示形式,由四个元素组成的 32 位有符号整数数组
        /// </summary>
        public static Int32[] GetBits(this Decimal d)
        {
            return Decimal.GetBits(d);
        }

        /// <summary>
        /// 两数相乘
        /// </summary>
        public static Decimal Multiply(this Decimal d1, Decimal d2)
        {
            return Decimal.Multiply(d1, d2);
        }

        /// <summary>
        /// 取反(乘-1）
        /// </summary>
        public static Decimal Negate(this Decimal d)
        {
            return Decimal.Negate(d);
        }

        /// <summary>
        /// 取余
        /// </summary>
        public static Decimal Remainder(this Decimal d1, Decimal d2)
        {
            return Decimal.Remainder(d1, d2);
        }

        /// <summary>
        ///     Subtracts one specified  value from another.
        /// </summary>
        public static Decimal Subtract(this Decimal d1, Decimal d2)
        {
            return Decimal.Subtract(d1, d2);
        }

        /// <summary>
        /// 转换为等效的 8 位无符号整数
        /// </summary>
        public static Byte ToByte(this Decimal value)
        {
            return Decimal.ToByte(value);
        }

        /// <summary>
        /// 转为双精度浮点数
        /// </summary>
        public static Double ToDouble(this Decimal d)
        {
            return Decimal.ToDouble(d);
        }
        
        /// <summary>
        /// 转为整形
        /// </summary>
        public static Int32 ToInt32(this Decimal d)
        {
            return Decimal.ToInt32(d);
        }

        /// <summary>
        /// 转为长整形
        /// </summary>
        public static Int64 ToInt64(this Decimal d)
        {
            return Decimal.ToInt64(d);
        }

        /// <summary>
        /// 转为float
        /// </summary>
        public static Single ToSingle(this Decimal d)
        {
            return Decimal.ToSingle(d);
        }
        #endregion

        #region 转换
        /// <summary>
        /// 转换人民币大写金额
        /// </summary>
        public static string CmycurD(this decimal num)
        {
            string str1 = "零壹贰叁肆伍陆柒捌玖";            //0-9所对应的汉字
            string str2 = "万仟佰拾亿仟佰拾万仟佰拾元角分"; //数字位所对应的汉字
            string str3 = "";    //从原num值中取出的值
            string str4 = "";    //数字的字符串形式
            string str5 = "";  //人民币大写金额形式
            int i;    //循环变量
            int j;    //num的值乘以100的字符串长度
            string ch1 = "";    //数字的汉语读法
            string ch2 = "";    //数字位的汉字读法
            int nzero = 0;  //用来计算连续的零值是几个
            int temp;            //从原num值中取出的值

            num = Math.Round(Math.Abs(num), 2);    //将num取绝对值并四舍五入取2位小数
            str4 = ((long)(num * 100)).ToString();        //将num乘100并转换成字符串形式
            j = str4.Length;      //找出最高位
            if (j > 15) { return "溢出"; }
            str2 = str2.Substring(15 - j);   //取出对应位数的str2的值。如：200.55,j为5所以str2=佰拾元角分

            //循环取出每一位需要转换的值
            for (i = 0; i < j; i++)
            {
                str3 = str4.Substring(i, 1);          //取出需转换的某一位的值
                temp = Convert.ToInt32(str3);      //转换为数字
                if (i != (j - 3) && i != (j - 7) && i != (j - 11) && i != (j - 15))
                {
                    //当所取位数不为元、万、亿、万亿上的数字时
                    if (str3 == "0")
                    {
                        ch1 = "";
                        ch2 = "";
                        nzero = nzero + 1;
                    }
                    else
                    {
                        if (str3 != "0" && nzero != 0)
                        {
                            ch1 = "零" + str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                    }
                }
                else
                {
                    //该位是万亿，亿，万，元位等关键位
                    if (str3 != "0" && nzero != 0)
                    {
                        ch1 = "零" + str1.Substring(temp * 1, 1);
                        ch2 = str2.Substring(i, 1);
                        nzero = 0;
                    }
                    else
                    {
                        if (str3 != "0" && nzero == 0)
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            if (str3 == "0" && nzero >= 3)
                            {
                                ch1 = "";
                                ch2 = "";
                                nzero = nzero + 1;
                            }
                            else
                            {
                                if (j >= 11)
                                {
                                    ch1 = "";
                                    nzero = nzero + 1;
                                }
                                else
                                {
                                    ch1 = "";
                                    ch2 = str2.Substring(i, 1);
                                    nzero = nzero + 1;
                                }
                            }
                        }
                    }
                }
                if (i == (j - 11) || i == (j - 3))
                {
                    //如果该位是亿位或元位，则必须写上
                    ch2 = str2.Substring(i, 1);
                }
                str5 = str5 + ch1 + ch2;

                if (i == j - 1 && str3 == "0")
                {
                    //最后一位（分）为0时，加上“整”
                    str5 = str5 + '整';
                }
            }
            if (num == 0)
            {
                str5 = "零元整";
            }
            return str5;
        }

        #endregion
    }
}
