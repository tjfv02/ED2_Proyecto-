using DiseñoChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiseñoChat.Controllers
{
    public class ChatController : Controller
    {
        public static List<Usuario> IngresoUsuario = new List<Usuario>();
        public static List<Contacto> InfoContactos = new List<Contacto>();


        
        // GET: Chat
        public ActionResult Index()
        {
            return View();
        }

        //LOGIN
        // GET: Chat/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Chat/Create
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            try
            {

                Usuario IngresoUser = new Usuario()
                {
                    User = collection["User"],
                    Contraseña = collection["Contraseña"],

                };

                IngresoUsuario.Add(IngresoUser);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // Lista de contactos 
        //GET 
        public ActionResult ListaContactos()
        {
            return View(InfoContactos);//Mostrar lista de contactos de un usuario
        }

        // CHAT
        public ActionResult Chat()
        {
            return View();
        }












        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Chat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chat/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Chat/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
