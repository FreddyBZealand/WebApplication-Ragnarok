using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_Ragnarok.Pages
{


    public class Kim_LarsenModel : PageModel
    {
        private readonly ILogger<Kim_LarsenModel> _logger;

        public Kim_LarsenModel(ILogger<Kim_LarsenModel> logger)
        {
            _logger = logger;
        }


        public void OnGet()
        {

        }
    }
}
