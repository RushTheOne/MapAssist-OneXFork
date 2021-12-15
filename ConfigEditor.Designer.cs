
namespace MapAssist
{
    partial class ConfigEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigEditor));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkToggleViaPanels = new System.Windows.Forms.CheckBox();
            this.chkToggleViaMap = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.chkOverlayMode = new System.Windows.Forms.CheckBox();
            this.lblIconOpacity = new System.Windows.Forms.Label();
            this.iconOpacity = new System.Windows.Forms.TrackBar();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.opacity = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblMapSize = new System.Windows.Forms.Label();
            this.mapSize = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            this.mapZoom = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBuffSize = new System.Windows.Forms.Label();
            this.buffSize = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBuffPosition = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buffSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(332, 351);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(324, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboBuffPosition);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblBuffSize);
            this.panel1.Controls.Add(this.buffSize);
            this.panel1.Controls.Add(this.lblZoom);
            this.panel1.Controls.Add(this.mapZoom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMapSize);
            this.panel1.Controls.Add(this.mapSize);
            this.panel1.Controls.Add(this.chkToggleViaPanels);
            this.panel1.Controls.Add(this.chkToggleViaMap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboPosition);
            this.panel1.Controls.Add(this.chkOverlayMode);
            this.panel1.Controls.Add(this.lblIconOpacity);
            this.panel1.Controls.Add(this.iconOpacity);
            this.panel1.Controls.Add(this.lblOpacity);
            this.panel1.Controls.Add(this.opacity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 547);
            this.panel1.TabIndex = 0;
            // 
            // chkToggleViaPanels
            // 
            this.chkToggleViaPanels.AutoSize = true;
            this.chkToggleViaPanels.Location = new System.Drawing.Point(9, 207);
            this.chkToggleViaPanels.Name = "chkToggleViaPanels";
            this.chkToggleViaPanels.Size = new System.Drawing.Size(196, 17);
            this.chkToggleViaPanels.TabIndex = 9;
            this.chkToggleViaPanels.Text = "Hide when InGame menus are open";
            this.chkToggleViaPanels.UseVisualStyleBackColor = true;
            this.chkToggleViaPanels.CheckedChanged += new System.EventHandler(this.chkToggleViaPanels_CheckedChanged);
            // 
            // chkToggleViaMap
            // 
            this.chkToggleViaMap.AutoSize = true;
            this.chkToggleViaMap.Location = new System.Drawing.Point(9, 184);
            this.chkToggleViaMap.Name = "chkToggleViaMap";
            this.chkToggleViaMap.Size = new System.Drawing.Size(172, 17);
            this.chkToggleViaMap.TabIndex = 8;
            this.chkToggleViaMap.Text = "Show/Hide using InGame Map";
            this.chkToggleViaMap.UseVisualStyleBackColor = true;
            this.chkToggleViaMap.CheckedChanged += new System.EventHandler(this.chkToggleViaMap_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Position:";
            // 
            // cboPosition
            // 
            this.cboPosition.AllowDrop = true;
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] {
            "TopLeft",
            "TopRight",
            "Center"});
            this.cboPosition.Location = new System.Drawing.Point(181, 146);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(107, 21);
            this.cboPosition.TabIndex = 6;
            this.cboPosition.SelectedIndexChanged += new System.EventHandler(this.cboPosition_SelectedIndexChanged);
            // 
            // chkOverlayMode
            // 
            this.chkOverlayMode.AutoSize = true;
            this.chkOverlayMode.Location = new System.Drawing.Point(9, 148);
            this.chkOverlayMode.Name = "chkOverlayMode";
            this.chkOverlayMode.Size = new System.Drawing.Size(92, 17);
            this.chkOverlayMode.TabIndex = 5;
            this.chkOverlayMode.Text = "Overlay Mode";
            this.chkOverlayMode.UseVisualStyleBackColor = true;
            this.chkOverlayMode.CheckedChanged += new System.EventHandler(this.chkOverlayMode_CheckedChanged);
            // 
            // lblIconOpacity
            // 
            this.lblIconOpacity.AutoSize = true;
            this.lblIconOpacity.BackColor = System.Drawing.Color.Transparent;
            this.lblIconOpacity.Location = new System.Drawing.Point(5, 118);
            this.lblIconOpacity.Name = "lblIconOpacity";
            this.lblIconOpacity.Size = new System.Drawing.Size(73, 13);
            this.lblIconOpacity.TabIndex = 4;
            this.lblIconOpacity.Text = "Icon Opacity: ";
            // 
            // iconOpacity
            // 
            this.iconOpacity.LargeChange = 10;
            this.iconOpacity.Location = new System.Drawing.Point(2, 86);
            this.iconOpacity.Maximum = 100;
            this.iconOpacity.Name = "iconOpacity";
            this.iconOpacity.Size = new System.Drawing.Size(302, 45);
            this.iconOpacity.TabIndex = 3;
            this.iconOpacity.Scroll += new System.EventHandler(this.iconOpacity_Scroll);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.BackColor = System.Drawing.Color.Transparent;
            this.lblOpacity.Location = new System.Drawing.Point(5, 67);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(73, 13);
            this.lblOpacity.TabIndex = 2;
            this.lblOpacity.Text = "Map Opacity: ";
            this.lblOpacity.Click += new System.EventHandler(this.label2_Click);
            // 
            // opacity
            // 
            this.opacity.LargeChange = 10;
            this.opacity.Location = new System.Drawing.Point(-1, 35);
            this.opacity.Maximum = 100;
            this.opacity.Name = "opacity";
            this.opacity.Size = new System.Drawing.Size(302, 45);
            this.opacity.TabIndex = 1;
            this.opacity.Scroll += new System.EventHandler(this.opacity_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Map Rendering:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(324, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Drawing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(324, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hotkeys";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(324, 325);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Advanced";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblMapSize
            // 
            this.lblMapSize.AutoSize = true;
            this.lblMapSize.BackColor = System.Drawing.Color.Transparent;
            this.lblMapSize.Location = new System.Drawing.Point(2, 312);
            this.lblMapSize.Name = "lblMapSize";
            this.lblMapSize.Size = new System.Drawing.Size(147, 13);
            this.lblMapSize.TabIndex = 11;
            this.lblMapSize.Text = "Map Size (non overlay mode):";
            // 
            // mapSize
            // 
            this.mapSize.LargeChange = 100;
            this.mapSize.Location = new System.Drawing.Point(-1, 280);
            this.mapSize.Maximum = 1600;
            this.mapSize.Name = "mapSize";
            this.mapSize.Size = new System.Drawing.Size(302, 45);
            this.mapSize.SmallChange = 25;
            this.mapSize.TabIndex = 10;
            this.mapSize.Scroll += new System.EventHandler(this.mapSize_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Map Sizing:";
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.BackColor = System.Drawing.Color.Transparent;
            this.lblZoom.Location = new System.Drawing.Point(2, 363);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(138, 13);
            this.lblZoom.TabIndex = 14;
            this.lblZoom.Text = "Zoom Level (overlay mode):";
            // 
            // mapZoom
            // 
            this.mapZoom.LargeChange = 10;
            this.mapZoom.Location = new System.Drawing.Point(-1, 331);
            this.mapZoom.Maximum = 400;
            this.mapZoom.Minimum = 1;
            this.mapZoom.Name = "mapZoom";
            this.mapZoom.Size = new System.Drawing.Size(302, 45);
            this.mapZoom.TabIndex = 13;
            this.mapZoom.Value = 1;
            this.mapZoom.Scroll += new System.EventHandler(this.mapZoom_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Buff Display:";
            // 
            // lblBuffSize
            // 
            this.lblBuffSize.AutoSize = true;
            this.lblBuffSize.BackColor = System.Drawing.Color.Transparent;
            this.lblBuffSize.Location = new System.Drawing.Point(2, 461);
            this.lblBuffSize.Name = "lblBuffSize";
            this.lblBuffSize.Size = new System.Drawing.Size(76, 13);
            this.lblBuffSize.TabIndex = 16;
            this.lblBuffSize.Text = "Buff Icon Size:";
            // 
            // buffSize
            // 
            this.buffSize.LargeChange = 25;
            this.buffSize.Location = new System.Drawing.Point(-1, 429);
            this.buffSize.Maximum = 200;
            this.buffSize.Name = "buffSize";
            this.buffSize.Size = new System.Drawing.Size(302, 45);
            this.buffSize.TabIndex = 15;
            this.buffSize.Scroll += new System.EventHandler(this.buffSize_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Position:";
            // 
            // cboBuffPosition
            // 
            this.cboBuffPosition.AllowDrop = true;
            this.cboBuffPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuffPosition.FormattingEnabled = true;
            this.cboBuffPosition.Items.AddRange(new object[] {
            "Top",
            "Player",
            "Bottom"});
            this.cboBuffPosition.Location = new System.Drawing.Point(181, 482);
            this.cboBuffPosition.Name = "cboBuffPosition";
            this.cboBuffPosition.Size = new System.Drawing.Size(107, 21);
            this.cboBuffPosition.TabIndex = 18;
            this.cboBuffPosition.SelectedIndexChanged += new System.EventHandler(this.cboBuffPosition_SelectedIndexChanged);
            // 
            // ConfigEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 370);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigEditor";
            this.Text = "ConfigEditor";
            this.Load += new System.EventHandler(this.ConfigEditor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buffSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar opacity;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.Label lblIconOpacity;
        private System.Windows.Forms.TrackBar iconOpacity;
        private System.Windows.Forms.CheckBox chkOverlayMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.CheckBox chkToggleViaPanels;
        private System.Windows.Forms.CheckBox chkToggleViaMap;
        private System.Windows.Forms.Label lblMapSize;
        private System.Windows.Forms.TrackBar mapSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.TrackBar mapZoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBuffPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBuffSize;
        private System.Windows.Forms.TrackBar buffSize;
    }
}
