namespace Yulgang_Auto_F
{
    partial class Form
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
            if( disposing && ( components != null ) )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.comboBoxButton1 = new System.Windows.Forms.ComboBox();
            this.comboBoxButton2 = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTime1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTime2 = new System.Windows.Forms.ComboBox();
            this.labelTimeout1 = new System.Windows.Forms.Label();
            this.labelTimeout2 = new System.Windows.Forms.Label();
            this.labelYulgang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPID = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerFindPID = new System.Windows.Forms.Timer(this.components);
            this.timerBot1 = new System.Windows.Forms.Timer(this.components);
            this.timerBot2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxButton1
            // 
            this.comboBoxButton1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxButton1.FormattingEnabled = true;
            this.comboBoxButton1.ItemHeight = 16;
            this.comboBoxButton1.Location = new System.Drawing.Point(12, 34);
            this.comboBoxButton1.Name = "comboBoxButton1";
            this.comboBoxButton1.Size = new System.Drawing.Size(51, 24);
            this.comboBoxButton1.TabIndex = 0;
            // 
            // comboBoxButton2
            // 
            this.comboBoxButton2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxButton2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxButton2.FormattingEnabled = true;
            this.comboBoxButton2.Location = new System.Drawing.Point(12, 74);
            this.comboBoxButton2.Name = "comboBoxButton2";
            this.comboBoxButton2.Size = new System.Drawing.Size(51, 24);
            this.comboBoxButton2.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonStart.Location = new System.Drawing.Point(12, 167);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(84, 32);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "เริ่มทำงาน";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.White;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFind.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonFind.Location = new System.Drawing.Point(113, 167);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(108, 32);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "เลือกหน้าจอเกม";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yulgang:";
            // 
            // comboBoxTime1
            // 
            this.comboBoxTime1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxTime1.FormattingEnabled = true;
            this.comboBoxTime1.Location = new System.Drawing.Point(69, 34);
            this.comboBoxTime1.Name = "comboBoxTime1";
            this.comboBoxTime1.Size = new System.Drawing.Size(67, 24);
            this.comboBoxTime1.TabIndex = 5;
            // 
            // comboBoxTime2
            // 
            this.comboBoxTime2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxTime2.FormattingEnabled = true;
            this.comboBoxTime2.Location = new System.Drawing.Point(69, 74);
            this.comboBoxTime2.Name = "comboBoxTime2";
            this.comboBoxTime2.Size = new System.Drawing.Size(67, 24);
            this.comboBoxTime2.TabIndex = 6;
            // 
            // labelTimeout1
            // 
            this.labelTimeout1.AutoSize = true;
            this.labelTimeout1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelTimeout1.Location = new System.Drawing.Point(146, 37);
            this.labelTimeout1.Name = "labelTimeout1";
            this.labelTimeout1.Size = new System.Drawing.Size(13, 16);
            this.labelTimeout1.TabIndex = 7;
            this.labelTimeout1.Text = "-";
            // 
            // labelTimeout2
            // 
            this.labelTimeout2.AutoSize = true;
            this.labelTimeout2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelTimeout2.Location = new System.Drawing.Point(146, 77);
            this.labelTimeout2.Name = "labelTimeout2";
            this.labelTimeout2.Size = new System.Drawing.Size(13, 16);
            this.labelTimeout2.TabIndex = 8;
            this.labelTimeout2.Text = "-";
            // 
            // labelYulgang
            // 
            this.labelYulgang.AutoSize = true;
            this.labelYulgang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelYulgang.Location = new System.Drawing.Point(66, 111);
            this.labelYulgang.Name = "labelYulgang";
            this.labelYulgang.Size = new System.Drawing.Size(13, 16);
            this.labelYulgang.TabIndex = 9;
            this.labelYulgang.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "PID:";
            // 
            // labelPID
            // 
            this.labelPID.AutoSize = true;
            this.labelPID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPID.Location = new System.Drawing.Point(41, 137);
            this.labelPID.Name = "labelPID";
            this.labelPID.Size = new System.Drawing.Size(13, 16);
            this.labelPID.TabIndex = 11;
            this.labelPID.Text = "-";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 211);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(271, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel.Text = "...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(271, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aboutToolStripMenuItem.Text = "เกี่ยวกับ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timerFindPID
            // 
            this.timerFindPID.Tick += new System.EventHandler(this.timerFindPID_Tick);
            // 
            // timerBot1
            // 
            this.timerBot1.Interval = 1000;
            this.timerBot1.Tick += new System.EventHandler(this.timerBot1_Tick);
            // 
            // timerBot2
            // 
            this.timerBot2.Interval = 1000;
            this.timerBot2.Tick += new System.EventHandler(this.timerBot2_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(271, 233);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelPID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelYulgang);
            this.Controls.Add(this.labelTimeout2);
            this.Controls.Add(this.labelTimeout1);
            this.Controls.Add(this.comboBoxTime2);
            this.Controls.Add(this.comboBoxTime1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxButton2);
            this.Controls.Add(this.comboBoxButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Text = "Yulgang Auto F";
            this.Load += new System.EventHandler(this.Form_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxButton1;
        private System.Windows.Forms.ComboBox comboBoxButton2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTime1;
        private System.Windows.Forms.ComboBox comboBoxTime2;
        private System.Windows.Forms.Label labelTimeout1;
        private System.Windows.Forms.Label labelTimeout2;
        private System.Windows.Forms.Label labelYulgang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timerFindPID;
        private System.Windows.Forms.Timer timerBot1;
        private System.Windows.Forms.Timer timerBot2;
    }
}

