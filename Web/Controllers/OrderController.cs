using BrainWare.Data.Library.Interfaces;
using BrainWare.Data.Library.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService orderService;
        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }      
        
        public JsonResult Index()
        {
            var orders = orderService.GetOrdersForCompany(1).ToList();
            return Json(orders, JsonRequestBehavior.AllowGet);
        }
    }
}