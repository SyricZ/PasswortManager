namespace PasswortManager
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tS_Dropcmd = new System.Windows.Forms.ToolStripDropDownButton();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteList = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_Copyright = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tB_SearchField = new System.Windows.Forms.TextBox();
            this.cmd_searchButton = new System.Windows.Forms.Button();
            this.ll_Km = new System.Windows.Forms.LinkLabel();
            this.l_Fragen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_Login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Passwort = new System.Windows.Forms.TextBox();
            this.cmd_Safe = new System.Windows.Forms.Button();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.cmd_Refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cB_SowAh = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tS_Dropcmd,
            this.cmd_Copyright});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(436, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tS_Dropcmd
            // 
            this.tS_Dropcmd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tS_Dropcmd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.DeleteList,
            this.Exit});
            this.tS_Dropcmd.Image = ((System.Drawing.Image)(resources.GetObject("tS_Dropcmd.Image")));
            this.tS_Dropcmd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tS_Dropcmd.Name = "tS_Dropcmd";
            this.tS_Dropcmd.Size = new System.Drawing.Size(47, 22);
            this.tS_Dropcmd.Text = "Datei";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openMenuItem.Text = "Öffnen";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // DeleteList
            // 
            this.DeleteList.Name = "DeleteList";
            this.DeleteList.Size = new System.Drawing.Size(186, 22);
            this.DeleteList.Text = "Passwortliste löschen";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(186, 22);
            this.Exit.Text = "Schließen";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // cmd_Copyright
            // 
            this.cmd_Copyright.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmd_Copyright.Image = ((System.Drawing.Image)(resources.GetObject("cmd_Copyright.Image")));
            this.cmd_Copyright.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmd_Copyright.Name = "cmd_Copyright";
            this.cmd_Copyright.Size = new System.Drawing.Size(64, 22);
            this.cmd_Copyright.Text = "Copyright";
            this.cmd_Copyright.Click += new System.EventHandler(this.cmd_Copyright_Click);
            // 
            // tB_SearchField
            // 
            this.tB_SearchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_SearchField.Location = new System.Drawing.Point(12, 37);
            this.tB_SearchField.Name = "tB_SearchField";
            this.tB_SearchField.Size = new System.Drawing.Size(336, 30);
            this.tB_SearchField.TabIndex = 6;
            // 
            // cmd_searchButton
            // 
            this.cmd_searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_searchButton.BackgroundImage")));
            this.cmd_searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_searchButton.Location = new System.Drawing.Point(354, 37);
            this.cmd_searchButton.Name = "cmd_searchButton";
            this.cmd_searchButton.Size = new System.Drawing.Size(32, 28);
            this.cmd_searchButton.TabIndex = 7;
            this.cmd_searchButton.UseVisualStyleBackColor = true;
            this.cmd_searchButton.Click += new System.EventHandler(this.cmd_searchButton_Click);
            // 
            // ll_Km
            // 
            this.ll_Km.AutoSize = true;
            this.ll_Km.Location = new System.Drawing.Point(128, 452);
            this.ll_Km.Name = "ll_Km";
            this.ll_Km.Size = new System.Drawing.Size(83, 13);
            this.ll_Km.TabIndex = 8;
            this.ll_Km.TabStop = true;
            this.ll_Km.Text = "Kontaktier mich,";
            this.ll_Km.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Km_LinkClicked);
            // 
            // l_Fragen
            // 
            this.l_Fragen.AutoSize = true;
            this.l_Fragen.Location = new System.Drawing.Point(207, 452);
            this.l_Fragen.Name = "l_Fragen";
            this.l_Fragen.Size = new System.Drawing.Size(102, 13);
            this.l_Fragen.TabIndex = 9;
            this.l_Fragen.Text = "falls du Fragen hast!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // tB_Name
            // 
            this.tB_Name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tB_Name.Location = new System.Drawing.Point(15, 101);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(100, 20);
            this.tB_Name.TabIndex = 11;
            this.tB_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Login:";
            // 
            // tB_Login
            // 
            this.tB_Login.Location = new System.Drawing.Point(174, 101);
            this.tB_Login.Name = "tB_Login";
            this.tB_Login.Size = new System.Drawing.Size(100, 20);
            this.tB_Login.TabIndex = 13;
            this.tB_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Passwort:";
            // 
            // tB_Passwort
            // 
            this.tB_Passwort.Location = new System.Drawing.Point(324, 101);
            this.tB_Passwort.Name = "tB_Passwort";
            this.tB_Passwort.Size = new System.Drawing.Size(100, 20);
            this.tB_Passwort.TabIndex = 15;
            this.tB_Passwort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Passwort.TextChanged += new System.EventHandler(this.tB_Passwort_TextChanged);
            // 
            // cmd_Safe
            // 
            this.cmd_Safe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_Safe.BackgroundImage")));
            this.cmd_Safe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_Safe.Location = new System.Drawing.Point(392, 134);
            this.cmd_Safe.Name = "cmd_Safe";
            this.cmd_Safe.Size = new System.Drawing.Size(32, 28);
            this.cmd_Safe.TabIndex = 16;
            this.cmd_Safe.UseVisualStyleBackColor = true;
            this.cmd_Safe.Click += new System.EventHandler(this.cmd_Safe_Click);
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayout.Location = new System.Drawing.Point(15, 176);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(409, 273);
            this.flowLayout.TabIndex = 18;
            this.flowLayout.WrapContents = false;
            // 
            // cmd_Refresh
            // 
            this.cmd_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_Refresh.BackgroundImage")));
            this.cmd_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_Refresh.Location = new System.Drawing.Point(354, 134);
            this.cmd_Refresh.Name = "cmd_Refresh";
            this.cmd_Refresh.Size = new System.Drawing.Size(32, 29);
            this.cmd_Refresh.TabIndex = 19;
            this.cmd_Refresh.UseVisualStyleBackColor = true;
            this.cmd_Refresh.Click += new System.EventHandler(this.cmd_Refresh_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(392, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 29);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cB_SowAh
            // 
            this.cB_SowAh.AutoSize = true;
            this.cB_SowAh.Location = new System.Drawing.Point(15, 141);
            this.cB_SowAh.Name = "cB_SowAh";
            this.cB_SowAh.Size = new System.Drawing.Size(244, 17);
            this.cB_SowAh.TabIndex = 21;
            this.cB_SowAh.Text = "Speichern ohne weitere Angabe hinzuzufügen";
            this.cB_SowAh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 474);
            this.Controls.Add(this.cB_SowAh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmd_Refresh);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.cmd_Safe);
            this.Controls.Add(this.tB_Passwort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_Fragen);
            this.Controls.Add(this.ll_Km);
            this.Controls.Add(this.cmd_searchButton);
            this.Controls.Add(this.tB_SearchField);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Passwort Manager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripDropDownButton tS_Dropcmd;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteList;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.TextBox tB_SearchField;
        private System.Windows.Forms.Button cmd_searchButton;
        private System.Windows.Forms.ToolStripButton cmd_Copyright;
        private System.Windows.Forms.LinkLabel ll_Km;
        private System.Windows.Forms.Label l_Fragen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Passwort;
        private System.Windows.Forms.Button cmd_Safe;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Button cmd_Refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cB_SowAh;
    }
}

