﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Learning.Models
{
    /// <summary>
    /// 
    /// </summary>
    //[XmlRoot]
    public class xml
    {
        //[XmlAttribute]
        public string return_code { get; set; }
        public string return_msg { get; set; }
        public string appid { get; set; }
        public string mch_id { get; set; }
        public string nonce_str { get; set; }
        public string sign { get; set; }
        public string result_code { get; set; }
        public string prepay_id { get; set; }
        public string trade_type { get; set; }
    }
}
