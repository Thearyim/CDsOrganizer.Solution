using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using CDsOrganizer.Models;
using CDs.Models;

namespace CDsOrganizer.Controllers
{
  public class CDsOrganizerController : Controller
  {
    [HttpGet("/cdsorganizer")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/cdsorganizer/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cdsorganizer")]
    public ActionResult Create(string title, string artist, string album)
    {
      TrackClass myTrack = new TrackClass(artist, album);
      CD myCD = new CD(title, myTrack);
      return View("Index", myCD);
    }
  }
}
