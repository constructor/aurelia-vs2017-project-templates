using AuVSIX.Models;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuVSIX.Forms
{
    public partial class AuVSTemplateForm : Form, IWizardForm
    {
        public AuVSTemplateModel Model { get; set; }
        public IWizardModel WizardModel { get { return Model; } }

        public TemplateItem SelectedTemplateItem { get; set; }

        public AuVSTemplateForm()
        {
            Model = new AuVSTemplateModel();
            InitializeComponent();

            logoImage.SizeMode = PictureBoxSizeMode.StretchImage;

            CancelButton = btnCancel;
            AcceptButton = btnOk;
        }

        public void BindForm()
        {
            lblTemplateName.Text = SelectedTemplateItem.Name;
            lblTemplateDescription.Text = SelectedTemplateItem.Description;

            cobMarkupProcessing.DataSource = Enum.GetValues(typeof(MinificationLevel));
            cobMarkupProcessing.SelectedIndex = 0;

            cobCSSProcessing.DataSource = Enum.GetValues(typeof(CSSProcessorTypes));
            cobCSSProcessing.SelectedIndex = 0;

            cobUntiTesting.DataSource = Enum.GetValues(typeof(UnitTestRunnerTypes));
            cobUntiTesting.SelectedIndex = 0;

            cobCSSProcessing.DataSource = Enum.GetValues(typeof(CSSProcessorTypes));
            cobCSSProcessing.SelectedIndex = 0;

            cobIntegrationTesting.DataSource = Enum.GetValues(typeof(IntegrationTestingTypes));
            cobIntegrationTesting.SelectedIndex = 0;
        }

        public void ParseForm()
        {
            Model.AureliaProjectName = tbAureliaProjectName.Text;

            Model.HttpType = rbHTTP1_1.Checked ? HttpTypes.Http1_1 : HttpTypes.Http2;

            MinificationLevel val1;
            Enum.TryParse(cobMarkupProcessing.SelectedValue.ToString(), out val1);
            Model.Minification = val1;

            CSSProcessorTypes val2;
            Enum.TryParse(cobCSSProcessing.SelectedValue.ToString(), out val2);
            Model.CSSProcessing = val2;

            UnitTestRunnerTypes val3;
            Enum.TryParse(cobUntiTesting.SelectedValue.ToString(), out val3);
            Model.UnitTestRunner = val3;

            CSSProcessorTypes val4;
            Enum.TryParse(cobCSSProcessing.SelectedValue.ToString(), out val4);
            Model.CSSProcessing = val4;

            IntegrationTestingTypes val5;
            Enum.TryParse(cobIntegrationTesting.SelectedValue.ToString(), out val5);
            Model.IntegrationTesting = val5;



            Model.InstallAfter = cbInstallAfter.Checked;
            Model.BuildAfter = cbBuildAfter.Checked;
        }

        public IWizardModel GetModel()
        {
            return Model;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Model.Create = false;
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Model.Create = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Model.Create = false;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cbBuildAfter_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                cbInstallAfter.Checked = true;
        }

        public Dictionary<string, string> ProcessModel(Dictionary<string, string> replacementsDictionary)
        {
            // Add custom parameters
            replacementsDictionary = Model.ToReplacementDictionary(replacementsDictionary);

            return replacementsDictionary;
        }

        public Process PerformInstallAndBuild(string path)
        {
            if (!Model.InstallAfter)
                return null;

            Process p = new Process();

            try
            {
                var dp = Path.GetPathRoot(path);
                var di = new DriveInfo(dp);
                var driveCMD = di.Name.Replace("\\", "");

                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = "cmd.exe";
                info.RedirectStandardInput = true;
                info.UseShellExecute = false;

                p.StartInfo = info;
                p.Start();

                using (StreamWriter sw = p.StandardInput)
                {
                    if (sw.BaseStream.CanWrite)
                    {
                        sw.WriteLine($"cd {path}");
                        sw.WriteLine($"{driveCMD}");
                        sw.WriteLine("yarn install");

                        if (Model.BuildAfter)
                        {
                            sw.WriteLine("au build");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                var exx = ex;
            }

            return p;
        }


    }

}
