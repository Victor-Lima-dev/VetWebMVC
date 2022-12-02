﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VetWeb;
using VetWebMVC.Context;
using VetWebMVC.Services;

namespace VetWebMVC.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalServices _animalServices;
        private readonly AppDbContext _context;
        

        public AnimalController(AnimalServices animalServices, AppDbContext context)
        {
            _animalServices = animalServices;
            _context = context;
        }

        public ActionResult Index()
        {
            var lista = _animalServices.ListaAnimais();
            //var listaParametros = _animalServices.ListaParametros();

            //foreach (var item in lista)
            //{
            //    //item.SetaParametros(item, 1, listaParametros);
            //}

            return View(lista);
        }

        // GET: AnimalController/Details/5
        public ActionResult Details(int id)
        {
                     

            return View();
        }

        // GET: AnimalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Animal animal)
        {
            try { 
            
               
                _animalServices.AdicionaAnimal(animal);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnimalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnimalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnimalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnimalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
