namespace EntityFrameworkMiniProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_prenom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_age = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAjouter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSupprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModifier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Message = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(233, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(99, 91);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // txt_id
            // 
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id.HintForeColor = System.Drawing.Color.Empty;
            this.txt_id.HintText = "";
            this.txt_id.isPassword = false;
            this.txt_id.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txt_id.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_id.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txt_id.LineThickness = 3;
            this.txt_id.Location = new System.Drawing.Point(154, 140);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(314, 31);
            this.txt_id.TabIndex = 1;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_nom
            // 
            this.txt_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nom.HintForeColor = System.Drawing.Color.Empty;
            this.txt_nom.HintText = "";
            this.txt_nom.isPassword = false;
            this.txt_nom.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txt_nom.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_nom.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txt_nom.LineThickness = 3;
            this.txt_nom.Location = new System.Drawing.Point(154, 187);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(314, 31);
            this.txt_nom.TabIndex = 2;
            this.txt_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_prenom.HintForeColor = System.Drawing.Color.Empty;
            this.txt_prenom.HintText = "";
            this.txt_prenom.isPassword = false;
            this.txt_prenom.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txt_prenom.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_prenom.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txt_prenom.LineThickness = 3;
            this.txt_prenom.Location = new System.Drawing.Point(154, 236);
            this.txt_prenom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(314, 31);
            this.txt_prenom.TabIndex = 3;
            this.txt_prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_age
            // 
            this.txt_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_age.HintForeColor = System.Drawing.Color.Empty;
            this.txt_age.HintText = "";
            this.txt_age.isPassword = false;
            this.txt_age.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txt_age.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_age.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txt_age.LineThickness = 3;
            this.txt_age.Location = new System.Drawing.Point(154, 281);
            this.txt_age.Margin = new System.Windows.Forms.Padding(4);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(314, 31);
            this.txt_age.TabIndex = 4;
            this.txt_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjouter.BorderRadius = 0;
            this.btnAjouter.ButtonText = "Ajouter";
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.DisabledColor = System.Drawing.Color.Gray;
            this.btnAjouter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAjouter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Iconimage")));
            this.btnAjouter.Iconimage_right = null;
            this.btnAjouter.Iconimage_right_Selected = null;
            this.btnAjouter.Iconimage_Selected = null;
            this.btnAjouter.IconMarginLeft = 0;
            this.btnAjouter.IconMarginRight = 0;
            this.btnAjouter.IconRightVisible = true;
            this.btnAjouter.IconRightZoom = 0D;
            this.btnAjouter.IconVisible = true;
            this.btnAjouter.IconZoom = 50D;
            this.btnAjouter.IsTab = false;
            this.btnAjouter.Location = new System.Drawing.Point(27, 345);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAjouter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAjouter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAjouter.selected = false;
            this.btnAjouter.Size = new System.Drawing.Size(110, 48);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Textcolor = System.Drawing.Color.White;
            this.btnAjouter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSupprimer.BorderRadius = 0;
            this.btnSupprimer.ButtonText = "Supprimer";
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.DisabledColor = System.Drawing.Color.Gray;
            this.btnSupprimer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSupprimer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.Iconimage")));
            this.btnSupprimer.Iconimage_right = null;
            this.btnSupprimer.Iconimage_right_Selected = null;
            this.btnSupprimer.Iconimage_Selected = null;
            this.btnSupprimer.IconMarginLeft = 0;
            this.btnSupprimer.IconMarginRight = 0;
            this.btnSupprimer.IconRightVisible = true;
            this.btnSupprimer.IconRightZoom = 0D;
            this.btnSupprimer.IconVisible = true;
            this.btnSupprimer.IconZoom = 50D;
            this.btnSupprimer.IsTab = false;
            this.btnSupprimer.Location = new System.Drawing.Point(270, 345);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSupprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSupprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSupprimer.selected = false;
            this.btnSupprimer.Size = new System.Drawing.Size(121, 48);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Textcolor = System.Drawing.Color.White;
            this.btnSupprimer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModifier.BorderRadius = 0;
            this.btnModifier.ButtonText = "Modifier";
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.DisabledColor = System.Drawing.Color.Gray;
            this.btnModifier.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModifier.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModifier.Iconimage")));
            this.btnModifier.Iconimage_right = null;
            this.btnModifier.Iconimage_right_Selected = null;
            this.btnModifier.Iconimage_Selected = null;
            this.btnModifier.IconMarginLeft = 0;
            this.btnModifier.IconMarginRight = 0;
            this.btnModifier.IconRightVisible = true;
            this.btnModifier.IconRightZoom = 0D;
            this.btnModifier.IconVisible = true;
            this.btnModifier.IconZoom = 50D;
            this.btnModifier.IsTab = false;
            this.btnModifier.Location = new System.Drawing.Point(143, 345);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModifier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnModifier.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModifier.selected = false;
            this.btnModifier.Size = new System.Drawing.Size(121, 48);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Textcolor = System.Drawing.Color.White;
            this.btnModifier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.ForeColor = System.Drawing.Color.SeaGreen;
            this.Message.Location = new System.Drawing.Point(183, 123);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 13);
            this.Message.TabIndex = 12;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Afficher";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(397, 345);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(121, 48);
            this.bunifuFlatButton1.TabIndex = 13;
            this.bunifuFlatButton1.Text = "Afficher";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(547, 405);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.bunifuImageButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_prenom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnAjouter;
        private Bunifu.Framework.UI.BunifuFlatButton btnSupprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btnModifier;
        private System.Windows.Forms.Label Message;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

