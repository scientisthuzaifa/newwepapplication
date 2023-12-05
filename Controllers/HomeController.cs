using System.Web.Mvc;
using MyApp.Db.DbOperations;
using MyApp.Models;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        EmployeeRepository repository = new EmployeeRepository();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel model)
        {

           
            {
                int id = repository.AddEmployee(model);
                if (id == 0)
                {
                    ModelState.Clear();
                    ViewBag.Issuccess = "DataADDED";
                }
            }
            return View();
        }
    }
}
