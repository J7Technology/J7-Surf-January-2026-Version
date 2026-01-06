using EasyTabs;

namespace Surf
{
    partial class SurfUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurfUI));
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.settings = new System.Windows.Forms.Panel();
            this.txtButton = new System.Windows.Forms.Button();
            this.docxButton = new System.Windows.Forms.Button();
            this.changeNotesFileLabel = new System.Windows.Forms.Label();
            this.dseLabel = new System.Windows.Forms.Label();
            this.yandexButton = new System.Windows.Forms.Button();
            this.baiduButton = new System.Windows.Forms.Button();
            this.naverButton = new System.Windows.Forms.Button();
            this.ecosiaButton = new System.Windows.Forms.Button();
            this.braveButton = new System.Windows.Forms.Button();
            this.yahooButton = new System.Windows.Forms.Button();
            this.moogleButton = new System.Windows.Forms.Button();
            this.bingButton = new System.Windows.Forms.Button();
            this.duckDuckGoButton = new System.Windows.Forms.Button();
            this.googleButton = new System.Windows.Forms.Button();
            this.ExitSettings = new System.Windows.Forms.Button();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.searchBar2 = new System.Windows.Forms.TextBox();
            this.mainBar = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardButton = new System.Windows.Forms.ToolStripButton();
            this.ReloadButton = new System.Windows.Forms.ToolStripButton();
            this.SearchBar = new System.Windows.Forms.ToolStripTextBox();
            this.SecureImage = new System.Windows.Forms.ToolStripButton();
            this.DownloadsButton = new System.Windows.Forms.ToolStripButton();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.Surf = new System.Windows.Forms.ToolStripButton();
            this.SideBar = new System.Windows.Forms.ToolStrip();
            this.SettingsButton = new System.Windows.Forms.ToolStripButton();
            this.HistoryButton = new System.Windows.Forms.ToolStripButton();
            this.OpenNotesButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LDButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DockButton = new System.Windows.Forms.ToolStripButton();
            this.VisibilityButton = new System.Windows.Forms.ToolStripButton();
            this.FullScreenButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.J7ModeCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.settings.SuspendLayout();
            this.mainBar.SuspendLayout();
            this.SideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(65, 41);
            this.webView.Margin = new System.Windows.Forms.Padding(0);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(2523, 1587);
            this.webView.TabIndex = 3;
            this.webView.ZoomFactor = 1D;
            this.webView.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.webView_NavigationStarting);
            this.webView.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView_NavigationCompleted);
            this.webView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // settings
            // 
            this.settings.AutoScroll = true;
            this.settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settings.BackColor = System.Drawing.Color.White;
            this.settings.Controls.Add(this.J7ModeCheckbox);
            this.settings.Controls.Add(this.label1);
            this.settings.Controls.Add(this.txtButton);
            this.settings.Controls.Add(this.docxButton);
            this.settings.Controls.Add(this.changeNotesFileLabel);
            this.settings.Controls.Add(this.dseLabel);
            this.settings.Controls.Add(this.yandexButton);
            this.settings.Controls.Add(this.baiduButton);
            this.settings.Controls.Add(this.naverButton);
            this.settings.Controls.Add(this.ecosiaButton);
            this.settings.Controls.Add(this.braveButton);
            this.settings.Controls.Add(this.yahooButton);
            this.settings.Controls.Add(this.moogleButton);
            this.settings.Controls.Add(this.bingButton);
            this.settings.Controls.Add(this.duckDuckGoButton);
            this.settings.Controls.Add(this.googleButton);
            this.settings.Controls.Add(this.ExitSettings);
            this.settings.Controls.Add(this.settingsLabel);
            this.settings.Location = new System.Drawing.Point(203, 47);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(2330, 1400);
            this.settings.TabIndex = 6;
            this.settings.Visible = false;
            // 
            // txtButton
            // 
            this.txtButton.BackColor = System.Drawing.Color.White;
            this.txtButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtButton.FlatAppearance.BorderSize = 0;
            this.txtButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtButton.Location = new System.Drawing.Point(1297, 791);
            this.txtButton.Name = "txtButton";
            this.txtButton.Size = new System.Drawing.Size(230, 160);
            this.txtButton.TabIndex = 24;
            this.txtButton.Text = ".txt";
            this.txtButton.UseVisualStyleBackColor = false;
            this.txtButton.Click += new System.EventHandler(this.txtButton_Click);
            // 
            // docxButton
            // 
            this.docxButton.BackColor = System.Drawing.Color.White;
            this.docxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.docxButton.FlatAppearance.BorderSize = 0;
            this.docxButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.docxButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.docxButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.docxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docxButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docxButton.Location = new System.Drawing.Point(791, 791);
            this.docxButton.Name = "docxButton";
            this.docxButton.Size = new System.Drawing.Size(230, 160);
            this.docxButton.TabIndex = 23;
            this.docxButton.Text = ".docx";
            this.docxButton.UseVisualStyleBackColor = false;
            this.docxButton.Click += new System.EventHandler(this.docxButton_Click);
            // 
            // changeNotesFileLabel
            // 
            this.changeNotesFileLabel.Font = new System.Drawing.Font("Yu Gothic", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeNotesFileLabel.Location = new System.Drawing.Point(651, 647);
            this.changeNotesFileLabel.Name = "changeNotesFileLabel";
            this.changeNotesFileLabel.Size = new System.Drawing.Size(1029, 106);
            this.changeNotesFileLabel.TabIndex = 22;
            this.changeNotesFileLabel.Text = "Surf Notes File Type";
            this.changeNotesFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dseLabel
            // 
            this.dseLabel.Font = new System.Drawing.Font("Yu Gothic", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dseLabel.Location = new System.Drawing.Point(647, 92);
            this.dseLabel.Name = "dseLabel";
            this.dseLabel.Size = new System.Drawing.Size(1029, 106);
            this.dseLabel.TabIndex = 21;
            this.dseLabel.Text = "Default Search Engine";
            this.dseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yandexButton
            // 
            this.yandexButton.BackColor = System.Drawing.Color.White;
            this.yandexButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yandexButton.FlatAppearance.BorderSize = 0;
            this.yandexButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yandexButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.yandexButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yandexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yandexButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yandexButton.Location = new System.Drawing.Point(1297, 479);
            this.yandexButton.Name = "yandexButton";
            this.yandexButton.Size = new System.Drawing.Size(230, 160);
            this.yandexButton.TabIndex = 20;
            this.yandexButton.Text = "Yandex";
            this.yandexButton.UseVisualStyleBackColor = false;
            this.yandexButton.Click += new System.EventHandler(this.yandexButton_Click);
            this.yandexButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // baiduButton
            // 
            this.baiduButton.BackColor = System.Drawing.Color.White;
            this.baiduButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baiduButton.FlatAppearance.BorderSize = 0;
            this.baiduButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.baiduButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.baiduButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.baiduButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baiduButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baiduButton.Location = new System.Drawing.Point(791, 479);
            this.baiduButton.Name = "baiduButton";
            this.baiduButton.Size = new System.Drawing.Size(230, 160);
            this.baiduButton.TabIndex = 19;
            this.baiduButton.Text = "Baidu";
            this.baiduButton.UseVisualStyleBackColor = false;
            this.baiduButton.Click += new System.EventHandler(this.baiduButton_Click);
            this.baiduButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // naverButton
            // 
            this.naverButton.BackColor = System.Drawing.Color.White;
            this.naverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.naverButton.FlatAppearance.BorderSize = 0;
            this.naverButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.naverButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.naverButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.naverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naverButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naverButton.Location = new System.Drawing.Point(1046, 479);
            this.naverButton.Name = "naverButton";
            this.naverButton.Size = new System.Drawing.Size(230, 160);
            this.naverButton.TabIndex = 18;
            this.naverButton.Text = "Naver";
            this.naverButton.UseVisualStyleBackColor = false;
            this.naverButton.Click += new System.EventHandler(this.naverButton_Click);
            this.naverButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // ecosiaButton
            // 
            this.ecosiaButton.BackColor = System.Drawing.Color.White;
            this.ecosiaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ecosiaButton.FlatAppearance.BorderSize = 0;
            this.ecosiaButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ecosiaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ecosiaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ecosiaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ecosiaButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecosiaButton.Location = new System.Drawing.Point(1808, 280);
            this.ecosiaButton.Name = "ecosiaButton";
            this.ecosiaButton.Size = new System.Drawing.Size(230, 167);
            this.ecosiaButton.TabIndex = 17;
            this.ecosiaButton.Text = "Ecosia";
            this.ecosiaButton.UseVisualStyleBackColor = false;
            this.ecosiaButton.Click += new System.EventHandler(this.ecosiaButton_Click);
            this.ecosiaButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // braveButton
            // 
            this.braveButton.BackColor = System.Drawing.Color.White;
            this.braveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.braveButton.FlatAppearance.BorderSize = 0;
            this.braveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.braveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.braveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.braveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.braveButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braveButton.Location = new System.Drawing.Point(1547, 280);
            this.braveButton.Name = "braveButton";
            this.braveButton.Size = new System.Drawing.Size(230, 167);
            this.braveButton.TabIndex = 16;
            this.braveButton.Text = "Brave";
            this.braveButton.UseVisualStyleBackColor = false;
            this.braveButton.Click += new System.EventHandler(this.braveButton_Click);
            this.braveButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // yahooButton
            // 
            this.yahooButton.BackColor = System.Drawing.Color.White;
            this.yahooButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yahooButton.FlatAppearance.BorderSize = 0;
            this.yahooButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yahooButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.yahooButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yahooButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yahooButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yahooButton.Location = new System.Drawing.Point(1297, 280);
            this.yahooButton.Name = "yahooButton";
            this.yahooButton.Size = new System.Drawing.Size(230, 167);
            this.yahooButton.TabIndex = 15;
            this.yahooButton.Text = "Yahoo";
            this.yahooButton.UseVisualStyleBackColor = false;
            this.yahooButton.Click += new System.EventHandler(this.yahooButton_Click);
            this.yahooButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // moogleButton
            // 
            this.moogleButton.BackColor = System.Drawing.Color.White;
            this.moogleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moogleButton.FlatAppearance.BorderSize = 0;
            this.moogleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.moogleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.moogleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.moogleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moogleButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moogleButton.Location = new System.Drawing.Point(1046, 280);
            this.moogleButton.Name = "moogleButton";
            this.moogleButton.Size = new System.Drawing.Size(230, 167);
            this.moogleButton.TabIndex = 14;
            this.moogleButton.Text = "Moogle";
            this.moogleButton.UseVisualStyleBackColor = false;
            this.moogleButton.Click += new System.EventHandler(this.moogleButton_Click);
            this.moogleButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // bingButton
            // 
            this.bingButton.BackColor = System.Drawing.Color.White;
            this.bingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bingButton.FlatAppearance.BorderSize = 0;
            this.bingButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bingButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingButton.Location = new System.Drawing.Point(791, 280);
            this.bingButton.Name = "bingButton";
            this.bingButton.Size = new System.Drawing.Size(230, 167);
            this.bingButton.TabIndex = 13;
            this.bingButton.Text = "Bing";
            this.bingButton.UseVisualStyleBackColor = false;
            this.bingButton.Click += new System.EventHandler(this.bingButton_Click);
            this.bingButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // duckDuckGoButton
            // 
            this.duckDuckGoButton.BackColor = System.Drawing.Color.White;
            this.duckDuckGoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duckDuckGoButton.FlatAppearance.BorderSize = 0;
            this.duckDuckGoButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.duckDuckGoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.duckDuckGoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.duckDuckGoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duckDuckGoButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duckDuckGoButton.Location = new System.Drawing.Point(542, 280);
            this.duckDuckGoButton.Name = "duckDuckGoButton";
            this.duckDuckGoButton.Size = new System.Drawing.Size(230, 167);
            this.duckDuckGoButton.TabIndex = 12;
            this.duckDuckGoButton.Text = "Duck Duck Go";
            this.duckDuckGoButton.UseVisualStyleBackColor = false;
            this.duckDuckGoButton.Click += new System.EventHandler(this.duckDuckGoButton_Click);
            this.duckDuckGoButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // googleButton
            // 
            this.googleButton.BackColor = System.Drawing.Color.White;
            this.googleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.googleButton.FlatAppearance.BorderSize = 0;
            this.googleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.googleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.googleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.googleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.googleButton.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.googleButton.Location = new System.Drawing.Point(293, 280);
            this.googleButton.Name = "googleButton";
            this.googleButton.Size = new System.Drawing.Size(230, 167);
            this.googleButton.TabIndex = 11;
            this.googleButton.Text = "Google";
            this.googleButton.UseVisualStyleBackColor = false;
            this.googleButton.Click += new System.EventHandler(this.googleButton_Click);
            this.googleButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // ExitSettings
            // 
            this.ExitSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExitSettings.BackgroundImage = global::Surf.Properties.Resources.XIcon;
            this.ExitSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitSettings.Location = new System.Drawing.Point(2247, 0);
            this.ExitSettings.Name = "ExitSettings";
            this.ExitSettings.Size = new System.Drawing.Size(74, 74);
            this.ExitSettings.TabIndex = 0;
            this.ExitSettings.UseVisualStyleBackColor = false;
            this.ExitSettings.Click += new System.EventHandler(this.ExitSettings_Click);
            this.ExitSettings.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // settingsLabel
            // 
            this.settingsLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.settingsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsLabel.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(2330, 74);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.Text = "J7 SURF SETTINGS";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBar2
            // 
            this.searchBar2.AutoCompleteCustomSource.AddRange(new string[] {
            "https://google.com",
            "https://youtube.com",
            "https://facebook.com",
            "https://instagram.com",
            "https://chatgpt.com",
            "https://x.com",
            "https://reddit.com",
            "https://whatsapp.com",
            "https://wikipedia.org",
            "https://bing.com",
            "https://yahoo.co.jp",
            "https://yahoo.com",
            "https://tiktok.com",
            "https://yandex.ru",
            "https://amazon.com",
            "https://baidu.com",
            "https://linkedin.com",
            "https://office.com",
            "https://netflix.com",
            "https://temu.com",
            "https://live.com",
            "https://pinterest.com",
            "https://dzen.ru",
            "https://bilibili.com",
            "https://microsoft.com",
            "https://twitch.tv",
            "https://gemini.google.com",
            "https://sharepoint.com",
            "https://canva.com",
            "https://samsung.com",
            "https://vk.com",
            "https://news.yahoo.co.jp",
            "https://mail.ru",
            "https://weather.com",
            "https://globo.com",
            "https://fandom.com",
            "https://t.me",
            "https://duckduckgo.com",
            "https://nytimes.com",
            "https://zoom.com",
            "https://docomo.ne.jp",
            "https://roblox.com",
            "https://ebay.com",
            "https://apple.com",
            "https://msn.com",
            "https://openai.com",
            "https://aliexpress.com",
            "https://paypal.com",
            "https://spotify.com",
            "https://discord.com",
            "https://imdb.com",
            "https://rottentomatoes.com",
            "https://amazon.co.jp",
            "https://github.com",
            "https://quora.com",
            "https://walmart.com",
            "https://espn.com",
            "https://disneyplus.com",
            "https://bbc.com",
            "https://bbc.co.uk",
            "https://telegram.org",
            "https://indeed.com",
            "https://usps.com",
            "https://etsy.com",
            "https://steampowered.com",
            "https://primevideo.com",
            "https://adobe.com",
            "https://theguardian.com",
            "https://dailymail.co.uk",
            "https://twitter.com",
            "https://outlook.com",
            "https://mail.google.com",
            "https://gmail.com"});
            this.searchBar2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchBar2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBar2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar2.Location = new System.Drawing.Point(113, 248);
            this.searchBar2.Name = "searchBar2";
            this.searchBar2.Size = new System.Drawing.Size(2449, 41);
            this.searchBar2.TabIndex = 22;
            this.searchBar2.Visible = false;
            this.searchBar2.Click += new System.EventHandler(this.LDButton_Click);
            this.searchBar2.DoubleClick += new System.EventHandler(this.SearchBar_DoubleClick);
            this.searchBar2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBar2_Search);
            // 
            // mainBar
            // 
            this.mainBar.BackColor = System.Drawing.Color.White;
            this.mainBar.CanOverflow = false;
            this.mainBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainBar.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.mainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.ForwardButton,
            this.ReloadButton,
            this.SearchBar,
            this.SecureImage,
            this.DownloadsButton,
            this.HomeButton,
            this.Surf});
            this.mainBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainBar.Location = new System.Drawing.Point(0, 0);
            this.mainBar.Name = "mainBar";
            this.mainBar.Padding = new System.Windows.Forms.Padding(0);
            this.mainBar.Size = new System.Drawing.Size(2588, 41);
            this.mainBar.Stretch = true;
            this.mainBar.TabIndex = 23;
            this.mainBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = global::Surf.Properties.Resources.BackIcon;
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(40, 41);
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.Transparent;
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardButton.Image = global::Surf.Properties.Resources.ForwardIcon;
            this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(0);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(40, 41);
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackColor = System.Drawing.Color.Transparent;
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReloadButton.Image = global::Surf.Properties.Resources.ReloadIcon;
            this.ReloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReloadButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(40, 41);
            this.ReloadButton.ToolTipText = "Reload";
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.AutoCompleteCustomSource.AddRange(new string[] {
            "https://google.com",
            "https://youtube.com",
            "https://facebook.com",
            "https://instagram.com",
            "https://chatgpt.com",
            "https://x.com",
            "https://reddit.com",
            "https://whatsapp.com",
            "https://wikipedia.org",
            "https://bing.com",
            "https://yahoo.co.jp",
            "https://yahoo.com",
            "https://tiktok.com",
            "https://yandex.ru",
            "https://amazon.com",
            "https://baidu.com",
            "https://linkedin.com",
            "https://office.com",
            "https://netflix.com",
            "https://temu.com",
            "https://live.com",
            "https://pinterest.com",
            "https://dzen.ru",
            "https://bilibili.com",
            "https://microsoft.com",
            "https://twitch.tv",
            "https://gemini.google.com",
            "https://sharepoint.com",
            "https://canva.com",
            "https://samsung.com",
            "https://vk.com",
            "https://news.yahoo.co.jp",
            "https://mail.ru",
            "https://weather.com",
            "https://globo.com",
            "https://fandom.com",
            "https://t.me",
            "https://duckduckgo.com",
            "https://nytimes.com",
            "https://zoom.com",
            "https://docomo.ne.jp",
            "https://roblox.com",
            "https://ebay.com",
            "https://apple.com",
            "https://msn.com",
            "https://openai.com",
            "https://aliexpress.com",
            "https://paypal.com",
            "https://spotify.com",
            "https://discord.com",
            "https://imdb.com",
            "https://rottentomatoes.com",
            "https://amazon.co.jp",
            "https://github.com",
            "https://quora.com",
            "https://walmart.com",
            "https://espn.com",
            "https://disneyplus.com",
            "https://bbc.com",
            "https://bbc.co.uk",
            "https://telegram.org",
            "https://indeed.com",
            "https://usps.com",
            "https://etsy.com",
            "https://steampowered.com",
            "https://primevideo.com",
            "https://adobe.com",
            "https://theguardian.com",
            "https://dailymail.co.uk",
            "https://twitter.com",
            "https://outlook.com",
            "https://mail.google.com",
            "https://gmail.com"});
            this.SearchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(2250, 41);
            this.SearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBar_Search);
            this.SearchBar.DoubleClick += new System.EventHandler(this.SearchBar_DoubleClick);
            // 
            // SecureImage
            // 
            this.SecureImage.BackColor = System.Drawing.Color.Transparent;
            this.SecureImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SecureImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SecureImage.Image = global::Surf.Properties.Resources.SecureIcon;
            this.SecureImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SecureImage.Margin = new System.Windows.Forms.Padding(0);
            this.SecureImage.Name = "SecureImage";
            this.SecureImage.Size = new System.Drawing.Size(40, 41);
            this.SecureImage.Text = "Secure";
            // 
            // DownloadsButton
            // 
            this.DownloadsButton.BackColor = System.Drawing.Color.Transparent;
            this.DownloadsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownloadsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DownloadsButton.Image = global::Surf.Properties.Resources.DownloadIcon;
            this.DownloadsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DownloadsButton.Margin = new System.Windows.Forms.Padding(0);
            this.DownloadsButton.Name = "DownloadsButton";
            this.DownloadsButton.Size = new System.Drawing.Size(40, 41);
            this.DownloadsButton.Text = "Downloads";
            this.DownloadsButton.Click += new System.EventHandler(this.DownloadsButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Image = global::Surf.Properties.Resources.HomeIcon;
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(40, 41);
            this.HomeButton.Text = "Home";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // Surf
            // 
            this.Surf.BackColor = System.Drawing.Color.Transparent;
            this.Surf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Surf.Image = global::Surf.Properties.Resources.SurfLogo;
            this.Surf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Surf.Margin = new System.Windows.Forms.Padding(0);
            this.Surf.Name = "Surf";
            this.Surf.Size = new System.Drawing.Size(40, 41);
            this.Surf.Text = "Surf";
            this.Surf.ToolTipText = "Surf";
            // 
            // SideBar
            // 
            this.SideBar.AutoSize = false;
            this.SideBar.BackColor = System.Drawing.Color.White;
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SideBar.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.SideBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsButton,
            this.HistoryButton,
            this.OpenNotesButton,
            this.toolStripSeparator1,
            this.LDButton,
            this.toolStripSeparator2,
            this.DockButton,
            this.VisibilityButton,
            this.FullScreenButton});
            this.SideBar.Location = new System.Drawing.Point(0, 41);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(65, 1587);
            this.SideBar.TabIndex = 24;
            this.SideBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsButton.Image = global::Surf.Properties.Resources.SettingsGear;
            this.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(62, 32);
            this.SettingsButton.ToolTipText = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.Transparent;
            this.HistoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HistoryButton.Image = global::Surf.Properties.Resources.HistoryIcon;
            this.HistoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(62, 32);
            this.HistoryButton.Text = "toolStripButton3";
            this.HistoryButton.ToolTipText = "History";
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // OpenNotesButton
            // 
            this.OpenNotesButton.BackColor = System.Drawing.Color.Transparent;
            this.OpenNotesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenNotesButton.Image = global::Surf.Properties.Resources.NotesIcon;
            this.OpenNotesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenNotesButton.Name = "OpenNotesButton";
            this.OpenNotesButton.Size = new System.Drawing.Size(62, 32);
            this.OpenNotesButton.Text = "toolStripButton1";
            this.OpenNotesButton.ToolTipText = "Open Notes";
            this.OpenNotesButton.Click += new System.EventHandler(this.OpenNotesButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(62, 6);
            // 
            // LDButton
            // 
            this.LDButton.BackColor = System.Drawing.Color.Transparent;
            this.LDButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LDButton.Image = global::Surf.Properties.Resources.L_Mode_Icon;
            this.LDButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LDButton.Name = "LDButton";
            this.LDButton.Size = new System.Drawing.Size(62, 32);
            this.LDButton.ToolTipText = "Light/Dark Mode Toggle";
            this.LDButton.Click += new System.EventHandler(this.LDButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(62, 6);
            // 
            // DockButton
            // 
            this.DockButton.BackColor = System.Drawing.Color.Transparent;
            this.DockButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DockButton.Image = global::Surf.Properties.Resources.MoveIcon;
            this.DockButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DockButton.Name = "DockButton";
            this.DockButton.Size = new System.Drawing.Size(62, 32);
            this.DockButton.Text = "toolStripButton7";
            this.DockButton.ToolTipText = "Move SideBar";
            this.DockButton.Click += new System.EventHandler(this.DockButton_Click);
            // 
            // VisibilityButton
            // 
            this.VisibilityButton.BackColor = System.Drawing.Color.Transparent;
            this.VisibilityButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VisibilityButton.Image = global::Surf.Properties.Resources.FullIcon;
            this.VisibilityButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VisibilityButton.Name = "VisibilityButton";
            this.VisibilityButton.Size = new System.Drawing.Size(62, 32);
            this.VisibilityButton.Text = "toolStripButton5";
            this.VisibilityButton.ToolTipText = "Hide Side Bar";
            this.VisibilityButton.Click += new System.EventHandler(this.VisibilityButton_Click);
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.BackColor = System.Drawing.Color.Transparent;
            this.FullScreenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FullScreenButton.Image = global::Surf.Properties.Resources.FullScreen;
            this.FullScreenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(62, 32);
            this.FullScreenButton.ToolTipText = "Fullscreen";
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 954);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1029, 106);
            this.label1.TabIndex = 25;
            this.label1.Text = "J7 Homepage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // J7ModeCheckbox
            // 
            this.J7ModeCheckbox.AutoSize = true;
            this.J7ModeCheckbox.Location = new System.Drawing.Point(1148, 1063);
            this.J7ModeCheckbox.Name = "J7ModeCheckbox";
            this.J7ModeCheckbox.Size = new System.Drawing.Size(22, 21);
            this.J7ModeCheckbox.TabIndex = 26;
            this.J7ModeCheckbox.UseVisualStyleBackColor = true;
            this.J7ModeCheckbox.CheckedChanged += new System.EventHandler(this.J7ModeCheckbox_CheckedChanged);
            // 
            // SurfUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(2588, 1628);
            this.Controls.Add(this.searchBar2);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.mainBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1800, 400);
            this.Name = "SurfUI";
            this.Text = "Surf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.mainBar.ResumeLayout(false);
            this.mainBar.PerformLayout();
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.Button ExitSettings;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label dseLabel;
        private System.Windows.Forms.Button yandexButton;
        private System.Windows.Forms.Button baiduButton;
        private System.Windows.Forms.Button naverButton;
        private System.Windows.Forms.Button ecosiaButton;
        private System.Windows.Forms.Button braveButton;
        private System.Windows.Forms.Button yahooButton;
        private System.Windows.Forms.Button moogleButton;
        private System.Windows.Forms.Button bingButton;
        private System.Windows.Forms.Button duckDuckGoButton;
        private System.Windows.Forms.Button googleButton;
        private System.Windows.Forms.TextBox searchBar2;
        private System.Windows.Forms.ToolStrip mainBar;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStrip SideBar;
        private System.Windows.Forms.ToolStripButton ForwardButton;
        private System.Windows.Forms.ToolStripButton ReloadButton;
        private System.Windows.Forms.ToolStripTextBox SearchBar;
        private System.Windows.Forms.ToolStripButton SecureImage;
        private System.Windows.Forms.ToolStripButton DownloadsButton;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.ToolStripButton Surf;
        private System.Windows.Forms.ToolStripButton SettingsButton;
        private System.Windows.Forms.ToolStripButton HistoryButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton LDButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton VisibilityButton;
        private System.Windows.Forms.ToolStripButton FullScreenButton;
        private System.Windows.Forms.ToolStripButton DockButton;
        private System.Windows.Forms.ToolStripButton OpenNotesButton;
        private System.Windows.Forms.Button txtButton;
        private System.Windows.Forms.Button docxButton;
        private System.Windows.Forms.Label changeNotesFileLabel;
        private System.Windows.Forms.CheckBox J7ModeCheckbox;
        private System.Windows.Forms.Label label1;
    }
}