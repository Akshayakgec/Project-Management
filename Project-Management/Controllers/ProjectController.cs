﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Management.Models;

namespace Project_Management.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project

        //    [Authorize]
        public ActionResult Index()
        {
            Projects List = new Projects();
            ViewBag.Projects = List.ListProject((int)Session["UserId"]);
            
            return View();
        }

        [HttpGet]
        public ActionResult CreateNewProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewProject(Projects AddProject)
        {
            Projects ToAdd = new Projects();
            ToAdd.AddProject(AddProject,(int)Session["UserId"]);
            return RedirectToAction("AddMembers");
        }

        public ActionResult AddMembers()
        {

            return View();
        }
    }
}