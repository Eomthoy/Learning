using System;

namespace NetCoreApp.Controllers
{
    public class BaseDistrict
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CoordMuster { get; set; }
        public Nullable<bool> IsProductPlace { get; set; }
        public string PinYin { get; set; }
        /// <summary>
        /// 是否审核通过
        /// </summary>
        public bool? IsFReviewed { get; set; }
        public DateTime? TspCreateDate { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude { get; set; }
        /// <summary>
        /// 维度
        /// </summary>
        public string Latitude { get; set; }
    }
}