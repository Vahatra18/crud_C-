namespace crud
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
            this.ajout = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.numVoiture = new System.Windows.Forms.TextBox();
            this.modelVoiture = new System.Windows.Forms.TextBox();
            this.marqueVoiture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.supprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ajout
            // 
            this.ajout.Location = new System.Drawing.Point(66, 114);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(75, 23);
            this.ajout.TabIndex = 0;
            this.ajout.Text = "Ajouter";
            this.ajout.UseVisualStyleBackColor = true;
            this.ajout.Click += new System.EventHandler(this.ajout_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(262, 114);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(75, 23);
            this.modifier.TabIndex = 1;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(165, 114);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 2;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // numVoiture
            // 
            this.numVoiture.Location = new System.Drawing.Point(66, 62);
            this.numVoiture.Name = "numVoiture";
            this.numVoiture.Size = new System.Drawing.Size(161, 20);
            this.numVoiture.TabIndex = 3;
            // 
            // modelVoiture
            // 
            this.modelVoiture.Location = new System.Drawing.Point(504, 62);
            this.modelVoiture.Name = "modelVoiture";
            this.modelVoiture.Size = new System.Drawing.Size(161, 20);
            this.modelVoiture.TabIndex = 4;
            // 
            // marqueVoiture
            // 
            this.marqueVoiture.Location = new System.Drawing.Point(282, 62);
            this.marqueVoiture.Name = "marqueVoiture";
            this.marqueVoiture.Size = new System.Drawing.Size(161, 20);
            this.marqueVoiture.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numéro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modèle";
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(359, 114);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(75, 23);
            this.supprimer.TabIndex = 9;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(599, 223);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marqueVoiture);
            this.Controls.Add(this.modelVoiture);
            this.Controls.Add(this.numVoiture);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajout;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.TextBox numVoiture;
        private System.Windows.Forms.TextBox modelVoiture;
        private System.Windows.Forms.TextBox marqueVoiture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

