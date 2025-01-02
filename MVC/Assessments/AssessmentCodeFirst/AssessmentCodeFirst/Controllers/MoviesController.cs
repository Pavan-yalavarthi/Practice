using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssessmentCodeFirst.Models;
using AssessmentCodeFirst.Repository;
namespace AssessmentCodeFirst.Controllers
{
    public class MoviesController : Controller
    {
        MovieRepository m = new MovieRepository(new MovieContext());

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                m.Insert(movie);
                m.Save();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            var movie = m.GetById(id);
            if (movie == null) return HttpNotFound();
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                m.Update(movie);
                m.Save();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public ActionResult Index()
        {
            var movies = m.GetAll();
            return View(movies);
        }
    }
}