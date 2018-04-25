using System.Collections.Generic;
using System.Web.Http;
using TomsAPI.Models;

namespace TomsAPI.Controllers
{
    public class OrderController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "Order", "NotFound" };
        }

        public IHttpActionResult Get(int id)
        {
            MenuModel m = new MenuModel(id);
            return Json(m.menuItm);
        }
    }
}