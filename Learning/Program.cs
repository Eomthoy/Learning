using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Eom.Common;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Learning.Models;
using System.Xml.Serialization;
using System.Text;
using cdutcm.Json;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading.Tasks;
using Eom.Common.Helpers;
using MonitorManageClient.Models;
using System.Timers;
using model;
using Newtonsoft.Json;
using OffService.Helper;

namespace Learning
{
    class Program
    {

        public static Timer timer;
        static void Main(string[] args)
        {
            //PLinq();

            #region ExcelHandle
            //SqlHelper.connString = @"Server=1TVFGO8OATR3Y7G\SQLEXPRESS;DataBase=MyDB;Uid=sa;Pwd=123;";
            //ExcelHelper.WirteExcel();
            #endregion

            #region MyRegion
            //DateTime a = DateTime.Now;
            //DateTime b = DateTime.UtcNow;
            //var ab = (a - b).TotalMinutes;

            //string str = "abcdefgahijklmnop";
            //Dictionary<string, int> dic = new Dictionary<string, int>();
            //for (int i = 0, j = 1; j <= str.Length; j++)
            //{
            //    string t = str.Substring(i, j);
            //    char next = str[j];
            //    if (t.Contains(next))
            //    {
            //        dic.Add(t, t.Count());
            //        i = str.IndexOf(str[j]) + 1;
            //    }
            //}
            //foreach (var item in dic)
            //{
            //    Console.WriteLine(item.Key + "\t", item.Value);
            //}
            #endregion

            #region Reg
            //string input = "10.126.6.113 10.126.6.256";
            ////string pattern = @"([01]?\d?\d|2[0-4]\d|25[0-5]\.){3}([01]?\d?\d|2[0-4]\d|25[0-5])";
            //string pattern = @"(([01]?\d?\d|2[0-4]\d|25[0-5])\.){3}([01]?\d?\d|2[0-4]\d|25[0-5])";
            //bool result = Regex.IsMatch(input, pattern);
            //Match matchas = Regex.Match(input, pattern);
            //foreach (Match item in Regex.Matches(input, pattern))
            //{
            //    string match = item.Value;
            //}
            #endregion

            #region MyRegion
            //double ahkd = Math.Pow(2, 32);

            //int i = int.MaxValue;

            //decimal dec = 9.1m;
            //float df = 1.1f;
            //int da = "9223372036854775807".Length;

            //Car car1 = new Car() { Name = "BMW", Price = 1 };
            //Car car2 = new Car() { Name = "红旗", Price = 2 };
            //Car car3 = new Car() { Name = "BMW", Price = 1 };

            //var sum = car1 + car2;

            //double shj = car1;
            //int daskj = (int)car2;

            //bool res1 = car1 == car2;
            //bool res2 = car1 == car3;

            //bool res3 = car1 != car2;
            //bool res4 = car1 != car3;

            //bool res5 = car1 >= car2;
            //bool res6 = car2 >= car3;
            //bool res7 = car1 >= car3;
            #endregion

            #region xmlTest
            //string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><note><to>George</to><from>John</from><heading>Reminder</heading><body>Don't forget the meeting!</body></note>";
            //string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><xml><return_code>[CDATA[SUCCESS]]</return_code><return_msg>[CDATA[OK]];</return_msg><appid>[CDATA[wx2421b1c4370ec43b]]</appid><mch_id>[CDATA[10000100]]</mch_id><nonce_str>[CDATA[IITRi8Iabbblz1Jc]]</nonce_str><sign>[CDATA[7921E432F65EB8ED0CE9755F0E86D72F]]</sign><result_code>[CDATA[SUCCESS]]</result_code><prepay_id>[CDATA[wx201411101639507cbf6ffd8b0779950874]]</prepay_id><trade_type>[CDATA[APP]]</trade_type></xml>";
            //string xml = "<xml><return_code><![CDATA[SUCCESS]]></return_code><return_msg><![CDATA[OK]]></return_msg><appid><![CDATA[wx2421b1c4370ec43b]]></appid><mch_id><![CDATA[10000100]]></mch_id><nonce_str><![CDATA[IITRi8Iabbblz1Jc]]></nonce_str><sign><![CDATA[7921E432F65EB8ED0CE9755F0E86D72F]]></sign><result_code><![CDATA[SUCCESS]]></result_code><prepay_id><![CDATA[wx201411101639507cbf6ffd8b0779950874]]></prepay_id><trade_type><![CDATA[APP]]></trade_type></xml>";
            //xml note = XmlHelper.XmlToEntity<xml>(xml, Encoding.UTF8);

            //string json = "[\r\n  {\r\n    \"Id\": 1,\r\n    \"Name\": \"01\"\r\n  }]";
            //List<Class> classes = JsonHelper.JsonToList<Class>(json);
            #endregion

            #region MyRegion
            //IList<Car> cars = new List<Car>()
            //{
            //    new Car(){ Name = "BWM",Price = 1000},
            //    new Car(){ Name = "cashkda",Price = 500},
            //    new Car(){ Name = "dasj",Price=500}
            //};
            //var var = cars.GroupBy(x => new { x.Price, x.Name }).Select(x => x.Key).ToList();
            //FileFunc();
            //ReadXML();
            //Car car = new Car();
            //car.ReadXML();

            //string sql = "select * from [MyDB].[dbo].[Class]";
            //List<Class> classList = SqlHelper.GetAll<Class>(sql, CommandType.Text, new SqlParameter[] { });

            //string sql2 = "select * from [MyDB].[dbo].[Class] where id = 2";
            //Class model = SqlHelper.Get<Class>(sql2, CommandType.Text, new SqlParameter[] { });
            #endregion

            #region MyRegion
            //string sql = "select * from [MyDB].[dbo].[Class]";
            //List<Class> obj = SqlHelper.GetAll<Class>(sql, CommandType.Text);
            //string djal = JsonHelper.EntityToJson(obj);

            //foreach (PropertyInfo p in typeof(Person).GetProperties())
            //{
            //    var propertyName = p.Name;
            //    var propertyType = p.PropertyType.ToString().Trim().ToLower();

            //    var attribute1 = p.GetCustomAttributes(true).Where(x => x.GetType() == typeof(ExcelColumAttribute)).FirstOrDefault() as ExcelColumAttribute;
            //    if (attribute1 != null)
            //    {
            //        var columName = attribute1.ColumName;
            //    }
            //    var attribute2 = p.GetCustomAttributes(typeof(ExcelColumAttribute), false);
            //}

            ////string sql = "select * from [MyDB].[dbo].[Student]";
            //DataTable dataTable = SqlHelper.ExecuteDataTable(sql, CommandType.Text, new SqlParameter[] { });
            //var sss = dataTable.Columns;
            //List<Student> list = new List<Student>();
            //foreach (DataRow item in dataTable.Rows)
            //{
            //    Student model = new Student();
            //    foreach (PropertyInfo propertyInfo in typeof(Student).GetProperties())
            //    {
            //        var val = item[propertyInfo.Name];
            //        string type = propertyInfo.PropertyType.Name;
            //        if (val != DBNull.Value && val != null)
            //        {
            //            propertyInfo.SetValue(model, val, null);
            //        }
            //    }
            //    list.Add(model);
            //}

            //string sql2 = "select * from [MyDB].[dbo].[Student]";
            //SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.Text, new SqlParameter[] { });
            //List<Student> students = new List<Student>();
            //using (reader)
            //{
            //    while (reader.Read())
            //    {
            //        Student model = new Student();
            //        foreach (PropertyInfo propertyInfo in typeof(Student).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            //        {
            //            object val = reader[propertyInfo.Name];
            //            string type = propertyInfo.PropertyType.ToString().Trim().ToLower();
            //            if (val != DBNull.Value && val != null)
            //            {
            //                propertyInfo.SetValue(model, val, null);
            //            }
            //        }
            //        students.Add(model);
            //    }
            //}


            //List<Person> personList = SqlHelper.GetAllFromExcel<Person>(@"C:\Users\Administrator\Desktop\智慧教室\研究所考勤\温江实习生.xls");

            //PropertyInfo[] propertyInfos = typeof(Person).GetProperties(BindingFlags.Instance | BindingFlags.Public);
            //foreach (PropertyInfo pi in propertyInfos)
            //{
            //    Console.WriteLine($"{pi.Name}\t\t{ pi.PropertyType}");
            //}
            #endregion

            #region MD5

            //string str = EncryptHelper.MD5Encryp("1234", 16);
            //string str1 = EncryptHelper.MD5Encryp("1234", 32);
            //Console.WriteLine("16:" + str);
            //Console.WriteLine("32:" + str1);

            #endregion

            #region 视频通道保存

            string text = System.IO.File.ReadAllText(@"C:\Users\admin\Desktop\111.txt", Encoding.UTF8);
            SqlHelper.connString = @"server=10.10.78.240;database=RecordDB;uid=sa;pwd=123456";
            foreach (var item in JsonHelper.JsonToList<Root>(text).Select(x => x.UnitNodes.Channel))
            {
                foreach (Channel model in item)
                {
                    string sql = $"UPDATE [RecordDB].[dbo].[Pass] SET [VideoChannelB] = '{model.id}' WHERE RName = '{model.name}' ";
                    SqlHelper.Execute(sql, CommandType.Text);
                }
            }

            #endregion

            #region 音频权限

            //int power = 0;
            //int roomId = 6;
            //power = GetPower(power, roomId);

            #endregion

            Console.ReadKey();
        }

        private static void Save(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(timer.Interval);
            timer.Interval = 6000;
        }

        public static int GetPower(int power, int roomID)
        {
            if (roomID <= 15)
            {
                if ((power & Convert.ToInt32(Math.Pow(2, roomID))) == 0)
                {
                    power += Convert.ToInt32(Math.Pow(2, roomID));
                }
            }
            else if (roomID > 15 && roomID <= 25)
            {
                if ((power & Convert.ToInt32(Math.Pow(2, roomID - 15))) == 0)
                {
                    power += Convert.ToInt32(Math.Pow(2, roomID - 15));
                }
            }
            else
            {
                if ((power & Convert.ToInt32(Math.Pow(2, roomID - 25))) == 0)
                {
                    power += Convert.ToInt32(Math.Pow(2, roomID - 25));
                }
            }
            return power;
        }
        public static async Task Cal()
        {
            var sum = await Calculator.AddAsync(2, 3);
            Console.WriteLine(sum);
        }
        public static void PLinq()
        {


            SqlHelper.connString = "data source=10.126.6.113;initial catalog=BehaviorAnalysis;user id=sa;password=cdutcm@123;";
            string sql = "SELECT *  FROM [BehaviorAnalysis].[dbo].[PersonFeaRecord]";
            List<PersonFeaRecord> list = SqlHelper.GetAll<PersonFeaRecord>(sql, CommandType.Text);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var a = list.Where(x => x.Id > 10000);
            stopwatch.Stop();
            TimeSpan timespan1 = stopwatch.Elapsed; //  获取当前实例测量得出的总时间

            stopwatch.Restart();
            var b = list.AsParallel().Where(x => x.Id > 10000);
            stopwatch.Stop();
            TimeSpan timespan2 = stopwatch.Elapsed; //  获取当前实例测量得出的总时间

            Console.WriteLine($"用时：{timespan1.TotalMilliseconds}");
            Console.WriteLine($"用时：{timespan2.TotalMilliseconds}");


        }
        /// <summary>
        /// 文件夹操作
        /// </summary>
        /// <returns></returns>
        public static void FileFunc()
        {
            //1.创建文件夹
            string path = Directory.GetCurrentDirectory() + "\\DirectoryTest";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string path1 = Environment.CurrentDirectory;

            //2.创建文件
            string filePath = Path.Combine(path, "test.txt");
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            //写入文件
            FileInfo info = new FileInfo(filePath);
            using (StreamWriter stream = info.CreateText())
            {
                stream.WriteLine("dashdjkajd\tdfahjdka\t467613");
                stream.WriteLine("dashdjkajd\ndfahjdka\n467613");
                stream.WriteLine("dashdjkajd\ndfahjdka\n467613");
                stream.Close();
            }

            //读取文件
            using (StreamReader reader = File.OpenText(filePath))
            {
                var ss = reader.ReadLine().ToString();
                var sss = reader.ReadLine().ToString();
                var ssss = reader.ReadLine().ToString();
            }

            //


            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        public static void ReadXML()
        {
            //将XML文件加载进来
            XDocument document = XDocument.Load(@"E:\test.txt");
            //获取到XML的根元素进行操作
            XElement root = document.Root;
            XElement ele = root.Element("Name");
            //获取name标签的值
            XElement name = root.Element("Age");
            //获取根元素下的所有子元素
            IEnumerable<XElement> enumerable = root.Elements();
            foreach (XElement item in enumerable)
            {
                foreach (XElement item1 in item.Elements())
                {
                    Console.WriteLine(item1.Name);   //输出 name  name1            
                }
                Console.WriteLine(item.Attribute("id").Value);  //输出20
            }
        }
    }

    public class PersonFeaRecord
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string Fea { get; set; }
        public int? CameraId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? PersonId { get; set; }
    }

    public class Car
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public void ReadXML()
        {
            //将XML文件加载进来
            XDocument document = XDocument.Load(@"E:\test.txt");
            //获取到XML的根元素进行操作
            XElement root = document.Root;
            XElement ele = root.Element("Name");
            //获取name标签的值
            XElement name = root.Element("Age");
            //获取根元素下的所有子元素
            IEnumerable<XElement> enumerable = root.Elements();
            foreach (XElement item in enumerable)
            {
                foreach (XElement item1 in item.Elements())
                {
                    Console.WriteLine(item1.Name);   //输出 name  name1            
                }
                Console.WriteLine(item.Attribute("id").Value);  //输出20
            }
        }

        #region 运算符重载

        public static bool operator ==(Car car1, Car car2)
        {
            if (!car1.Name.Equals(car2.Name) || !car1.Price.Equals(car2.Price))
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Car car1, Car car2)
        {
            if (car1.Name.Equals(car2.Name) || car1.Price.Equals(car2.Price))
            {
                return false;
            }
            return true;
        }
        public static implicit operator double(Car car)
        {
            return (double)car.Price / 2.0;
        }
        public static explicit operator int(Car car)
        {
            return car.Price;
        }
        public static bool operator >=(Car car1, Car car2)
        {
            if (car1.Price >= car2.Price)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(Car car1, Car car2)
        {
            if (car1.Price <= car2.Price)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Car car1, Car car2)
        {
            if (car1.Price < car2.Price)
            {
                return false;
            }
            return true;
        }
        public static bool operator <(Car car1, Car car2)
        {
            if (car1.Price > car2.Price)
            {
                return false;
            }
            return true;
        }
        public static Car operator +(Car car1, Car car2)
        {
            return new Car()
            {
                Name = car1.Name + " & " + car2.Name,
                Price = car1.Price + car2.Price
            };
        }
        #endregion

        public Car()
        {

        }

        public Car(string name)
        {
            Name = name;
            Name = "BMW";
        }
    }

}
