using System.Text;

namespace BotConsoleManager.App
{
    public partial class MainForm : Form
    {
        private readonly string settingsFilePath;

        public MainForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            // settings file in AppData
            settingsFilePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "CS2ConfigGenerator",
                "settings.txt");

            // Load persisted path (if any)
            textBox_Path.Text = LoadPreferredPath();

            // Init Difficulty - Easy
            comboBox_Difficulty.SelectedIndex = 2;
            comboBox_Difficulty.Text = comboBox_Difficulty.Items[2]?.ToString()
                    ?? comboBox_Difficulty.SelectedItem?.ToString()
                    ?? string.Empty;

            // Init Gamemode - Balanced
            comboBox_GameMode.SelectedIndex = 0;
            comboBox_GameMode.Text = comboBox_GameMode.Items[0]?.ToString()
                    ?? comboBox_GameMode.SelectedItem?.ToString()
                    ?? string.Empty;
        }

        private void SavePreferredPath(string path)
        {
            try
            {
                string? dir = Path.GetDirectoryName(settingsFilePath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                File.WriteAllText(settingsFilePath, path ?? string.Empty);
            }
            catch
            {
                // Ignore failures to avoid blocking user; optionally log if you have logging.
            }
        }

        private string LoadPreferredPath()
        {
            try
            {
                if (File.Exists(settingsFilePath))
                {
                    string content = File.ReadAllText(settingsFilePath);
                    return content ?? string.Empty;
                }
            }
            catch
            {
                // Ignore read errors and return empty
            }

            return string.Empty;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the value of each text box
                string casualConfig =
                    $"sv_cheats 1\n" +
                    $"mp_respawn_on_death_ct 0\n" +
                    $"mp_respawn_on_death_t 0\n" +
                    $"mp_team_intro_time 0\n" +
                    $"mp_autokick 0\n" +
                    $"mp_disable_autokick 1\n" +
                    $"mp_limitteams 0\n" +
                    $"mp_autoteambalance 0\n\n" +

                    $"bot_difficulty {comboBox_Difficulty.SelectedIndex}\n" +
                    $"mp_roundtime_defuse {textBox_DefuseTime.Text}\n" +
                    $"mp_roundtime_hostage {textBox_ResqueTime.Text}\n" +
                    $"mp_c4timer {textBox_C4Timer.Text}\n" +
                    $"mp_freezetime {textBox_FreezeTime.Text}\n" +
                    $"mp_maxmoney {textBox_MaxMoney.Text}\n" +
                    $"mp_startmoney {textBox_StartMoney.Text}\n" +
                    $"mp_buytime {textBox_BuyTime.Text}\n" +
                    $"mp_buy_anywhere {textBox_BuyAnywhere.Text}\n\n" +

                    $"mp_friendlyfire {textBox_FriendlyFire.Text}\n" +
                    $"mp_free_armor {textBox_FreeArmor.Text}\n" +
                    $"mp_max_armor {textBox_MaxArmor.Text}\n" +
                    $"mp_defuser_allocation {textBox_DefuserKit.Text}\n\n" +

                    $"ammo_grenade_limit_total {textBox_NadeTotal.Text}\n" +
                    $"ammo_grenade_limit_default {textBox_NadeDefaultAmount.Text}\n" +
                    $"ammo_grenade_limit_flashbang {textBox_NadeFlashbangAmount.Text}\n" +
                    $"sv_infinite_ammo {textBox_InfiniteAmmo.Text}\n" +
                    $"sv_grenade_trajectory {textBox_Trajectory.Text}\n" +
                    $"sv_grenade_trajectory_prac_pipreview {textBox_TrajectoryPreview.Text}\n\n" +

                    $"{textBox_Customs.Text}\n\n";

                string dmConfig =
                    $"sv_cheats 1\n" +
                    $"mp_autokick 0\n" +
                    $"mp_disable_autokick 1\n" +
                    $"mp_limitteams 0\n" +
                    $"mp_autoteambalance 0\n" +
                    $"mp_roundtime {textBox_RoundTime.Text}\n" +
                    $"mp_teammates_are_enemies 0\n\n" +

                    $"bot_difficulty {comboBox_Difficulty.SelectedIndex}\n\n" +

                    $"sv_infinite_ammo {textBox_InfiniteAmmo.Text}\n" +
                    $"sv_grenade_trajectory {textBox_Trajectory.Text}\n" +
                    $"sv_grenade_trajectory_prac_pipreview {textBox_TrajectoryPreview.Text}\n\n" +

                    $"{textBox_Customs.Text}\n\n";

                // bot_quota 별 파일 생성
                // 프로그램이 실행 중인 폴더
                //string exeDir = AppDomain.CurrentDomain.BaseDirectory;
                string preferredDir = textBox_Path.Text ?? string.Empty;
                string exeDir;

                if (Directory.Exists(preferredDir))
                {
                    exeDir = preferredDir;
                }
                else
                {
                    try
                    {
                        // attempt to create the preferred folder
                        Directory.CreateDirectory(preferredDir);
                        exeDir = preferredDir;
                    }
                    catch
                    {
                        // creation failed (likely permissions); safely fall back to app folder
                        exeDir = AppDomain.CurrentDomain.BaseDirectory;
                    }
                }

                string[] botLevels = { "easy", "normal", "hard", "expert" };
                Int32 selectedIndex = Math.Clamp(comboBox_Difficulty.SelectedIndex, 0, 3);

                // clamp game mode index to a safe range
                int gameModeIndex = Math.Clamp(comboBox_GameMode.SelectedIndex, 0, 2);

                // bot_quota inputs
                int[] quotas = { 6, 10, 12, 16, 20 };

                // single Random instance to avoid reseeding each iteration
                Random random = new Random();

                foreach (int quota in quotas)
                {
                    string fileName = $"{quota}.cfg";
                    string filePath = Path.Combine(exeDir, fileName);


                    int botsPerTeam = quota / 2;
                    if (botsPerTeam != 0)
                    {
                        // challenge mode: no opposing team, add all bots to the single team
                        botsPerTeam = quota;
                    }

                    // Construct the bot add command string
                    StringBuilder botLines = new StringBuilder();

                    for (int i = 0; i < botsPerTeam; i++)
                    {
                        string targetLevel = botLevels[selectedIndex];

                        if (checkBox_AutoDiff.Checked && i > 0)
                        {
                            Int32 lowerBound = Math.Clamp(selectedIndex - 2, 0, 3);
                            targetLevel = botLevels[random.Next(lowerBound, selectedIndex + 1)];
                        }

                        if (gameModeIndex == 0)
                        {
                            botLines.AppendLine($"bot_add_t {targetLevel}");
                            botLines.AppendLine($"bot_add_ct {targetLevel}");

                        }
                        else if (gameModeIndex == 1)
                        {
                            // T team restricted — only add CT bots
                            botLines.AppendLine($"bot_add_ct {targetLevel}");
                        }
                        else // gameModeIndex == 2
                        {
                            // CT team restricted — only add T bots
                            botLines.AppendLine($"bot_add_t {targetLevel}");
                        }
                    }

                    string cfgText =
                        casualConfig +
                        $"bot_kick\n" +                       // Initialize bots currently in the room
                        botLines.ToString() +
                        $"bot_quota {quota}\n" +
                        $"\nmp_restartgame 1\n";

                    File.WriteAllText(filePath, cfgText);

                    // Generate Team Deathmatch cfg as well
                    if (checkBox_IsTeamDeathmatch.Checked)
                    {
                        string tdmFileName = $"{quota}dm.cfg";
                        string tdmFilePath = Path.Combine(exeDir, tdmFileName);

                        string tdmCfgText =
                            dmConfig +
                            $"bot_kick\n" +
                            botLines.ToString() +
                            $"bot_quota {quota}\n" +
                            $"\nmp_restartgame 1\n";

                        File.WriteAllText(tdmFilePath, tdmCfgText);
                    }
                }

                MessageBox.Show("Successfully generated!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_FindPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog1.SelectedPath;

                textBox_Path.Text = selectedPath;
                SavePreferredPath(selectedPath);
            }
        }
    }
}
