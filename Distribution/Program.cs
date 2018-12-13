using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using cdutcm.Common;
using Newtonsoft.Json;

namespace Distribution
{
    class Program
    {
        static void Main(string[] args)
        {
            Get();

            Console.ReadKey();
        }
        public static void Get()
        {
            ParametersDto parametersModel = new ParametersDto()
            {
                partnerId = "zhaijisong",
                partnerKey = "zhaijisong",
                net = "zhaijisong",
                kuaidicom = "zhaijisong",
                kuaidinum = "13245679",
                orderId = "13245679",
                recMan = new RecManDto()
                {
                    name = "程恩蒙",
                    mobile = "15228530671",
                    tel = "15228530671",
                    //zipCode = "",
                    //province = "",
                    //city = "",
                    //district = "",
                    //addr = "",
                    printAddr = "成都中医药大学",
                    company = "成都中医药大学"
                },
                sendMan = new SendManDto()
                {
                    name = "敖龙彪",
                    mobile = "15228530671",
                    tel = "15228530671",
                    //zipCode = "",
                    //province = "",
                    //city = "",
                    //district = "",
                    //addr = "",
                    printAddr = "成都中医药大学十二桥校区",
                    company = "成都中医药大学十二桥校区"
                },
                cargo = "测试物品",
                count = "1",
                weight = "1",
                volumn = "1",
                payType = "SHIPPER",
                expType = "标准快递",
                remark = "备注",
                //valinsPay = "",
                //collection = "",
                needChild = "0",
                needBack = "0",
                needTemplate = "1"
            };
            string parameters = JsonConvert.SerializeObject(parametersModel);//参数
            string timeSpan = GetTimeStamp();//时间戳
            string key = "TwTCHgMs2046";
            string secret = "dee08629d9eb4625b50f361884f867d5";
            string sign = GetMd5(parameters + timeSpan + key + secret);
            string url = $"http://api.kuaidi100.com/eorderapi.do?method=getElecOrder&param={parameters}&sign={sign}&t={timeSpan}&key={key}";
            string result = SendRequest(url, Encoding.UTF8);
            RequestResultsDto requestResults = JsonConvert.DeserializeObject<RequestResultsDto>(result);
        }
        /// <summary>  
        /// 获取时间戳  
        /// </summary>  
        /// <returns></returns>  
        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
        /// <summary>   
        /// Get方式获取url地址输出内容   
        /// </summary> /// <param name="url">url</param>   
        /// <param name="encoding">返回内容编码方式，例如：Encoding.UTF8</param>   
        public static string SendRequest(string url, Encoding encoding)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "POST";
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            StreamReader sr = new StreamReader(webResponse.GetResponseStream(), encoding);
            return sr.ReadToEnd();
        }
        /// <summary>
        /// MD5加密方法
        /// </summary>
        /// <param name="str">传入一个字符串</param>
        /// <returns></returns>
        public static string GetMd5(string str)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string a = BitConverter.ToString(md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str)));
            a = a.Replace("-", "");
            return a.ToUpper();
        }
    }
}
