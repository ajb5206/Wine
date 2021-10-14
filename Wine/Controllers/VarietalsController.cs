using Microsoft.AspNetCore.Mvc;
using Wine.Models;
using System.Collections.Generic;
using System.Linq;

namespace Wine.Controllers
{
	public class VarietalsController : Controller
	{
		private readonly WineContext _db;

		public VarietalsController(WineContext db)
		{
			_db = db;
		}

		public ActionResult Index()
		{
			List<Varietal> model = _db.Varietals.ToList();
			return View(model);
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(Varietal varietal)
		{
			_db.Varietals.Add(varietal);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}