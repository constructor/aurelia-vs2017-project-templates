namespace AuVSIX.Forms
{
    partial class AuVSTemplateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.lblTemplateDescription = new System.Windows.Forms.Label();
            this.cbInstallAfter = new System.Windows.Forms.CheckBox();
            this.cbBuildAfter = new System.Windows.Forms.CheckBox();
            this.rbTypescript = new System.Windows.Forms.RadioButton();
            this.gbScriptOptions = new System.Windows.Forms.GroupBox();
            this.rbBabel = new System.Windows.Forms.RadioButton();
            this.gbProtocol = new System.Windows.Forms.GroupBox();
            this.rbHTTP2 = new System.Windows.Forms.RadioButton();
            this.rbHTTP1_1 = new System.Windows.Forms.RadioButton();
            this.cobMarkupProcessing = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cobCSSProcessing = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cobUntiTesting = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cobIntegrationTesting = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAureliaProjectName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTemplateName = new System.Windows.Forms.Label();
            this.templateItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wizardModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wizardModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.gbScriptOptions.SuspendLayout();
            this.gbProtocol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(544, 410);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 28);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(667, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // logoImage
            // 
            this.logoImage.BackgroundImage = global::AuVSIX.Properties.Resources.aurelia_logo;
            this.logoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoImage.InitialImage = null;
            this.logoImage.Location = new System.Drawing.Point(12, 21);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(278, 80);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImage.TabIndex = 0;
            this.logoImage.TabStop = false;
            // 
            // lblTemplateDescription
            // 
            this.lblTemplateDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemplateDescription.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTemplateDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTemplateDescription.Location = new System.Drawing.Point(311, 57);
            this.lblTemplateDescription.Name = "lblTemplateDescription";
            this.lblTemplateDescription.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.lblTemplateDescription.Size = new System.Drawing.Size(477, 53);
            this.lblTemplateDescription.TabIndex = 4;
            this.lblTemplateDescription.Text = "Template description text...";
            // 
            // cbInstallAfter
            // 
            this.cbInstallAfter.AutoSize = true;
            this.cbInstallAfter.Location = new System.Drawing.Point(320, 340);
            this.cbInstallAfter.Name = "cbInstallAfter";
            this.cbInstallAfter.Size = new System.Drawing.Size(243, 17);
            this.cbInstallAfter.TabIndex = 5;
            this.cbInstallAfter.Text = "Install dependencies after generating template";
            this.cbInstallAfter.UseVisualStyleBackColor = true;
            // 
            // cbBuildAfter
            // 
            this.cbBuildAfter.AutoSize = true;
            this.cbBuildAfter.Location = new System.Drawing.Point(320, 363);
            this.cbBuildAfter.Name = "cbBuildAfter";
            this.cbBuildAfter.Size = new System.Drawing.Size(239, 17);
            this.cbBuildAfter.TabIndex = 6;
            this.cbBuildAfter.Text = "Build Aurelia project after generating template";
            this.cbBuildAfter.UseVisualStyleBackColor = true;
            this.cbBuildAfter.CheckedChanged += new System.EventHandler(this.cbBuildAfter_CheckedChanged);
            // 
            // rbTypescript
            // 
            this.rbTypescript.AutoSize = true;
            this.rbTypescript.Checked = true;
            this.rbTypescript.Location = new System.Drawing.Point(11, 24);
            this.rbTypescript.Name = "rbTypescript";
            this.rbTypescript.Size = new System.Drawing.Size(74, 17);
            this.rbTypescript.TabIndex = 9;
            this.rbTypescript.TabStop = true;
            this.rbTypescript.Text = "Typescript";
            this.rbTypescript.UseVisualStyleBackColor = true;
            // 
            // gbScriptOptions
            // 
            this.gbScriptOptions.Controls.Add(this.rbBabel);
            this.gbScriptOptions.Controls.Add(this.rbTypescript);
            this.gbScriptOptions.Location = new System.Drawing.Point(555, 128);
            this.gbScriptOptions.Name = "gbScriptOptions";
            this.gbScriptOptions.Padding = new System.Windows.Forms.Padding(8);
            this.gbScriptOptions.Size = new System.Drawing.Size(233, 73);
            this.gbScriptOptions.TabIndex = 10;
            this.gbScriptOptions.TabStop = false;
            this.gbScriptOptions.Text = "Script Options";
            this.gbScriptOptions.Visible = false;
            // 
            // rbBabel
            // 
            this.rbBabel.AutoSize = true;
            this.rbBabel.Location = new System.Drawing.Point(12, 48);
            this.rbBabel.Name = "rbBabel";
            this.rbBabel.Size = new System.Drawing.Size(52, 17);
            this.rbBabel.TabIndex = 10;
            this.rbBabel.TabStop = true;
            this.rbBabel.Text = "Babel";
            this.rbBabel.UseVisualStyleBackColor = true;
            // 
            // gbProtocol
            // 
            this.gbProtocol.Controls.Add(this.rbHTTP2);
            this.gbProtocol.Controls.Add(this.rbHTTP1_1);
            this.gbProtocol.Location = new System.Drawing.Point(311, 128);
            this.gbProtocol.Name = "gbProtocol";
            this.gbProtocol.Padding = new System.Windows.Forms.Padding(8);
            this.gbProtocol.Size = new System.Drawing.Size(238, 73);
            this.gbProtocol.TabIndex = 11;
            this.gbProtocol.TabStop = false;
            this.gbProtocol.Text = "Http Protocol";
            // 
            // rbHTTP2
            // 
            this.rbHTTP2.AutoSize = true;
            this.rbHTTP2.Location = new System.Drawing.Point(12, 49);
            this.rbHTTP2.Name = "rbHTTP2";
            this.rbHTTP2.Size = new System.Drawing.Size(65, 17);
            this.rbHTTP2.TabIndex = 1;
            this.rbHTTP2.TabStop = true;
            this.rbHTTP2.Text = "HTTP/2";
            this.rbHTTP2.UseVisualStyleBackColor = true;
            // 
            // rbHTTP1_1
            // 
            this.rbHTTP1_1.AutoSize = true;
            this.rbHTTP1_1.Checked = true;
            this.rbHTTP1_1.Location = new System.Drawing.Point(12, 25);
            this.rbHTTP1_1.Name = "rbHTTP1_1";
            this.rbHTTP1_1.Size = new System.Drawing.Size(74, 17);
            this.rbHTTP1_1.TabIndex = 0;
            this.rbHTTP1_1.TabStop = true;
            this.rbHTTP1_1.Text = "HTTP/1.1";
            this.rbHTTP1_1.UseVisualStyleBackColor = true;
            // 
            // cobMarkupProcessing
            // 
            this.cobMarkupProcessing.FormattingEnabled = true;
            this.cobMarkupProcessing.Items.AddRange(new object[] {
            "None",
            "Minimum",
            "Maximum"});
            this.cobMarkupProcessing.Location = new System.Drawing.Point(562, 212);
            this.cobMarkupProcessing.Name = "cobMarkupProcessing";
            this.cobMarkupProcessing.Size = new System.Drawing.Size(121, 21);
            this.cobMarkupProcessing.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Markup Processing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // cobCSSProcessing
            // 
            this.cobCSSProcessing.FormattingEnabled = true;
            this.cobCSSProcessing.Items.AddRange(new object[] {
            "None",
            "Less",
            "Sass",
            "Stylus",
            "PostCSS"});
            this.cobCSSProcessing.Location = new System.Drawing.Point(562, 239);
            this.cobCSSProcessing.Name = "cobCSSProcessing";
            this.cobCSSProcessing.Size = new System.Drawing.Size(121, 21);
            this.cobCSSProcessing.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "CSS Processing";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Javascript Unit Testing";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // cobUntiTesting
            // 
            this.cobUntiTesting.FormattingEnabled = true;
            this.cobUntiTesting.Items.AddRange(new object[] {
            "None",
            "Karma",
            "Jest"});
            this.cobUntiTesting.Location = new System.Drawing.Point(562, 266);
            this.cobUntiTesting.Name = "cobUntiTesting";
            this.cobUntiTesting.Size = new System.Drawing.Size(121, 21);
            this.cobUntiTesting.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Integration Testing";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // cobIntegrationTesting
            // 
            this.cobIntegrationTesting.FormattingEnabled = true;
            this.cobIntegrationTesting.Items.AddRange(new object[] {
            "None",
            "Protractor"});
            this.cobIntegrationTesting.Location = new System.Drawing.Point(562, 293);
            this.cobIntegrationTesting.Name = "cobIntegrationTesting";
            this.cobIntegrationTesting.Size = new System.Drawing.Size(121, 21);
            this.cobIntegrationTesting.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Aurelia Project Name";
            this.label6.Visible = false;
            // 
            // tbAureliaProjectName
            // 
            this.tbAureliaProjectName.Location = new System.Drawing.Point(120, 136);
            this.tbAureliaProjectName.Name = "tbAureliaProjectName";
            this.tbAureliaProjectName.Size = new System.Drawing.Size(170, 20);
            this.tbAureliaProjectName.TabIndex = 21;
            this.tbAureliaProjectName.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 28);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTemplateName
            // 
            this.lblTemplateName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemplateName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTemplateName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTemplateName.Location = new System.Drawing.Point(311, 12);
            this.lblTemplateName.Name = "lblTemplateName";
            this.lblTemplateName.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.lblTemplateName.Size = new System.Drawing.Size(477, 45);
            this.lblTemplateName.TabIndex = 23;
            this.lblTemplateName.Text = "Template name...";
            this.lblTemplateName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // templateItemBindingSource
            // 
            this.templateItemBindingSource.DataSource = typeof(AuVSIX.Models.TemplateItem);
            // 
            // wizardModelBindingSource
            // 
            this.wizardModelBindingSource.DataSource = typeof(AuVSIX.Forms.IWizardModel);
            // 
            // wizardModelBindingSource1
            // 
            this.wizardModelBindingSource1.DataSource = typeof(AuVSIX.Forms.IWizardModel);
            // 
            // AuVSTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTemplateName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbAureliaProjectName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cobIntegrationTesting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cobUntiTesting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cobCSSProcessing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cobMarkupProcessing);
            this.Controls.Add(this.gbProtocol);
            this.Controls.Add(this.gbScriptOptions);
            this.Controls.Add(this.cbBuildAfter);
            this.Controls.Add(this.cbInstallAfter);
            this.Controls.Add(this.lblTemplateDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.logoImage);
            this.Name = "AuVSTemplateForm";
            this.Text = "Aurelia CLI Visual Studio Project Templates";
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.gbScriptOptions.ResumeLayout(false);
            this.gbScriptOptions.PerformLayout();
            this.gbProtocol.ResumeLayout(false);
            this.gbProtocol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templateItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardModelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTemplateDescription;
        private System.Windows.Forms.CheckBox cbInstallAfter;
        private System.Windows.Forms.CheckBox cbBuildAfter;
        private System.Windows.Forms.RadioButton rbTypescript;
        private System.Windows.Forms.GroupBox gbScriptOptions;
        private System.Windows.Forms.RadioButton rbBabel;
        private System.Windows.Forms.GroupBox gbProtocol;
        private System.Windows.Forms.RadioButton rbHTTP2;
        private System.Windows.Forms.RadioButton rbHTTP1_1;
        private System.Windows.Forms.ComboBox cobMarkupProcessing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobCSSProcessing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobUntiTesting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cobIntegrationTesting;
        private System.Windows.Forms.BindingSource wizardModelBindingSource;
        private System.Windows.Forms.BindingSource wizardModelBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAureliaProjectName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource templateItemBindingSource;
        private System.Windows.Forms.Label lblTemplateName;
    }
}
