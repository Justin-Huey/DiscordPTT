using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace DiscordPTT
{
    public partial class Form1 : MetroForm
    {
        private bool ptt = true;

        public Form1()
        {
            InitializeComponent();
            string theme = ConfigurationManager.AppSettings["theme"].ToLower();
            switch (theme)
            {
                case "dark":
                    Theme = MetroThemeStyle.Dark;
                    break;
                case "light":
                    Theme = MetroThemeStyle.Light;
                    break;
                default:
                    Theme = MetroThemeStyle.Dark;
                    MetroMessageBox.Show(this, "You need to look at your theme in the config! Re-read the read-me file for more info!", "Theme Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    break;
            }

            string color = ConfigurationManager.AppSettings["color"].ToLower();
            switch (color)
            {
                case "lime":
                    Style = MetroColorStyle.Lime;
                    break;
                case "black":
                    Style = MetroColorStyle.Black;
                    break;
                case "blue":
                    Style = MetroColorStyle.Blue;
                    break;
                case "brown":
                    Style = MetroColorStyle.Brown;
                    break;
                case "green":
                    Style = MetroColorStyle.Green;
                    break;
                case "magenta":
                    Style = MetroColorStyle.Magenta;
                    break;
                case "orange":
                    Style = MetroColorStyle.Orange;
                    break;
                case "pink":
                    Style = MetroColorStyle.Pink;
                    break;
                case "purple":
                    Style = MetroColorStyle.Purple;
                    break;
                case "red":
                    Style = MetroColorStyle.Red;
                    break;
                case "silver":
                    Style = MetroColorStyle.Silver;
                    break;
                case "teal":
                    Style = MetroColorStyle.Teal;
                    break;
                case "white":
                    Style = MetroColorStyle.White;
                    break;
                case "yellow":
                    Style = MetroColorStyle.Yellow;
                    break;
                default:
                    Style = MetroColorStyle.Lime;
                    MetroMessageBox.Show(this, "You need to look at your color in the config! Re-read the read-me file for more info!", "Color Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    break;
            }

            if(Theme == MetroThemeStyle.Dark)
            {
                PTTButton.BackgroundImage = Properties.Resources.talkingLight;
            } 
            else
            {
                PTTButton.BackgroundImage = Properties.Resources.talkingDark;
            }
        }

        private void PTTButton_Click(object sender, EventArgs e)
        {
            string keybind = ConfigurationManager.AppSettings["keybind"].ToUpper();
            string modifierstring = ConfigurationManager.AppSettings["keybind modifier"];
            string modifier;


            bool pass = keybind.All(char.IsLetterOrDigit);

            if (!(pass))
            {
                MetroMessageBox.Show(this, "You need to look at your keybind in the config! Re-read the read-me file for more info!", "Keybind Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            } 


            switch (modifierstring)
            {
                case "SHIFT":
                    modifier = "+";
                    break;
                case "CTRL":
                    modifier = "^";
                    break;
                case "ALT":
                    modifier = "%";
                    break;
                default:
                    modifier = "!!!!!!!";
                    break;
            }

            if (modifier.Equals("!!!!!!!"))
            {
                MetroMessageBox.Show(this, "You need to look at your modifier in the config! It needs to be (SHIFT, CTRL, or ALT)", "Modifier Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (!(keybind.Length.Equals(1)))
                {
                    MetroMessageBox.Show(this, "You need to look at your keybind in the config! It needs to be one letter!", "Keybind Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    SendKeys.Send($"{modifier}({keybind})");
                    if (!ptt)
                    {
                        ptt = true;
                        if (Theme == MetroThemeStyle.Dark)
                        {
                            PTTButton.BackgroundImage = Properties.Resources.talkingLight;
                        }
                        else
                        {
                            PTTButton.BackgroundImage = Properties.Resources.talkingDark;
                        }
                    }
                    else
                    {
                        ptt = false;
                        if (Theme == MetroThemeStyle.Dark)
                        {
                            PTTButton.BackgroundImage = Properties.Resources.mutedLight;
                        }
                        else
                        {
                            PTTButton.BackgroundImage = Properties.Resources.mutedDark;
                        }
                    }
                }
            }
        }
    }
}
