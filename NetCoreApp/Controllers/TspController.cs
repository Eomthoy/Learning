using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreApp.Controllers
{
    //[Produces("application/json")]
    //[Route("api/Tsp")]
    public class TspController : Controller
    {

        #region 题目一  根据企业类型查询企业列表
        /***********************************题目要求***********************************
        1. 传入企业类型，获取所有该类型的企业，返回企业列表。
        ********************************题目资料**************************        
        1. 企业类为 BaseEnterprise  (提示: 可按F12转到BaseEnterprise的定义或右键转到定义)
        2. 方法传入参数为 type (企业类型)
        3. 使用EntityFramework查询的，PatientModel对应的Entity为tbPatient
        4. 使用sql查询的，调用 DataTable SqlDbHelper.ExecuteDataTable(string sql)方法进行查询
        5. 涉及表如下：
         *  企业表（[TSP].[dbo].[Base_Enterprise]）
        6. 自测时，type可传入参数“plant”
         ** ******************************/
        /// <summary>
        /// 根据企业类型查询企业列表
        /// </summary>
        /// <param name="type">企业类型</param>
        /// <returns>企业列表</returns>
        public List<BaseEnterprise> GetBaseEnterprisesByType(string type)
        {
            List<BaseEnterprise> result = new List<BaseEnterprise>();
            string sql = string.Empty;  // 声明 sql变量，sql: 获取企业信息的sql语句
            /******请在下面完善代码******/


            /******  代码完善区 End    ******/
            DataTable table = SqlHelper.ExecuteDataTable(sql, CommandType.Text);     // 从数据库获取企业信息，存入DataTable中
            /******请在下面完善代码******/


            /******  代码完善区 End    ******/
            return result;
        }
        #endregion

        #region 题目二 根据省份编码查询地区树状列表
        /***********************************题目要求***********************************
        1. 传入省份编码，获取该省份所有的地区信息，返回地区树状列表。
        2. 提示：
            *a.可按F12转到TreeNode<T>的定义或右键转到定义
            *b.模糊查询
        ********************************题目资料**************************        
        1. 地区类 BaseDistrict  (提示: 可按F12转到BaseDistrict的定义或右键转到定义)
        2. 方法传入参数为 code (地区编码)
        3. 返回树状结构分为三层：省（地区编码长度为6）/市县（地区编码长度为6）/乡镇、街道（地区编码长度大于6）
        4. 同一省份地区编码（Code字段）前两位字符相同，例如：四川省（510000），成都市（510100），锦江区（510104）
        5. 同一市县地区编码（Code字段）前六位字符相同，例如：锦江区（510104），督院街街道（510104020），春熙路街道（510104022）
        6. 使用sql查询的，调用 DataTable SqlDbHelper.ExecuteDataTable(string sql)方法进行查询
        7.  SQL方法： 
                * 执行sql语句，返回DataTable,   方法： DataTable SqlDbHelper.ExecuteDataTable(string sql)
                * 执行sql语句，返回第一行第一列数据，方法 ：object SqlDbHelper.ExecuteScalar(string sql)
                * 执行sql语句，执行增删改，返回受影响的行数，方法 ： int SqlDbHelper.ExecuteSql(string sql)
        8. 涉及表如下：
         *  地区表（[TSP].[dbo].[Base_District]）
        9. 自测时，code可传入参数“510000”
         ********************************/
        /// <summary>
        /// 根据省份编码查询地区列表
        /// </summary>
        /// <param name="code">地区编码</param>
        /// <returns>地区列表</returns>
        [HttpPost]
        [Route("api/Tsp/GetBaseDistrictsByCode")]
        public TreeNode<BaseDistrict> GetBaseDistrictsByCode(string code)
        {
            TreeNode<BaseDistrict> result = new TreeNode<BaseDistrict>();
            string sql = string.Empty;
            /******请在下面完善代码******/
            sql = $"select * from [TSP].[dbo].[Base_District] where Code like '{code.Substring(0, 2)}%'";
            DataTable dt = SqlHelper.ExecuteDataTable(sql, CommandType.Text);
            List<BaseDistrict> list = new List<BaseDistrict>();
            foreach (DataRow data in dt.Rows)
            {
                list.Add(DatatableToEntity<BaseDistrict>(data));
            }

            result.Node = list.SingleOrDefault(x => x.Code == code);
            result.Children = new List<TreeNode<BaseDistrict>>();
            foreach (var city in list.Where(x => x.Code.Length == 6 && x.Code != code))
            {
                List<BaseDistrict> baseDistricts = list.Where(x => x.Code.Length > 6 && x.Code.StartsWith(city.Code)).ToList();
                List<TreeNode<BaseDistrict>> children = new List<TreeNode<BaseDistrict>>();
                foreach (var item in baseDistricts)
                {
                    children.Add(new TreeNode<BaseDistrict>()
                    {
                        Node = item,
                        Children = new List<TreeNode<BaseDistrict>>()
                    });
                }
                result.Children.Add(new TreeNode<BaseDistrict>()
                {
                    Node = city,
                    Children = children
                });
            }
            /******  代码完善区 End    ******/
            return result;
        }

        /// <summary>
        /// 树结构
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class TreeNode<T>
        {
            /// <summary>
            /// 当前节点
            /// </summary>
            public T Node { get; set; }
            /// <summary>
            /// 子节点
            /// </summary>
            public List<TreeNode<T>> Children { get; set; }
        }
        #endregion

        #region 题目三 获取种子种苗环节采收总产量
        /***********************************题目要求***********************************
        1. 种子种苗-采收管理环节，获取采收环节所有产量，返回总产量。
        ********************************题目资料**************************        
        1. 采收类 PlantHarvest  (提示: 可按F12转到PlantHarvest的定义或右键转到定义)
        2. 采收产量字段：RealHarvest
        3. 使用sql查询的，调用 DataTable SqlDbHelper.ExecuteDataTable(string sql)方法进行查询
        4.  SQL方法： 
                * 执行sql语句，返回DataTable,   方法： DataTable SqlDbHelper.ExecuteDataTable(string sql)
                * 执行sql语句，返回第一行第一列数据，方法 ：object SqlDbHelper.ExecuteScalar(string sql)
                * 执行sql语句，执行增删改，返回受影响的行数，方法 ： int SqlDbHelper.ExecuteSql(string sql)
        5. 涉及表如下：
         *  采收表（[TSP].[dbo].[Plant_Harvest]）
         ********************************/
        /// <summary>
        /// 获取种子种苗环节采收总产量
        /// </summary>
        /// <returns>采收总产量</returns>
        public decimal GetHarvest()
        {
            decimal result = 0M;
            /******请在下面完善代码******/



            /******  代码完善区 End    ******/
            return result;
        }

        #endregion

        #region 题目四 根据产品批号获取饮片生产-销售出库环节的企业名称
        /***********************************题目要求***********************************
        1. 饮片生产-销售出库环节，传入产品批号，获取该条数据所属企业的企业名称，返回企业名称。
        ********************************题目资料**************************        
        1. 销售出库类 PdtOutWarehouse  (提示: 可按F12转到PdtOutWarehouse的定义或右键转到定义)
        2. 方法传入参数为 batchNumber (产品批号)
        3. 产品批号字段：BatchNumber
        4. 使用sql查询的，调用 DataTable SqlDbHelper.ExecuteDataTable(string sql)方法进行查询
        5.  SQL方法： 
                * 执行sql语句，返回DataTable,   方法： DataTable SqlDbHelper.ExecuteDataTable(string sql)
                * 执行sql语句，返回第一行第一列数据，方法 ：object SqlDbHelper.ExecuteScalar(string sql)
                * 执行sql语句，执行增删改，返回受影响的行数，方法 ： int SqlDbHelper.ExecuteSql(string sql)
        6. 涉及表如下：
         *  销售出库表（[TSP].[dbo].[Product_OutWarehouse]）
         *  企业表（[TSP].[dbo].[Base_Enterprise]）
        7. 自测时，batchNumber可传入参数“SA5121”
         ********************************/
        /// <summary>
        /// 根据产品批号获取饮片生产-销售出库环节的企业名称
        /// </summary>
        /// <param name="batchNumber">产品批号</param>
        /// <returns>企业名称</returns>
        public string GetEnterpriseNameByBatchNumber(string batchNumber)
        {
            PdtOutWarehouse pdtOutWarehouse = new PdtOutWarehouse();
            string result = string.Empty;
            /******请在下面完善代码******/


            /******  代码完善区 End    ******/
            return result;
        }

        #endregion

        #region 题目五 根据企业Id获取药材种植环节农户档案分页数据
        /***********************************题目要求***********************************
        1. 药材种植-农户档案环节，传入企业Id、pageSize、pageNumber，获取指定企业所有农户信息，并按照面积降序排序，返回农户分页数据。
        2. 提示：
            *a.可按F12转到PagedResult<T>的定义或右键转到定义，Total为数据总条数，Rows为数据储存字段
            *b.可使用Linq进行分页数据组装
        ********************************题目资料**************************        
        1. 地区类 PlantFarmer  (提示: 可按F12转到PlantFarmer的定义或右键转到定义)
        2. 方法传入参数为 enterpriseId (企业Id)、pageNumber(页码)、pageSize(页大小)
        3. 企业Id字段：EnterpriseId
        4. 使用sql查询的，调用 DataTable SqlDbHelper.ExecuteDataTable(string sql)方法进行查询
        5.  SQL方法： 
                * 执行sql语句，返回DataTable,   方法： DataTable SqlDbHelper.ExecuteDataTable(string sql)
                * 执行sql语句，返回第一行第一列数据，方法 ：object SqlDbHelper.ExecuteScalar(string sql)
                * 执行sql语句，执行增删改，返回受影响的行数，方法 ： int SqlDbHelper.ExecuteSql(string sql)
        6. 涉及表如下：
         *  农户档案表（[TSP].[dbo].[Plant_Farmer]）
        7. 自测时，可传入参数enterpriseId = 6，pageNumber = 2，pageSize = 10
         ********************************/
        /// <summary>
        /// 根据企业Id获取药材种植环节农户档案分页数据
        /// </summary>
        /// <param name="enterpriseId">企业Id</param>
        /// <param name="pageNumber">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <returns>农户分页数据</returns>
        public PagedResult<PlantFarmer> GetPlantFarmerPagedResult(int enterpriseId, int pageNumber, int pageSize)
        {
            PagedResult<PlantFarmer> result = new PagedResult<PlantFarmer>();
            /******请在下面完善代码******/


            /******  代码完善区 End    ******/
            return result;
        }

        #endregion

        private T DatatableToEntity<T>(DataRow data) where T : new()
        {
            T model = new T();
            foreach (var propertyInfo in typeof(T).GetProperties())
            {
                string propName = propertyInfo.Name;
                object val = data[propName];
                if (val != DBNull.Value && val != null)
                {
                    propertyInfo.SetValue(model, val, null);
                }
            }
            return model;
        }
    }
}