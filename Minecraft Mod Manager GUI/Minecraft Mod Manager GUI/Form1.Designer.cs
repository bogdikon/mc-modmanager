namespace Minecraft_Mod_Manager_GUI
{
    partial class Form1
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
            this.modpacksGroup = new System.Windows.Forms.GroupBox();
            this.packList = new System.Windows.Forms.ListBox();
            this.infoGroup = new System.Windows.Forms.GroupBox();
            this.packInfoVersion = new System.Windows.Forms.Label();
            this.packInfoDesc = new System.Windows.Forms.Label();
            this.packInfoName = new System.Windows.Forms.Label();
            this.logoGroup = new System.Windows.Forms.GroupBox();
            this.packLogo = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.modpacksGroup.SuspendLayout();
            this.infoGroup.SuspendLayout();
            this.logoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // modpacksGroup
            // 
            this.modpacksGroup.Controls.Add(this.packList);
            this.modpacksGroup.Location = new System.Drawing.Point(12, 12);
            this.modpacksGroup.Name = "modpacksGroup";
            this.modpacksGroup.Size = new System.Drawing.Size(266, 416);
            this.modpacksGroup.TabIndex = 0;
            this.modpacksGroup.TabStop = false;
            this.modpacksGroup.Text = "Mod Packs";
            // 
            // packList
            // 
            this.packList.FormattingEnabled = true;
            this.packList.Location = new System.Drawing.Point(7, 20);
            this.packList.Name = "packList";
            this.packList.Size = new System.Drawing.Size(253, 381);
            this.packList.TabIndex = 0;
            this.packList.SelectedIndexChanged += new System.EventHandler(this.modList_SelectedIndexChanged);
            // 
            // infoGroup
            // 
            this.infoGroup.Controls.Add(this.packInfoVersion);
            this.infoGroup.Controls.Add(this.packInfoDesc);
            this.infoGroup.Controls.Add(this.packInfoName);
            this.infoGroup.Location = new System.Drawing.Point(284, 12);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(266, 186);
            this.infoGroup.TabIndex = 1;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "Info";
            // 
            // packInfoVersion
            // 
            this.packInfoVersion.AutoSize = true;
            this.packInfoVersion.Location = new System.Drawing.Point(7, 46);
            this.packInfoVersion.Name = "packInfoVersion";
            this.packInfoVersion.Size = new System.Drawing.Size(91, 13);
            this.packInfoVersion.TabIndex = 3;
            this.packInfoVersion.Text = "Minecraft version:";
            // 
            // packInfoDesc
            // 
            this.packInfoDesc.AutoSize = true;
            this.packInfoDesc.Location = new System.Drawing.Point(7, 33);
            this.packInfoDesc.Name = "packInfoDesc";
            this.packInfoDesc.Size = new System.Drawing.Size(89, 13);
            this.packInfoDesc.TabIndex = 2;
            this.packInfoDesc.Text = "Pack description:";
            // 
            // packInfoName
            // 
            this.packInfoName.AutoSize = true;
            this.packInfoName.Location = new System.Drawing.Point(7, 20);
            this.packInfoName.Name = "packInfoName";
            this.packInfoName.Size = new System.Drawing.Size(64, 13);
            this.packInfoName.TabIndex = 1;
            this.packInfoName.Text = "Pack name:";
            // 
            // logoGroup
            // 
            this.logoGroup.Controls.Add(this.packLogo);
            this.logoGroup.Location = new System.Drawing.Point(284, 204);
            this.logoGroup.Name = "logoGroup";
            this.logoGroup.Size = new System.Drawing.Size(142, 156);
            this.logoGroup.TabIndex = 2;
            this.logoGroup.TabStop = false;
            this.logoGroup.Text = "Logo";
            // 
            // packLogo
            // 
            this.packLogo.Location = new System.Drawing.Point(6, 19);
            this.packLogo.Name = "packLogo";
            this.packLogo.Size = new System.Drawing.Size(128, 128);
            this.packLogo.TabIndex = 0;
            this.packLogo.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Swap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 30);
            this.button3.TabIndex = 6;
            this.button3.Text = "Refresh list";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 440);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logoGroup);
            this.Controls.Add(this.infoGroup);
            this.Controls.Add(this.modpacksGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Minecraft Mod Manager GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.modpacksGroup.ResumeLayout(false);
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            this.logoGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.packLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox modpacksGroup;
        private System.Windows.Forms.ListBox packList;
        private System.Windows.Forms.GroupBox infoGroup;
        private System.Windows.Forms.GroupBox logoGroup;
        private System.Windows.Forms.PictureBox packLogo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label packInfoVersion;
        private System.Windows.Forms.Label packInfoDesc;
        private System.Windows.Forms.Label packInfoName;
        private System.Windows.Forms.Button button3;
    }
}

