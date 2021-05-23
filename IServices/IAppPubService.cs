using StreamWebPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamWebPage.IServices
{
    public interface IAppPubService
    {
        IEnumerable<AppPub> GetApp();

        AppPub GetAppById(int id);

        AppPub AddApp(AppPub app);

        AppPub UpdateApp(AppPub app);

        AppPub DeleteApp(int id);
    }
}