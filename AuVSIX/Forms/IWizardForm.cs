using AuVSIX.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuVSIX.Forms
{
    public interface IWizardForm
    {
        IWizardModel WizardModel { get; }
        TemplateItem SelectedTemplateItem { get; set; }

        void BindForm();
        void ParseForm();
        Dictionary<string, string> ProcessModel(Dictionary<string, string> replacementsDictionary);

        Process PerformInstallAndBuild(string path);
    }
}
