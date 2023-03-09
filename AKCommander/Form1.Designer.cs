namespace AKCommander
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            plikiToolStripMenuItem = new ToolStripMenuItem();
            zmieńAtrybutyToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            bUtwKat = new Button();
            bKopiuj = new Button();
            bZmPrzen = new Button();
            bAltF4Zakoncz = new Button();
            bUsun = new Button();
            tableLayoutPanelButton = new TableLayoutPanel();
            bPodglad = new Button();
            bEdycja = new Button();
            tableLayoutPanelCMD = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanelButton.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // plikiToolStripMenuItem
            // 
            plikiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zmieńAtrybutyToolStripMenuItem });
            plikiToolStripMenuItem.Name = "plikiToolStripMenuItem";
            plikiToolStripMenuItem.Size = new Size(41, 20);
            plikiToolStripMenuItem.Text = "Pliki";
            // 
            // zmieńAtrybutyToolStripMenuItem
            // 
            zmieńAtrybutyToolStripMenuItem.Name = "zmieńAtrybutyToolStripMenuItem";
            zmieńAtrybutyToolStripMenuItem.Size = new Size(167, 22);
            zmieńAtrybutyToolStripMenuItem.Text = "Zmień atrybuty ...";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanelCMD, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(800, 425);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(bUtwKat, 4, 0);
            tableLayoutPanel2.Controls.Add(bKopiuj, 2, 0);
            tableLayoutPanel2.Controls.Add(bZmPrzen, 3, 0);
            tableLayoutPanel2.Controls.Add(bAltF4Zakoncz, 6, 0);
            tableLayoutPanel2.Controls.Add(bUsun, 5, 0);
            tableLayoutPanel2.Location = new Point(3, 395);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 27);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(113, 27);
            button1.TabIndex = 0;
            button1.Text = "F3 Podgląd";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(113, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(113, 27);
            button2.TabIndex = 1;
            button2.Text = "F4 Edycja";
            button2.UseVisualStyleBackColor = true;
            // 
            // bUtwKat
            // 
            bUtwKat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bUtwKat.FlatStyle = FlatStyle.System;
            bUtwKat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bUtwKat.Location = new Point(452, 0);
            bUtwKat.Margin = new Padding(0);
            bUtwKat.Name = "bUtwKat";
            bUtwKat.Size = new Size(113, 27);
            bUtwKat.TabIndex = 4;
            bUtwKat.Text = "F7 UtwKat";
            bUtwKat.UseVisualStyleBackColor = true;
            // 
            // bKopiuj
            // 
            bKopiuj.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bKopiuj.FlatStyle = FlatStyle.System;
            bKopiuj.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bKopiuj.Location = new Point(226, 0);
            bKopiuj.Margin = new Padding(0);
            bKopiuj.Name = "bKopiuj";
            bKopiuj.Size = new Size(113, 27);
            bKopiuj.TabIndex = 2;
            bKopiuj.Text = "F5 Kopiuj";
            bKopiuj.UseVisualStyleBackColor = true;
            // 
            // bZmPrzen
            // 
            bZmPrzen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bZmPrzen.FlatStyle = FlatStyle.System;
            bZmPrzen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bZmPrzen.Location = new Point(339, 0);
            bZmPrzen.Margin = new Padding(0);
            bZmPrzen.Name = "bZmPrzen";
            bZmPrzen.Size = new Size(113, 27);
            bZmPrzen.TabIndex = 3;
            bZmPrzen.Text = "F6 ZmPrzen";
            bZmPrzen.UseVisualStyleBackColor = true;
            // 
            // bAltF4Zakoncz
            // 
            bAltF4Zakoncz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bAltF4Zakoncz.FlatStyle = FlatStyle.System;
            bAltF4Zakoncz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bAltF4Zakoncz.Location = new Point(678, 0);
            bAltF4Zakoncz.Margin = new Padding(0);
            bAltF4Zakoncz.Name = "bAltF4Zakoncz";
            bAltF4Zakoncz.Size = new Size(116, 27);
            bAltF4Zakoncz.TabIndex = 6;
            bAltF4Zakoncz.Text = "Alt+F4 Zakończ";
            bAltF4Zakoncz.UseVisualStyleBackColor = true;
            // 
            // bUsun
            // 
            bUsun.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bUsun.FlatStyle = FlatStyle.System;
            bUsun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bUsun.Location = new Point(565, 0);
            bUsun.Margin = new Padding(0);
            bUsun.Name = "bUsun";
            bUsun.Size = new Size(113, 27);
            bUsun.TabIndex = 5;
            bUsun.Text = "F8 Usuń";
            bUsun.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelButton
            // 
            tableLayoutPanelButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelButton.ColumnCount = 7;
            tableLayoutPanelButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanelButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanelButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanelButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanelButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanelButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanelButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanelButton.Controls.Add(bPodglad, 0, 0);
            tableLayoutPanelButton.Location = new Point(0, 0);
            tableLayoutPanelButton.Name = "tableLayoutPanelButton";
            tableLayoutPanelButton.RowCount = 1;
            tableLayoutPanelButton.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelButton.Size = new Size(200, 100);
            tableLayoutPanelButton.TabIndex = 0;
            // 
            // bPodglad
            // 
            bPodglad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bPodglad.FlatStyle = FlatStyle.System;
            bPodglad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bPodglad.Location = new Point(0, 0);
            bPodglad.Margin = new Padding(0);
            bPodglad.Name = "bPodglad";
            bPodglad.Size = new Size(28, 100);
            bPodglad.TabIndex = 0;
            bPodglad.Text = "F3 Podgląd";
            bPodglad.UseVisualStyleBackColor = true;
            // 
            // bEdycja
            // 
            bEdycja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bEdycja.FlatStyle = FlatStyle.System;
            bEdycja.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bEdycja.Location = new Point(28, 0);
            bEdycja.Margin = new Padding(0);
            bEdycja.Name = "bEdycja";
            bEdycja.Size = new Size(28, 100);
            bEdycja.TabIndex = 1;
            bEdycja.Text = "F4 Edycja";
            bEdycja.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCMD
            // 
            tableLayoutPanelCMD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelCMD.ColumnCount = 2;
            tableLayoutPanelCMD.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelCMD.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelCMD.Location = new Point(3, 375);
            tableLayoutPanelCMD.Name = "tableLayoutPanelCMD";
            tableLayoutPanelCMD.RowCount = 3;
            tableLayoutPanelCMD.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelCMD.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelCMD.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelCMD.Size = new Size(794, 14);
            tableLayoutPanelCMD.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanelButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripMenuItem plikiToolStripMenuItem;
        private ToolStripMenuItem zmieńAtrybutyToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
        private Button bUtwKat;
        private Button bKopiuj;
        private Button bZmPrzen;
        private Button bAltF4Zakoncz;
        private Button bUsun;
        private TableLayoutPanel tableLayoutPanelButton;
        private Button bPodglad;
        private Button bEdycja;
        private TableLayoutPanel tableLayoutPanelCMD;
    }
}