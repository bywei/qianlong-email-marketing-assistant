using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace dao.common
{
  public  class ChkUtil
    {
        #region  验证输入字符串为正确的用户名密码
        /// <summary>
        /// 验证输入字符串为数字
        /// </summary>
        /// <param name="P_str_num">输入字符</param>
        /// <returns>返回一个bool类型的值</returns>
        public bool validateUser(string P_str_user)
        {
            return Regex.IsMatch(P_str_user, "^[a-zA-Z0-9]{5,18}$");
        }
        #endregion

        #region  验证输入字符串为数字
        /// <summary>
        /// 验证输入字符串为数字
        /// </summary>
        /// <param name="P_str_num">输入字符</param>
        /// <returns>返回一个bool类型的值</returns>
        public bool validateNum(string P_str_num)
        {
            return Regex.IsMatch(P_str_num, "^[0-9]*$");
        }
        #endregion

        #region  验证输入字符串为电话号码
        /// <summary>
        /// 验证输入字符串为电话号码
        /// </summary>
        /// <param name="P_str_phone">输入字符串</param>
        /// <returns>返回一个bool类型的值</returns>
        public bool validatePhone(string P_str_phone)
        {
            return Regex.IsMatch(P_str_phone, @"\d{3,4}-\d{7,8}");
        }
        #endregion

        #region  验证输入字符串为传真号码
        /// <summary>
        /// 验证输入字符串为传真号码
        /// </summary>
        /// <param name="P_str_fax">输入字符串</param>
        /// <returns>返回一个bool类型的值</returns>
        public bool validateFax(string P_str_fax)
        {
            return Regex.IsMatch(P_str_fax, @"86-\d{2,3}-\d{7,8}");
        }
        #endregion

        #region  验证输入字符串为邮政编码
        /// <summary>
        /// 验证输入字符串为邮政编码
        /// </summary>
        /// <param name="P_str_postcode">输入字符串</param>
        /// <returns>返回一个bool类型的值</returns>
        public bool validatePostCode(string P_str_postcode)
        {
            return Regex.IsMatch(P_str_postcode, @"\d{6}");
        }
        #endregion

        #region  验证输入字符串为E-mail地址
        /// <summary>
        /// 验证输入字符串为E-mail地址
        /// </summary>
        /// <param name="P_str_email">输入字符串</param>
        /// <returns>返回一个bool类型的值</returns>
        public bool validateEmail(string P_str_email)
        {
            return Regex.IsMatch(P_str_email, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }
        #endregion

        #region  验证输入字符串为网络地址
        /// <summary>
        /// 验证输入字符串为网络地址
        /// </summary>
        /// <param name="P_str_naddress">输入字符串</param>
        /// <returns>返回一个bool类型的值</returns>
        public bool validateNAddress(string P_str_naddress)
        {
            return Regex.IsMatch(P_str_naddress, @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
        }
        #endregion
    }
}
