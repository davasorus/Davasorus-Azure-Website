using StreamWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class MockWebAPIRepo : IWebAPIRepo
    {
        public void CreatApp(AppPub App)
        {
            throw new NotImplementedException();
        }

        public void DeleteApp(AppPub App)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AppPub> GetAllApps()
        {
            var AppPub = new List<AppPub>
            {
                new AppPub { Id = 0, AppName = "test", AppVersion = "1" },
                new AppPub { Id = 1, AppName = "test", AppVersion = "1" },
                new AppPub { Id = 2, AppName = "test", AppVersion = "1" }
            };
            return AppPub;
        }

        public AppPub GetAppPubByID(int id)
        {
            return new AppPub { Id = 0, AppName = "test", AppVersion = "1" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateApp(AppPub App)
        {
            throw new NotImplementedException();
        }
    }
}