using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StreamWebPage.IServices;
using StreamWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamWebPage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppPubController : ControllerBase
    {
        private readonly IAppPubService AppPubService;

        public AppPubController(IAppPubService AppPub)
        {
            AppPubService = AppPub;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployee")]
        public IEnumerable<AppPub> GetApp()
        {
            return AppPubService.GetApp();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/AddEmployee")]
        public AppPub AddEmployee(AppPub AP)
        {
            return AppPubService.AddApp(AP);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Employee/EditEmployee")]
        public AppPub EditEmployee(AppPub AP)
        {
            return AppPubService.UpdateApp(AP);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Employee/DeleteEmployee")]
        public AppPub DeleteApp(int id)
        {
            return AppPubService.DeleteApp(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployeeId")]
        public AppPub GetEmployeeId(int id)
        {
            return AppPubService.GetAppById(id);
        }
    }
}