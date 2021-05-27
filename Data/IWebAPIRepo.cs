using StreamWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IWebAPIRepo
    {
        bool SaveChanges();

        IEnumerable<AppPub> GetAllApps();

        AppPub GetAppPubByID(int id);

        void CreatApp(AppPub App);

        void UpdateApp(AppPub App);

        void DeleteApp(AppPub App);
    }
}