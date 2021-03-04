using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StreamWebPage.Pages
{
    [Authorize]
    public class StreamingDBUpdateModel : PageModel
    {
        public class Student
        {
            public string GameName { get; set; }
            public string GameTypeName { get; set; }
            public string GameTypeID { get; set; }
            public string Class { get; set; }
        }

        public void OnGet()
        {
            if (HttpContext.User.Identity.GetUserName() == "admin@admin.com")
            {
            }
            else
            {
                Response.Redirect("https://streamwebpage.azurewebsites.net/NotFound");
            }
        }
    }
}