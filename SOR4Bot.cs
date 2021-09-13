using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SOR4VSChat
{
    public class SOR4Bot
    {
        SOR4VSChatLib sor4vschatlib = new SOR4VSChatLib();
        Random randomgenerator = new Random();

        public class CommandObject
        {
            public string Category { get; set; }
            public string Command { get; set; }
            public int ChangeValue { get; set; }
            public bool? Parameters { get; set; }
        }

        public static Dictionary<string, CommandObject> botCommandsList = new Dictionary<string, CommandObject>()
        {
            ["lifeup"] = new CommandObject { Category = "life", ChangeValue = 1, Parameters = true, },
            ["lifedown"] = new CommandObject { Category = "life", ChangeValue = 0, Parameters = true, },
            ["life"] = new CommandObject { Category = "life", Command = "random" },
            ["addstar"] = new CommandObject { Category = "star", ChangeValue = 1, Parameters = true, },
            ["removestar"] = new CommandObject { Category = "star", ChangeValue = 0, Parameters = true, },
            ["star"] = new CommandObject { Category = "star", Command = "random" },
            ["helium"] = new CommandObject { Category = "gravity", ChangeValue = 0 },
            ["moon"] = new CommandObject { Category = "gravity", ChangeValue = 1 },
            ["jupiter"] = new CommandObject { Category = "gravity", ChangeValue = 2 },
            ["nojumping"] = new CommandObject { Category = "gravity", ChangeValue = 3 },
            ["gravity"] = new CommandObject { Category = "gravity", Command = "random" },
            ["resetgravity"] = new CommandObject { Category = "gravity", Command = "reset" },
            ["antman"] = new CommandObject { Category = "size", ChangeValue = 0 },
            ["toddler"] = new CommandObject { Category = "size", ChangeValue = 1 },
            ["kiddo"] = new CommandObject { Category = "size", ChangeValue = 2 },
            ["downsize"] = new CommandObject { Category = "size", ChangeValue = 3 },
            ["grow"] = new CommandObject { Category = "size", ChangeValue = 4 },
            ["titan"] = new CommandObject { Category = "size", ChangeValue = 5 },
            ["resize"] = new CommandObject { Category = "size", Command = "random" },
            ["resetsize"] = new CommandObject { Category = "size", Command = "reset" },
            ["teleport"] = new CommandObject { Category = "speed", ChangeValue = 0 },
            ["fastest"] = new CommandObject { Category = "speed", ChangeValue = 1 },
            ["faster"] = new CommandObject { Category = "speed", ChangeValue = 2 },
            ["fast"] = new CommandObject { Category = "speed", ChangeValue = 3 },
            ["slow"] = new CommandObject { Category = "speed", ChangeValue = 4 },
            ["slower"] = new CommandObject { Category = "speed", ChangeValue = 5 },
            ["moonwalk"] = new CommandObject { Category = "speed", ChangeValue = 6 },
            ["speed"] = new CommandObject { Category = "speed", Command = "random" },
            ["resetspeed"] = new CommandObject { Category = "speed", Command = "reset" },
            ["resurrection"] = new CommandObject { Category = "health", ChangeValue = 0 },
            ["organics"] = new CommandObject { Category = "health", ChangeValue = 1 },
            ["fastfood"] = new CommandObject { Category = "health", ChangeValue = 2 },
            ["5050"] = new CommandObject { Category = "health", ChangeValue = 3 },
            ["dying"] = new CommandObject { Category = "health", ChangeValue = 4 },
            ["dead"] = new CommandObject { Category = "health", ChangeValue = 5 },
            ["kill"] = new CommandObject { Category = "health", ChangeValue = 6 },
            ["health"] = new CommandObject { Category = "health", Command = "random" },
            ["randomchar"] = new CommandObject { Category = "character", Command = "random" },
            ["mixitup"] = new CommandObject { Category = "moves", Command = "random" },
            ["char"] = new CommandObject { Category = "character", Parameters = true },
        };

        public static Dictionary<int, SOR4VSChatLib.CharacterSpeed> characters = new Dictionary<int, SOR4VSChatLib.CharacterSpeed>
        {
            [1] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4784, SpeedY = 2818, SpeedJump = 7864 },
            [2] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4915, SpeedY = 2949, SpeedJump = 8519 },
            [3] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4784, SpeedY = 2686, SpeedJump = 8519 },
            [4] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 3932, SpeedY = 2490, SpeedJump = 8519 },
            [5] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4849, SpeedY = 2621, SpeedJump = 7208 },
            [19] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4784, SpeedY = 2818, SpeedJump = 7208 },
            [20] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4259, SpeedY = 2949, SpeedJump = 6553 },
            [21] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4784, SpeedY = 4128, SpeedJump = 7208 },
            [8] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4587, SpeedY = 2490, SpeedJump = 7208 },
            [6] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 5242, SpeedY = 3276, SpeedJump = 8519 },
            [7] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4586, SpeedY = 2490, SpeedJump = 7208 },
            [11] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4587, SpeedY = 2490, SpeedJump = 7208 },
            [10] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4915, SpeedY = 2949, SpeedJump = 8519 },
            [12] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4259, SpeedY = 1966, SpeedJump = 6553 },
            [9] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4915, SpeedY = 2949, SpeedJump = 7864 },
            [13] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4587, SpeedY = 2490, SpeedJump = 7208 },
            [14] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4915, SpeedY = 2949, SpeedJump = 8519 },
            [16] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4915, SpeedY = 2949, SpeedJump = 7864 },
            [17] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4849, SpeedY = 2883, SpeedJump = 6553 },
            [18] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 4915, SpeedY = 3932, SpeedJump = 7864 },
            [15] = new SOR4VSChatLib.CharacterSpeed { SpeedX = 5242, SpeedY = 2621, SpeedJump = 6553 },
        };

        private Dictionary<string, int> characterIDs = new Dictionary<string, int>
        {
            ["axel"] = 1,
            ["blaze"] = 2,
            ["cherry"] = 3,
            ["floyd"] = 4,
            ["adam"] = 5,
            ["blaze1"] = 6,
            ["adam1"] = 7,
            ["axel1"] = 8,
            ["skate2"] = 9,
            ["blaze2"] = 10,
            ["axel2"] = 11,
            ["max2"] = 12,
            ["axel3"] = 13,
            ["blaze3"] = 14,
            ["roo"] = 15,
            ["skate3"] = 16,
            ["zan"] = 17,
            ["shiva3"] = 18,
            ["estel"] = 19,
            ["max"] = 20,
            ["shiva"] = 21,
       };

        public string RunCommand(MainWindow mainwindow, string[] commandpair, string chatsender)
        {
            string response = "false12345false";
            int no_of_players = sor4vschatlib.CheckNumPlayers();
            string command = commandpair[0];
            if (no_of_players > 0)
            {
                for (int player_no = 1; player_no <= no_of_players; player_no++)
                {
                    int? newValue = null;
                    if (botCommandsList.ContainsKey(command))
                    {
                        string item = botCommandsList[command].Category;
                        string mode = "";
                        if (botCommandsList[command].Command != null)
                        {
                            mode = botCommandsList[command].Command;
                            if (botCommandsList[command].Command == "reset") newValue = GetDefaultValues(item, player_no);
                        }
                        else if ((botCommandsList[command].Parameters != null) && (commandpair.Count() > 1))
                        {
                            if (item == "character")
                            {
                                try
                                {
                                    newValue = characterIDs[commandpair[1].ToLower()];
                                }
                                catch (Exception)
                                {
                                    newValue = sor4vschatlib.changechar(player_no);
                                }
                            }
                            else if (Int32.TryParse(commandpair[1], out int parameterValue))
                            {
                                // set parameter if enabled and existing
                                if (botCommandsList[command].ChangeValue == 0) parameterValue *= -1;
                                newValue = parameterValue;
                            }
                        }
                        else
                        {
                            newValue = botCommandsList[command].ChangeValue;
                        }

                        string tempResponse = ExecuteCommand(mainwindow, chatsender, player_no, item, command, value: newValue, mode: mode);
                        // value needs to be known (and bracketed) for reset commands
                        if (tempResponse != "false12345false")
                        {
                            if (no_of_players > 1 && item != "gravity")
                            {
                                if (player_no == 1) response = "";
                                tempResponse += " (P" + player_no + "), ";
                                if (player_no == no_of_players) tempResponse = tempResponse.TrimEnd(' ').TrimEnd(',');
                                response += tempResponse;
                            }
                            else
                            {
                                response = tempResponse;
                            }
                        }
                        if (item == "gravity") break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No players!");
            }
            return response;
        }

        private string ExecuteCommand(MainWindow mainwindow, string chatsender, int player_no, string item, string command, int? value = 0, string mode = "", int? addl_int = 0)
        {
            int newValue;
            int? currentValue = null;
            string returnString = "false12345false";
            if (mode != "")
            {
                switch (mode)
                {
                    case "random":
                        int randomValue = CoinFlip(player_no, item);
                        int internalValue;
                        string internalCommand;
                        if (brackets.ContainsKey(item))
                        {
                            int bracket = randomValue;
                            internalCommand = item + bracket;
                            internalValue = bracket;
                        }
                        else if (item == "character")
                        {
                            internalCommand = "";
                            internalValue = randomValue;
                        }
                        else if (item == "moves")
                        {
                            internalCommand = "";
                            internalValue = randomValue;
                        }
                        else
                        {
                            // fetch new command (e.g. star -> addstar)
                            internalCommand = item + randomValue;
                            internalValue = randomValue;  // just a placeholder, will not be used
                        }
                        if (item == "moves")
                        {
                            for (int i = 0; i <= 4; i++)
                            {
                                internalValue = CoinFlip(player_no, item);
                                returnString = ExecuteCommand(mainwindow, chatsender, player_no, item, internalCommand, internalValue, "", i);
                            }
                        }
                        else
                        {
                            returnString = ExecuteCommand(mainwindow, chatsender, player_no, item, internalCommand, internalValue);
                        }
                        if (returnString != "false12345false") return returnString;
                        break;
                    case "reset":
                        internalCommand = "reset";
                        internalValue = GetDefaultValues(item, player_no);
                        returnString = ExecuteCommand(mainwindow, chatsender, player_no, item, internalCommand, internalValue);
                        if (returnString != "false12345false") return returnString;
                        break;
                }
                return "";
            }
            else
            {
                if ((item == "character") || (item == "moves"))
                {
                    newValue = (int)value;
                }
                else if (brackets.ContainsKey(item))
                {
                    if (command == "reset")
                    {
                        newValue = (int)value;
                    }
                    else
                    {
                        if ((item == "health") && (value == 6))
                        {
                            newValue = -1;
                        }
                        else
                        {
                            int bracket = (int)value;
                            newValue = randomgenerator.Next(brackets[item][bracket][0], brackets[item][bracket][1]);
                        }

                    }
                }
                else
                {
                    newValue = value == null ? default(int) : value.Value;
                }
            }

            int chatReplyValueChange = 0;
            switch (item)
            {
                case "life":
                    if (newValue == 0) newValue = -1;
                    chatReplyValueChange = 1;
                    currentValue = sor4vschatlib.life(player_no, sor4vschatlib.life(player_no) + newValue);
                    break;
                case "star":
                    if (newValue == 0) newValue = -1;
                    chatReplyValueChange = 1;
                    currentValue = sor4vschatlib.star(player_no, sor4vschatlib.star(player_no) + newValue);
                    break;
                case "speed":
                    currentValue = sor4vschatlib.charspeed(player_no, newValue);
                    chatReplyValueChange = (int)currentValue;
                    break;
                case "size":
                    currentValue = sor4vschatlib.charsize(player_no, newValue);
                    chatReplyValueChange = (int)currentValue;
                    break;
                case "gravity":
                    currentValue = sor4vschatlib.gravity(newValue);
                    chatReplyValueChange = (int)currentValue;
                    break;
                case "health":
                    currentValue = sor4vschatlib.health(player_no, newValue);
                    chatReplyValueChange = (int)currentValue;
                    break;
                case "character":
                    currentValue = sor4vschatlib.changechar(player_no, newValue);
                    chatReplyValueChange = (int)currentValue;
                    break;
                case "moves":
                    currentValue = sor4vschatlib.changemoves(player_no, (int)addl_int, newValue);
                    chatReplyValueChange = (int)currentValue;
                    break;
            }

            if (currentValue.HasValue)
            {
                string controlname = "";
                string replyValue = currentValue.ToString();
                if (command == "reset")
                {
                    controlname = "reset" + item;
                }
                else if (item == "character")
                {
                    controlname = "char";
                    replyValue = characterIDs.FirstOrDefault(x => x.Value == currentValue).Key;
                }
                else if (item == "moves")
                {
                    controlname = "moves";
                }
                else
                {
                    int internalValue = value == null ? default(int) : value.Value;
                    controlname = item + internalValue;
                }

                //mainwindow.SendFeedback(controlname); - specific commands
                mainwindow.SendFeedback(item);
                //mainwindow.UpdateOverlayValues(player_no, item, (int)currentValue);
                returnString = mainwindow.GetBotResponse(item, controlname, chatsender, chatReplyValueChange, replyValue).Trim();
            }
            return returnString;
        }

        public Dictionary<string, Dictionary<int, int>> CheckValues()
        {
            int no_of_players = sor4vschatlib.CheckNumPlayers();
            Dictionary<string, Dictionary<int, int>> returnValues = new Dictionary<string, Dictionary<int, int>>();
            if (no_of_players > 0)
            {
                returnValues["gravity"] = new Dictionary<int, int>();
                returnValues["life"] = new Dictionary<int, int>();
                returnValues["star"] = new Dictionary<int, int>();
                returnValues["health"] = new Dictionary<int, int>();
                returnValues["speed"] = new Dictionary<int, int>();
                returnValues["size"] = new Dictionary<int, int>();
                for (int player_no = 1; player_no <= no_of_players; player_no++)
                {
                    if (player_no == 1) returnValues["gravity"][player_no] = sor4vschatlib.gravity(null);
                    returnValues["life"][player_no] = sor4vschatlib.life(player_no);
                    returnValues["star"][player_no] = sor4vschatlib.star(player_no);
                    returnValues["health"][player_no] = sor4vschatlib.health(player_no, null);
                    returnValues["speed"][player_no] = sor4vschatlib.charspeed(player_no, null);
                    returnValues["size"][player_no] = sor4vschatlib.charsize(player_no, null);
                }
            }
            return returnValues;
        }

        static Dictionary<int, Dictionary<string, int>> coinside_repeats = new Dictionary<int, Dictionary<string, int>>
        {
            [1] = new Dictionary<string, int> 
            {
                { "gravity", 0 },
                { "star", 0 },
                { "life", 0 },
                { "speed", 0 },
                { "health", 0 },
                { "size", 0 },
            },
            [2] = new Dictionary<string, int>
            {
                { "gravity", 0 },
                { "star", 0 },
                { "life", 0 },
                { "speed", 0 },
                { "health", 0 },
                { "size", 0 },
            },
            [3] = new Dictionary<string, int>
            {
                { "gravity", 0 },
                { "star", 0 },
                { "life", 0 },
                { "speed", 0 },
                { "health", 0 },
                { "size", 0 },
            },
            [4] = new Dictionary<string, int>
            {
                { "gravity", 0 },
                { "star", 0 },
                { "life", 0 },
                { "speed", 0 },
                { "health", 0 },
                { "size", 0 },
            },
         };

        static Dictionary<int, Dictionary<string, int>> coinside_old_values = new Dictionary<int, Dictionary<string, int>>
        {
            [1] = new Dictionary<string, int>
            {
                { "gravity", 0 },
                { "star", 0 },
                { "life", 0 },
                { "speed", 0 },
                { "health", 0 },
                { "size", 0 },
            },
            [2] = new Dictionary<string, int>
            {
                { "gravity", 0 },
                { "star", 0 },
                { "life", 0 },
                { "speed", 0 },
                { "health", 0 },
                { "size", 0 },
            },
            [3] = new Dictionary<string, int>
            {
                { "gravity", 0 },
                { "star", 0 },
                { "life", 0 },
                { "speed", 0 },
                { "health", 0 },
                { "size", 0 },
            },
            [4] = new Dictionary<string, int>
            {
                { "gravity", 0 },
                { "star", 0 },
                { "life", 0 },
                { "speed", 0 },
                { "health", 0 },
                { "size", 0 },
            },
        };

        static Dictionary<int, int[]> health_bias = new Dictionary<int, int[]>()
        {
            [0] = Enumerable.Range(0,2).ToArray(),
            [1] = Enumerable.Range(2,3).ToArray()
        };

        static Dictionary<int, int[]> speed_bias = new Dictionary<int, int[]>()
        {
            [0] = Enumerable.Range(0, 4).ToArray(),
            [1] = Enumerable.Range(4, 3).ToArray()
        };

        static Dictionary<int, int[]> size_bias = new Dictionary<int, int[]>()
        {
            [0] = Enumerable.Range(0, 4).ToArray(),
            [1] = Enumerable.Range(4, 2).ToArray()
        };

        static Dictionary<int, int[]> gravity_bias = new Dictionary<int, int[]>()
        {
            [0] = Enumerable.Range(0, 2).ToArray(),
            [1] = Enumerable.Range(2, 2).ToArray()
        };

        static Dictionary<int, int[]> health_brackets = new Dictionary<int, int[]>()
        {
            [0] = new int[] {100, 100},
            [1] = new int[] {75, 90},
            [2] = new int[] {50, 75},
            [3] = new int[] {30, 50},
            [4] = new int[] {10, 30},
            [5] = new int[] {1, 10},
        };

        static Dictionary<int, int[]> size_brackets = new Dictionary<int, int[]>()
        {
            [0] = new int[] {9000, 15000},
            [1] = new int[] {15000, 32000},
            [2] = new int[] {32000, 45000},
            [3] = new int[] {45000, 60000},
            [4] = new int[] {70000, 100000},
            [5] = new int[] {100000, 200000},
        };

        static Dictionary<int, int[]> speed_brackets = new Dictionary<int, int[]>()
        {
            [0] = new int[] {1000, 2000},
            [1] = new int[] {500, 1000},
            [2] = new int[] {150, 500},
            [3] = new int[] {100, 150},
            [4] = new int[] {50, 100},
            [5] = new int[] {10, 50},
            [6] = new int[] {-120, -30},
        };

        static Dictionary<int, int[]> gravity_brackets = new Dictionary<int, int[]>()
        {
            [0] = new int[] {100, 600},
            [1] = new int[] {600, 1000},
            [2] = new int[] {1400, 1900},
            [3] = new int[] {1900, 2400},
        };

        readonly Dictionary<string, Dictionary<int, int[]>> brackets = new Dictionary<string, Dictionary<int, int[]>>
        {
            ["size"] = size_brackets,
            ["speed"] = speed_brackets,
            ["gravity"] = gravity_brackets,
            ["health"] = health_brackets,
        };

        readonly Dictionary<string, Dictionary<int, int[]>> bias = new Dictionary<string, Dictionary<int, int[]>>
        {
            ["size"] = size_bias,
            ["speed"] = speed_bias,
            ["gravity"] = gravity_bias,
            ["health"] = health_bias,
        };

        private int CoinFlip(int player_no, string item)
        {
            // returns 2 values for items with binary results
            // returns indexes of brackets otherwise
            int side = randomgenerator.Next(2);
            int maxRepeats = 3;
            if (side == 0)
            {
                switch (item)
                {
                    case "life":
                        if (sor4vschatlib.life(player_no) == 0) side = 1;
                        break;
                    case "star":
                        if (sor4vschatlib.star(player_no) == 0) side = 1;
                        break;
                }
            }
            if ((item != "character") && (item != "moves"))
            {
                if (coinside_old_values[player_no][item] == side)
                {
                    coinside_repeats[player_no][item]++;
                }
                else
                {
                    coinside_repeats[player_no][item] = 1;
                    coinside_old_values[player_no][item] = side;
                }

                if (coinside_repeats[player_no][item] > maxRepeats)
                {
                    coinside_repeats[player_no][item] = 1;
                    coinside_old_values[player_no][item] = side;
                    if (side == 0)
                    {
                        side = 1;
                    }
                    else
                    {
                        side = 0;
                    }
                }
            }

            switch (item)
            {
                case "size":
                case "speed":
                case "gravity":
                case "health":
                    int[] random_range;
                    random_range = bias[item][side].OrderBy(_ => randomgenerator.Next()).ToArray();
                    side = random_range[0];
                    break;
                case "character":
                    side = randomgenerator.Next(characters.Count());
                    break;
            }

            return side;
        }

        private int GetDefaultValues(string item, int player_no)
        {
            int returnVal = 0;
            switch (item) {
                case "life":
                    returnVal = sor4vschatlib.life(player_no);
                    break;
                case "star":
                    returnVal = sor4vschatlib.star(player_no);
                    break;
                case "gravity":
                    returnVal = sor4vschatlib.gravity();
                    break;
                case "speed":
                    returnVal = sor4vschatlib.charspeed(player_no);
                    break;
                case "size":
                    returnVal = sor4vschatlib.charsize(player_no);
                    break;
                case "health":
                    returnVal = sor4vschatlib.health(player_no);
                    break;
                case "character":
                    returnVal = sor4vschatlib.changechar(player_no);
                    break;
                case "moves":
                    returnVal = sor4vschatlib.changemoves(player_no);
                    break;
            }
            return returnVal;
        }
    }
}
