namespace CheckPoint
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelSideMenu = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnUserManagement = new Button();
            btnUserPanel = new Button();
            btnNotifyError = new Button();
            btnSettings = new Button();
            btnChangeTask = new Button();
            btnCheck = new Button();
            panelTitle = new Panel();
            btnSideMenu = new Button();
            panelTopMenu = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnClose = new Button();
            panelLaw = new Panel();
            lblRealDecretoLey = new Label();
            panelDateTime = new Panel();
            lblTime = new Label();
            lblDate = new Label();
            lblInstructions = new Label();
            panel1 = new Panel();
            panelCheckedUsers = new DataGridView();
            timerHour = new System.Windows.Forms.Timer(components);
            panelSideMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitle.SuspendLayout();
            panelTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelLaw.SuspendLayout();
            panelDateTime.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCheckedUsers).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.Azure;
            panelSideMenu.Controls.Add(panel2);
            panelSideMenu.Controls.Add(btnUserManagement);
            panelSideMenu.Controls.Add(btnUserPanel);
            panelSideMenu.Controls.Add(btnNotifyError);
            panelSideMenu.Controls.Add(btnSettings);
            panelSideMenu.Controls.Add(btnChangeTask);
            panelSideMenu.Controls.Add(btnCheck);
            panelSideMenu.Controls.Add(panelTitle);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.ForeColor = SystemColors.ControlText;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(231, 1080);
            panelSideMenu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 410);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 400);
            panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.diservaulecLogo150x150Black;
            pictureBox1.Location = new Point(48, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 85);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnUserManagement
            // 
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnUserManagement.Image = Properties.Resources.Users;
            btnUserManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.Location = new Point(1, 916);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Padding = new Padding(10, 0, 0, 0);
            btnUserManagement.Size = new Size(231, 58);
            btnUserManagement.TabIndex = 6;
            btnUserManagement.Tag = "   Gestión de usuarios";
            btnUserManagement.Text = "   Gestión de usuarios";
            btnUserManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // btnUserPanel
            // 
            btnUserPanel.FlatAppearance.BorderSize = 0;
            btnUserPanel.FlatStyle = FlatStyle.Flat;
            btnUserPanel.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnUserPanel.Image = Properties.Resources.profile;
            btnUserPanel.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserPanel.Location = new Point(0, 346);
            btnUserPanel.Name = "btnUserPanel";
            btnUserPanel.Padding = new Padding(10, 0, 0, 0);
            btnUserPanel.Size = new Size(231, 58);
            btnUserPanel.TabIndex = 3;
            btnUserPanel.Tag = "   Panel de usuario";
            btnUserPanel.Text = "   Panel de usuario";
            btnUserPanel.TextAlign = ContentAlignment.MiddleLeft;
            btnUserPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserPanel.UseVisualStyleBackColor = true;
            // 
            // btnNotifyError
            // 
            btnNotifyError.FlatAppearance.BorderSize = 0;
            btnNotifyError.FlatStyle = FlatStyle.Flat;
            btnNotifyError.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnNotifyError.Image = Properties.Resources.computer;
            btnNotifyError.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotifyError.Location = new Point(-2, 816);
            btnNotifyError.Name = "btnNotifyError";
            btnNotifyError.Padding = new Padding(10, 0, 0, 0);
            btnNotifyError.Size = new Size(231, 58);
            btnNotifyError.TabIndex = 4;
            btnNotifyError.Tag = "   Notificar error";
            btnNotifyError.Text = "   Notificar error";
            btnNotifyError.TextAlign = ContentAlignment.MiddleLeft;
            btnNotifyError.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNotifyError.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnSettings.Image = Properties.Resources.General;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(1, 1016);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(231, 58);
            btnSettings.TabIndex = 5;
            btnSettings.Tag = "   Configuración";
            btnSettings.Text = "   Configuración";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnChangeTask
            // 
            btnChangeTask.FlatAppearance.BorderSize = 0;
            btnChangeTask.FlatStyle = FlatStyle.Flat;
            btnChangeTask.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnChangeTask.Image = Properties.Resources.exchange;
            btnChangeTask.ImageAlign = ContentAlignment.MiddleLeft;
            btnChangeTask.Location = new Point(0, 246);
            btnChangeTask.Name = "btnChangeTask";
            btnChangeTask.Padding = new Padding(10, 0, 0, 0);
            btnChangeTask.Size = new Size(231, 58);
            btnChangeTask.TabIndex = 2;
            btnChangeTask.Tag = "   Cambiar de tarea";
            btnChangeTask.Text = "   Cambiar de tarea";
            btnChangeTask.TextAlign = ContentAlignment.MiddleLeft;
            btnChangeTask.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChangeTask.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnCheck.Image = Properties.Resources.scanner__1_;
            btnCheck.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheck.Location = new Point(0, 146);
            btnCheck.Name = "btnCheck";
            btnCheck.Padding = new Padding(10, 0, 0, 0);
            btnCheck.Size = new Size(231, 58);
            btnCheck.TabIndex = 1;
            btnCheck.Tag = "   Fichaje";
            btnCheck.Text = "   Fichaje";
            btnCheck.TextAlign = ContentAlignment.MiddleLeft;
            btnCheck.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(btnSideMenu);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(231, 100);
            panelTitle.TabIndex = 0;
            // 
            // btnSideMenu
            // 
            btnSideMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSideMenu.FlatAppearance.BorderSize = 0;
            btnSideMenu.FlatStyle = FlatStyle.Flat;
            btnSideMenu.Image = Properties.Resources.menuIcon;
            btnSideMenu.Location = new Point(193, 11);
            btnSideMenu.Name = "btnSideMenu";
            btnSideMenu.Size = new Size(32, 32);
            btnSideMenu.TabIndex = 0;
            btnSideMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnSideMenu.UseVisualStyleBackColor = true;
            btnSideMenu.Click += btnSideMenu_Click;
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = SystemColors.ButtonHighlight;
            panelTopMenu.Controls.Add(btnMinimize);
            panelTopMenu.Controls.Add(btnMaximize);
            panelTopMenu.Controls.Add(pictureBox2);
            panelTopMenu.Controls.Add(label1);
            panelTopMenu.Controls.Add(btnClose);
            panelTopMenu.Controls.Add(panelLaw);
            panelTopMenu.Controls.Add(panelDateTime);
            panelTopMenu.Controls.Add(lblInstructions);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(231, 0);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(1689, 146);
            panelTopMenu.TabIndex = 1;
            panelTopMenu.MouseDown += panelTopMenu_MouseDown_1;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.minimizeIcon;
            btnMinimize.Location = new Point(1549, 6);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(40, 42);
            btnMinimize.TabIndex = 7;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = Properties.Resources.maximizeIcon;
            btnMaximize.Location = new Point(1596, 6);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 42);
            btnMaximize.TabIndex = 6;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.diservaulecBigLogo;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(329, 146);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label1.Location = new Point(1572, 122);
            label1.Name = "label1";
            label1.Size = new Size(114, 14);
            label1.TabIndex = 4;
            label1.Text = "Versión: 2.4.3.3";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.closeIcon;
            btnClose.Location = new Point(1643, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 42);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panelLaw
            // 
            panelLaw.Controls.Add(lblRealDecretoLey);
            panelLaw.Dock = DockStyle.Top;
            panelLaw.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            panelLaw.ForeColor = Color.DarkRed;
            panelLaw.Location = new Point(0, 0);
            panelLaw.Name = "panelLaw";
            panelLaw.Size = new Size(1689, 21);
            panelLaw.TabIndex = 3;
            // 
            // lblRealDecretoLey
            // 
            lblRealDecretoLey.AutoSize = true;
            lblRealDecretoLey.Location = new Point(411, 3);
            lblRealDecretoLey.Name = "lblRealDecretoLey";
            lblRealDecretoLey.Size = new Size(867, 15);
            lblRealDecretoLey.TabIndex = 0;
            lblRealDecretoLey.Text = "Real Decreto-ley 8/2019 de 8 de Marzo de medidas urgentes de protección social y de lucha contra la precariedad laboral en la jornada de trabajo. (13 Mayo de 2019)";
            lblRealDecretoLey.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelDateTime
            // 
            panelDateTime.Anchor = AnchorStyles.Top;
            panelDateTime.BackColor = Color.Azure;
            panelDateTime.BorderStyle = BorderStyle.Fixed3D;
            panelDateTime.Controls.Add(lblTime);
            panelDateTime.Controls.Add(lblDate);
            panelDateTime.Location = new Point(695, 27);
            panelDateTime.Name = "panelDateTime";
            panelDateTime.Size = new Size(298, 86);
            panelDateTime.TabIndex = 2;
            panelDateTime.Paint += panelDateTime_Paint;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Verdana", 25F, FontStyle.Bold);
            lblTime.Location = new Point(52, 30);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(190, 41);
            lblTime.TabIndex = 1;
            lblTime.Text = "00:00:00";
            lblTime.Click += lblTime_Click;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblDate.Location = new Point(42, 8);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(211, 14);
            lblDate.TabIndex = 0;
            lblDate.Text = "miércoles, 24 de abril de 2024";
            // 
            // lblInstructions
            // 
            lblInstructions.Anchor = AnchorStyles.Bottom;
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Verdana", 9F, FontStyle.Bold);
            lblInstructions.Location = new Point(738, 122);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(212, 14);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Escanee su código con el lector";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panelCheckedUsers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(231, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(1689, 934);
            panel1.TabIndex = 2;
            // 
            // panelCheckedUsers
            // 
            panelCheckedUsers.BackgroundColor = SystemColors.ButtonFace;
            panelCheckedUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            panelCheckedUsers.DefaultCellStyle = dataGridViewCellStyle1;
            panelCheckedUsers.Dock = DockStyle.Fill;
            panelCheckedUsers.Location = new Point(0, 0);
            panelCheckedUsers.Name = "panelCheckedUsers";
            panelCheckedUsers.ReadOnly = true;
            panelCheckedUsers.Size = new Size(1689, 934);
            panelCheckedUsers.TabIndex = 0;
            // 
            // timerHour
            // 
            timerHour.Enabled = true;
            timerHour.Interval = 1000;
            timerHour.Tick += timerHour_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panel1);
            Controls.Add(panelTopMenu);
            Controls.Add(panelSideMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMain_Load;
            panelSideMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitle.ResumeLayout(false);
            panelTopMenu.ResumeLayout(false);
            panelTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelLaw.ResumeLayout(false);
            panelLaw.PerformLayout();
            panelDateTime.ResumeLayout(false);
            panelDateTime.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCheckedUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelTopMenu;
        private Button btnClose;
        private Panel panel1;
        private Button btnSideMenu;
        private Panel panelTitle;
        private PictureBox pictureBox1;
        private Button btnCheck;
        private Button btnUserManagement;
        private Button btnSettings;
        private Button btnNotifyError;
        private Button btnUserPanel;
        private Button btnChangeTask;
        private Label lblInstructions;
        private DataGridView panelCheckedUsers;
        private Panel panelDateTime;
        private Label lblDate;
        private Label lblTime;
        private Panel panelLaw;
        private Label lblRealDecretoLey;
        private System.Windows.Forms.Timer timerHour;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button btnMinimize;
        private Button btnMaximize;
    }
}