using AuVSIX.Forms;
using AuVSIX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuVSIX
{
    public abstract class TemplateModelBase
    {
        public TemplateItem TemplateItem { get; set; }

        public bool InstallAfter { get; set; }
        public bool BuildAfter { get; set; }

        public string InstallAfterCommand { get; set; }
        public string BuildAfterCommand { get; set; }
    }
}
