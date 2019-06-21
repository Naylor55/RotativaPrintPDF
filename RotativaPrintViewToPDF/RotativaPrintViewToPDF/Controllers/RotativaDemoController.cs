/********************************************************************
* Copyright (c) 2019 ALL Rights Reserved.
* CLR版本：4.0.30319.42000
* 机器名称：NAYLOR
* 公司名称：
* 命名空间：RotativaPrintViewToPDF.Controllers
* 文件名： RotativaDemoController
* 版本号： V1.0.0.0
* 唯一标识： fa05c0b0-99b7-4d7f-8b1f-518aa7811d42
* 当前的用户域： NAYLOR
* 创建人： Cnayl
* 电子邮箱： cnaylor@163.com
* 创建时间： 2019/6/21 18:03:38

* 描述：
*
* ==================================================================
* 修改标记
* 修改时间： 2019/6/21 18:03:38
* 修改人： Cnayl
* 版本号： 
* 描述：
*
*
********************************************************************/

using RotativaPrintViewToPDF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RotativaPrintViewToPDF.Controllers
{
    public class RotativaDemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 下载PDF
        /// </summary>
        /// <returns></returns>
        public ActionResult DownloadPDF()
        {
            string orderId = "555";
            return new Rotativa.RouteAsPdf("Pdf", new { orderId = orderId }) { FileName = "pdfFileName.pdf" };
        }

        /// <summary>
        /// PDF文件内容
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public ActionResult PdfTemplate(string orderId)
        {
            OrderModel order = new OrderModel() { orderId = orderId, orderAddress = "北京市", orderRemark = "备注一些信息" };
            return View(order);
        }
    }
}