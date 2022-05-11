using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncAwaitBestPractices;
using System.IO;
using System.Reflection;
using System.Net.Http;
using System.Globalization;

namespace SOR4VSChat
{
    public partial class MainWindow : Form
    {
        // based on https://medium.com/swlh/writing-a-twitch-bot-from-scratch-in-c-f59d9fed10f3
        // 1. Create a bot account if you don't have one yet.
        // 2. Get an OAuth token for your bot from https://twitchapps.com/tmi/.
        // 3. Input your bot's name and your channel name.

        // internal variables
        public Assembly imageAssembly = Assembly.GetExecutingAssembly();

        // class references
        public BotCredentialsForm botCredentialsForm;
        public MainForm mainform;
        public SOR4VSChatLib sor4vschatlib;

        public bool updateAvailable = false;
        string updateurl = "https://raw.githubusercontent.com/honganqi/SOR4VSChat/main/latest.json";
        string downloadURL = "";

        List<string> messageList = new();
        public panels.ChatLog chatWindow;
        Dictionary<string, DateTime> cooldowns = new()
        {
            ["life"] = DateTime.Now,
            ["star"] = DateTime.Now,
            ["gravity"] = DateTime.Now,
            ["size"] = DateTime.Now,
            ["speed"] = DateTime.Now,
            ["health"] = DateTime.Now,
            ["character"] = DateTime.Now,
            ["moves"] = DateTime.Now
        };

        List<string> botCredentialsList = new() {
            "botToken",
            "botNick",
            "channelName",
            "notifNowOnline",
            "notifNoGameYet",
            "botRepliesToFile"
        };

        // window stuff
        public Point lastLocation;

        public MainWindow()
        {
            InitializeComponent();

            botCredentialsForm = new BotCredentialsForm(this) { TopLevel = false, TopMost = true };
            mainform = new MainForm(this) { TopLevel = false, TopMost = true };
            chatWindow = new panels.ChatLog(this);
            SOR4VSChatLib sor4vschatlib = new();
            sor4vschatlib.characters = SOR4Bot.characters;

            panelLeft.BackColor = Color.FromArgb(33, 33, 33);
            btnMinimize.BackColor = Color.FromArgb(33, 33, 33);
            btnClose.BackColor = Color.FromArgb(33, 33, 33);

            string currentVerString = Application.ProductVersion;
            List<string> currentVersionSplit = currentVerString.Split('.').ToList();
            if (currentVersionSplit[3] == "0") currentVersionSplit.RemoveAt(3);
            if (currentVersionSplit[2] == "0") currentVersionSplit.RemoveAt(2);
            labelVerNum.Text = "v" + string.Join(".", currentVersionSplit) + " by honganqi";

            Stream thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.bmc.png");
            Bitmap thumbBitmap = new(thumbStream);
            imgBMCSupport.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.sflogo.png");
            thumbBitmap = new(thumbStream);
            imgSF.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.youtube.png");
            thumbBitmap = new(thumbStream);
            imgYoutube.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.twitch.png");
            thumbBitmap = new(thumbStream);
            imgTwitch.Image = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.help.png");
            thumbBitmap = new(thumbStream);
            btnGravityPanel.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.exit.png");
            thumbBitmap = new(thumbStream);
            btnClose.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.min.png");
            thumbBitmap = new(thumbStream);
            btnMinimize.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.settings.png");
            thumbBitmap = new(thumbStream);
            btnBotCredentials.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.gravity.png");
            thumbBitmap = new(thumbStream);
            btnGravityPanel.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.size.png");
            thumbBitmap = new(thumbStream);
            btnSizePanel.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.speed.png");
            thumbBitmap = new(thumbStream);
            btnSpeedPanel.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.lives.png");
            thumbBitmap = new(thumbStream);
            btnLivesPanel.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.health.png");
            thumbBitmap = new(thumbStream);
            btnHealthPanel.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.save.png");
            thumbBitmap = new(thumbStream);
            mainform.btnSaveSettings.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.settings_sm.png");
            thumbBitmap = new(thumbStream);
            mainform.btnBotSettings.BackgroundImage = thumbBitmap;

            thumbStream = imageAssembly.GetManifestResourceStream("SOR4VSChat.img.character.png");
            thumbBitmap = new(thumbStream);
            btnCharPanel.BackgroundImage = thumbBitmap;

            CheckUpdate(updateurl);

            SwitchPanel("main");
            mainform.SwitchPanel("lives");
            CheckSettings();
            ReadAllSettings();
            ClearBotReplies();
        }

        public async void CheckUpdate(string url)
        {
            List<string> onlineVer = new();
            List<string> currentVer = new();
            var client = new HttpClient();
            var request = client.GetAsync(url);

            Task timeout = Task.Delay(3000);
            await Task.WhenAny(timeout, request);

            try
            {
                HttpResponseMessage response = request.Result;
                if (response.IsSuccessStatusCode)
                {
                    var page = response.Content.ReadAsStringAsync();
                    var queryResult = Newtonsoft.Json.JsonConvert.DeserializeObject<SOR4Bot.VersionClass>(page.Result);

                    if ((queryResult != null) && (queryResult.ReleaseDate != null))
                    {
                        DateTime releaseDate = DateTime.Parse(queryResult.ReleaseDate).ToUniversalTime();
                        string onlineVerString = queryResult.Version;
                        string currentVerString = Application.ProductVersion;
                        downloadURL = queryResult.DownloadURL;
                        if (onlineVerString.CompareTo(currentVerString) > 0)
                        {
                            List<string> versionSplit = onlineVerString.Split('.').ToList();
                            if (versionSplit[3] == "0") versionSplit.RemoveAt(3);
                            if (versionSplit[2] == "0") versionSplit.RemoveAt(2);
                            onlineVer.Add(string.Join(".", versionSplit));
                            onlineVer.Add(releaseDate.ToLocalTime().ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern));
                            btnUpdateNotif.Text = "v" + onlineVer[0] + " is now available!\nGET IT NOW!";
                            if (queryResult.Description != "")
                            {
                                ToolTip updateTooltip = new();
                                updateTooltip.SetToolTip(btnUpdateNotif, "Download from: " + queryResult.DownloadURL + "\n\n" + queryResult.Description);
                            }

                            versionSplit = new(currentVerString.Split('.').ToList());
                            if (versionSplit[3] == "0") versionSplit.RemoveAt(3);
                            if (versionSplit[2] == "0") versionSplit.RemoveAt(2);
                            currentVer.Add(string.Join(".", versionSplit));
                            currentVer.Add(releaseDate.ToLocalTime().ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern));
                            btnUpdateNotif.Show();
                        }
                    }
                }
                else
                {
                    switch (response.StatusCode)
                    {
                        case System.Net.HttpStatusCode.NotFound:
                            throw new Exception("The update file was not found on the server.");
                        case System.Net.HttpStatusCode.BadRequest:
                            throw new Exception("");
                        case System.Net.HttpStatusCode.InternalServerError:
                            throw new Exception("");
                        case System.Net.HttpStatusCode.MethodNotAllowed:
                            throw new Exception("");
                        case System.Net.HttpStatusCode.Forbidden:
                            throw new Exception("");
                    }
                }
            }
            catch (HttpRequestException)
            {
                throw;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        public void GetUpdate()
        {
            if (downloadURL != "") System.Diagnostics.Process.Start(downloadURL);
        }


        public async Task<TwitchBot> StartBot()
        {
            string botToken = ReadSetting("botToken");
            string botNick = ReadSetting("botNick").ToLower();
            string channelName = ReadSetting("channelName").ToLower();
            string notifNowOnline = ReadSetting("notifNowOnline");
            string notifNoGameYet = ReadSetting("notifNoGameYet");

            TwitchBot twitchBot = new(botNick, botToken);
            twitchBot.Start(this).SafeFireAndForget();
            //We could .SafeFireAndForget() these two calls if we want to
            await twitchBot.JoinChannel(channelName);
            await twitchBot.SendMessage(channelName, notifNowOnline);
            mainform.UpdateUI("start");
            //ClearBotReplies();
            messageList.Add("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] Bot is now online");
            if (messageList.Count() > 3000) messageList.Remove(messageList[0]);
            chatWindow.txtChatLog.Text = string.Join(Environment.NewLine, messageList);
            SOR4Bot sor4bot = new();


            twitchBot.OnMessage += async (sender, twitchChatMessage) =>
            {
                //Listen for commands
                string tryCommand = twitchChatMessage.Message;
                string[] commandpair;
                if (tryCommand.StartsWith("!"))
                {
                    commandpair = CheckCommandIfExistAndEnabled(tryCommand);
                    Dictionary<string, Dictionary<int, int>> gameValues = sor4bot.CheckValues();
                    if (gameValues.Count > 0)
                    {
                        // fetch only LIFE for now
                        foreach (KeyValuePair<int, int> pair in gameValues["life"])
                        {
                            UpdateOverlayValues(pair.Key, "life", pair.Value);
                        }
                    }
                    else
                    {
                        for (int player_no = 1; player_no <= 4; player_no++)
                        {
                            UpdateOverlayValues(player_no, "life", null);
                        }
                    }
                    string newMessage = "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] " + twitchChatMessage.Sender + ": ";
                    if (commandpair != null)
                    {
                        string botresponse = "";
                        switch (commandpair[0])
                        {
                            case "commandlist":
                                botresponse = commandpair[1];
                                newMessage += botresponse;
                                break;
                            case "cooldown":
                                botresponse = "\"" + commandpair[1] + "\" on cooldown";
                                newMessage += botresponse;
                                break;
                            case "disabled":
                                botresponse = "\"" + commandpair[1] + "\" not enabled";
                                newMessage += botresponse;
                                break;
                            default:
                                // need to execute command based on the string that "functionname" returns
                                botresponse = sor4bot.RunCommand(this, commandpair, twitchChatMessage.Sender);
                                if (botresponse == "false12345false")
                                {
                                    newMessage += "Game not found or level not yet loaded";
                                    botresponse = notifNoGameYet;
                                }
                                else
                                {
                                    newMessage += commandpair[0];
                                    if (commandpair.Count() > 1) newMessage += " (" + commandpair[1] + ")";

                                }

                                break;
                        }
                        if (botCredentialsForm.chkBotRepliesToFile.Checked && (commandpair[0] != "commandlist"))
                        {
                            SendBotRepliesToFile($"{botresponse}");
                        }
                        else
                        {
                            await twitchBot.SendMessage(twitchChatMessage.Channel, $"{botresponse}");
                        }
                    }
                    else
                    {
                        //await twitchBot.SendMessage(twitchChatMessage.Channel, $"Hey there {twitchChatMessage.Sender}");
                        string[] commandsarray = tryCommand.ToLower().Trim().Trim('!').Split(' ');
                        if (commandsarray.Length > 0) newMessage += "\"" + commandsarray[0] + "\" not found";
                    }
                    // output to command log
                    if (commandpair == null || commandpair[0] != "commandlist")
                    {
                        messageList.Add(newMessage);
                        if (messageList.Count() > 3000) messageList.Remove(messageList[0]);
                        chatWindow.txtChatLog.Text = string.Join(Environment.NewLine, messageList);
                    }
                }

            };

            await Task.Delay(-1);
            return twitchBot;
        }

        public static string ReadSetting(string key)
        {
            string result;
            try
            {
                NameValueCollection appSettings = ConfigurationManager.AppSettings;
                result = appSettings[key] ?? "";
            }
            catch (ConfigurationErrorsException)
            {
                result = "";
            }
            return result;
        }

        private void ReadAllSettings()
        {
            Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;

            List<Form> panels = new List<Form> {
                mainform.panelLives, mainform.panelSpeed, mainform.panelSize, mainform.panelGravity, mainform.panelHealth, mainform.panelCharacters
            };

            foreach (Form form in panels)
            {
                CheckBox[] checkboxes = form.Controls.OfType<CheckBox>().ToArray();
                TextBox[] textboxes = form.Controls.OfType<TextBox>().ToArray();
                foreach (CheckBox control in checkboxes)
                {
                    if (settings[control.Name] != null)
                    {
                        string value = settings[control.Name].Value;
                        ((CheckBox)control).Checked = Convert.ToBoolean(value);
                    }
                }
                foreach (TextBox control in textboxes)
                {
                    if (settings[control.Name] != null)
                    {
                        control.Text = settings[control.Name].Value;
                    }
                }
            }
        }

        public bool CheckSettings()
        {
            string botToken = ReadSetting("botToken");
            string botNick = ReadSetting("botNick");
            string channelName = ReadSetting("channelName");
            string notifNowOnline = ReadSetting("notifNowOnline");
            string notifNoGameYet = ReadSetting("notifNoGameYet");
            string botRepliesToFile = ReadSetting("botRepliesToFile");

            Dictionary<string, string> settings = new()
            {
                ["botToken"] = botToken,
                ["botNick"] = botNick,
                ["channelName"] = channelName,
                ["notifNowOnline"] = notifNowOnline,
                ["notifNoGameYet"] = notifNoGameYet,
                ["botRepliesToFile"] = botRepliesToFile,
            };
            botCredentialsForm.FillBotSettings(settings);

            if (botToken.Trim() == "" || botNick.Trim() == "" || channelName.Trim() == "")
            {
                MessageBox.Show("Bot hasn't been fully configured yet. Please input the following details.", "Bot Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBotCredentials.Location = new Point(10, 10);
                SwitchPanel("botcredentials");
                return false;
            }
            else
            {
                btnLivesPanel.Visible = true;
                btnSpeedPanel.Visible = true;
                btnSizePanel.Visible = true;
                btnGravityPanel.Visible = true;
                btnHealthPanel.Visible = true;
                btnCharPanel.Visible = true;

                btnBotCredentials.Visible = false;
                btnBotCredentials.Location = new Point(10, 670);

                return true;
            }
        }

        public void SaveSettings()
        {
            try
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;

                // process bot credentials
                Dictionary<string, string> botCredentials = botCredentialsForm.BotCredentials();
                if (botCredentials["botRepliesToFile"] == "True")
                {
                    string filename = "SOR4VSChat_botreplies.txt";
                    if (!File.Exists(filename)) File.Create(filename).Close();
                }
                foreach (string setting in botCredentialsList)
                {
                    if (settings[setting] == null)
                    {
                        settings.Add(setting, botCredentials[setting]);
                    }
                    else
                    {
                        settings[setting].Value = botCredentials[setting];
                    }
                }

                List<Form> panels = new() {
                    mainform.panelLives, mainform.panelSpeed, mainform.panelSize, mainform.panelGravity, mainform.panelHealth, mainform.panelCharacters
                };

                foreach (Form form in panels)
                {
                    CheckBox[] checkboxes = form.Controls.OfType<CheckBox>().ToArray();
                    TextBox[] textboxes = form.Controls.OfType<TextBox>().ToArray();
                    foreach (CheckBox control in checkboxes)
                    {
                        if (settings[control.Name] == null)
                        {
                            settings.Add(control.Name, control.Checked.ToString());
                        }
                        else
                        {
                            settings[control.Name].Value = control.Checked.ToString();
                        }
                    }
                    foreach (TextBox control in textboxes)
                    {
                        if (settings[control.Name] == null)
                        {
                            settings.Add(control.Name, control.Text);
                        }
                        else
                        {
                            settings[control.Name].Value = control.Text;
                        }
                    }
                }

                // process bot settings

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CheckSettings();
            }
            catch (ConfigurationErrorsException)
            {
                System.Console.WriteLine("Error writing app settings");
            }
        }

        public void SwitchPanel(string panelname)
        {
            activePanel.Visible = false;
            activePanel.Controls.Clear();
            switch (panelname)
            {
                case "main":
                    activePanel.Controls.Add(mainform);
                    mainform.Show();
                    break;
                case "botcredentials":
                    activePanel.Controls.Add(botCredentialsForm);
                    botCredentialsForm.Show();
                    break;
            }
            activePanel.Visible = true;
        }

        private string[] CheckCommandIfExistAndEnabled(string commandstring)
        {
            string[] commandsarray = commandstring.ToLower().Trim().Trim('!').Split(' ');
            string command = commandsarray[0];
            string[] commandpair;
            bool paramAttempt = false;
            bool paramCheck = false;
            bool withCommand = false;
            int cooldown = 0;
            int difference = 0;
            if (commandsarray.Count() > 1)
            {
                commandpair = new string[2];
                commandpair[0] = command;
                commandpair[1] = commandsarray[1];
            }
            else
            {
                commandpair = new string[1];
                commandpair[0] = command;
            }
            if (SOR4Bot.botCommandsList.ContainsKey(command))
            {
                Control[] controls = new Control[] { };
                string item = SOR4Bot.botCommandsList[command].Category;
                if (SOR4Bot.botCommandsList[command].Command != null)
                {
                    withCommand = true;
                }
                else if (item != "character")
                {
                    command = item + SOR4Bot.botCommandsList[command].ChangeValue;
                }

                // get cooldown info
                cooldown = mainform.panelLives.GetCooldown(item);
                difference = (int)DateTime.Now.Subtract(cooldowns[item]).TotalSeconds;

                if (difference - cooldown >= 0)
                {
                    cooldowns[item] = DateTime.Now;
                    switch (item)
                    {
                        case "life":
                        case "star":
                            controls = mainform.panelLives.Controls.Find("chk_" + command, true);
                            // if not resetting or randomizing, then maybe attempting to use parameters for this item
                            if ((withCommand == false) && (commandpair.Count() > 1))
                            {
                                paramAttempt = true;
                                Control[] paramControls = mainform.panelLives.Controls.Find("chk_" + command + "param", true);
                                if (paramControls.Length > 0)
                                {
                                    if ((paramControls[0] as CheckBox)?.Checked == true) paramCheck = true;
                                }
                            }
                            break;
                        case "size":
                            controls = mainform.panelSize.Controls.Find("chk_" + command, true);
                            break;
                        case "speed":
                            controls = mainform.panelSpeed.Controls.Find("chk_" + command, true);
                            break;
                        case "gravity":
                            controls = mainform.panelGravity.Controls.Find("chk_" + command, true);
                            break;
                        case "health":
                            controls = mainform.panelHealth.Controls.Find("chk_" + command, true);
                            break;
                        case "character":
                            controls = mainform.panelCharacters.Controls.Find("chk_" + command, true);
                            if ((command != "randomchar") && (commandpair.Count() > 1))
                            {
                                paramAttempt = true;
                                Control[] paramControls = mainform.panelCharacters.Controls.Find("chk_character" + commandpair[1], true);
                                if (paramControls.Length > 0)
                                {
                                    if ((paramControls[0] as CheckBox)?.Checked == true)
                                    {
                                        paramCheck = true;
                                    }
                                }
                            }
                            break;
                        case "moves":
                            controls = mainform.panelCharacters.Controls.Find("chk_" + command, true);
                            break;
                    }
                }
                else
                {
                    // if command is on cooldown
                    commandpair = new string[2];
                    commandpair[0] = "cooldown";
                    commandpair[1] = commandsarray[0];
                    return commandpair;
                }

                if (controls.Length > 0)
                {
                    if ((controls[0] as CheckBox)?.Checked == true)
                    {
                        if (paramAttempt == true)
                        {
                            if (paramCheck == true)
                            {
                                return commandpair;
                            }
                            else
                            {
                                return null;
                            }
                        }
                        else
                        {
                            return commandpair;
                        }
                    }
                    else
                    {
                        commandpair = new string[2];
                        commandpair[0] = "disabled";
                        commandpair[1] = commandsarray[0];
                    }
                    return null;
                }
                return null;
            }
            else
            {
                if (command == "vs" || command == "vschat")
                {
                    commandpair = new string[2];
                    commandpair[0] = "commandlist";
                    commandpair[1] = "VS Chat command list: ";
                    string previousItem = "";
                    foreach (string actualcommand in SOR4Bot.botCommandsList.Keys)
                    {
                        string[] result = CheckCommandIfExistAndEnabled(actualcommand);
                        if (result != null)
                        {
                            // only other possibilities are:
                            // "not found" (impossible since coming from list)
                            // "null" (checked above)
                            // "commandlist"  (impossible since coming from list)
                            // else this is going to be the command itself
                            if (result[0] != "disabled")
                            {

                                if (previousItem != "" && previousItem != SOR4Bot.botCommandsList[actualcommand].Category) commandpair[1] += "|| ";
                                commandpair[1] += "!" + result[0] + " ";
                                // if either a reset or a random
                                if (SOR4Bot.botCommandsList[actualcommand].Command != null)
                                {
                                    commandpair[1] += "(" + SOR4Bot.botCommandsList[actualcommand].Command + ") ";
                                }
                                if (SOR4Bot.botCommandsList[actualcommand].Parameters != null)
                                {
                                    Control[] paramControls = new Control[0];
                                    string parameterName = "";
                                    // need to check if parameter checkbox is enabled
                                    switch (SOR4Bot.botCommandsList[actualcommand].Category)
                                    {
                                        case "life":
                                        case "star":
                                            if (SOR4Bot.botCommandsList[actualcommand].Category == "life")
                                            {
                                                parameterName = "[lives] ";
                                            }
                                            else
                                            {
                                                parameterName = "[stars] ";
                                            }
                                            paramControls = mainform.panelLives.Controls.Find("chk_" + SOR4Bot.botCommandsList[actualcommand].Category + SOR4Bot.botCommandsList[actualcommand].ChangeValue + "param", true);
                                            break;
                                        case "character":
                                            paramControls = mainform.panelCharacters.Controls.Find("chk_char", true);
                                            parameterName = "[char name] ";
                                            break;
                                    }
                                    if (paramControls.Length > 0)
                                    {
                                        if ((paramControls[0] as CheckBox)?.Checked == true) commandpair[1] += parameterName;
                                    }
                                }
                                previousItem = SOR4Bot.botCommandsList[actualcommand].Category;
                            }
                        }
                    }
                    commandpair[1] = commandpair[1].Substring(0, commandpair[1].LastIndexOf("|| "));
                    if (commandpair[1].Length > 500) commandpair[1] = commandpair[1].Substring(0, 500);
                    return commandpair;
                }
            }
            return null;
        }

        public string GetBotResponse(string item, string command, string chatsender, int replyValue, string replyCurrent)
        {
            Control[] controls = new Control[] { };

            string textBoxName = "txt_" + command;
            switch (item)
            {
                case "life":
                case "star":
                    controls = mainform.panelLives.Controls.Find(textBoxName, true);
                    break;
                case "size":
                    controls = mainform.panelSize.Controls.Find(textBoxName, true);
                    break;
                case "speed":
                    controls = mainform.panelSpeed.Controls.Find(textBoxName, true);
                    break;
                case "gravity":
                    controls = mainform.panelGravity.Controls.Find(textBoxName, true);
                    break;
                case "health":
                    controls = mainform.panelHealth.Controls.Find(textBoxName, true);
                    break;
                case "character":
                    controls = mainform.panelCharacters.Controls.Find(textBoxName, true);
                    break;
                case "moves":
                    controls = mainform.panelCharacters.Controls.Find(textBoxName, true);
                    break;
            }

            // if control/textbox is found
            if (controls.Length > 0)
            {
                string botreply = controls[0].Text;
                if (botreply.Contains('{') && botreply.Contains('}'))
                {
                    int from = botreply.IndexOf('{') + 1;
                    int to = botreply.IndexOf('}');
                    string result = botreply.Substring(from, to - from);
                    string field = FormatReplyParameters(botreply);
                    if (field != "")
                    {
                        string insertString = "";
                        switch (field)
                        {
                            case "sender":
                                insertString = "@" + chatsender;
                                break;
                            case "value":
                                insertString = "0";
                                break;
                            case "current":
                                insertString = replyCurrent;
                                break;
                        }
                        botreply = botreply.Remove(from - 1, result.Length + 2);
                        botreply = botreply.Insert(from - 1, insertString);
                    }
                }
                return botreply;
            }

            return "";
        }

        private string FormatReplyParameters(string botreply)
        {
            string reply = botreply;
            int from = botreply.IndexOf('{') + 1;
            int to = botreply.IndexOf('}');
            string field = botreply.Substring(from, to - from);
            if (field != "") reply = field;
            return reply;
        }

        private void SendBotRepliesToFile(string botreply)
        {
            string filename = "SOR4VSChat_botreplies.txt";
            if (!File.Exists(filename)) File.Create(filename).Close();
            string[] oldlines = File.ReadAllLines(filename).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToArray();
            int newline_count = 3;
            if (oldlines.Count() < 3) newline_count = oldlines.Count() + 1;
            string[] newlines = new string[newline_count];
            int linectr = 0;
            if (oldlines.Count() > 0)
            {
                foreach (string line in oldlines)
                {
                    if (linectr < 2)
                    {
                        if (oldlines.Count() >= 3)
                        {
                            newlines[linectr++] = oldlines[linectr];
                        }
                        else
                        {
                            newlines[linectr++] = line;
                        }
                    }

                }
            }
            newlines[linectr] = botreply;
            File.WriteAllLines(filename, newlines);
        }

        private void ClearBotReplies()
        {
            List<string> items = new()
            {
                "life",
                /*
                "star",
                "health",
                "speed",
                "size",
                "gravity",
                "character",
                "moves"
                */
            };
            string filename = "";
            for (int player_no = 1; player_no <= 4; player_no++)
            {
                foreach (string item in items)
                {
                    filename = "response_p" + player_no + "_" + item + ".txt";
                    if (!File.Exists(filename))
                    {
                        File.Create(filename).Close();
                    }
                    else
                    {
                        File.WriteAllText(filename, string.Empty);
                    }
                }
            }
            filename = "SOR4VSChat_botreplies.txt";
            if (!File.Exists(filename)) File.Create(filename).Close();
            File.WriteAllText(filename, string.Empty);

        }

        public void SendFeedback(string feedback)
        {
            //string filename = "response_p" + player_no + "_" + item + ".txt";
            string filename = "response_feedback.txt";
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
            }
            else
            {
                DateTime dt1 = DateTime.Now;
                feedback = dt1.ToString() + "\n" + feedback;
                File.WriteAllText(filename, feedback);
            }
        }

        public void UpdateOverlayValues(int player_no, string item, int? value)
        {
            string filename = "response_p" + player_no + "_" + item + ".txt";
            //string filename = "response_feedback.txt";
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
            }
            else
            {
                File.WriteAllText(filename, value.ToString());
            }
        }

        private void vSChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchPanel("main");
        }

        private void botLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchPanel("botcredentials");
        }

        private void btnBotCredentials_Click(object sender, EventArgs e)
        {
            SwitchPanel("botcredentials");
        }

        private void btnLivesPanel_Click(object sender, EventArgs e)
        {
            if (!activePanel.Controls.Contains(mainform)) SwitchPanel("main");
            mainform.SwitchPanel("lives");
        }

        private void btnSpeedPanel_Click(object sender, EventArgs e)
        {
            if (!activePanel.Controls.Contains(mainform)) SwitchPanel("main");
            mainform.SwitchPanel("speed");
        }

        private void btnSizePanel_Click(object sender, EventArgs e)
        {
            if (!activePanel.Controls.Contains(mainform)) SwitchPanel("main");
            mainform.SwitchPanel("size");

        }

        private void btnGravityPanel_Click(object sender, EventArgs e)
        {
            if (!activePanel.Controls.Contains(mainform)) SwitchPanel("main");
            mainform.SwitchPanel("gravity");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // window movement stuff
        public void MoveWindow(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - lastLocation.X;
                int dy = e.Location.Y - lastLocation.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            //lastLocation = e.Location;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            //MoveWindow(e);
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void panelLeft_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            //lastLocation = e.Location;
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            //MoveWindow(e);
        }

        private void labelAuthor_MouseDown(object sender, MouseEventArgs e)
        {
            // lastLocation = e.Location;
        }

        private void labelAuthor_MouseMove(object sender, MouseEventArgs e)
        {
            //MoveWindow(e);
        }

        private void activePanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void activePanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnHealthPanel_Click(object sender, EventArgs e)
        {
            if (!activePanel.Controls.Contains(mainform)) SwitchPanel("main");
            mainform.SwitchPanel("health");
        }

        private void btnCharPanel_Click(object sender, EventArgs e)
        {
            if (!activePanel.Controls.Contains(mainform)) SwitchPanel("main");
            mainform.SwitchPanel("character");
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exitAsk = MessageBox.Show("You sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (exitAsk == DialogResult.No);
        }

        private void imgSF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sourceforge.net/projects/sor4-vs-chat/");
        }

        public void AttemptOnlineThrowError()
        {
            mainform.UpdateUI("reset");
            MessageBox.Show("Bot failed to start. Please restart this app."); 
        }
    }
}
