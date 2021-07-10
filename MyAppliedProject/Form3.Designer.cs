
namespace MyAppliedProject
{
    partial class Form3
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
            this.UserLoginBox = new System.Windows.Forms.TextBox();
            this.PassLoginBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.signInBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLoginBox
            // 
            this.UserLoginBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserLoginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserLoginBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserLoginBox.ForeColor = System.Drawing.Color.White;
            this.UserLoginBox.Location = new System.Drawing.Point(13, 204);
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
            this.PassLoginBox.Location = new System.Drawing.Point(13, 230);
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
            this.tableLayoutPanel1.Controls.Add(this.signInBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UserLoginBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PassLoginBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
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
            this.signInBtn.Location = new System.Drawing.Point(13, 255);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(219, 26);
            this.signInBtn.TabIndex = 21;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(245, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserLoginBox;
        private System.Windows.Forms.TextBox PassLoginBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button signInBtn;
    }
}