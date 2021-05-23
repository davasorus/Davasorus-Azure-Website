using Microsoft.EntityFrameworkCore;
using StreamWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamWebPage.Services
{
    public class AppPubService
    {
        private StreamingDBContext dbContext;

        public AppPubService(StreamingDBContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<AppPub> GetApp()
        {
            var App = dbContext.AppPub.ToList();
            return App;
        }

        public AppPub AddApp(AppPub App)
        {
            if (App != null)
            {
                dbContext.AppPub.Add(App);
                dbContext.SaveChanges();
                return App;
            }
            return null;
        }

        public AppPub UpdateApp(AppPub App)
        {
            dbContext.Entry(App).State = EntityState.Modified;
            dbContext.SaveChanges();
            return App;
        }

        public AppPub DeleteApp(int id)
        {
            var App = dbContext.AppPub.FirstOrDefault(x => x.Id == id);
            dbContext.Entry(App).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return App;
        }

        public AppPub GetAppPubById(int id)
        {
            var App = dbContext.AppPub.FirstOrDefault(x => x.Id == id);
            return App;
        }
    }
}