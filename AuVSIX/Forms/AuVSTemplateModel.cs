using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuVSIX.Models;

namespace AuVSIX.Forms
{
    public class AuVSTemplateModel : IWizardModel
    {
        public bool Create { get; set; }
        public string AureliaProjectName { get; set; }

        public ModuleLoaderTypes ModuleLoader { get; set; }
        public HttpTypes HttpType { get; set; }
        public PlatformTypes PlatformType { get; set; }
        public TranspilerTypes Transpiler { get; set; }
        public MinificationLevel Minification { get; set; }
        public CSSProcessorTypes CSSProcessing { get; set; }
        public UnitTestRunnerTypes UnitTestRunner { get; set; }
        public IntegrationTestingTypes IntegrationTesting { get; set; }

        public bool InstallAfter { get; set; }
        public bool BuildAfter { get; set; }

        public string InstallAfterCommand { get; set; }
        public string BuildAfterCommand { get; set; }

        public Dictionary<string, string> ToReplacementDictionary(Dictionary<string, string> dct)
        {
            dct.Add("$aurelia_project_name$", AureliaProjectName);
            dct.Add("$aurelia_module_loader$", ModuleLoader.ToString());
            dct.Add("$aurelia_http_type$", HttpType.ToString());
            dct.Add("$aurelia_transpiler$", Transpiler.ToString());
            dct.Add("$aurelia_minification$", Minification.ToString());
            dct.Add("$aurelia_css_processing$", CSSProcessing.ToString());
            dct.Add("$aurelia_unit_ruinner$", UnitTestRunner.ToString());
            dct.Add("$aurelia_integration_testing$", IntegrationTesting.ToString());
            dct.Add("$aurelia_install_after$", InstallAfter.ToString());
            dct.Add("$aurelia_build_after$", BuildAfter.ToString());

            return dct;
        }
    }

    public enum ModuleLoaderTypes
    {
        Webpack = 0,
        RequireJS = 1,
        Alameda = 2,
        SystemJS = 3
    }

    public enum HttpTypes
    {
        Http1_1 = 0,
        Http2 = 1
    }

    public enum PlatformTypes
    {
        Web = 0,
        ASP_NET_CORE = 1
    }

    public enum TranspilerTypes
    {
        Babel = 0,
        TypeScript = 1
    }

    public enum MinificationLevel
    {
        None = 0,
        Minimum = 1,
        Maximum = 2
    }

    public enum CSSProcessorTypes
    {
        None = 0,
        Less = 1,
        Sass = 2,
        Stylus = 3,
        PostCSS = 4
    }

    public enum UnitTestRunnerTypes
    {
        None = 0,
        Karma = 1,
        Jest = 2
    }

    public enum IntegrationTestingTypes
    {
        None = 0,
        Protractor = 1
    }
}
