using AuVSIX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuVSIX.Data
{
    public static class TemplateData
    {
        public static List<TemplateItem> AllTemplates { get; set; }

        static TemplateData()
        {
            AllTemplates = new List<TemplateItem>();
            AllTemplates.Add(new TemplateItem { Name = "CLI Project with MVC *", Description = "Aurelia CLI project with Webpack, Babel and ASP.NET Core 2.2 MVC", VSTemplateFileName = "AuMVCBLWP.vstemplate" });
            AllTemplates.Add(new TemplateItem { Name = "CLI Project with MVC *", Description = "Aurelia CLI project with Webpack, Typescript and ASP.NET Core 2.2 MVC", VSTemplateFileName= "AuMVCTSWP.vstemplate" });
        }

    }
}
