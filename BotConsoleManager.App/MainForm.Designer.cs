namespace BotConsoleManager.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            textBox_FreezeTime = new TextBox();
            textBox_MaxMoney = new TextBox();
            GenerateButton = new Button();
            label_FreezeTime = new Label();
            label_MaxMoney = new Label();
            label_StartMoney = new Label();
            label_BuyTime = new Label();
            label_BuyAnywhere = new Label();
            label_FriendlyFire = new Label();
            label_FreeArmor = new Label();
            label_MaxArmor = new Label();
            label_DefuserKit = new Label();
            label_NadeTotal = new Label();
            label_NadeDefaultAmount = new Label();
            label_NadeFlashbangAmount = new Label();
            textBox_StartMoney = new TextBox();
            textBox_BuyTime = new TextBox();
            textBox_BuyAnywhere = new TextBox();
            textBox_FriendlyFire = new TextBox();
            textBox_FreeArmor = new TextBox();
            textBox_MaxArmor = new TextBox();
            textBox_DefuserKit = new TextBox();
            label_Trajectory = new Label();
            textBox_NadeTotal = new TextBox();
            textBox_NadeDefaultAmount = new TextBox();
            textBox_NadeFlashbangAmount = new TextBox();
            textBox_Trajectory = new TextBox();
            label_Title = new Label();
            panel1 = new Panel();
            label_InfiniteAmmo = new Label();
            label_TrajectoryPreview = new Label();
            textBox_TrajectoryPreview = new TextBox();
            textBox_InfiniteAmmo = new TextBox();
            label3 = new Label();
            textBox_Customs = new TextBox();
            label_ResqueTime = new Label();
            label_RoundTime = new Label();
            label_DefuseTime = new Label();
            textBox_RoundTime = new TextBox();
            textBox_ResqueTime = new TextBox();
            textBox_DefuseTime = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label_MadeBy = new Label();
            label_Difficulty = new Label();
            checkBox_IsTeamDeathmatch = new CheckBox();
            label_IsTeamDeathmatch = new Label();
            toolTip1 = new ToolTip(components);
            label_C4Timer = new Label();
            label2 = new Label();
            label_GameMode = new Label();
            label_Path = new Label();
            comboBox_Difficulty = new ComboBox();
            textBox_C4Timer = new TextBox();
            checkBox_AutoDiff = new CheckBox();
            label4 = new Label();
            panel2 = new Panel();
            comboBox_GameMode = new ComboBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBox_Path = new TextBox();
            button_FindPath = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_FreezeTime
            // 
            textBox_FreezeTime.Location = new Point(146, 16);
            textBox_FreezeTime.Name = "textBox_FreezeTime";
            textBox_FreezeTime.Size = new Size(59, 23);
            textBox_FreezeTime.TabIndex = 0;
            textBox_FreezeTime.Text = "15";
            // 
            // textBox_MaxMoney
            // 
            textBox_MaxMoney.Location = new Point(146, 45);
            textBox_MaxMoney.Name = "textBox_MaxMoney";
            textBox_MaxMoney.Size = new Size(59, 23);
            textBox_MaxMoney.TabIndex = 1;
            textBox_MaxMoney.Text = "16000";
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(614, 453);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(202, 43);
            GenerateButton.TabIndex = 0;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // label_FreezeTime
            // 
            label_FreezeTime.AccessibleDescription = "";
            label_FreezeTime.AutoSize = true;
            label_FreezeTime.Location = new Point(4, 19);
            label_FreezeTime.Name = "label_FreezeTime";
            label_FreezeTime.Size = new Size(87, 15);
            label_FreezeTime.TabIndex = 3;
            label_FreezeTime.Text = "mp_Freezetime";
            toolTip1.SetToolTip(label_FreezeTime, "Sets the duration (in seconds) of the 'freeze time' at the start of each round, during which players cannot move or shoot.");
            // 
            // label_MaxMoney
            // 
            label_MaxMoney.AutoSize = true;
            label_MaxMoney.Location = new Point(4, 48);
            label_MaxMoney.Name = "label_MaxMoney";
            label_MaxMoney.Size = new Size(90, 15);
            label_MaxMoney.TabIndex = 4;
            label_MaxMoney.Text = "mp_maxmoney";
            toolTip1.SetToolTip(label_MaxMoney, "Sets the maximum amount of money a player can save in the match.");
            // 
            // label_StartMoney
            // 
            label_StartMoney.AutoSize = true;
            label_StartMoney.Location = new Point(4, 77);
            label_StartMoney.Name = "label_StartMoney";
            label_StartMoney.Size = new Size(90, 15);
            label_StartMoney.TabIndex = 5;
            label_StartMoney.Text = "mp_startmoney";
            toolTip1.SetToolTip(label_StartMoney, "Sets the amount of money players start with at the beginning of the match.");
            // 
            // label_BuyTime
            // 
            label_BuyTime.AutoSize = true;
            label_BuyTime.Location = new Point(4, 106);
            label_BuyTime.Name = "label_BuyTime";
            label_BuyTime.Size = new Size(74, 15);
            label_BuyTime.TabIndex = 6;
            label_BuyTime.Text = "mp_buytime";
            toolTip1.SetToolTip(label_BuyTime, "Sets the time limit (in seconds) from the start of the round during which players can buy weapons.");
            // 
            // label_BuyAnywhere
            // 
            label_BuyAnywhere.AutoSize = true;
            label_BuyAnywhere.Location = new Point(4, 135);
            label_BuyAnywhere.Name = "label_BuyAnywhere";
            label_BuyAnywhere.Size = new Size(106, 15);
            label_BuyAnywhere.TabIndex = 7;
            label_BuyAnywhere.Text = "mp_buy_anywhere";
            toolTip1.SetToolTip(label_BuyAnywhere, "Allows players to open the buy menu anywhere on the map (1 = On, 0 = Off).");
            // 
            // label_FriendlyFire
            // 
            label_FriendlyFire.AutoSize = true;
            label_FriendlyFire.Location = new Point(4, 164);
            label_FriendlyFire.Name = "label_FriendlyFire";
            label_FriendlyFire.Size = new Size(87, 15);
            label_FriendlyFire.TabIndex = 8;
            label_FriendlyFire.Text = "mp_friendlyfire";
            toolTip1.SetToolTip(label_FriendlyFire, "Enables or disables friendly fire (damage to teammates). (1 = On/Enabled, 0 = Off/Disabled).");
            // 
            // label_FreeArmor
            // 
            label_FreeArmor.AutoSize = true;
            label_FreeArmor.Location = new Point(4, 193);
            label_FreeArmor.Name = "label_FreeArmor";
            label_FreeArmor.Size = new Size(87, 15);
            label_FreeArmor.TabIndex = 9;
            label_FreeArmor.Text = "mp_free_armor";
            toolTip1.SetToolTip(label_FreeArmor, "Gives players free armor automatically at the start of the round (0: Off, 1: Armor only, 2: Armor + Helmet).");
            // 
            // label_MaxArmor
            // 
            label_MaxArmor.AutoSize = true;
            label_MaxArmor.Location = new Point(4, 222);
            label_MaxArmor.Name = "label_MaxArmor";
            label_MaxArmor.Size = new Size(90, 15);
            label_MaxArmor.TabIndex = 10;
            label_MaxArmor.Text = "mp_max_armor";
            toolTip1.SetToolTip(label_MaxArmor, "Sets the maximum armor state to grant at the start of a round (1: Armor only, 2: Armor + Helmet).");
            // 
            // label_DefuserKit
            // 
            label_DefuserKit.AutoSize = true;
            label_DefuserKit.Location = new Point(4, 251);
            label_DefuserKit.Name = "label_DefuserKit";
            label_DefuserKit.Size = new Size(126, 15);
            label_DefuserKit.TabIndex = 10;
            label_DefuserKit.Text = "mp_defuser_allocation";
            toolTip1.SetToolTip(label_DefuserKit, "Controls how defuse kits are allocated (0: None, 1: Randomly, 2: All CTs get one).");
            // 
            // label_NadeTotal
            // 
            label_NadeTotal.AutoSize = true;
            label_NadeTotal.Location = new Point(220, 19);
            label_NadeTotal.Name = "label_NadeTotal";
            label_NadeTotal.Size = new Size(148, 15);
            label_NadeTotal.TabIndex = 10;
            label_NadeTotal.Text = "ammo_grenade_limit_total";
            toolTip1.SetToolTip(label_NadeTotal, "Sets the maximum number of grenades (all types combined) a player can carry.");
            // 
            // label_NadeDefaultAmount
            // 
            label_NadeDefaultAmount.AutoSize = true;
            label_NadeDefaultAmount.Location = new Point(220, 48);
            label_NadeDefaultAmount.Name = "label_NadeDefaultAmount";
            label_NadeDefaultAmount.Size = new Size(161, 15);
            label_NadeDefaultAmount.TabIndex = 10;
            label_NadeDefaultAmount.Text = "ammo_grenade_limit_default";
            toolTip1.SetToolTip(label_NadeDefaultAmount, "Sets the maximum number of basic grenades (HE, Smoke, Decoy) a player can carry.");
            // 
            // label_NadeFlashbangAmount
            // 
            label_NadeFlashbangAmount.AutoSize = true;
            label_NadeFlashbangAmount.Location = new Point(220, 77);
            label_NadeFlashbangAmount.Name = "label_NadeFlashbangAmount";
            label_NadeFlashbangAmount.Size = new Size(176, 15);
            label_NadeFlashbangAmount.TabIndex = 10;
            label_NadeFlashbangAmount.Text = "ammo_grenade_limit_flashbang";
            toolTip1.SetToolTip(label_NadeFlashbangAmount, "Sets the maximum number of Flashbangs a player can carry.");
            // 
            // textBox_StartMoney
            // 
            textBox_StartMoney.Location = new Point(146, 74);
            textBox_StartMoney.Name = "textBox_StartMoney";
            textBox_StartMoney.Size = new Size(59, 23);
            textBox_StartMoney.TabIndex = 1;
            textBox_StartMoney.Text = "800";
            // 
            // textBox_BuyTime
            // 
            textBox_BuyTime.Location = new Point(146, 103);
            textBox_BuyTime.Name = "textBox_BuyTime";
            textBox_BuyTime.Size = new Size(59, 23);
            textBox_BuyTime.TabIndex = 1;
            textBox_BuyTime.Text = "15";
            // 
            // textBox_BuyAnywhere
            // 
            textBox_BuyAnywhere.Location = new Point(146, 132);
            textBox_BuyAnywhere.Name = "textBox_BuyAnywhere";
            textBox_BuyAnywhere.Size = new Size(59, 23);
            textBox_BuyAnywhere.TabIndex = 1;
            textBox_BuyAnywhere.Text = "0";
            // 
            // textBox_FriendlyFire
            // 
            textBox_FriendlyFire.Location = new Point(146, 161);
            textBox_FriendlyFire.Name = "textBox_FriendlyFire";
            textBox_FriendlyFire.Size = new Size(59, 23);
            textBox_FriendlyFire.TabIndex = 1;
            textBox_FriendlyFire.Text = "1";
            // 
            // textBox_FreeArmor
            // 
            textBox_FreeArmor.Location = new Point(146, 190);
            textBox_FreeArmor.Name = "textBox_FreeArmor";
            textBox_FreeArmor.Size = new Size(59, 23);
            textBox_FreeArmor.TabIndex = 1;
            textBox_FreeArmor.Text = "0";
            // 
            // textBox_MaxArmor
            // 
            textBox_MaxArmor.Location = new Point(146, 219);
            textBox_MaxArmor.Name = "textBox_MaxArmor";
            textBox_MaxArmor.Size = new Size(59, 23);
            textBox_MaxArmor.TabIndex = 1;
            textBox_MaxArmor.Text = "2";
            // 
            // textBox_DefuserKit
            // 
            textBox_DefuserKit.Location = new Point(146, 248);
            textBox_DefuserKit.Name = "textBox_DefuserKit";
            textBox_DefuserKit.Size = new Size(59, 23);
            textBox_DefuserKit.TabIndex = 1;
            textBox_DefuserKit.Text = "0";
            // 
            // label_Trajectory
            // 
            label_Trajectory.AutoSize = true;
            label_Trajectory.Location = new Point(220, 135);
            label_Trajectory.Name = "label_Trajectory";
            label_Trajectory.Size = new Size(121, 15);
            label_Trajectory.TabIndex = 10;
            label_Trajectory.Text = "sv_grenade_trajectory";
            toolTip1.SetToolTip(label_Trajectory, "Shows the trajectory of thrown grenades (requires sv_cheats 1). (1 = On, 0 = Off).");
            // 
            // textBox_NadeTotal
            // 
            textBox_NadeTotal.Location = new Point(401, 16);
            textBox_NadeTotal.Name = "textBox_NadeTotal";
            textBox_NadeTotal.Size = new Size(59, 23);
            textBox_NadeTotal.TabIndex = 1;
            textBox_NadeTotal.Text = "4";
            // 
            // textBox_NadeDefaultAmount
            // 
            textBox_NadeDefaultAmount.Location = new Point(401, 45);
            textBox_NadeDefaultAmount.Name = "textBox_NadeDefaultAmount";
            textBox_NadeDefaultAmount.Size = new Size(59, 23);
            textBox_NadeDefaultAmount.TabIndex = 1;
            textBox_NadeDefaultAmount.Text = "1";
            // 
            // textBox_NadeFlashbangAmount
            // 
            textBox_NadeFlashbangAmount.Location = new Point(401, 74);
            textBox_NadeFlashbangAmount.Name = "textBox_NadeFlashbangAmount";
            textBox_NadeFlashbangAmount.Size = new Size(59, 23);
            textBox_NadeFlashbangAmount.TabIndex = 1;
            textBox_NadeFlashbangAmount.Text = "2";
            // 
            // textBox_Trajectory
            // 
            textBox_Trajectory.Location = new Point(401, 132);
            textBox_Trajectory.Name = "textBox_Trajectory";
            textBox_Trajectory.Size = new Size(59, 23);
            textBox_Trajectory.TabIndex = 1;
            textBox_Trajectory.Text = "0";
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Location = new Point(652, 9);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(166, 15);
            label_Title.TabIndex = 10;
            label_Title.Text = "CS2 Bot Config File Generator ";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label_NadeTotal);
            panel1.Controls.Add(textBox_NadeTotal);
            panel1.Controls.Add(textBox_NadeDefaultAmount);
            panel1.Controls.Add(label_DefuserKit);
            panel1.Controls.Add(label_InfiniteAmmo);
            panel1.Controls.Add(label_TrajectoryPreview);
            panel1.Controls.Add(label_Trajectory);
            panel1.Controls.Add(label_MaxArmor);
            panel1.Controls.Add(textBox_NadeFlashbangAmount);
            panel1.Controls.Add(label_FreeArmor);
            panel1.Controls.Add(label_NadeFlashbangAmount);
            panel1.Controls.Add(label_FriendlyFire);
            panel1.Controls.Add(textBox_TrajectoryPreview);
            panel1.Controls.Add(textBox_InfiniteAmmo);
            panel1.Controls.Add(textBox_Trajectory);
            panel1.Controls.Add(label_BuyAnywhere);
            panel1.Controls.Add(label_NadeDefaultAmount);
            panel1.Controls.Add(label_BuyTime);
            panel1.Controls.Add(label_FreezeTime);
            panel1.Controls.Add(label_StartMoney);
            panel1.Controls.Add(textBox_FreezeTime);
            panel1.Controls.Add(label_MaxMoney);
            panel1.Controls.Add(textBox_MaxMoney);
            panel1.Controls.Add(textBox_StartMoney);
            panel1.Controls.Add(textBox_BuyTime);
            panel1.Controls.Add(textBox_BuyAnywhere);
            panel1.Controls.Add(textBox_DefuserKit);
            panel1.Controls.Add(textBox_FriendlyFire);
            panel1.Controls.Add(textBox_MaxArmor);
            panel1.Controls.Add(textBox_FreeArmor);
            panel1.Location = new Point(12, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 286);
            panel1.TabIndex = 11;
            // 
            // label_InfiniteAmmo
            // 
            label_InfiniteAmmo.AutoSize = true;
            label_InfiniteAmmo.Location = new Point(220, 106);
            label_InfiniteAmmo.Name = "label_InfiniteAmmo";
            label_InfiniteAmmo.Size = new Size(100, 15);
            label_InfiniteAmmo.TabIndex = 10;
            label_InfiniteAmmo.Text = "sv_infinite_ammo";
            toolTip1.SetToolTip(label_InfiniteAmmo, "Controls infinite ammunition mode (requires sv_cheats 1). (0: Off, 1: Infinite reserve ammo, 2: Infinite reserve and no reload).");
            // 
            // label_TrajectoryPreview
            // 
            label_TrajectoryPreview.AutoSize = true;
            label_TrajectoryPreview.Location = new Point(220, 164);
            label_TrajectoryPreview.Name = "label_TrajectoryPreview";
            label_TrajectoryPreview.Size = new Size(205, 15);
            label_TrajectoryPreview.TabIndex = 10;
            label_TrajectoryPreview.Text = "sv_grenade_trajectory_prac_pipreview";
            toolTip1.SetToolTip(label_TrajectoryPreview, "Enables the picture-in-picture preview of where a smoke grenade will land (requires sv_cheats 1). (1 = On, 0 = Off).");
            // 
            // textBox_TrajectoryPreview
            // 
            textBox_TrajectoryPreview.Location = new Point(431, 161);
            textBox_TrajectoryPreview.Name = "textBox_TrajectoryPreview";
            textBox_TrajectoryPreview.Size = new Size(29, 23);
            textBox_TrajectoryPreview.TabIndex = 1;
            textBox_TrajectoryPreview.Text = "0";
            // 
            // textBox_InfiniteAmmo
            // 
            textBox_InfiniteAmmo.Location = new Point(401, 103);
            textBox_InfiniteAmmo.Name = "textBox_InfiniteAmmo";
            textBox_InfiniteAmmo.Size = new Size(59, 23);
            textBox_InfiniteAmmo.TabIndex = 1;
            textBox_InfiniteAmmo.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(499, 125);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 10;
            label3.Text = "Custom commands";
            // 
            // textBox_Customs
            // 
            textBox_Customs.Font = new Font("Segoe UI", 8F);
            textBox_Customs.Location = new Point(12, 18);
            textBox_Customs.Multiline = true;
            textBox_Customs.Name = "textBox_Customs";
            textBox_Customs.Size = new Size(303, 251);
            textBox_Customs.TabIndex = 1;
            textBox_Customs.Text = "//The team that first secures 16 rounds wins (Score 16:X).\r\n//mp_maxrounds 30";
            // 
            // label_ResqueTime
            // 
            label_ResqueTime.AutoSize = true;
            label_ResqueTime.Location = new Point(12, 91);
            label_ResqueTime.Name = "label_ResqueTime";
            label_ResqueTime.Size = new Size(126, 15);
            label_ResqueTime.TabIndex = 10;
            label_ResqueTime.Text = "Round Time (Hostage)";
            toolTip1.SetToolTip(label_ResqueTime, "Sets the duration (in minutes) of a Hostage Rescue round.");
            // 
            // label_RoundTime
            // 
            label_RoundTime.AutoSize = true;
            label_RoundTime.Location = new Point(232, 62);
            label_RoundTime.Name = "label_RoundTime";
            label_RoundTime.Size = new Size(147, 15);
            label_RoundTime.TabIndex = 10;
            label_RoundTime.Text = "Round Time (Deathmatch)";
            toolTip1.SetToolTip(label_RoundTime, "Sets the duration (in minutes) of a Deathmatch round.");
            // 
            // label_DefuseTime
            // 
            label_DefuseTime.AutoSize = true;
            label_DefuseTime.Location = new Point(12, 62);
            label_DefuseTime.Name = "label_DefuseTime";
            label_DefuseTime.Size = new Size(118, 15);
            label_DefuseTime.TabIndex = 10;
            label_DefuseTime.Text = "Round Time (Defuse)";
            toolTip1.SetToolTip(label_DefuseTime, "Sets the duration (in minutes) of a Bomb Defusal round.");
            // 
            // textBox_RoundTime
            // 
            textBox_RoundTime.Location = new Point(385, 59);
            textBox_RoundTime.Name = "textBox_RoundTime";
            textBox_RoundTime.Size = new Size(59, 23);
            textBox_RoundTime.TabIndex = 1;
            textBox_RoundTime.Text = "5.0";
            // 
            // textBox_ResqueTime
            // 
            textBox_ResqueTime.Location = new Point(144, 88);
            textBox_ResqueTime.Name = "textBox_ResqueTime";
            textBox_ResqueTime.Size = new Size(59, 23);
            textBox_ResqueTime.TabIndex = 1;
            textBox_ResqueTime.Text = "1.92";
            // 
            // textBox_DefuseTime
            // 
            textBox_DefuseTime.Location = new Point(144, 59);
            textBox_DefuseTime.Name = "textBox_DefuseTime";
            textBox_DefuseTime.Size = new Size(59, 23);
            textBox_DefuseTime.TabIndex = 1;
            textBox_DefuseTime.Text = "1.92";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.cat_32;
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(614, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(794, 38);
            label1.Name = "label1";
            label1.Size = new Size(22, 12);
            label1.TabIndex = 10;
            label1.Text = "v1.0";
            // 
            // label_MadeBy
            // 
            label_MadeBy.AutoSize = true;
            label_MadeBy.Font = new Font("Segoe UI", 7F);
            label_MadeBy.Location = new Point(758, 26);
            label_MadeBy.Name = "label_MadeBy";
            label_MadeBy.Size = new Size(59, 12);
            label_MadeBy.TabIndex = 10;
            label_MadeBy.Text = "by normalbt";
            // 
            // label_Difficulty
            // 
            label_Difficulty.AutoSize = true;
            label_Difficulty.Location = new Point(205, 25);
            label_Difficulty.Name = "label_Difficulty";
            label_Difficulty.Size = new Size(55, 15);
            label_Difficulty.TabIndex = 10;
            label_Difficulty.Text = "Difficulty";
            toolTip1.SetToolTip(label_Difficulty, "Sets the skill level for bots added to the server. (0: Passive, 1: Easy, 2: Normal, 3: Hard/Expert).");
            // 
            // checkBox_IsTeamDeathmatch
            // 
            checkBox_IsTeamDeathmatch.AutoSize = true;
            checkBox_IsTeamDeathmatch.Location = new Point(348, 433);
            checkBox_IsTeamDeathmatch.Name = "checkBox_IsTeamDeathmatch";
            checkBox_IsTeamDeathmatch.Size = new Size(15, 14);
            checkBox_IsTeamDeathmatch.TabIndex = 11;
            checkBox_IsTeamDeathmatch.UseVisualStyleBackColor = true;
            // 
            // label_IsTeamDeathmatch
            // 
            label_IsTeamDeathmatch.AutoSize = true;
            label_IsTeamDeathmatch.Font = new Font("Segoe UI", 8F);
            label_IsTeamDeathmatch.Location = new Point(180, 433);
            label_IsTeamDeathmatch.Name = "label_IsTeamDeathmatch";
            label_IsTeamDeathmatch.Size = new Size(162, 13);
            label_IsTeamDeathmatch.TabIndex = 10;
            label_IsTeamDeathmatch.Text = "Generate Deathmatch Configs";
            toolTip1.SetToolTip(label_IsTeamDeathmatch, "Also generates Deathmatch config files. (e.g., 10dm)");
            // 
            // label_C4Timer
            // 
            label_C4Timer.AutoSize = true;
            label_C4Timer.Location = new Point(232, 91);
            label_C4Timer.Name = "label_C4Timer";
            label_C4Timer.Size = new Size(54, 15);
            label_C4Timer.TabIndex = 10;
            label_C4Timer.Text = "C4 Timer";
            toolTip1.SetToolTip(label_C4Timer, "Sets the duration (in seconds) of the C4 bomb timer, from the moment it is planted until it detonates.");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(12, 433);
            label2.Name = "label2";
            label2.Size = new Size(117, 13);
            label2.TabIndex = 10;
            label2.Text = "Randomize Bot Levels";
            toolTip1.SetToolTip(label2, "Applies an automatic difficulty range of –2 levels.\r\n(e.g., Levels 0–2 appear at Hard difficulty)");
            // 
            // label_GameMode
            // 
            label_GameMode.AutoSize = true;
            label_GameMode.Font = new Font("Segoe UI", 8F);
            label_GameMode.Location = new Point(12, 26);
            label_GameMode.Name = "label_GameMode";
            label_GameMode.Size = new Size(69, 13);
            label_GameMode.TabIndex = 10;
            label_GameMode.Text = "Game Mode";
            toolTip1.SetToolTip(label_GameMode, "Balanced\tEqual players on both teams.\r\nSolo (T)\t\tT team is restricted to one player.\r\nSolo (CT)\tCT team is restricted to one player.");
            // 
            // label_Path
            // 
            label_Path.AutoSize = true;
            label_Path.Font = new Font("Segoe UI", 8F);
            label_Path.Location = new Point(12, 468);
            label_Path.Name = "label_Path";
            label_Path.Size = new Size(30, 13);
            label_Path.TabIndex = 10;
            label_Path.Text = "Path";
            toolTip1.SetToolTip(label_Path, "Select the CS2 folder to save CFG files.");
            // 
            // comboBox_Difficulty
            // 
            comboBox_Difficulty.FormattingEnabled = true;
            comboBox_Difficulty.Items.AddRange(new object[] { "0: Easy", "1: Normal", "2: Hard", "3: Expert" });
            comboBox_Difficulty.Location = new Point(266, 22);
            comboBox_Difficulty.Name = "comboBox_Difficulty";
            comboBox_Difficulty.Size = new Size(99, 23);
            comboBox_Difficulty.TabIndex = 14;
            // 
            // textBox_C4Timer
            // 
            textBox_C4Timer.Location = new Point(292, 88);
            textBox_C4Timer.Name = "textBox_C4Timer";
            textBox_C4Timer.Size = new Size(59, 23);
            textBox_C4Timer.TabIndex = 1;
            textBox_C4Timer.Text = "40";
            // 
            // checkBox_AutoDiff
            // 
            checkBox_AutoDiff.AutoSize = true;
            checkBox_AutoDiff.Location = new Point(135, 433);
            checkBox_AutoDiff.Name = "checkBox_AutoDiff";
            checkBox_AutoDiff.Size = new Size(15, 14);
            checkBox_AutoDiff.TabIndex = 11;
            checkBox_AutoDiff.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(17, 125);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 10;
            label4.Text = "Main Commands";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox_Customs);
            panel2.Location = new Point(487, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 286);
            panel2.TabIndex = 15;
            // 
            // comboBox_GameMode
            // 
            comboBox_GameMode.FormattingEnabled = true;
            comboBox_GameMode.Items.AddRange(new object[] { "Balanced", "Solo (T)", "Solo (CT)" });
            comboBox_GameMode.Location = new Point(87, 22);
            comboBox_GameMode.Name = "comboBox_GameMode";
            comboBox_GameMode.Size = new Size(99, 23);
            comboBox_GameMode.TabIndex = 14;
            // 
            // textBox_Path
            // 
            textBox_Path.Location = new Point(48, 464);
            textBox_Path.Name = "textBox_Path";
            textBox_Path.Size = new Size(483, 23);
            textBox_Path.TabIndex = 1;
            // 
            // button_FindPath
            // 
            button_FindPath.Location = new Point(537, 464);
            button_FindPath.Name = "button_FindPath";
            button_FindPath.Size = new Size(38, 23);
            button_FindPath.TabIndex = 16;
            button_FindPath.Text = "Find";
            button_FindPath.UseVisualStyleBackColor = true;
            button_FindPath.Click += button_FindPath_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.Location = new Point(577, 469);
            label5.Name = "label5";
            label5.Size = new Size(31, 13);
            label5.TabIndex = 10;
            label5.Text = ">>>";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 512);
            Controls.Add(button_FindPath);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox_GameMode);
            Controls.Add(comboBox_Difficulty);
            Controls.Add(checkBox_AutoDiff);
            Controls.Add(checkBox_IsTeamDeathmatch);
            Controls.Add(label_ResqueTime);
            Controls.Add(label_MadeBy);
            Controls.Add(label_DefuseTime);
            Controls.Add(label_C4Timer);
            Controls.Add(label_RoundTime);
            Controls.Add(label_Difficulty);
            Controls.Add(label_GameMode);
            Controls.Add(label5);
            Controls.Add(label_Path);
            Controls.Add(label2);
            Controls.Add(label_IsTeamDeathmatch);
            Controls.Add(label_Title);
            Controls.Add(GenerateButton);
            Controls.Add(textBox_C4Timer);
            Controls.Add(textBox_RoundTime);
            Controls.Add(textBox_Path);
            Controls.Add(textBox_DefuseTime);
            Controls.Add(textBox_ResqueTime);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "MainForm";
            Text = "Bot Config Generator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_FreezeTime;
        private TextBox textBox_MaxMoney;
        private Button GenerateButton;
        private Label label_FreezeTime;
        private Label label_MaxMoney;
        private Label label_StartMoney;
        private Label label_BuyTime;
        private Label label_BuyAnywhere;
        private Label label_FriendlyFire;
        private Label label_FreeArmor;
        private Label label_MaxArmor;
        private Label label_DefuserKit;
        private Label label_NadeTotal;
        private Label label_NadeDefaultAmount;
        private Label label_NadeFlashbangAmount;
        private TextBox textBox_StartMoney;
        private TextBox textBox_BuyTime;
        private TextBox textBox_BuyAnywhere;
        private TextBox textBox_FriendlyFire;
        private TextBox textBox_FreeArmor;
        private TextBox textBox_MaxArmor;
        private TextBox textBox_DefuserKit;
        private Label label_Trajectory;
        private TextBox textBox_NadeTotal;
        private TextBox textBox_NadeDefaultAmount;
        private TextBox textBox_NadeFlashbangAmount;
        private TextBox textBox_Trajectory;
        private Label label_Title;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label_MadeBy;
        private Label label_TrajectoryPreview;
        private TextBox textBox_TrajectoryPreview;
        private Label label_Difficulty;
        private CheckBox checkBox_IsTeamDeathmatch;
        private Label label_IsTeamDeathmatch;
        private Label label_ResqueTime;
        private Label label_DefuseTime;
        private TextBox textBox_ResqueTime;
        private TextBox textBox_DefuseTime;
        private Label label_RoundTime;
        private TextBox textBox_RoundTime;
        private ToolTip toolTip1;
        private Label label_InfiniteAmmo;
        private TextBox textBox_InfiniteAmmo;
        private ComboBox comboBox_Difficulty;
        private Label label_C4Timer;
        private TextBox textBox_C4Timer;
        private Label label2;
        private CheckBox checkBox_AutoDiff;
        private TextBox textBox_Customs;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label label_GameMode;
        private ComboBox comboBox_GameMode;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox_Path;
        private Label label_Path;
        private Button button_FindPath;
        private Label label5;
    }
}
