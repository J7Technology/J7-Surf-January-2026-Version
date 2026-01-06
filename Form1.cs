using EasyTabs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win32Interop.Structs;
using CefSharp;
using CefSharp.WinForms;
using Microsoft.Web.WebView2.Core;

namespace Surf
{
    public partial class SurfUI : Form
    {
        // Static variables for settings
        private static bool darkMode = false;
            // If the browser is in full screen mode
        private static bool fullScreen = false;
            // If the sidebar is hidden
        private static bool hideSide = false;
            // If the settings menu is open
        private static bool settingsOpen = false;
            // Currently selected default search engine
        private static string defaultSearch = "https://google.com/search?q=";
            // All possible default search engines
        private static string[] searchEngines = { "https://google.com/search?q=", "https://duckduckgo.com/?q=", "https://www.bing.com/search?q=", "https://api.moogle.app/api/search?q=", "https://search.yahoo.com/search?p=", "https://search.brave.com/search?q=", "https://www.ecosia.org/search?method=index&q=", "https://www.baidu.com/s?ie=utf-8&f=8&rsv_bp=1&rsv_idx=1&tn=baidu&wd=", "https://search.naver.com/search.naver?sm=tab_hty.top&where=nexearch&ssc=tab.nx.all&query=", "https://yandex.com/search/?text="}; //{ "Google", "DuckDuckGo", "Bing", "Moogle", "Yahoo", "Brave", "Ecosia", "Baidu", "Naver", "Yandex"};
            // KeyBoard Shortcut Variables
        private static Keys closeKey = Keys.W;
        private static Keys refreshKey = Keys.R;
        private static Keys historyKey = Keys.H;
        private static Keys downloadsKey = Keys.D;
        private static Keys settingsKey = Keys.S;
        private static Keys backKey = Keys.Left; 
        private static Keys forwardKey = Keys.Right;

        // Create a new instance of the AppContainer class
        AppContainer container = new AppContainer();

        public SurfUI()
        {
            // Initialize the form and its components
            InitializeComponent();

            // If dark mode is enabled, change the color scheme accordingly
            if (darkMode)
            {
                mainBar.BackColor = Color.FromArgb(0, 0, 0);
                SearchBar.BackColor = Color.FromArgb(10, 10, 10);
                SearchBar.ForeColor = Color.FromArgb(255, 255, 255);
                SideBar.BackColor = Color.FromArgb(0, 0, 0);
                LDButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\D Mode Icon.png");
                BackButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\BackIcon(D-Mode).png");
                ForwardButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\ForwardIcon(D-Mode).png");
                ReloadButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\ReloadIcon(D-Mode).png");
                HistoryButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\HistoryIcon(D-Mode).png");
                DockButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\MoveIcon(D-Mode).png");
                DownloadsButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\DownloadIcon(D-Mode).png");
                VisibilityButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\FullIcon(D-Mode).png");
                FullScreenButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\FullScreen(D-Mode).png");
                HomeButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\HomeIcon(D-Mode).png");
                Surf.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\SurfLogo(D-Mode).png");
                SettingsButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\SettingsGear(D-Mode).png");
                darkMode = true;
            }

            // if full screen enabled, hide the sidebar and main bar
            if (fullScreen) {
                SideBar.Visible = false;
                mainBar.Visible = false;
                ExitFullscreenButton.Visible = true;
            }

            // if sidebar disabled, hide it
            if (hideSide) {
                SideBar.Visible = false;
                ShowSideButton.Visible = true;
            }

            // Start on default search engine
            if (defaultSearch == searchEngines[3])
            {
                webView.Source = new Uri("https://moogle.app/");
            }
            else if (defaultSearch == searchEngines[6])
            {
                webView.Source = new Uri("https://ecosia.org/");
            }
            else 
            {
                webView.Source = new Uri(defaultSearch);
            }
        }

        protected TitleBarTabs ParentTabs
        {
            get {
                return (ParentForm as TitleBarTabs);
            }
        }

        
        // when the form is loaded, do something
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // when user utilizes the search bar
        private void SearchBar_Search(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed and the search bar is not empty
            if (e.KeyCode == Keys.Enter && SearchBar.Text != "")
            {
                // Navigate to the entered URL or search query based on the text in the search bar
                if (SearchBar.Text.Contains("http://") || SearchBar.Text.Contains("https://") || SearchBar.Text.Contains("edge://"))
                {
                    webView.Source = new Uri(SearchBar.Text);
                    SearchBar.Text = webView.Source.ToString();
                } 
                else if (SearchBar.Text.Contains(".com") || SearchBar.Text.Contains(".net") || SearchBar.Text.Contains(".org") || SearchBar.Text.Contains(".io") || SearchBar.Text.Contains(".co") || SearchBar.Text.Contains(".tech") || SearchBar.Text.Contains(".xyz") || SearchBar.Text.Contains(".app"))
                { 
                    webView.Source = new Uri("https://" + SearchBar.Text);
                    SearchBar.Text = webView.Source.ToString();
                } 
                else
                {
                    // Allow users to use DuckDuckGo like "bangs" to search for things on specific websites like youtube
                    if (SearchBar.Text.Contains("!Y") || SearchBar.Text.Contains("!y"))
                    {

                        webView.Source = new Uri("https://www.youtube.com/results?search_query=" + SearchBar.Text);
                        SearchBar.Text = webView.Source.ToString();

                    }
                    else // once all else fails, just search using user's default search engine
                    {
                        webView.Source = new Uri(defaultSearch + SearchBar.Text);
                        SearchBar.Text = webView.Source.ToString();
                    }
                    
                }
            }
        }

        // Keyboard Shortcuts
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == historyKey) {
                webView.Source = new Uri("edge://history/");
            }
            if (e.Control && e.KeyCode == downloadsKey)
            {
                webView.Source = new Uri("edge://downloads/");
            }
            if (e.Control && e.KeyCode == refreshKey)
            {
                webView.Refresh();
            }
            if (e.Control && e.KeyCode == backKey)
            {
                webView.GoBack();
            }
            if (e.Control && e.KeyCode == forwardKey)
            {
                webView.GoForward();
            }
            if (e.Control && e.KeyCode == closeKey)
            {
                this.Close();
            }
            if (e.Control && e.KeyCode == settingsKey)
            {
                if (!settingsOpen)
                {
                    settingsOpen = true;
                    settings.Visible = true;
                }
                else 
                {
                    settingsOpen = false;
                    settings.Visible = false;
                }
            }
        }

        // home button to go back to default search engine
        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (defaultSearch == searchEngines[3])
            {
                webView.Source = new Uri("https://moogle.app/");
            }
            else if (defaultSearch == searchEngines[6])
            {
                webView.Source = new Uri("https://ecosia.org/");
            }
            else
            {
                webView.Source = new Uri(defaultSearch);
            }
        }

        // Navigation buttons
            private void BackButton_Click(object sender, EventArgs e)
            {
                if (webView.CanGoBack) {
                    webView.GoBack();
                }
            }

            private void ForwardButton_Click(object sender, EventArgs e)
            {
                if (webView.CanGoForward) {
                    webView.GoForward();
                }
            }

            private void ReloadButton_Click(object sender, EventArgs e)
            {
                webView.Reload();
            }

        // show user downloads
        private void DownloadsButton_Click(object sender, EventArgs e)
        {
            webView.Source = new Uri("edge://downloads/");
        }

        // complete certain actions when the webview is done loading a webpage
        private void webView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            SearchBar.Text = webView.Source.ToString();

            if (darkMode) {
                ReloadButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\ReloadIcon(D-Mode).png");
            }
            else {
                ReloadButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\ReloadIcon.png");
            }

            string title = webView.CoreWebView2.DocumentTitle;

            if (string.IsNullOrWhiteSpace(title))
            {
                this.Text = "New Tab";
            }
            else { 
                this.Text = title;
            }

            // Check if HTTP is Secured (https) or not (http) and show corresponding icon
            if (webView.Source.ToString().Contains("https") || webView.Source.ToString().Contains("edge://"))
            {
                if (!darkMode)
                    SecureImage.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\SecureIcon.png");
                else
                    SecureImage.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\SecureIcon(D-Mode).png");
            }
            else if (webView.Source.ToString().Contains("http")) { 
                if (!darkMode)
                    SecureImage.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\InsecureIcon.png");
                else
                    SecureImage.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\InsecureIcon(D-Mode).png");
            }
        }

        // double click selects entire URL/URI in the search bar
        private void SearchBar_DoubleClick(object sender, EventArgs e)
        {
            SearchBar.SelectAll();
        }

        // open the browser history
        private void HistoryButton_Click(object sender, EventArgs e)
        {
            
            webView.Source = new Uri(" edge://history/");
        }

        // Light and Dark Mode
        private void LDButton_Click(object sender, EventArgs e)
        {
            if (!darkMode)
            {
                mainBar.BackColor = Color.FromArgb(0, 0, 0);
                SearchBar.BackColor = Color.FromArgb(10, 10, 10);
                SearchBar.ForeColor = Color.FromArgb(255, 255, 255);
                SideBar.BackColor = Color.FromArgb(0, 0, 0);
                LDButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\D Mode Icon.png");
                BackButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\BackIcon(D-Mode).png");
                ForwardButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\ForwardIcon(D-Mode).png");
                ReloadButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\ReloadIcon(D-Mode).png");
                HistoryButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\HistoryIcon(D-Mode).png");
                DockButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\MoveIcon(D-Mode).png");
                DownloadsButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\DownloadIcon(D-Mode).png");
                VisibilityButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\FullIcon(D-Mode).png"); 
                FullScreenButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\FullScreen(D-Mode).png");
                HomeButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\HomeIcon(D-Mode).png");
                Surf.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\SurfLogo(D-Mode).png");
                SettingsButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\SettingsGear(D-Mode).png");
                darkMode = true;
            }
            else
            {
                mainBar.BackColor = Color.FromArgb(255, 255, 255);
                SearchBar.BackColor = Color.FromArgb(245, 245, 245);
                SearchBar.ForeColor = Color.FromArgb(0, 0, 0);
                SideBar.BackColor = Color.FromArgb(255, 255, 255);
                LDButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\L Mode Icon.png");
                BackButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\BackIcon.png");
                ForwardButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\ForwardIcon.png");
                ReloadButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\ReloadIcon.png");
                HistoryButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\HistoryIcon.png");
                DockButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\MoveIcon.png");
                VisibilityButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\FullIcon.png");
                FullScreenButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\FullScreen.png");
                DownloadsButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\DownloadIcon.png");
                HomeButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\HomeIcon.png");
                Surf.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\SurfLogo.png");
                SettingsButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\SettingsGear.png");
                darkMode = false;
            }
            if (webView.Source.ToString().Contains("https") || webView.Source.ToString().Contains("edge://"))
            {
                if (!darkMode)
                    SecureImage.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\SecureIcon.png");
                else
                    SecureImage.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\SecureIcon(D-Mode).png");
            }
            else if (webView.Source.ToString().Contains("http"))
            {
                if (!darkMode)
                    SecureImage.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\InsecureIcon.png");
                else
                    SecureImage.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\InsecureIcon(D-Mode).png");
            }
        }

        // change position of the sidebar
        private void DockButton_Click(object sender, EventArgs e)
        {
            switch (SideBar.Dock)
            {
                case DockStyle.Left:
                    SideBar.Dock = DockStyle.Bottom;
                    SideBar.Visible = true;
                    break;
                case DockStyle.Bottom:
                    SideBar.Dock = DockStyle.Right;
                    SideBar.Visible = true;
                    break;
                case DockStyle.Right:
                    SideBar.Dock = DockStyle.Top;
                    SideBar.Visible = true;
                    break;
                default:
                    SideBar.Dock = DockStyle.Left;
                    SideBar.Visible = true;
                    break;
            }
        }

        // Hide the sidebar
        private void VisibilityButton_Click(object sender, EventArgs e)
        {
            
            SideBar.Visible = false;
            ShowSideButton.Visible = true;
            hideSide = true;
            
        }

        // Show the sidebar
        private void ShowSideButton_Click(object sender, EventArgs e)
        {
            SideBar.Visible = true;
            ShowSideButton.Visible = false;
            hideSide = false;
        }

        // complete certain actions when wbview begins navigating to a new page
        private void webView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            
            ReloadButton.Image = Image.FromFile("C:\\Users\\monst\\source\\repos\\Surf\\assets\\ReloadAni.gif");
            string title = webView.CoreWebView2.DocumentTitle;

            if (string.IsNullOrWhiteSpace(title))
            {
                this.Text = "New Tab";
            }
            else
            {
                this.Text = title;
            }
        }

        // enter full screen mode
        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            SideBar.Visible = false;
            mainBar.Visible = false;
            ExitFullscreenButton.Visible = true;
            fullScreen = true;
        }

        // exit full screen mode
        private void ExitFullscreenButton_Click(object sender, EventArgs e)
        {
            SideBar.Visible = true;
            mainBar.Visible = true;
            ExitFullscreenButton.Visible = false;
            fullScreen = false;
        }

        // Enter/Exit Settings
            private void SettingsButton_Click(object sender, EventArgs e)
            {
                settingsOpen = true;
                settings.Visible = true;
            }

            private void ExitSettings_Click(object sender, EventArgs e)
            {
                settingsOpen = false;
                settings.Visible = false;
            }

        // Default Search Engine Buttons
            private void googleButton_Click(object sender, EventArgs e)
            {
                defaultSearch = searchEngines[0];
            }

            private void duckDuckGoButton_Click(object sender, EventArgs e)
            {
                defaultSearch = searchEngines[1];
            }

            private void bingButton_Click(object sender, EventArgs e)
            {
                defaultSearch = searchEngines[2];
            }

            private void moogleButton_Click(object sender, EventArgs e)
            {
                defaultSearch = searchEngines[3];
            }

            private void yahooButton_Click(object sender, EventArgs e)
            {
                defaultSearch = searchEngines[4];
            }

            private void braveButton_Click(object sender, EventArgs e)
            {
                defaultSearch = searchEngines[5];
            }

            private void ecosiaButton_Click(object sender, EventArgs e)
            {
                defaultSearch = searchEngines[6];
            }

            private void baiduButton_Click(object sender, EventArgs e)
            {
                defaultSearch = searchEngines[7];
            }

            private void naverButton_Click(object sender, EventArgs e)
            {
                defaultSearch = searchEngines[8];
            }

            private void yandexButton_Click(object sender, EventArgs e)
            {
                defaultSearch = searchEngines[9];
            }
    }
}
