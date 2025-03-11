namespace FormShotgun
{
    partial class Form1
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
            buttonShoot = new Button();
            buttonReload = new Button();
            buttonShotgun = new Button();
            buttonBlock = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            flpPlayer = new FlowLayoutPanel();
            flpComputer = new FlowLayoutPanel();
            labelPlayerAction = new Label();
            labelComputerAction = new Label();
            buttonStartGame = new Button();
            buttonRestart = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // buttonShoot
            // 
            buttonShoot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonShoot.BackColor = SystemColors.ControlDark;
            buttonShoot.Enabled = false;
            buttonShoot.Font = new Font("Segoe UI Black", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShoot.Location = new Point(209, 727);
            buttonShoot.Margin = new Padding(200, 3, 3, 50);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(203, 149);
            buttonShoot.TabIndex = 0;
            buttonShoot.Text = "Shoot";
            buttonShoot.UseVisualStyleBackColor = false;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonReload
            // 
            buttonReload.BackColor = SystemColors.ControlDark;
            buttonReload.Enabled = false;
            buttonReload.Font = new Font("Segoe UI Black", 14.1428576F, FontStyle.Bold);
            buttonReload.Location = new Point(445, 727);
            buttonReload.Margin = new Padding(30, 3, 30, 3);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(203, 150);
            buttonReload.TabIndex = 1;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = false;
            buttonReload.Click += buttonReload_Click;
            // 
            // buttonShotgun
            // 
            buttonShotgun.BackColor = SystemColors.ControlDark;
            buttonShotgun.Enabled = false;
            buttonShotgun.Font = new Font("Segoe UI Black", 14.1428576F, FontStyle.Bold);
            buttonShotgun.Location = new Point(976, 727);
            buttonShotgun.Margin = new Padding(30, 3, 200, 3);
            buttonShotgun.Name = "buttonShotgun";
            buttonShotgun.Size = new Size(203, 150);
            buttonShotgun.TabIndex = 2;
            buttonShotgun.Text = "Shotgun";
            buttonShotgun.UseVisualStyleBackColor = false;
            buttonShotgun.Click += buttonShotgun_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.BackColor = SystemColors.ControlDark;
            buttonBlock.Enabled = false;
            buttonBlock.Font = new Font("Segoe UI Black", 14.1428576F, FontStyle.Bold);
            buttonBlock.Location = new Point(740, 727);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(203, 150);
            buttonBlock.TabIndex = 3;
            buttonBlock.Text = "Block";
            buttonBlock.UseVisualStyleBackColor = false;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.1428585F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(502, 9);
            label1.Name = "label1";
            label1.Size = new Size(422, 55);
            label1.TabIndex = 4;
            label1.Text = "Game of Shotgun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.8571434F);
            label2.Location = new Point(1032, 201);
            label2.Name = "label2";
            label2.Size = new Size(181, 42);
            label2.TabIndex = 5;
            label2.Text = "Computer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(197, 201);
            label3.Name = "label3";
            label3.Size = new Size(119, 42);
            label3.TabIndex = 6;
            label3.Text = "Player";
            // 
            // flpPlayer
            // 
            flpPlayer.BackColor = SystemColors.ControlLightLight;
            flpPlayer.FlowDirection = FlowDirection.BottomUp;
            flpPlayer.Location = new Point(207, 266);
            flpPlayer.Name = "flpPlayer";
            flpPlayer.Size = new Size(100, 336);
            flpPlayer.TabIndex = 7;
            flpPlayer.WrapContents = false;
            // 
            // flpComputer
            // 
            flpComputer.BackColor = SystemColors.ControlLightLight;
            flpComputer.FlowDirection = FlowDirection.BottomUp;
            flpComputer.Location = new Point(1079, 266);
            flpComputer.Name = "flpComputer";
            flpComputer.Size = new Size(100, 336);
            flpComputer.TabIndex = 8;
            // 
            // labelPlayerAction
            // 
            labelPlayerAction.AutoSize = true;
            labelPlayerAction.Font = new Font("Arial", 12F);
            labelPlayerAction.Location = new Point(379, 401);
            labelPlayerAction.Name = "labelPlayerAction";
            labelPlayerAction.Size = new Size(0, 32);
            labelPlayerAction.TabIndex = 9;
            // 
            // labelComputerAction
            // 
            labelComputerAction.AutoSize = true;
            labelComputerAction.Font = new Font("Arial", 12F);
            labelComputerAction.Location = new Point(880, 401);
            labelComputerAction.Name = "labelComputerAction";
            labelComputerAction.RightToLeft = RightToLeft.No;
            labelComputerAction.Size = new Size(0, 32);
            labelComputerAction.TabIndex = 10;
            // 
            // buttonStartGame
            // 
            buttonStartGame.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonStartGame.BackColor = SystemColors.ControlLightLight;
            buttonStartGame.Font = new Font("Arial", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonStartGame.Location = new Point(231, 962);
            buttonStartGame.Margin = new Padding(200, 3, 3, 50);
            buttonStartGame.Name = "buttonStartGame";
            buttonStartGame.Size = new Size(203, 83);
            buttonStartGame.TabIndex = 11;
            buttonStartGame.Text = "Start game";
            buttonStartGame.UseVisualStyleBackColor = false;
            buttonStartGame.Click += buttonStartGame_Click;
            // 
            // buttonRestart
            // 
            buttonRestart.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRestart.BackColor = SystemColors.ControlLightLight;
            buttonRestart.Font = new Font("Arial", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRestart.Location = new Point(525, 962);
            buttonRestart.Margin = new Padding(200, 3, 3, 50);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(203, 83);
            buttonRestart.TabIndex = 12;
            buttonRestart.Text = "Restart";
            buttonRestart.UseVisualStyleBackColor = false;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonClose.BackColor = SystemColors.ControlLightLight;
            buttonClose.Font = new Font("Arial", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(1146, 962);
            buttonClose.Margin = new Padding(200, 3, 3, 50);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(203, 83);
            buttonClose.TabIndex = 13;
            buttonClose.Text = "Exit";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1388, 1104);
            Controls.Add(buttonClose);
            Controls.Add(buttonRestart);
            Controls.Add(buttonStartGame);
            Controls.Add(labelComputerAction);
            Controls.Add(labelPlayerAction);
            Controls.Add(flpComputer);
            Controls.Add(flpPlayer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBlock);
            Controls.Add(buttonShotgun);
            Controls.Add(buttonReload);
            Controls.Add(buttonShoot);
            Name = "Form1";
            Text = "Shotgun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShoot;
        private Button buttonReload;
        private Button buttonShotgun;
        private Button buttonBlock;
        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flpPlayer;
        private FlowLayoutPanel flpComputer;
        private Label labelPlayerAction;
        private Label labelComputerAction;
        private Button buttonStartGame;
        private Button buttonRestart;
        private Button buttonClose;
    }
}
