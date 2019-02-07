using AuVSIX.Data;
using AuVSIX.Forms;
using AuVSIX.Models;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AuVSIX
{
    public class TemplateWizard : IWizard
    {
        DTE dte;
        TemplateItem selectedTemplate;
        IWizardForm inputForm;
        IWizardModel model;
        string installationPath;

        public void BeforeOpeningFile(ProjectItem projectItem)
        {

        }

        public void ProjectFinishedGenerating(Project project)
        {
            inputForm.PerformInstallAndBuild(installationPath);
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {

        }

        // This is called after the project is created. 
        public void RunFinished()
        {
            Debug.WriteLine("All done! Enjoy Aurelia!");
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            dte = automationObject as DTE;
            installationPath = replacementsDictionary["$destinationdirectory$"];

            InitTemplateUI(customParams);

            if (((Form)inputForm).DialogResult == DialogResult.OK)
            {
                inputForm.ParseForm();
                model = inputForm.WizardModel;

                replacementsDictionary = inputForm.ProcessModel(replacementsDictionary);
            }
            else if (((Form)inputForm).DialogResult == DialogResult.Cancel)
            {
                CancelTemplate(replacementsDictionary);
                return;
            }
            else if (((Form)inputForm).DialogResult == DialogResult.Retry)
            {
                CancelTemplate(replacementsDictionary);
                return;
            }
        }

        private static void CancelTemplate(Dictionary<string, string> replacementsDictionary)
        {
            CleanupDirectories(replacementsDictionary);
            throw new WizardCancelledException();
        }

        private static void GoBackToTemplateSelection(Dictionary<string, string> replacementsDictionary)
        {
            CleanupDirectories(replacementsDictionary);
            throw new WizardBackoutException();
        }

        void InitTemplateUI(object[] customParams)
        {
            selectedTemplate = IdentifyTemplateType(customParams);

            // Display a form to the user to gather their project requirements
            if (selectedTemplate.VSTemplateFileName == "AuMVCTSWP.vstemplate")
            {
                inputForm = new AuVSTemplateForm();
                inputForm.SelectedTemplateItem = selectedTemplate;
                inputForm.BindForm();
                ((Form)inputForm).ShowDialog();
            }

            if (selectedTemplate.VSTemplateFileName == "AuMVCBLWP.vstemplate")
            {
                inputForm = new AuVSTemplateForm();
                inputForm.SelectedTemplateItem = selectedTemplate;
                inputForm.BindForm();
                ((Form)inputForm).ShowDialog();
            }
        }

        TemplateItem IdentifyTemplateType(object[] customParams)
        {
            // customParams[0] contains the physical location of the template to be applied
            var t = customParams[0].ToString();

            var templateItem = TemplateData.AllTemplates
                .Where(x => t.EndsWith(x.VSTemplateFileName))
                .SingleOrDefault();

            return templateItem;
        }

        private static void CleanupDirectories(Dictionary<string, string> replacementsDictionary)
        {
            // the user has cancelled so clean up the folders that are otherwise left behind
            var dir = replacementsDictionary["$solutiondirectory$"];

            if (Directory.Exists(dir))
                Directory.Delete(dir, true);
        }

        // This is only called for item templates,  
        // not for project templates.
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }

}
