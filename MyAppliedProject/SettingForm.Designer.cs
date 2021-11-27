
namespace MyAppliedProject
{
    partial class SettingForm
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.upBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.rightBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.ColorBox = new System.Windows.Forms.PictureBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.WeatherCheck = new System.Windows.Forms.CheckBox();
            this.MarketCheck = new System.Windows.Forms.CheckBox();
            this.PerformanceCheck = new System.Windows.Forms.CheckBox();
            this.titlePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titlePanel.Controls.Add(this.closeBtn);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(300, 24);
            this.titlePanel.TabIndex = 20;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseUp);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.closeBtn.Location = new System.Drawing.Point(279, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(21, 24);
            this.closeBtn.TabIndex = 21;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ColorBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(153, 276);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.upBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.leftBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.rightBtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.downBtn, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(147, 132);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // upBtn
            // 
            this.upBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.upBtn.BackgroundImage = global::MyAppliedProject.Properties.Resources.up;
            this.upBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.upBtn.FlatAppearance.BorderSize = 0;
            this.upBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.upBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.upBtn.Location = new System.Drawing.Point(52, 3);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(43, 38);
            this.upBtn.TabIndex = 25;
            this.upBtn.UseVisualStyleBackColor = false;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.leftBtn.BackgroundImage = global::MyAppliedProject.Properties.Resources.left;
            this.leftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftBtn.FlatAppearance.BorderSize = 0;
            this.leftBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.leftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftBtn.Location = new System.Drawing.Point(3, 47);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(43, 38);
            this.leftBtn.TabIndex = 24;
            this.leftBtn.UseVisualStyleBackColor = false;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // rightBtn
            // 
            this.rightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rightBtn.BackgroundImage = global::MyAppliedProject.Properties.Resources.right;
            this.rightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightBtn.FlatAppearance.BorderSize = 0;
            this.rightBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightBtn.Location = new System.Drawing.Point(101, 47);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(43, 38);
            this.rightBtn.TabIndex = 23;
            this.rightBtn.UseVisualStyleBackColor = false;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.downBtn.BackgroundImage = global::MyAppliedProject.Properties.Resources.down;
            this.downBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.downBtn.FlatAppearance.BorderSize = 0;
            this.downBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.downBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.downBtn.Location = new System.Drawing.Point(52, 91);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(43, 38);
            this.downBtn.TabIndex = 26;
            this.downBtn.UseVisualStyleBackColor = false;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // ColorBox
            // 
            this.ColorBox.BackgroundImage = global::MyAppliedProject.Properties.Resources.color;
            this.ColorBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ColorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ColorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorBox.Location = new System.Drawing.Point(3, 141);
            this.ColorBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(147, 135);
            this.ColorBox.TabIndex = 1;
            this.ColorBox.TabStop = false;
            this.ColorBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorBox_MouseDown);
            this.ColorBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorBox_MouseMove);
            this.ColorBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColorBox_MouseUp);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClearBtn.Location = new System.Drawing.Point(8, 8);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(131, 26);
            this.ClearBtn.TabIndex = 0;
            this.ClearBtn.Text = "Clear Settings and Data";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveBtn.Location = new System.Drawing.Point(8, 40);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(131, 27);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save New Settings";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.SaveBtn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ClearBtn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(153, 225);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(147, 75);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.WeatherCheck);
            this.flowLayoutPanel1.Controls.Add(this.MarketCheck);
            this.flowLayoutPanel1.Controls.Add(this.PerformanceCheck);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(153, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(147, 201);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // WeatherCheck
            // 
            this.WeatherCheck.AutoSize = true;
            this.WeatherCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WeatherCheck.Checked = true;
            this.WeatherCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WeatherCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.WeatherCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WeatherCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WeatherCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeatherCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WeatherCheck.Location = new System.Drawing.Point(8, 8);
            this.WeatherCheck.Name = "WeatherCheck";
            this.WeatherCheck.Size = new System.Drawing.Size(83, 17);
            this.WeatherCheck.TabIndex = 8;
            this.WeatherCheck.Text = "Weather";
            this.WeatherCheck.UseVisualStyleBackColor = false;
            this.WeatherCheck.CheckedChanged += new System.EventHandler(this.WeatherCheck_CheckedChanged);
            // 
            // MarketCheck
            // 
            this.MarketCheck.AutoSize = true;
            this.MarketCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MarketCheck.Checked = true;
            this.MarketCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MarketCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarketCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MarketCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MarketCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarketCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarketCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MarketCheck.Location = new System.Drawing.Point(8, 31);
            this.MarketCheck.Name = "MarketCheck";
            this.MarketCheck.Size = new System.Drawing.Size(83, 17);
            this.MarketCheck.TabIndex = 9;
            this.MarketCheck.Text = "Stock";
            this.MarketCheck.UseVisualStyleBackColor = false;
            this.MarketCheck.CheckedChanged += new System.EventHandler(this.MarketCheck_CheckedChanged);
            // 
            // PerformanceCheck
            // 
            this.PerformanceCheck.AutoSize = true;
            this.PerformanceCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PerformanceCheck.Checked = true;
            this.PerformanceCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PerformanceCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.PerformanceCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PerformanceCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PerformanceCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerformanceCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerformanceCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PerformanceCheck.Location = new System.Drawing.Point(8, 54);
            this.PerformanceCheck.Name = "PerformanceCheck";
            this.PerformanceCheck.Size = new System.Drawing.Size(83, 17);
            this.PerformanceCheck.TabIndex = 10;
            this.PerformanceCheck.Text = "Performance";
            this.PerformanceCheck.UseVisualStyleBackColor = false;
            this.PerformanceCheck.CheckedChanged += new System.EventHandler(this.PerformanceCheck_CheckedChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.titlePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox WeatherCheck;
        private System.Windows.Forms.CheckBox MarketCheck;
        private System.Windows.Forms.CheckBox PerformanceCheck;
        private System.Windows.Forms.PictureBox ColorBox;
    }
}