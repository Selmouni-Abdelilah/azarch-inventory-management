using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inventory.Data;
using inventory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace inventory.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MenuContext _context;

        public IndexModel(ILogger<IndexModel> logger,MenuContext context)
        {
            _logger = logger;
            _context= context;
        }

        public void OnGet()
        {
            List<Menu> menus=null;
            
            ViewData["menus"] =menus;
            
            // UNCOMMENT AFTER SETTING THE CONNECTION STRING
            try  {
                menus=_context.Menus.ToList();
            }
            catch (Exception ex)  {
                ViewData["Error"]=ex.Message;
            }
            ViewData["menus"]=menus;

        }

        public IActionResult OnPostSaveInventory()  {
            var menuId=int.Parse(Request.Form["menuId"]);
            var quantity=int.Parse(Request.Form["menu.InStock"]);
            var menu=_context.Menus.Find(menuId);
            menu.InStock=quantity;
            _context.SaveChanges();           

            return RedirectToPage();
        }      
    }
}
