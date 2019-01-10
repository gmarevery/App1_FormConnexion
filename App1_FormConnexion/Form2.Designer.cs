namespace App1_FormConnexion
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonSexeH = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonSexeF = new System.Windows.Forms.RadioButton();
            this.radioButtonEtudiant = new System.Windows.Forms.RadioButton();
            this.radioButtonSalarie = new System.Windows.Forms.RadioButton();
            this.radioButtonChomeur = new System.Windows.Forms.RadioButton();
            this.dateTimePickerNaissance = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelNumeroEtudiant = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxRemarque = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxSexe = new System.Windows.Forms.GroupBox();
            this.groupBoxStaut = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdresseRue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAdresseVille = new System.Windows.Forms.TextBox();
            this.numericUpDownAdresseCP = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxSexe.SuspendLayout();
            this.groupBoxStaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdresseCP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxStaut);
            this.panel1.Controls.Add(this.groupBoxSexe);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.richTextBoxRemarque);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelNumeroEtudiant);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.buttonEnregistrer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 441);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonSexeH
            // 
            this.radioButtonSexeH.AutoSize = true;
            this.radioButtonSexeH.Location = new System.Drawing.Point(17, 24);
            this.radioButtonSexeH.Name = "radioButtonSexeH";
            this.radioButtonSexeH.Size = new System.Drawing.Size(61, 17);
            this.radioButtonSexeH.TabIndex = 0;
            this.radioButtonSexeH.TabStop = true;
            this.radioButtonSexeH.Tag = "";
            this.radioButtonSexeH.Text = "Homme";
            this.radioButtonSexeH.UseVisualStyleBackColor = true;
            this.radioButtonSexeH.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mon compte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(17, 37);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(139, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(178, 37);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(139, 20);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prénom";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButtonSexeF
            // 
            this.radioButtonSexeF.AutoSize = true;
            this.radioButtonSexeF.Location = new System.Drawing.Point(17, 45);
            this.radioButtonSexeF.Name = "radioButtonSexeF";
            this.radioButtonSexeF.Size = new System.Drawing.Size(59, 17);
            this.radioButtonSexeF.TabIndex = 7;
            this.radioButtonSexeF.TabStop = true;
            this.radioButtonSexeF.Tag = "";
            this.radioButtonSexeF.Text = "Femme";
            this.radioButtonSexeF.UseVisualStyleBackColor = true;
            // 
            // radioButtonEtudiant
            // 
            this.radioButtonEtudiant.AutoSize = true;
            this.radioButtonEtudiant.Location = new System.Drawing.Point(16, 21);
            this.radioButtonEtudiant.Name = "radioButtonEtudiant";
            this.radioButtonEtudiant.Size = new System.Drawing.Size(64, 17);
            this.radioButtonEtudiant.TabIndex = 9;
            this.radioButtonEtudiant.TabStop = true;
            this.radioButtonEtudiant.Tag = "Statut";
            this.radioButtonEtudiant.Text = "Etudiant";
            this.radioButtonEtudiant.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalarie
            // 
            this.radioButtonSalarie.AutoSize = true;
            this.radioButtonSalarie.Location = new System.Drawing.Point(16, 44);
            this.radioButtonSalarie.Name = "radioButtonSalarie";
            this.radioButtonSalarie.Size = new System.Drawing.Size(57, 17);
            this.radioButtonSalarie.TabIndex = 10;
            this.radioButtonSalarie.TabStop = true;
            this.radioButtonSalarie.Tag = "";
            this.radioButtonSalarie.Text = "Salarié";
            this.radioButtonSalarie.UseVisualStyleBackColor = true;
            // 
            // radioButtonChomeur
            // 
            this.radioButtonChomeur.AutoSize = true;
            this.radioButtonChomeur.Location = new System.Drawing.Point(16, 67);
            this.radioButtonChomeur.Name = "radioButtonChomeur";
            this.radioButtonChomeur.Size = new System.Drawing.Size(67, 17);
            this.radioButtonChomeur.TabIndex = 11;
            this.radioButtonChomeur.TabStop = true;
            this.radioButtonChomeur.Text = "Chomeur";
            this.radioButtonChomeur.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNaissance
            // 
            this.dateTimePickerNaissance.Location = new System.Drawing.Point(409, 36);
            this.dateTimePickerNaissance.Name = "dateTimePickerNaissance";
            this.dateTimePickerNaissance.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNaissance.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date de naissance";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(20, 396);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrer.TabIndex = 14;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Numéro étudiant :";
            // 
            // labelNumeroEtudiant
            // 
            this.labelNumeroEtudiant.AutoSize = true;
            this.labelNumeroEtudiant.Location = new System.Drawing.Point(611, 14);
            this.labelNumeroEtudiant.Name = "labelNumeroEtudiant";
            this.labelNumeroEtudiant.Size = new System.Drawing.Size(37, 13);
            this.labelNumeroEtudiant.TabIndex = 16;
            this.labelNumeroEtudiant.Text = "00000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Remarques";
            // 
            // richTextBoxRemarque
            // 
            this.richTextBoxRemarque.Location = new System.Drawing.Point(341, 260);
            this.richTextBoxRemarque.Name = "richTextBoxRemarque";
            this.richTextBoxRemarque.Size = new System.Drawing.Size(307, 119);
            this.richTextBoxRemarque.TabIndex = 18;
            this.richTextBoxRemarque.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(534, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxSexe
            // 
            this.groupBoxSexe.Controls.Add(this.radioButtonSexeH);
            this.groupBoxSexe.Controls.Add(this.radioButtonSexeF);
            this.groupBoxSexe.Location = new System.Drawing.Point(20, 131);
            this.groupBoxSexe.Name = "groupBoxSexe";
            this.groupBoxSexe.Size = new System.Drawing.Size(295, 95);
            this.groupBoxSexe.TabIndex = 20;
            this.groupBoxSexe.TabStop = false;
            this.groupBoxSexe.Text = "Sexe";
            // 
            // groupBoxStaut
            // 
            this.groupBoxStaut.Controls.Add(this.radioButtonEtudiant);
            this.groupBoxStaut.Controls.Add(this.radioButtonSalarie);
            this.groupBoxStaut.Controls.Add(this.radioButtonChomeur);
            this.groupBoxStaut.Location = new System.Drawing.Point(341, 131);
            this.groupBoxStaut.Name = "groupBoxStaut";
            this.groupBoxStaut.Size = new System.Drawing.Size(307, 95);
            this.groupBoxStaut.TabIndex = 21;
            this.groupBoxStaut.TabStop = false;
            this.groupBoxStaut.Text = "Statut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Numéro et nom de rue";
            // 
            // textBoxAdresseRue
            // 
            this.textBoxAdresseRue.Location = new System.Drawing.Point(18, 46);
            this.textBoxAdresseRue.Name = "textBoxAdresseRue";
            this.textBoxAdresseRue.Size = new System.Drawing.Size(139, 20);
            this.textBoxAdresseRue.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Code postal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ville";
            // 
            // textBoxAdresseVille
            // 
            this.textBoxAdresseVille.Location = new System.Drawing.Point(134, 98);
            this.textBoxAdresseVille.Name = "textBoxAdresseVille";
            this.textBoxAdresseVille.Size = new System.Drawing.Size(139, 20);
            this.textBoxAdresseVille.TabIndex = 27;
            // 
            // numericUpDownAdresseCP
            // 
            this.numericUpDownAdresseCP.Location = new System.Drawing.Point(18, 99);
            this.numericUpDownAdresseCP.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownAdresseCP.Name = "numericUpDownAdresseCP";
            this.numericUpDownAdresseCP.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownAdresseCP.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownAdresseCP);
            this.groupBox1.Controls.Add(this.textBoxAdresseRue);
            this.groupBox1.Controls.Add(this.textBoxAdresseVille);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(20, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 135);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adresse";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxNom);
            this.groupBox2.Controls.Add(this.textBoxPrenom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePickerNaissance);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(20, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 70);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations personnelles";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 465);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Mon compte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxSexe.ResumeLayout(false);
            this.groupBoxSexe.PerformLayout();
            this.groupBoxStaut.ResumeLayout(false);
            this.groupBoxStaut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdresseCP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonSexeF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSexeH;
        private System.Windows.Forms.RadioButton radioButtonChomeur;
        private System.Windows.Forms.RadioButton radioButtonSalarie;
        private System.Windows.Forms.RadioButton radioButtonEtudiant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerNaissance;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.RichTextBox richTextBoxRemarque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelNumeroEtudiant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxSexe;
        private System.Windows.Forms.GroupBox groupBoxStaut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownAdresseCP;
        private System.Windows.Forms.TextBox textBoxAdresseVille;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAdresseRue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}