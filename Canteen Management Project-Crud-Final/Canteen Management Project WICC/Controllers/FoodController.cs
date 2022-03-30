using Canteen.Model;
using Canteen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Canteen_Management.WebUI.Controllers
{
    
    public class FoodController : Controller
    {
        private readonly IfoodRepo _repo;
        public FoodController()
        {
            _repo = new FoodRepo();
        }
        // GET: Food
        public ActionResult Index()
        {
            return View(_repo.GetList());
        }

        // GET: Food/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetById(id));
        }

        // GET: Food/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Food/Create
        [HttpPost]
        public ActionResult Create(Food data)
        {
            try
            {
                data.UserId = 1;
                _repo.Add(data);
                 //tmro database ma kun chai user id store bhairaxa// khali nai xa kei data xaina user ko ni garum testo bhaye
                 return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Food/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetById(id));
        }


      


        // POST: Food/Edit/5
        [HttpPost]
        public ActionResult Edit(Food data)
        {
            try
            {

                _repo.Update(data);
              return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

     //   GET: Food/Delete/5
        //public ActionResult Delete(int Id)
        //{
            
        //        return View(_repo.GetById(Id));

           
            
                
            
        //}

        //POST: Food/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            try
            {
                _repo.Delete(Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
