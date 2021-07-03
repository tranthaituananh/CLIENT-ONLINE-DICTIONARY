
namespace Client
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.btnExport = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Ip = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wbOutput = new System.Windows.Forms.WebBrowser();
            this.label5 = new System.Windows.Forms.Label();
            this.lvSearchHistory = new System.Windows.Forms.ListView();
            this.btnListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(28, 495);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(275, 60);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(467, 284);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(127, 60);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "→";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(702, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 44);
            this.label4.TabIndex = 34;
            this.label4.Text = "Vietnamese";
            // 
            // rtbInput
            // 
            this.rtbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInput.Location = new System.Drawing.Point(28, 227);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(419, 241);
            this.rtbInput.TabIndex = 2;
            this.rtbInput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 44);
            this.label3.TabIndex = 32;
            this.label3.Text = "Server IP";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(328, 495);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 60);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 44);
            this.label2.TabIndex = 30;
            this.label2.Text = "English";
            // 
            // Ip
            // 
            this.Ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ip.Location = new System.Drawing.Point(522, 70);
            this.Ip.Multiline = true;
            this.Ip.Name = "Ip";
            this.Ip.Size = new System.Drawing.Size(265, 45);
            this.Ip.TabIndex = 0;
            this.Ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(822, 70);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(181, 45);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(610, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 44);
            this.label1.TabIndex = 27;
            this.label1.Text = "CLIENT";
            // 
            // wbOutput
            // 
            this.wbOutput.Location = new System.Drawing.Point(618, 227);
            this.wbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.wbOutput.MinimumSize = new System.Drawing.Size(27, 25);
            this.wbOutput.Name = "wbOutput";
            this.wbOutput.Size = new System.Drawing.Size(426, 337);
            this.wbOutput.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1106, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 44);
            this.label5.TabIndex = 40;
            this.label5.Text = "Search history";
            // 
            // lvSearchHistory
            // 
            this.lvSearchHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSearchHistory.Enabled = false;
            this.lvSearchHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSearchHistory.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lvSearchHistory.HideSelection = false;
            this.lvSearchHistory.Location = new System.Drawing.Point(1074, 227);
            this.lvSearchHistory.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.lvSearchHistory.Name = "lvSearchHistory";
            this.lvSearchHistory.Size = new System.Drawing.Size(322, 337);
            this.lvSearchHistory.TabIndex = 41;
            this.lvSearchHistory.UseCompatibleStateImageBehavior = false;
            this.lvSearchHistory.View = System.Windows.Forms.View.List;
            // 
            // btnListen
            // 
            this.btnListen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(467, 367);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(127, 60);
            this.btnListen.TabIndex = 42;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = false;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1433, 597);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.lvSearchHistory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wbOutput);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ip);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENT _ NHÓM 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ip;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser wbOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvSearchHistory;
        private System.Windows.Forms.Button btnListen;
    }
}

