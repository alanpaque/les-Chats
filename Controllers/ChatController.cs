using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LesChats.Models;

namespace LesChats.Controllers
{
    public class ChatController : Controller
    {

        private static List<Chat> ListeChats;
        public List<Chat> Chats => ListeChats ?? (ListeChats = Chat.GetMeuteDeChats());

        // GET: Chat
        public ActionResult Index()
        {

            return View(Chats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
            var chat = Chats.FirstOrDefault(c => c.Id == id);
            return View(chat);
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
            var chat = Chats.FirstOrDefault(c => c.Id == id);
            return View(chat);
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var chat = Chats.FirstOrDefault(c => c.Id == id);
                Chats.Remove(chat);

            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
