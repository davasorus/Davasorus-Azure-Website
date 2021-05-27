using StreamWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SQLWebAPIRepo : IWebAPIRepo
    {
        private readonly STREAMINGDBContext _context;

        public SQLWebAPIRepo(STREAMINGDBContext context)
        {
            _context = context;
        }

        public void CreatApp(AppPub App)
        {
            if (App == null)
            {
                throw new ArgumentNullException(nameof(App));
            }

            _context.AppPub.Add(App);
        }

        public void DeleteApp(AppPub App)
        {
            if (App == null)
            {
                throw new ArgumentNullException(nameof(App));
            }

            _context.AppPub.Remove(App);
        }

        public IEnumerable<AppPub> GetAllApps()
        {
            return _context.AppPub.ToList();
        }

        public AppPub GetAppPubByID(int id)
        {
            return _context.AppPub.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateApp(AppPub App)
        {
            //nothing
        }
    }
}