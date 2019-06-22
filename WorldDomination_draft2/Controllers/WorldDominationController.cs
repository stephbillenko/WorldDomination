using WorldDomination_draft2.Models;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Web.Routing;
//using System.Windows.Forms;


namespace WorldDomination_draft2.Controllers
{
    public class WorldDominationController : Controller
    {
        // GET: WorldDomination
        public ActionResult CreatePlan()
        {
            Plan model = new Plan();
            
            return View(model);
        }

        [HttpPost]
        public ActionResult CreatePlan(Plan plan)
        {
           if(ModelState.IsValid)
            {
                //send to PleanDetails' view
                return RedirectToAction("MyPlanDetails", new { planId=plan.planId, name=plan.name, country= plan.country, date=plan.date,  method = plan.takeoverMethod });
            }
                return View();
            
        }

        

        public ActionResult MyPlanDetails(int planId, string name, string country, DateTime date, string method)
        {
            Plan model = new Plan(planId, name, country, date, method);

            return View(model);
        }


        public ActionResult ListPlans()
        {
            List<Plan> MyPlans = new List<Plan>();
            MyPlans.Add(new Plan(1, "My First Takeover", "Canada", Convert.ToDateTime("2019-01-01"), "polar bear army"));
            MyPlans.Add(new Plan(2, "To the South!", "USA", Convert.ToDateTime("2019-02-12"), "meteror shower"));
            MyPlans.Add(new Plan(3, "Le Mwahahaha!!", "France", Convert.ToDateTime("2019-05-02"), "cheese embargo"));
            MyPlans.Add(new Plan(4, "The stealth plan", "Russia", Convert.ToDateTime("2019-06-21"), "ant invasion"));

            ListOfPlans plans = new ListOfPlans();
            plans.plans = MyPlans;

            return View(plans);
        }
 


    }
}
