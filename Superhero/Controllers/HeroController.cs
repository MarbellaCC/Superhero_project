using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Superhero.Data;
using Superhero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Superhero.Controllers
{
    public class HeroController : Controller
    {

        private readonly ApplicationDbContext _context;
        public HeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: HeroController
        public ActionResult Index()
        {
            var heroes = _context.Superheroes;
            return View(heroes);
        }

        // GET: HeroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HeroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hero hero)
        {
            try
            {
                _context.Superheroes.Add(hero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroController/Edit/5
        public ActionResult Edit(int id)
        {
            var hero = _context.Superheroes.Where(h => h.Id == id).FirstOrDefault();
            return View(hero);
        }

        // POST: HeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Hero superhero, IFormCollection collection)
        {
            try
            {
                var hero = _context.Superheroes.Where(h => h.Id == superhero.Id).FirstOrDefault();
                _context.Superheroes.Remove(hero);
                _context.Superheroes.Add(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroController/Delete/5
        public ActionResult Delete(int id)
        {
            var hero = _context.Superheroes.Where(h => h.Id == id).FirstOrDefault();
            return View(hero);
        }

        // POST: HeroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var hero = _context.Superheroes.Where(h => h.Id == id).FirstOrDefault();
                _context.Superheroes.Remove(hero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
