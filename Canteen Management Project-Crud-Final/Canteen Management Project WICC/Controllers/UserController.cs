using Canteen.Model;
using Canteen.Repository;
using Canteen.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Canteen_Management.WebUI.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserRepo _repo;
        public UserController ()
        {
            _repo = new UserRepo();
        }
        // GET: User
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                return View(_repo.GetList());
            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }

        // GET: User/Details/5
        public ActionResult DetailX(int id)
        {
            return View(_repo.GetById(id));
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User data )
        {
            try
            {

                _repo.Add(data);
                
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetById(id));
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(User data)
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

        // GET: User/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            try
            {
                _repo.GetById(Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            return View(); //page load hunna ai 2 tai get rw post chaixa
        }
        [HttpPost]
        public ActionResult Login(User entity )
        {
            try
            {
                // TODO: Add delete logic here
                var data=_repo.ValidateUser(entity.Email, entity.Password);


                if (data == true)
                {
                    Session["UserID"] = entity.Id.ToString();
                    Session["Email"] = entity.Email.ToString();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invallid User Name or Password";
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }
    }
}
