
namespace MyAppliedProject
{
    partial class BaseForm
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
            this.WeatherBox = new System.Windows.Forms.TextBox();
            this.WeatherLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.minBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightPanelFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.weatherPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeatherIcon = new System.Windows.Forms.PictureBox();
            this.WeatherButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MarketBox = new System.Windows.Forms.TextBox();
            this.MarketLabel = new System.Windows.Forms.Label();
            this.MarketButton = new System.Windows.Forms.Button();
            this.MarketIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ramBar = new System.Windows.Forms.ProgressBar();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.ramLabel = new System.Windows.Forms.Label();
            this.cpuBar = new System.Windows.Forms.ProgressBar();
            this.separatorPanel = new System.Windows.Forms.Panel();
            this.watchTimer = new System.Windows.Forms.Timer(this.components);
            this.weatherTimer = new System.Windows.Forms.Timer(this.components);
            this.performanceTimer = new System.Windows.Forms.Timer(this.components);
            this.mailTimer = new System.Windows.Forms.Timer(this.components);
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.rightPanelFlow.SuspendLayout();
            this.weatherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarketIcon)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeatherBox
            // 
            this.WeatherBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WeatherBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeatherBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeatherBox.ForeColor = System.Drawing.Color.White;
            this.WeatherBox.Location = new System.Drawing.Point(3, 3);
            this.WeatherBox.Name = "WeatherBox";
            this.WeatherBox.Size = new System.Drawing.Size(87, 20);
            this.WeatherBox.TabIndex = 3;
            // 
            // WeatherLabel
            // 
            this.WeatherLabel.AutoSize = true;
            this.WeatherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WeatherLabel.Location = new System.Drawing.Point(5, 27);
            this.WeatherLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.WeatherLabel.Name = "WeatherLabel";
            this.WeatherLabel.Size = new System.Drawing.Size(0, 17);
            this.WeatherLabel.TabIndex = 4;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titlePanel.Controls.Add(this.SettingsBtn);
            this.titlePanel.Controls.Add(this.TimeLabel);
            this.titlePanel.Controls.Add(this.LogoBox);
            this.titlePanel.Controls.Add(this.minBtn);
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Padding = new System.Windows.Forms.Padding(3);
            this.titlePanel.Size = new System.Drawing.Size(400, 30);
            this.titlePanel.TabIndex = 19;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseUp);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingsBtn.BackgroundImage = global::MyAppliedProject.Properties.Resources.settings;
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SettingsBtn.Location = new System.Drawing.Point(319, 3);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsBtn.Size = new System.Drawing.Size(24, 24);
            this.SettingsBtn.TabIndex = 27;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(28, 3);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(66, 26);
            this.TimeLabel.TabIndex = 25;
            this.TimeLabel.Text = "00:00";
            // 
            // LogoBox
            // 
            this.LogoBox.BackgroundImage = global::MyAppliedProject.Properties.Resources.placeholderlogo;
            this.LogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoBox.Location = new System.Drawing.Point(3, 3);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(5);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Padding = new System.Windows.Forms.Padding(3);
            this.LogoBox.Size = new System.Drawing.Size(25, 24);
            this.LogoBox.TabIndex = 24;
            this.LogoBox.TabStop = false;
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minBtn.Location = new System.Drawing.Point(343, 3);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(27, 24);
            this.minBtn.TabIndex = 22;
            this.minBtn.Text = "_";
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.closeBtn.Location = new System.Drawing.Point(370, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(27, 24);
            this.closeBtn.TabIndex = 21;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 30);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(250, 370);
            this.leftPanel.TabIndex = 20;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.rightPanelFlow);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(250, 30);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(10);
            this.rightPanel.Size = new System.Drawing.Size(150, 370);
            this.rightPanel.TabIndex = 21;
            // 
            // rightPanelFlow
            // 
            this.rightPanelFlow.Controls.Add(this.weatherPanel);
            this.rightPanelFlow.Controls.Add(this.tableLayoutPanel2);
            this.rightPanelFlow.Controls.Add(this.tableLayoutPanel3);
            this.rightPanelFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.rightPanelFlow.Location = new System.Drawing.Point(10, 10);
            this.rightPanelFlow.Name = "rightPanelFlow";
            this.rightPanelFlow.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.rightPanelFlow.Size = new System.Drawing.Size(130, 350);
            this.rightPanelFlow.TabIndex = 15;
            // 
            // weatherPanel
            // 
            this.weatherPanel.ColumnCount = 2;
            this.weatherPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.weatherPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.weatherPanel.Controls.Add(this.WeatherIcon, 1, 1);
            this.weatherPanel.Controls.Add(this.WeatherBox, 0, 0);
            this.weatherPanel.Controls.Add(this.WeatherLabel, 0, 1);
            this.weatherPanel.Controls.Add(this.WeatherButton, 1, 0);
            this.weatherPanel.Location = new System.Drawing.Point(3, 13);
            this.weatherPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.weatherPanel.Name = "weatherPanel";
            this.weatherPanel.RowCount = 2;
            this.weatherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weatherPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.weatherPanel.Size = new System.Drawing.Size(124, 55);
            this.weatherPanel.TabIndex = 15;
            // 
            // WeatherIcon
            // 
            this.WeatherIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WeatherIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeatherIcon.Location = new System.Drawing.Point(96, 30);
            this.WeatherIcon.Name = "WeatherIcon";
            this.WeatherIcon.Size = new System.Drawing.Size(25, 22);
            this.WeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WeatherIcon.TabIndex = 5;
            this.WeatherIcon.TabStop = false;
            // 
            // WeatherButton
            // 
            this.WeatherButton.BackgroundImage = global::MyAppliedProject.Properties.Resources.search;
            this.WeatherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WeatherButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeatherButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WeatherButton.FlatAppearance.BorderSize = 0;
            this.WeatherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeatherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WeatherButton.Location = new System.Drawing.Point(96, 3);
            this.WeatherButton.Name = "WeatherButton";
            this.WeatherButton.Size = new System.Drawing.Size(25, 21);
            this.WeatherButton.TabIndex = 2;
            this.WeatherButton.UseVisualStyleBackColor = true;
            this.WeatherButton.Click += new System.EventHandler(this.WeatherButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.MarketBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MarketLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.MarketButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MarketIcon, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 101);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(124, 55);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // MarketBox
            // 
            this.MarketBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MarketBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MarketBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketBox.ForeColor = System.Drawing.Color.White;
            this.MarketBox.Location = new System.Drawing.Point(3, 3);
            this.MarketBox.Name = "MarketBox";
            this.MarketBox.Size = new System.Drawing.Size(87, 20);
            this.MarketBox.TabIndex = 3;
            // 
            // MarketLabel
            // 
            this.MarketLabel.AutoSize = true;
            this.MarketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarketLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MarketLabel.Location = new System.Drawing.Point(5, 27);
            this.MarketLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.MarketLabel.Name = "MarketLabel";
            this.MarketLabel.Size = new System.Drawing.Size(0, 13);
            this.MarketLabel.TabIndex = 4;
            // 
            // MarketButton
            // 
            this.MarketButton.BackgroundImage = global::MyAppliedProject.Properties.Resources.search;
            this.MarketButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MarketButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MarketButton.FlatAppearance.BorderSize = 0;
            this.MarketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarketButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MarketButton.Location = new System.Drawing.Point(96, 3);
            this.MarketButton.Name = "MarketButton";
            this.MarketButton.Size = new System.Drawing.Size(25, 21);
            this.MarketButton.TabIndex = 2;
            this.MarketButton.UseVisualStyleBackColor = true;
            this.MarketButton.Click += new System.EventHandler(this.MarketButton_Click);
            // 
            // MarketIcon
            // 
            this.MarketIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketIcon.Location = new System.Drawing.Point(96, 30);
            this.MarketIcon.Name = "MarketIcon";
            this.MarketIcon.Size = new System.Drawing.Size(25, 22);
            this.MarketIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MarketIcon.TabIndex = 5;
            this.MarketIcon.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel3.Controls.Add(this.ramBar, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cpuLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ramLabel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cpuBar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 189);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(124, 62);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // ramBar
            // 
            this.ramBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ramBar.ForeColor = System.Drawing.Color.Teal;
            this.ramBar.Location = new System.Drawing.Point(3, 34);
            this.ramBar.Name = "ramBar";
            this.ramBar.Size = new System.Drawing.Size(78, 10);
            this.ramBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ramBar.TabIndex = 8;
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpuLabel.Location = new System.Drawing.Point(89, 0);
            this.cpuLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(0, 13);
            this.cpuLabel.TabIndex = 4;
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ramLabel.Location = new System.Drawing.Point(89, 31);
            this.ramLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(0, 13);
            this.ramLabel.TabIndex = 5;
            // 
            // cpuBar
            // 
            this.cpuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpuBar.ForeColor = System.Drawing.Color.Teal;
            this.cpuBar.Location = new System.Drawing.Point(3, 3);
            this.cpuBar.Name = "cpuBar";
            this.cpuBar.Size = new System.Drawing.Size(78, 10);
            this.cpuBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpuBar.TabIndex = 7;
            // 
            // separatorPanel
            // 
            this.separatorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.separatorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.separatorPanel.Location = new System.Drawing.Point(250, 30);
            this.separatorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.separatorPanel.Name = "separatorPanel";
            this.separatorPanel.Size = new System.Drawing.Size(1, 370);
            this.separatorPanel.TabIndex = 22;
            // 
            // watchTimer
            // 
            this.watchTimer.Enabled = true;
            this.watchTimer.Interval = 60000;
            this.watchTimer.Tick += new System.EventHandler(this.watchTimer_Tick);
            // 
            // weatherTimer
            // 
            this.weatherTimer.Interval = 300000;
            this.weatherTimer.Tick += new System.EventHandler(this.weatherTimer_Tick);
            // 
            // performanceTimer
            // 
            this.performanceTimer.Interval = 2000;
            this.performanceTimer.Tick += new System.EventHandler(this.performanceTimer_Tick);
            // 
            // mailTimer
            // 
            this.mailTimer.Interval = 300000;
            this.mailTimer.Tick += new System.EventHandler(this.mailTimer_Tick);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.separatorPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 800);
            this.MinimumSize = new System.Drawing.Size(250, 400);
            this.Name = "BaseForm";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanelFlow.ResumeLayout(false);
            this.weatherPanel.ResumeLayout(false);
            this.weatherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarketIcon)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button WeatherButton;
        private System.Windows.Forms.TextBox WeatherBox;
        private System.Windows.Forms.Label WeatherLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.FlowLayoutPanel rightPanelFlow;
        private System.Windows.Forms.TableLayoutPanel weatherPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox MarketBox;
        private System.Windows.Forms.Label MarketLabel;
        private System.Windows.Forms.Button MarketButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Panel separatorPanel;
        private System.Windows.Forms.ProgressBar ramBar;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.ProgressBar cpuBar;
        private System.Windows.Forms.PictureBox WeatherIcon;
        private System.Windows.Forms.PictureBox MarketIcon;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Timer watchTimer;
        private System.Windows.Forms.Timer weatherTimer;
        private System.Windows.Forms.Timer performanceTimer;
        private System.Windows.Forms.Timer mailTimer;
    }
}

