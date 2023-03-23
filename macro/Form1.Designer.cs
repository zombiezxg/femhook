namespace macro
{
    partial class femhook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(femhook));
            this.triggerwall = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.macro = new System.Windows.Forms.Timer(this.components);
            this.macrobutton = new System.Windows.Forms.CheckBox();
            this.hidebutton = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.triggerwallbutton = new System.Windows.Forms.CheckBox();
            this.layerrushbutton = new System.Windows.Forms.CheckBox();
            this.tunnelbutton = new System.Windows.Forms.CheckBox();
            this.towerbutton = new System.Windows.Forms.CheckBox();
            this.norecoilbutton = new System.Windows.Forms.CheckBox();
            this.bindedit = new System.Windows.Forms.Timer(this.components);
            this.btBind = new System.Windows.Forms.Button();
            this.ramprush = new System.Windows.Forms.Timer(this.components);
            this.tower = new System.Windows.Forms.Timer(this.components);
            this.astolfo = new System.Windows.Forms.PictureBox();
            this.astolfobutton = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.astolfo)).BeginInit();
            this.SuspendLayout();
            // 
            // triggerwall
            // 
            this.triggerwall.Enabled = true;
            this.triggerwall.Interval = 10;
            this.triggerwall.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 5);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // settingbutton
            // 
            this.settingbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.settingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingbutton.ForeColor = System.Drawing.Color.White;
            this.settingbutton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.settingbutton.Location = new System.Drawing.Point(131, 41);
            this.settingbutton.Name = "settingbutton";
            this.settingbutton.Size = new System.Drawing.Size(123, 27);
            this.settingbutton.TabIndex = 2;
            this.settingbutton.Text = "Setting";
            this.settingbutton.UseVisualStyleBackColor = false;
            this.settingbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "FEMHOOK V.1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mainbutton
            // 
            this.mainbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.mainbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainbutton.ForeColor = System.Drawing.Color.White;
            this.mainbutton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.mainbutton.Location = new System.Drawing.Point(2, 41);
            this.mainbutton.Name = "mainbutton";
            this.mainbutton.Size = new System.Drawing.Size(123, 27);
            this.mainbutton.TabIndex = 1;
            this.mainbutton.Text = "Main";
            this.mainbutton.UseVisualStyleBackColor = false;
            this.mainbutton.Click += new System.EventHandler(this.mainbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(15, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 3);
            this.panel2.TabIndex = 6;
            // 
            // macro
            // 
            this.macro.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // macrobutton
            // 
            this.macrobutton.AutoSize = true;
            this.macrobutton.ForeColor = System.Drawing.Color.White;
            this.macrobutton.Location = new System.Drawing.Point(15, 86);
            this.macrobutton.Name = "macrobutton";
            this.macrobutton.Size = new System.Drawing.Size(44, 17);
            this.macrobutton.TabIndex = 7;
            this.macrobutton.Text = "Edit";
            this.macrobutton.UseVisualStyleBackColor = true;
            this.macrobutton.CheckedChanged += new System.EventHandler(this.macrobutton_CheckedChanged);
            // 
            // hidebutton
            // 
            this.hidebutton.AutoSize = true;
            this.hidebutton.Location = new System.Drawing.Point(-100, 294);
            this.hidebutton.Name = "hidebutton";
            this.hidebutton.Size = new System.Drawing.Size(15, 14);
            this.hidebutton.TabIndex = 8;
            this.hidebutton.UseVisualStyleBackColor = true;
            this.hidebutton.CheckedChanged += new System.EventHandler(this.hidebutton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(235, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 30);
            this.panel3.TabIndex = 11;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_event);
            // 
            // triggerwallbutton
            // 
            this.triggerwallbutton.AutoSize = true;
            this.triggerwallbutton.ForeColor = System.Drawing.Color.White;
            this.triggerwallbutton.Location = new System.Drawing.Point(15, 109);
            this.triggerwallbutton.Name = "triggerwallbutton";
            this.triggerwallbutton.Size = new System.Drawing.Size(83, 17);
            this.triggerwallbutton.TabIndex = 12;
            this.triggerwallbutton.Text = "Trigger Wall";
            this.triggerwallbutton.UseVisualStyleBackColor = true;
            this.triggerwallbutton.CheckedChanged += new System.EventHandler(this.takewallbutton_CheckedChanged);
            // 
            // layerrushbutton
            // 
            this.layerrushbutton.AutoSize = true;
            this.layerrushbutton.ForeColor = System.Drawing.Color.White;
            this.layerrushbutton.Location = new System.Drawing.Point(15, 132);
            this.layerrushbutton.Name = "layerrushbutton";
            this.layerrushbutton.Size = new System.Drawing.Size(80, 17);
            this.layerrushbutton.TabIndex = 13;
            this.layerrushbutton.Text = "Layer Rush";
            this.layerrushbutton.UseVisualStyleBackColor = true;
            this.layerrushbutton.CheckedChanged += new System.EventHandler(this.layerrushbutton_CheckedChanged);
            // 
            // tunnelbutton
            // 
            this.tunnelbutton.AutoSize = true;
            this.tunnelbutton.ForeColor = System.Drawing.Color.White;
            this.tunnelbutton.Location = new System.Drawing.Point(15, 155);
            this.tunnelbutton.Name = "tunnelbutton";
            this.tunnelbutton.Size = new System.Drawing.Size(59, 17);
            this.tunnelbutton.TabIndex = 14;
            this.tunnelbutton.Text = "Tunnel";
            this.tunnelbutton.UseVisualStyleBackColor = true;
            // 
            // towerbutton
            // 
            this.towerbutton.AutoSize = true;
            this.towerbutton.ForeColor = System.Drawing.Color.White;
            this.towerbutton.Location = new System.Drawing.Point(15, 178);
            this.towerbutton.Name = "towerbutton";
            this.towerbutton.Size = new System.Drawing.Size(43, 17);
            this.towerbutton.TabIndex = 15;
            this.towerbutton.Text = "90s";
            this.towerbutton.UseVisualStyleBackColor = true;
            this.towerbutton.CheckedChanged += new System.EventHandler(this.towerbutton_CheckedChanged);
            // 
            // norecoilbutton
            // 
            this.norecoilbutton.AutoSize = true;
            this.norecoilbutton.ForeColor = System.Drawing.Color.White;
            this.norecoilbutton.Location = new System.Drawing.Point(16, 201);
            this.norecoilbutton.Name = "norecoilbutton";
            this.norecoilbutton.Size = new System.Drawing.Size(68, 17);
            this.norecoilbutton.TabIndex = 16;
            this.norecoilbutton.Text = "No recoil";
            this.norecoilbutton.UseVisualStyleBackColor = true;
            // 
            // bindedit
            // 
            this.bindedit.Interval = 150;
            this.bindedit.Tick += new System.EventHandler(this.bindedit_Tick);
            // 
            // btBind
            // 
            this.btBind.BackColor = System.Drawing.Color.Black;
            this.btBind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBind.ForeColor = System.Drawing.Color.White;
            this.btBind.Location = new System.Drawing.Point(15, 278);
            this.btBind.Name = "btBind";
            this.btBind.Size = new System.Drawing.Size(41, 21);
            this.btBind.TabIndex = 18;
            this.btBind.Text = "none";
            this.btBind.UseVisualStyleBackColor = false;
            this.btBind.Click += new System.EventHandler(this.btBind_Click);
            this.btBind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button2_KeyUp);
            // 
            // ramprush
            // 
            this.ramprush.Tick += new System.EventHandler(this.ramprush_Tick);
            // 
            // tower
            // 
            this.tower.Tick += new System.EventHandler(this.tower_Tick);
            // 
            // astolfo
            // 
            this.astolfo.Image = ((System.Drawing.Image)(resources.GetObject("astolfo.Image")));
            this.astolfo.Location = new System.Drawing.Point(245, 74);
            this.astolfo.Name = "astolfo";
            this.astolfo.Size = new System.Drawing.Size(123, 186);
            this.astolfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.astolfo.TabIndex = 19;
            this.astolfo.TabStop = false;
            // 
            // astolfobutton
            // 
            this.astolfobutton.AutoSize = true;
            this.astolfobutton.Checked = true;
            this.astolfobutton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.astolfobutton.ForeColor = System.Drawing.Color.White;
            this.astolfobutton.Location = new System.Drawing.Point(-100, 294);
            this.astolfobutton.Name = "astolfobutton";
            this.astolfobutton.Size = new System.Drawing.Size(58, 17);
            this.astolfobutton.TabIndex = 20;
            this.astolfobutton.Text = "Astolfo";
            this.astolfobutton.UseVisualStyleBackColor = true;
            this.astolfobutton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCoral;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(-1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 1);
            this.panel4.TabIndex = 21;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // femhook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(254, 311);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.astolfobutton);
            this.Controls.Add(this.astolfo);
            this.Controls.Add(this.btBind);
            this.Controls.Add(this.norecoilbutton);
            this.Controls.Add(this.towerbutton);
            this.Controls.Add(this.tunnelbutton);
            this.Controls.Add(this.layerrushbutton);
            this.Controls.Add(this.triggerwallbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hidebutton);
            this.Controls.Add(this.macrobutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "femhook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FEMHOOK";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.astolfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer triggerwall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button settingbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mainbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer macro;
        private System.Windows.Forms.CheckBox macrobutton;
        private System.Windows.Forms.CheckBox hidebutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox triggerwallbutton;
        private System.Windows.Forms.CheckBox layerrushbutton;
        private System.Windows.Forms.CheckBox tunnelbutton;
        private System.Windows.Forms.CheckBox towerbutton;
        private System.Windows.Forms.CheckBox norecoilbutton;
        private System.Windows.Forms.Timer bindedit;
        private System.Windows.Forms.Button btBind;
        private System.Windows.Forms.Timer ramprush;
        private System.Windows.Forms.Timer tower;
        private System.Windows.Forms.PictureBox astolfo;
        private System.Windows.Forms.CheckBox astolfobutton;
        private System.Windows.Forms.Panel panel4;
    }
}

