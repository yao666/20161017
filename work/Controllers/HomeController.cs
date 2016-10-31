using News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace work.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult yao(int page=10)
        {
            string[] data = new string[] {  "(2016-10-19) 广西日报头版：桂林电子科技大学为广西捧回金杯 ",
                                            "(2016-10-18)机电工程系举办拔河比赛",
                                            "(2016-10-17）院学生会开展第一次干部培训大会",
                                            "(2016-10-17) 金奖背后的支撑体系：“两融合，三坚持”创新创业培养模式 ",
                                            "(2016-10-17) 广州时代地产营销学院执行院长胡可德讲座通知 " };

            ViewBag.data = data;
            ViewBag.Page = page;
   
            return View();
        }
        public ActionResult Add()
        {
           

            return View();
        }
        public ActionResult Save(string title,string content)
        {
            ViewBag.TTitle = title;
            ViewBag.Content = content;
            return View();
        }
        public ActionResult Show(int id)
        {
            var db = new BlogDatabase();
            var article = db.BlogArticles.First(o => o.Id == id);

            ViewData.Model = article;
            return View();
        }

    }
}