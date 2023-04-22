using DotNetCore5CRUD.Models;
using DotNetCore5CRUD.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// This project is used to show Movies.
/// We can apply CRUD operations on it.
/// It has two model classes(Movie,Genre).
/// It has Domain Model and View Model.
/// Genre model is fill out by database.
/// Used SQLServer.
/// </summary>
namespace DotNetCore5CRUD.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IToastNotification toastNotification;
        public MoviesController(ApplicationDbContext context, IToastNotification toastNotification)
        {
            this.context = context;
            this.toastNotification = toastNotification;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await context.Movies.OrderBy(m=>m.MovieID).ToListAsync();
            return View(movies);
        }
        
        public async Task<IActionResult> MovieForm()
        {
            var ViewModel = new MovieFormViewModel
            {
                Genres = await context.Genres.OrderBy(name => name.Name).ToListAsync()
            };

            //ViewBag.movelst = context.Movies;
            return View(ViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MovieForm(MovieFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                //send Genres for DropdownList of GenreID in MovieForm
                model.Genres = await context.Genres.OrderBy(name => name.Name).ToListAsync();
                return View("MovieForm", model);
            }
            //assign uploaded attatched files in var files
            var files = Request.Form.Files;
            //check if there file uploaded or not
            if (!files.Any())
            {
                model.Genres = await context.Genres.OrderBy(name => name.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Please select Movie Poster");
                return View("MovieForm", model);
            }
            var Poster = files.FirstOrDefault();
            //check extension of uploaded file
            var allowedExtenstions = new List<string> { ".jpg", ".png" };
            if (!allowedExtenstions.Contains(Path.GetExtension(Poster.FileName.ToLower())))
            {
                model.Genres = await context.Genres.OrderBy(name => name.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Only .jpg and .png images are allowed ");
                return View("MovieForm", model);
            }
            //check size of uploaded file
            if (Poster.Length > 1048576)//calculate length in byte..1048576 byte = 1 Mega
            {
                model.Genres = await context.Genres.OrderBy(name => name.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Poster can not be more 1 MB");
                return View("MovieForm", model);
            }
            //model.Poster = Poster;//error... can't contvert IFormFile to byte[]
            using var dataStream = new MemoryStream();//using feature in C#-8
            //convert IFormFile Poster to byte[] or Stream Poster
            await Poster.CopyToAsync(dataStream);
            //munual mapper
            var movies = new Movie
            {
                Title = model.Title,
                Year = model.Year,
                Rate = model.Rate,
                StoreLine = model.StoreLine,
                Poster = dataStream.ToArray(),
                GenreID = model.GenreID


            };
            context.Movies.Add(movies);
            context.SaveChanges();
            //add Toast Notification
            toastNotification.AddSuccessToastMessage("Movie Created Successfully");
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var movie = await context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            //manual mapper
            var ViewModel = new MovieFormViewModel
            {
                MovieID = movie.MovieID,
                GenreID = movie.GenreID,
                Title = movie.Title,
                Year = movie.Year,
                Rate = movie.Rate,
                StoreLine = movie.StoreLine,
                Poster = movie.Poster,
                Genres = await context.Genres.OrderBy(name => name.Name).ToListAsync()

            };
            return View("MovieForm", ViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MovieFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Genres = await context.Genres.OrderBy(name => name.Name).ToListAsync();
                return View("MovieForm", model);
            }
            var movie = await context.Movies.FindAsync(model.MovieID);
            if (movie == null)
            {
                return NotFound();
            }

            //mapper
            movie.GenreID = model.GenreID;
            movie.Title = model.Title;
            movie.Rate = model.Rate;
            movie.Year = model.Year;
            movie.StoreLine = model.StoreLine;
            //poster mapper
            var files = Request.Form.Files;
            if (files.Any())
            {
                var Poster = files.FirstOrDefault();
                using var dataStream = new MemoryStream();
                await Poster.CopyToAsync(dataStream);//convet poster form file to byte[]
                model.Poster= dataStream.ToArray();
                //check extension of uploaded file
                var allowedExtenstions = new List<string> { ".jpg", ".png" };
                if (!allowedExtenstions.Contains(Path.GetExtension(Poster.FileName.ToLower())))
                {
                    model.Genres = await context.Genres.OrderBy(name => name.Name).ToListAsync();
                    ModelState.AddModelError("Poster", "Only .jpg and .png images are allowed ");
                    return View("MovieForm", model);
                }
                //check size of uploaded file
                if (Poster.Length > 1048576)//calculate length in byte..1048576 byte = 1 Mega
                {
                    model.Genres = await context.Genres.OrderBy(name => name.Name).ToListAsync();
                    ModelState.AddModelError("Poster", "Poster can not be more 1 MB");
                    return View("MovieForm", model);
                }

                
                movie.Poster = dataStream.ToArray(); //mapper poster 
            }
            context.SaveChanges();
            toastNotification.AddSuccessToastMessage("Movie Updated Successfully");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var movie =await context.Movies.Include(m=>m.Genre).SingleOrDefaultAsync(m=>m.MovieID==id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var movie = await context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            context.Remove(movie);
            context.SaveChanges();
            return Ok();
        }

    }
}
