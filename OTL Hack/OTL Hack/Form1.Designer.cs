namespace OTL_Hack
{
    partial class Messages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.Send_Button = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.BottomBar = new System.Windows.Forms.PictureBox();
            this.TopBar = new System.Windows.Forms.PictureBox();
            this.delay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BottomBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(289, 509);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(43, 23);
            this.Send_Button.TabIndex = 0;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Visible = false;
            this.Send_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox
            // 
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(114, 546);
            this.TextBox.MaxLength = 100;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(187, 16);
            this.TextBox.TabIndex = 1;
            this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // BottomBar
            // 
            this.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBar.Image = global::OTL_Hack.Properties.Resources.BottomBar;
            this.BottomBar.Location = new System.Drawing.Point(0, 538);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(344, 34);
            this.BottomBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomBar.TabIndex = 3;
            this.BottomBar.TabStop = false;
            // 
            // TopBar
            // 
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Image = global::OTL_Hack.Properties.Resources.TopBar2;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(344, 76);
            this.TopBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopBar.TabIndex = 2;
            this.TopBar.TabStop = false;
            // 
            // delay
            // 
            this.delay.Enabled = true;
            this.delay.Interval = 300;
            this.delay.Tick += new System.EventHandler(this.messagedelay);
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 572);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.BottomBar);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Messages";
            this.Text = "Messages";
            ((System.ComponentModel.ISupportInitialize)(this.BottomBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.PictureBox MB1;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.PictureBox TopBar;
        private System.Windows.Forms.PictureBox BottomBar;
        private System.Windows.Forms.Timer delay;
    }
}

