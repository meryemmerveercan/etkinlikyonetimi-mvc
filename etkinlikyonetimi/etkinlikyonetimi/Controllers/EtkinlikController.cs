using etkinlikyonetimi.Data;
using etkinlikyonetimi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Diagnostics;

namespace etkinlikyonetimi.Controllers
{
	public class EtkinlikController : Controller
	{
		private readonly etkinlikyonetimiDbContext _context;

		public EtkinlikController(etkinlikyonetimiDbContext context)
		{
			_context = context;
		}

		public IActionResult List()
		{
			var activities = _context.Etkinlik.ToList();
			return View(activities);
		}
		public IActionResult Create()
		{
			return View("Create", new Etkinlik());
		}

		[HttpPost]
		public IActionResult Create(Etkinlik etkinlik)
		{
			if (ModelState.IsValid)
			{
				_context.Etkinlik.Add(etkinlik);
				_context.SaveChanges();
				return RedirectToAction("List");
			}

			return View(etkinlik);
		}

		[HttpGet]
		public ViewResult Edit(int id)
		{
			Etkinlik etkinlik = _context.Etkinlik.Find(id)!;
			EtkinlikEditViewModel etkinlikEditViewModel = new EtkinlikEditViewModel
			{
				Id = etkinlik.Id,
				Baslik = etkinlik.Baslik,
				Yer = etkinlik.Yer,
				Zaman = etkinlik.Zaman,
				Aciklama = etkinlik.Aciklama,
				UcretTip = etkinlik.UcretTip,
				Ucret = etkinlik.Ucret
			};
			return View(etkinlikEditViewModel);
		}

		[HttpPost]
		public IActionResult Edit(EtkinlikEditViewModel model)
		{
			if (ModelState.IsValid)
			{
				Etkinlik record = _context.Etkinlik
										.Where(x => x.Id == model.Id)
										.SingleOrDefault()!;

				record.Baslik = model.Baslik;
				record.Yer = model.Yer;
				record.Zaman = model.Zaman;
				record.Aciklama = model.Aciklama;
				record.UcretTip = model.UcretTip;
				record.Ucret = model.Ucret;

				_context.Entry(record).State = EntityState.Modified;
				_context.SaveChanges();
				return RedirectToAction("List");
			}
			return View(model);
		}
	}
}

