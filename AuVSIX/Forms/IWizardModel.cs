using AuVSIX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuVSIX.Forms
{
    public interface IWizardModel
    {
        bool InstallAfter { get; set; }
        bool BuildAfter { get; set; }

        string InstallAfterCommand { get; set; }
        string BuildAfterCommand { get; set; }

    }
}
