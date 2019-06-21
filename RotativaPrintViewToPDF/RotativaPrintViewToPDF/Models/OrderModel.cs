/********************************************************************
* Copyright (c) 2019 ALL Rights Reserved.
* CLR版本：4.0.30319.42000
* 机器名称：NAYLOR
* 公司名称：
* 命名空间：RotativaPrintViewToPDF.Models
* 文件名： OrderModel
* 版本号： V1.0.0.0
* 唯一标识： adde026e-096c-46b6-b5f4-9adb181481c7
* 当前的用户域： NAYLOR
* 创建人： Cnayl
* 电子邮箱： cnaylor@163.com
* 创建时间： 2019/6/21 18:18:59

* 描述：
*
* ==================================================================
* 修改标记
* 修改时间： 2019/6/21 18:18:59
* 修改人： Cnayl
* 版本号： 
* 描述：
*
*
********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RotativaPrintViewToPDF.Models
{
    public class OrderModel
    {
        public string orderId { get; set; }
        public string orderAddress { get; set; }
        public string orderRemark { get; set; }
    }
}