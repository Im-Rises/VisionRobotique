namespace TP13_Vision_Robot
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.grpSelectionFichier = new System.Windows.Forms.GroupBox();
            this.radFichierAutre = new System.Windows.Forms.RadioButton();
            this.radFichierExistant = new System.Windows.Forms.RadioButton();
            this.cmdValiderImage = new System.Windows.Forms.Button();
            this.cmdOuvreFichier = new System.Windows.Forms.Button();
            this.cmbBoxFichierExistant = new System.Windows.Forms.ComboBox();
            this.OuvreFichier = new System.Windows.Forms.OpenFileDialog();
            this.grpInfosFichier = new System.Windows.Forms.GroupBox();
            this.lblDimensionsImage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDy = new System.Windows.Forms.Label();
            this.lblCy = new System.Windows.Forms.Label();
            this.lblOx = new System.Windows.Forms.Label();
            this.lblCx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.lblOy = new System.Windows.Forms.Label();
            this.lblDx = new System.Windows.Forms.Label();
            this.picImageSelectionnee = new System.Windows.Forms.PictureBox();
            this.lblx = new System.Windows.Forms.Label();
            this.grpResultats = new System.Windows.Forms.GroupBox();
            this.lblReelCy = new System.Windows.Forms.Label();
            this.lblReelCx = new System.Windows.Forms.Label();
            this.lblReelDy = new System.Windows.Forms.Label();
            this.lblReelDx = new System.Windows.Forms.Label();
            this.lblValeursReels = new System.Windows.Forms.Label();
            this.lblReelY = new System.Windows.Forms.Label();
            this.lblReelX = new System.Windows.Forms.Label();
            this.txtReelY = new System.Windows.Forms.TextBox();
            this.txtReelX = new System.Windows.Forms.TextBox();
            this.cmdValiderVraiXY = new System.Windows.Forms.Button();
            this.grpSelectionFichier.SuspendLayout();
            this.grpInfosFichier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSelectionnee)).BeginInit();
            this.grpResultats.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(741, 396);
            this.cmdQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(87, 43);
            this.cmdQuitter.TabIndex = 0;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // grpSelectionFichier
            // 
            this.grpSelectionFichier.Controls.Add(this.radFichierAutre);
            this.grpSelectionFichier.Controls.Add(this.radFichierExistant);
            this.grpSelectionFichier.Controls.Add(this.cmdValiderImage);
            this.grpSelectionFichier.Controls.Add(this.cmdOuvreFichier);
            this.grpSelectionFichier.Controls.Add(this.cmbBoxFichierExistant);
            this.grpSelectionFichier.Location = new System.Drawing.Point(12, 12);
            this.grpSelectionFichier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelectionFichier.Name = "grpSelectionFichier";
            this.grpSelectionFichier.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSelectionFichier.Size = new System.Drawing.Size(417, 215);
            this.grpSelectionFichier.TabIndex = 1;
            this.grpSelectionFichier.TabStop = false;
            this.grpSelectionFichier.Text = "Sélection fichier";
            // 
            // radFichierAutre
            // 
            this.radFichierAutre.AutoSize = true;
            this.radFichierAutre.Location = new System.Drawing.Point(267, 55);
            this.radFichierAutre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radFichierAutre.Name = "radFichierAutre";
            this.radFichierAutre.Size = new System.Drawing.Size(105, 21);
            this.radFichierAutre.TabIndex = 6;
            this.radFichierAutre.TabStop = true;
            this.radFichierAutre.Text = "Autre fichier";
            this.radFichierAutre.UseVisualStyleBackColor = true;
            this.radFichierAutre.CheckedChanged += new System.EventHandler(this.radFichierAutre_CheckedChanged);
            // 
            // radFichierExistant
            // 
            this.radFichierExistant.AutoSize = true;
            this.radFichierExistant.Location = new System.Drawing.Point(19, 57);
            this.radFichierExistant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radFichierExistant.Name = "radFichierExistant";
            this.radFichierExistant.Size = new System.Drawing.Size(123, 21);
            this.radFichierExistant.TabIndex = 5;
            this.radFichierExistant.TabStop = true;
            this.radFichierExistant.Text = "Fichier existant";
            this.radFichierExistant.UseVisualStyleBackColor = true;
            this.radFichierExistant.CheckedChanged += new System.EventHandler(this.radFichierExistant_CheckedChanged);
            // 
            // cmdValiderImage
            // 
            this.cmdValiderImage.Location = new System.Drawing.Point(151, 171);
            this.cmdValiderImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdValiderImage.Name = "cmdValiderImage";
            this.cmdValiderImage.Size = new System.Drawing.Size(109, 32);
            this.cmdValiderImage.TabIndex = 4;
            this.cmdValiderImage.Text = "Valider image";
            this.cmdValiderImage.UseVisualStyleBackColor = true;
            this.cmdValiderImage.Click += new System.EventHandler(this.cmdValiderImage_Click);
            // 
            // cmdOuvreFichier
            // 
            this.cmdOuvreFichier.Location = new System.Drawing.Point(267, 117);
            this.cmdOuvreFichier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdOuvreFichier.Name = "cmdOuvreFichier";
            this.cmdOuvreFichier.Size = new System.Drawing.Size(127, 23);
            this.cmdOuvreFichier.TabIndex = 3;
            this.cmdOuvreFichier.Text = "Chercher Fichier";
            this.cmdOuvreFichier.UseVisualStyleBackColor = true;
            this.cmdOuvreFichier.Click += new System.EventHandler(this.cmdOuvreFichier_Click);
            // 
            // cmbBoxFichierExistant
            // 
            this.cmbBoxFichierExistant.FormattingEnabled = true;
            this.cmbBoxFichierExistant.Items.AddRange(new object[] {
            "VisionRobot1.bmp",
            "VisionRobot2.bmp",
            "VisionRobot3.bmp",
            "VisionRobot4.bmp",
            "VisionRobot5.bmp",
            "VisionRobot6.bmp",
            "VisionRobot7.bmp",
            "VisionRobot8.bmp",
            "VisionRobot9.bmp",
            "VisionRobot10.bmp"});
            this.cmbBoxFichierExistant.Location = new System.Drawing.Point(19, 117);
            this.cmbBoxFichierExistant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoxFichierExistant.Name = "cmbBoxFichierExistant";
            this.cmbBoxFichierExistant.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxFichierExistant.TabIndex = 2;
            // 
            // OuvreFichier
            // 
            this.OuvreFichier.FileName = "OuvreFichier";
            // 
            // grpInfosFichier
            // 
            this.grpInfosFichier.Controls.Add(this.lblDimensionsImage);
            this.grpInfosFichier.Controls.Add(this.label1);
            this.grpInfosFichier.Controls.Add(this.lblDy);
            this.grpInfosFichier.Controls.Add(this.lblCy);
            this.grpInfosFichier.Controls.Add(this.lblOx);
            this.grpInfosFichier.Controls.Add(this.lblCx);
            this.grpInfosFichier.Controls.Add(this.lbly);
            this.grpInfosFichier.Controls.Add(this.lblOy);
            this.grpInfosFichier.Controls.Add(this.lblDx);
            this.grpInfosFichier.Controls.Add(this.picImageSelectionnee);
            this.grpInfosFichier.Controls.Add(this.lblx);
            this.grpInfosFichier.Location = new System.Drawing.Point(435, 12);
            this.grpInfosFichier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfosFichier.Name = "grpInfosFichier";
            this.grpInfosFichier.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInfosFichier.Size = new System.Drawing.Size(393, 215);
            this.grpInfosFichier.TabIndex = 2;
            this.grpInfosFichier.TabStop = false;
            this.grpInfosFichier.Text = "Informations fichier";
            // 
            // lblDimensionsImage
            // 
            this.lblDimensionsImage.AutoSize = true;
            this.lblDimensionsImage.Location = new System.Drawing.Point(7, 191);
            this.lblDimensionsImage.Name = "lblDimensionsImage";
            this.lblDimensionsImage.Size = new System.Drawing.Size(78, 17);
            this.lblDimensionsImage.TabIndex = 4;
            this.lblDimensionsImage.Text = "Dimension ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Coordonnées en pixels :";
            // 
            // lblDy
            // 
            this.lblDy.AutoSize = true;
            this.lblDy.Location = new System.Drawing.Point(115, 127);
            this.lblDy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDy.Name = "lblDy";
            this.lblDy.Size = new System.Drawing.Size(25, 17);
            this.lblDy.TabIndex = 6;
            this.lblDy.Text = "Dy";
            // 
            // lblCy
            // 
            this.lblCy.AutoSize = true;
            this.lblCy.Location = new System.Drawing.Point(115, 155);
            this.lblCy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCy.Name = "lblCy";
            this.lblCy.Size = new System.Drawing.Size(24, 17);
            this.lblCy.TabIndex = 8;
            this.lblCy.Text = "Cy";
            // 
            // lblOx
            // 
            this.lblOx.AutoSize = true;
            this.lblOx.Location = new System.Drawing.Point(11, 72);
            this.lblOx.Name = "lblOx";
            this.lblOx.Size = new System.Drawing.Size(25, 17);
            this.lblOx.TabIndex = 1;
            this.lblOx.Text = "Ox";
            // 
            // lblCx
            // 
            this.lblCx.AutoSize = true;
            this.lblCx.Location = new System.Drawing.Point(11, 155);
            this.lblCx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCx.Name = "lblCx";
            this.lblCx.Size = new System.Drawing.Size(23, 17);
            this.lblCx.TabIndex = 7;
            this.lblCx.Text = "Cx";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(118, 100);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(29, 17);
            this.lbly.TabIndex = 2;
            this.lbly.Text = "lbly";
            // 
            // lblOy
            // 
            this.lblOy.AutoSize = true;
            this.lblOy.Location = new System.Drawing.Point(114, 72);
            this.lblOy.Name = "lblOy";
            this.lblOy.Size = new System.Drawing.Size(26, 17);
            this.lblOy.TabIndex = 0;
            this.lblOy.Text = "Oy";
            // 
            // lblDx
            // 
            this.lblDx.AutoSize = true;
            this.lblDx.Location = new System.Drawing.Point(11, 127);
            this.lblDx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDx.Name = "lblDx";
            this.lblDx.Size = new System.Drawing.Size(24, 17);
            this.lblDx.TabIndex = 5;
            this.lblDx.Text = "Dx";
            // 
            // picImageSelectionnee
            // 
            this.picImageSelectionnee.Location = new System.Drawing.Point(187, 9);
            this.picImageSelectionnee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picImageSelectionnee.Name = "picImageSelectionnee";
            this.picImageSelectionnee.Size = new System.Drawing.Size(200, 199);
            this.picImageSelectionnee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageSelectionnee.TabIndex = 3;
            this.picImageSelectionnee.TabStop = false;
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(11, 100);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(28, 17);
            this.lblx.TabIndex = 0;
            this.lblx.Text = "lblx";
            // 
            // grpResultats
            // 
            this.grpResultats.Controls.Add(this.lblReelCy);
            this.grpResultats.Controls.Add(this.lblReelCx);
            this.grpResultats.Controls.Add(this.lblReelDy);
            this.grpResultats.Controls.Add(this.lblReelDx);
            this.grpResultats.Controls.Add(this.lblValeursReels);
            this.grpResultats.Controls.Add(this.lblReelY);
            this.grpResultats.Controls.Add(this.lblReelX);
            this.grpResultats.Controls.Add(this.txtReelY);
            this.grpResultats.Controls.Add(this.txtReelX);
            this.grpResultats.Controls.Add(this.cmdValiderVraiXY);
            this.grpResultats.Location = new System.Drawing.Point(12, 233);
            this.grpResultats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpResultats.Name = "grpResultats";
            this.grpResultats.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpResultats.Size = new System.Drawing.Size(717, 206);
            this.grpResultats.TabIndex = 3;
            this.grpResultats.TabStop = false;
            this.grpResultats.Text = "Resultats";
            this.grpResultats.Enter += new System.EventHandler(this.grpResultats_Enter);
            // 
            // lblReelCy
            // 
            this.lblReelCy.AutoSize = true;
            this.lblReelCy.Location = new System.Drawing.Point(539, 117);
            this.lblReelCy.Name = "lblReelCy";
            this.lblReelCy.Size = new System.Drawing.Size(24, 17);
            this.lblReelCy.TabIndex = 9;
            this.lblReelCy.Text = "Cy";
            // 
            // lblReelCx
            // 
            this.lblReelCx.AutoSize = true;
            this.lblReelCx.Location = new System.Drawing.Point(539, 77);
            this.lblReelCx.Name = "lblReelCx";
            this.lblReelCx.Size = new System.Drawing.Size(23, 17);
            this.lblReelCx.TabIndex = 8;
            this.lblReelCx.Text = "Cx";
            // 
            // lblReelDy
            // 
            this.lblReelDy.AutoSize = true;
            this.lblReelDy.Location = new System.Drawing.Point(420, 117);
            this.lblReelDy.Name = "lblReelDy";
            this.lblReelDy.Size = new System.Drawing.Size(25, 17);
            this.lblReelDy.TabIndex = 7;
            this.lblReelDy.Text = "Dy";
            // 
            // lblReelDx
            // 
            this.lblReelDx.AutoSize = true;
            this.lblReelDx.Location = new System.Drawing.Point(420, 77);
            this.lblReelDx.Name = "lblReelDx";
            this.lblReelDx.Size = new System.Drawing.Size(24, 17);
            this.lblReelDx.TabIndex = 6;
            this.lblReelDx.Text = "Dx";
            // 
            // lblValeursReels
            // 
            this.lblValeursReels.AutoSize = true;
            this.lblValeursReels.Location = new System.Drawing.Point(420, 35);
            this.lblValeursReels.Name = "lblValeursReels";
            this.lblValeursReels.Size = new System.Drawing.Size(204, 17);
            this.lblValeursReels.TabIndex = 5;
            this.lblValeursReels.Text = "Résultat dans le domaine réel :";
            // 
            // lblReelY
            // 
            this.lblReelY.AutoSize = true;
            this.lblReelY.Location = new System.Drawing.Point(19, 109);
            this.lblReelY.Name = "lblReelY";
            this.lblReelY.Size = new System.Drawing.Size(23, 17);
            this.lblReelY.TabIndex = 4;
            this.lblReelY.Text = "y :";
            // 
            // lblReelX
            // 
            this.lblReelX.AutoSize = true;
            this.lblReelX.Location = new System.Drawing.Point(19, 35);
            this.lblReelX.Name = "lblReelX";
            this.lblReelX.Size = new System.Drawing.Size(22, 17);
            this.lblReelX.TabIndex = 3;
            this.lblReelX.Text = "x :";
            // 
            // txtReelY
            // 
            this.txtReelY.Location = new System.Drawing.Point(19, 129);
            this.txtReelY.Name = "txtReelY";
            this.txtReelY.Size = new System.Drawing.Size(100, 22);
            this.txtReelY.TabIndex = 2;
            // 
            // txtReelX
            // 
            this.txtReelX.Location = new System.Drawing.Point(19, 58);
            this.txtReelX.Name = "txtReelX";
            this.txtReelX.Size = new System.Drawing.Size(100, 22);
            this.txtReelX.TabIndex = 1;
            // 
            // cmdValiderVraiXY
            // 
            this.cmdValiderVraiXY.Location = new System.Drawing.Point(151, 86);
            this.cmdValiderVraiXY.Name = "cmdValiderVraiXY";
            this.cmdValiderVraiXY.Size = new System.Drawing.Size(109, 34);
            this.cmdValiderVraiXY.TabIndex = 0;
            this.cmdValiderVraiXY.Text = "Valider x et y";
            this.cmdValiderVraiXY.UseVisualStyleBackColor = true;
            this.cmdValiderVraiXY.Click += new System.EventHandler(this.cmdValiderVraiXY_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.grpResultats);
            this.Controls.Add(this.grpInfosFichier);
            this.Controls.Add(this.grpSelectionFichier);
            this.Controls.Add(this.cmdQuitter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSelectionFichier.ResumeLayout(false);
            this.grpSelectionFichier.PerformLayout();
            this.grpInfosFichier.ResumeLayout(false);
            this.grpInfosFichier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSelectionnee)).EndInit();
            this.grpResultats.ResumeLayout(false);
            this.grpResultats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.GroupBox grpSelectionFichier;
        private System.Windows.Forms.ComboBox cmbBoxFichierExistant;
        private System.Windows.Forms.Button cmdOuvreFichier;
        private System.Windows.Forms.OpenFileDialog OuvreFichier;
        private System.Windows.Forms.Button cmdValiderImage;
        private System.Windows.Forms.GroupBox grpInfosFichier;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.GroupBox grpResultats;
        private System.Windows.Forms.RadioButton radFichierAutre;
        private System.Windows.Forms.RadioButton radFichierExistant;
        private System.Windows.Forms.PictureBox picImageSelectionnee;
        private System.Windows.Forms.Label lblDimensionsImage;
        private System.Windows.Forms.Label lblDy;
        private System.Windows.Forms.Label lblDx;
        private System.Windows.Forms.Label lblCx;
        private System.Windows.Forms.Label lblCy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOx;
        private System.Windows.Forms.Label lblOy;
        private System.Windows.Forms.TextBox txtReelY;
        private System.Windows.Forms.TextBox txtReelX;
        private System.Windows.Forms.Button cmdValiderVraiXY;
        private System.Windows.Forms.Label lblReelX;
        private System.Windows.Forms.Label lblReelY;
        private System.Windows.Forms.Label lblReelDy;
        private System.Windows.Forms.Label lblReelDx;
        private System.Windows.Forms.Label lblValeursReels;
        private System.Windows.Forms.Label lblReelCy;
        private System.Windows.Forms.Label lblReelCx;
    }
}

