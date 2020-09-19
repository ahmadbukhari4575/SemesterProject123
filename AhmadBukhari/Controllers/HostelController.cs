using AhmadBukhari.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AhmadBukhari.Controllers
{
    public class HostelController : Controller
    {
        

            private Contxt db = null;

            public HostelController()
            {
                db = new Contxt();
            }

            public ActionResult Index(string search)
            {
                if (search != null)
                {
                    return View(db.Hostels.Where(x => x.Name.StartsWith(search)).ToList());
                }
                else
                {
                    return View(db.Hostels.ToList());
                }
            }

            public ActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Create(Hostel h)
            {
                if (ModelState.IsValid)
                {
                    db.Hostels.Add(h);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Hostel");
                }
                return View();
            }

            public ActionResult Edit(int id)
            {
                if (id > 0)
                {
                    return View(db.Hostels.Find(id));
                }

                return View();
            }

            [HttpPost]
            public ActionResult Edit(Hostel h)
            {
                if (ModelState.IsValid)
                {
                    db.Entry(h).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index","Hostel");
                }

                return View();
            }

            public ActionResult Delete(int id)
            {
                if (id > 0)
                {
                    var data = db.Hostels.Find(id);
                    if (data != null)
                    {
                        db.Hostels.Remove(data);
                        db.SaveChanges();
                        return RedirectToAction("Index", "Hostel");
                    }
                }

                return View();
            }


            public ActionResult Details(int id)
            {
                var data = db.Hostels.Find(id);
                return View(data);
            }
        }
    }
