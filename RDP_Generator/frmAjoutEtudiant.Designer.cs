﻿
namespace RDP_Generator
{
    partial class frmAjoutEtudiant
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.cmdMinimiser = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblOrdinateur = new System.Windows.Forms.Label();
            this.txtOrdinateur = new System.Windows.Forms.TextBox();
            this.lblDA = new System.Windows.Forms.Label();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel16.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.Snow;
            this.lblTitre.Location = new System.Drawing.Point(12, 5);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(101, 45);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "Login";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel16.Controls.Add(this.button9);
            this.panel16.Controls.Add(this.lblTitre);
            this.panel16.Location = new System.Drawing.Point(-460, -265);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1720, 55);
            this.panel16.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button9.ForeColor = System.Drawing.Color.Snow;
            this.button9.Location = new System.Drawing.Point(1583, 9);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 36);
            this.button9.TabIndex = 24;
            this.button9.Text = "Retour";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(146)))));
            this.pnlHeader.Controls.Add(this.panel2);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Controls.Add(this.cmdMinimiser);
            this.pnlHeader.Controls.Add(this.cmdQuitter);
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(596, 45);
            this.pnlHeader.TabIndex = 4;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 2);
            this.panel2.TabIndex = 41;
            this.panel2.Tag = "div";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::RDP_Generator.Properties.Resources.logo_trans;
            this.picLogo.Location = new System.Drawing.Point(4, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(45, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 35;
            this.picLogo.TabStop = false;
            // 
            // cmdMinimiser
            // 
            this.cmdMinimiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMinimiser.BackColor = System.Drawing.Color.Transparent;
            this.cmdMinimiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimiser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmdMinimiser.ForeColor = System.Drawing.Color.Snow;
            this.cmdMinimiser.Location = new System.Drawing.Point(517, 8);
            this.cmdMinimiser.Margin = new System.Windows.Forms.Padding(0);
            this.cmdMinimiser.Name = "cmdMinimiser";
            this.cmdMinimiser.Size = new System.Drawing.Size(30, 30);
            this.cmdMinimiser.TabIndex = 26;
            this.cmdMinimiser.Text = "-";
            this.cmdMinimiser.UseVisualStyleBackColor = false;
            this.cmdMinimiser.Click += new System.EventHandler(this.cmdMinimiser_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdQuitter.BackColor = System.Drawing.Color.Transparent;
            this.cmdQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdQuitter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmdQuitter.ForeColor = System.Drawing.Color.Snow;
            this.cmdQuitter.Location = new System.Drawing.Point(557, 8);
            this.cmdQuitter.Margin = new System.Windows.Forms.Padding(0);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(30, 30);
            this.cmdQuitter.TabIndex = 25;
            this.cmdQuitter.Text = "X";
            this.cmdQuitter.UseVisualStyleBackColor = false;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(1583, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Snow;
            this.lblHeader.Location = new System.Drawing.Point(46, -1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(99, 45);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Ajout";
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.lblHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.lblHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Snow;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblOrdinateur);
            this.pnlMain.Controls.Add(this.txtOrdinateur);
            this.pnlMain.Controls.Add(this.lblDA);
            this.pnlMain.Controls.Add(this.txtDA);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.cmdAnnuler);
            this.pnlMain.Controls.Add(this.cmdOK);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(598, 230);
            this.pnlMain.TabIndex = 5;
            // 
            // lblOrdinateur
            // 
            this.lblOrdinateur.AutoSize = true;
            this.lblOrdinateur.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblOrdinateur.Location = new System.Drawing.Point(58, 122);
            this.lblOrdinateur.Name = "lblOrdinateur";
            this.lblOrdinateur.Size = new System.Drawing.Size(111, 25);
            this.lblOrdinateur.TabIndex = 51;
            this.lblOrdinateur.Text = "Ordinateur:";
            // 
            // txtOrdinateur
            // 
            this.txtOrdinateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrdinateur.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtOrdinateur.Location = new System.Drawing.Point(201, 116);
            this.txtOrdinateur.Name = "txtOrdinateur";
            this.txtOrdinateur.Size = new System.Drawing.Size(348, 35);
            this.txtOrdinateur.TabIndex = 50;
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDA.Location = new System.Drawing.Point(89, 72);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(44, 25);
            this.lblDA.TabIndex = 46;
            this.lblDA.Text = "DA:";
            // 
            // txtDA
            // 
            this.txtDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDA.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.txtDA.Location = new System.Drawing.Point(201, 66);
            this.txtDA.Name = "txtDA";
            this.txtDA.Size = new System.Drawing.Size(348, 35);
            this.txtDA.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(575, 2);
            this.panel4.TabIndex = 44;
            this.panel4.Tag = "div";
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAnnuler.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Underline);
            this.cmdAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAnnuler.Location = new System.Drawing.Point(361, 180);
            this.cmdAnnuler.Margin = new System.Windows.Forms.Padding(0);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(97, 36);
            this.cmdAnnuler.TabIndex = 30;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = false;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(100)))));
            this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOK.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.ForeColor = System.Drawing.Color.Snow;
            this.cmdOK.Location = new System.Drawing.Point(473, 180);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(0);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(101, 36);
            this.cmdOK.TabIndex = 25;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = false;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // frmAjoutEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 230);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAjoutEtudiant";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAjoutEtudiant_Load);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button cmdMinimiser;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.Label lblOrdinateur;
        private System.Windows.Forms.TextBox txtOrdinateur;
        private System.Windows.Forms.ErrorProvider erp;
    }
}

