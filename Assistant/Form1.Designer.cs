namespace Assistant
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.richTextBox_console = new System.Windows.Forms.RichTextBox();
            this.textBox_leftMouse = new System.Windows.Forms.TextBox();
            this.textBox_rightMouse = new System.Windows.Forms.TextBox();
            this.btn_kofi = new System.Windows.Forms.Button();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.label_eventTypes = new System.Windows.Forms.Label();
            this.panel_events = new System.Windows.Forms.Panel();
            this.pictureBox_warning = new System.Windows.Forms.PictureBox();
            this.textBox_warning = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_status = new System.Windows.Forms.Panel();
            this.label_timeLeft = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.panel_events.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_warning)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(129, 15);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.StartClick);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(128, 63);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.StopClick);
            // 
            // richTextBox_console
            // 
            this.richTextBox_console.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_console.Location = new System.Drawing.Point(0, 427);
            this.richTextBox_console.Name = "richTextBox_console";
            this.richTextBox_console.ReadOnly = true;
            this.richTextBox_console.Size = new System.Drawing.Size(683, 293);
            this.richTextBox_console.TabIndex = 2;
            this.richTextBox_console.Text = "";
            // 
            // textBox_leftMouse
            // 
            this.textBox_leftMouse.Location = new System.Drawing.Point(28, 37);
            this.textBox_leftMouse.Multiline = true;
            this.textBox_leftMouse.Name = "textBox_leftMouse";
            this.textBox_leftMouse.ReadOnly = true;
            this.textBox_leftMouse.Size = new System.Drawing.Size(136, 35);
            this.textBox_leftMouse.TabIndex = 4;
            this.textBox_leftMouse.Text = "LM_D = Left Mouse Down\r\nLM_U = Left Mouse Up";
            // 
            // textBox_rightMouse
            // 
            this.textBox_rightMouse.Location = new System.Drawing.Point(170, 37);
            this.textBox_rightMouse.Multiline = true;
            this.textBox_rightMouse.Name = "textBox_rightMouse";
            this.textBox_rightMouse.ReadOnly = true;
            this.textBox_rightMouse.Size = new System.Drawing.Size(144, 35);
            this.textBox_rightMouse.TabIndex = 5;
            this.textBox_rightMouse.Text = "RM_D = Right Mouse Down\r\nRM_U = Right Mouse Up";
            // 
            // btn_kofi
            // 
            this.btn_kofi.BackgroundImage = global::Assistant.Properties.Resources.BuyMeACoffee_dark_2x;
            this.btn_kofi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kofi.Location = new System.Drawing.Point(248, 113);
            this.btn_kofi.Name = "btn_kofi";
            this.btn_kofi.Size = new System.Drawing.Size(148, 38);
            this.btn_kofi.TabIndex = 7;
            this.btn_kofi.UseVisualStyleBackColor = true;
            this.btn_kofi.Click += new System.EventHandler(this.btn_kofi_Click);
            // 
            // textBox_info
            // 
            this.textBox_info.Location = new System.Drawing.Point(12, 5);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.ReadOnly = true;
            this.textBox_info.Size = new System.Drawing.Size(659, 102);
            this.textBox_info.TabIndex = 8;
            this.textBox_info.Text = resources.GetString("textBox_info.Text");
            // 
            // label_eventTypes
            // 
            this.label_eventTypes.AutoSize = true;
            this.label_eventTypes.Location = new System.Drawing.Point(112, 20);
            this.label_eventTypes.Name = "label_eventTypes";
            this.label_eventTypes.Size = new System.Drawing.Size(107, 13);
            this.label_eventTypes.TabIndex = 9;
            this.label_eventTypes.Text = "Description of events";
            // 
            // panel_events
            // 
            this.panel_events.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_events.Controls.Add(this.label_eventTypes);
            this.panel_events.Controls.Add(this.textBox_leftMouse);
            this.panel_events.Controls.Add(this.textBox_rightMouse);
            this.panel_events.Location = new System.Drawing.Point(293, 281);
            this.panel_events.Name = "panel_events";
            this.panel_events.Size = new System.Drawing.Size(351, 103);
            this.panel_events.TabIndex = 10;
            this.panel_events.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox_warning
            // 
            this.pictureBox_warning.Location = new System.Drawing.Point(10, 39);
            this.pictureBox_warning.Name = "pictureBox_warning";
            this.pictureBox_warning.Size = new System.Drawing.Size(36, 34);
            this.pictureBox_warning.TabIndex = 11;
            this.pictureBox_warning.TabStop = false;
            // 
            // textBox_warning
            // 
            this.textBox_warning.Location = new System.Drawing.Point(56, 10);
            this.textBox_warning.Multiline = true;
            this.textBox_warning.Name = "textBox_warning";
            this.textBox_warning.Size = new System.Drawing.Size(587, 87);
            this.textBox_warning.TabIndex = 12;
            this.textBox_warning.Text = resources.GetString("textBox_warning.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.textBox_warning);
            this.panel2.Controls.Add(this.pictureBox_warning);
            this.panel2.Location = new System.Drawing.Point(12, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 108);
            this.panel2.TabIndex = 13;
            // 
            // panel_status
            // 
            this.panel_status.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_status.Controls.Add(this.label_timeLeft);
            this.panel_status.Controls.Add(this.label_status);
            this.panel_status.Controls.Add(this.btn_start);
            this.panel_status.Controls.Add(this.btn_stop);
            this.panel_status.Location = new System.Drawing.Point(36, 281);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(226, 103);
            this.panel_status.TabIndex = 14;
            // 
            // label_timeLeft
            // 
            this.label_timeLeft.AutoSize = true;
            this.label_timeLeft.Location = new System.Drawing.Point(13, 68);
            this.label_timeLeft.Name = "label_timeLeft";
            this.label_timeLeft.Size = new System.Drawing.Size(82, 13);
            this.label_timeLeft.TabIndex = 11;
            this.label_timeLeft.Text = "placeholder text";
            this.label_timeLeft.Visible = false;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(13, 20);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(83, 13);
            this.label_status.TabIndex = 10;
            this.label_status.Text = "Status: Stopped";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 720);
            this.Controls.Add(this.panel_status);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_events);
            this.Controls.Add(this.btn_kofi);
            this.Controls.Add(this.textBox_info);
            this.Controls.Add(this.richTextBox_console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Assistant";
            this.panel_events.ResumeLayout(false);
            this.panel_events.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_warning)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.RichTextBox richTextBox_console;
        private System.Windows.Forms.TextBox textBox_leftMouse;
        private System.Windows.Forms.TextBox textBox_rightMouse;
        private System.Windows.Forms.Button btn_kofi;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.Label label_eventTypes;
        private System.Windows.Forms.Panel panel_events;
        private System.Windows.Forms.PictureBox pictureBox_warning;
        private System.Windows.Forms.TextBox textBox_warning;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_timeLeft;
    }
}

