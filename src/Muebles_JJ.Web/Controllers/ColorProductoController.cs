using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Muebles_JJ.Core.Domain;
using Muebles_JJ.Core;
using Muebles_JJ.Infrastructure.Data;

namespace Muebles_JJ.Web.Controllers
{
    public class ColorProductoController : Controller
    {

        private readonly STAR_JJDbContext _context;

        public ColorProductoController(STAR_JJDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var listado = new Prueba().ConsultarProducto();
            return View(listado);
        }

        /// <summary>
        /// Metodo GET para crear
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }
    }
}
