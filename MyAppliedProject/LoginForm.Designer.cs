
namespace MyAppliedProject
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserLoginBox = new System.Windows.Forms.TextBox();
            this.PassLoginBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.signInBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveCheck = new System.Windows.Forms.CheckBox();
            this.OutlookButton = new System.Windows.Forms.Button();
            this.GmailButton = new System.Windows.Forms.Button();
            this.RoundcubeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLoginBox
            // 
            this.UserLoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserLoginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserLoginBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserLoginBox.ForeColor = System.Drawing.Color.White;
            this.UserLoginBox.Location = new System.Drawing.Point(13, 211);
            this.UserLoginBox.Name = "UserLoginBox";
            this.UserLoginBox.Size = new System.Drawing.Size(219, 20);
            this.UserLoginBox.TabIndex = 19;
            this.UserLoginBox.Text = "Email";
            // 
            // PassLoginBox
            // 
            this.PassLoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassLoginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassLoginBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PassLoginBox.ForeColor = System.Drawing.Color.White;
            this.PassLoginBox.Location = new System.Drawing.Point(13, 237);
            this.PassLoginBox.Name = "PassLoginBox";
            this.PassLoginBox.Size = new System.Drawing.Size(219, 20);
            this.PassLoginBox.TabIndex = 20;
            this.PassLoginBox.Text = "Password";
            this.PassLoginBox.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.signInBtn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PassLoginBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.UserLoginBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SaveCheck, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 480);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // signInBtn
            // 
            this.signInBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.signInBtn.Location = new System.Drawing.Point(13, 262);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(219, 26);
            this.signInBtn.TabIndex = 21;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.OutlookButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.GmailButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.RoundcubeButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(219, 44);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // SaveCheck
            // 
            this.SaveCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCheck.AutoSize = true;
            this.SaveCheck.Checked = true;
            this.SaveCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCheck.Location = new System.Drawing.Point(135, 297);
            this.SaveCheck.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.SaveCheck.Name = "SaveCheck";
            this.SaveCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaveCheck.Size = new System.Drawing.Size(97, 17);
            this.SaveCheck.TabIndex = 23;
            this.SaveCheck.Text = "Save Password";
            this.SaveCheck.UseVisualStyleBackColor = true;
            this.SaveCheck.CheckedChanged += new System.EventHandler(this.SaveCheck_CheckedChanged);
            // 
            // OutlookButton
            // 
            this.OutlookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OutlookButton.BackgroundImage")));
            this.OutlookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OutlookButton.FlatAppearance.BorderSize = 0;
            this.OutlookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutlookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OutlookButton.Location = new System.Drawing.Point(115, 7);
            this.OutlookButton.Margin = new System.Windows.Forms.Padding(7);
            this.OutlookButton.Name = "OutlookButton";
            this.OutlookButton.Size = new System.Drawing.Size(38, 30);
            this.OutlookButton.TabIndex = 1;
            this.OutlookButton.UseVisualStyleBackColor = true;
            this.OutlookButton.Click += new System.EventHandler(this.OutlookButton_Click);
            // 
            // GmailButton
            // 
            this.GmailButton.BackgroundImage = global::MyAppliedProject.Properties.Resources.gmail_logo;
            this.GmailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GmailButton.FlatAppearance.BorderSize = 0;
            this.GmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GmailButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GmailButton.Location = new System.Drawing.Point(61, 7);
            this.GmailButton.Margin = new System.Windows.Forms.Padding(7);
            this.GmailButton.Name = "GmailButton";
            this.GmailButton.Size = new System.Drawing.Size(38, 30);
            this.GmailButton.TabIndex = 0;
            this.GmailButton.UseVisualStyleBackColor = true;
            this.GmailButton.Click += new System.EventHandler(this.GmailButton_Click);
            // 
            // RoundcubeButton
            // 
            this.RoundcubeButton.BackgroundImage = global::MyAppliedProject.Properties.Resources.Roundcube_Webmail_Logo;
            this.RoundcubeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RoundcubeButton.FlatAppearance.BorderSize = 0;
            this.RoundcubeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoundcubeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RoundcubeButton.Location = new System.Drawing.Point(7, 7);
            this.RoundcubeButton.Margin = new System.Windows.Forms.Padding(7);
            this.RoundcubeButton.Name = "RoundcubeButton";
            this.RoundcubeButton.Size = new System.Drawing.Size(38, 30);
            this.RoundcubeButton.TabIndex = 2;
            this.RoundcubeButton.UseVisualStyleBackColor = true;
            this.RoundcubeButton.Click += new System.EventHandler(this.RoundcubeButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(245, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form3";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserLoginBox;
        private System.Windows.Forms.TextBox PassLoginBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button GmailButton;
        private System.Windows.Forms.Button OutlookButton;
        private System.Windows.Forms.CheckBox SaveCheck;
        private System.Windows.Forms.Button RoundcubeButton;
    }
}