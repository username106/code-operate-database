namespace DD
{
    partial class Form3
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
            this.BookTi = new System.Windows.Forms.TextBox();
            this.VidIz = new System.Windows.Forms.TextBox();
            this.TitleIzd = new System.Windows.Forms.TextBox();
            this.Numb = new System.Windows.Forms.TextBox();
            this.Place = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.AuthorO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AUt = new System.Windows.Forms.DataGridView();
            this.автор_код = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отчество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AUt)).BeginInit();
            this.SuspendLayout();
            // 
            // BookTi
            // 
            this.BookTi.Location = new System.Drawing.Point(21, 104);
            this.BookTi.Name = "BookTi";
            this.BookTi.Size = new System.Drawing.Size(160, 20);
            this.BookTi.TabIndex = 1;
            this.BookTi.TextChanged += new System.EventHandler(this.BookTi_TextChanged);
            // 
            // VidIz
            // 
            this.VidIz.Location = new System.Drawing.Point(20, 171);
            this.VidIz.Name = "VidIz";
            this.VidIz.Size = new System.Drawing.Size(160, 20);
            this.VidIz.TabIndex = 2;
            this.VidIz.TextChanged += new System.EventHandler(this.VidIz_TextChanged);
            // 
            // TitleIzd
            // 
            this.TitleIzd.Location = new System.Drawing.Point(20, 248);
            this.TitleIzd.Name = "TitleIzd";
            this.TitleIzd.Size = new System.Drawing.Size(160, 20);
            this.TitleIzd.TabIndex = 3;
            // 
            // Numb
            // 
            this.Numb.Location = new System.Drawing.Point(20, 323);
            this.Numb.Name = "Numb";
            this.Numb.Size = new System.Drawing.Size(160, 20);
            this.Numb.TabIndex = 4;
            // 
            // Place
            // 
            this.Place.Location = new System.Drawing.Point(21, 373);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(160, 20);
            this.Place.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(21, 419);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(160, 20);
            this.Date.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(207, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите Название книги";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(194, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите вид издания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(194, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите название издательства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(194, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите Кол-во страниц";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(194, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введите место издания";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(194, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Введите дату издания(гг-мм-д)";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.ConfirmButton.Image = global::DD.Properties.Resources._1;
            this.ConfirmButton.Location = new System.Drawing.Point(907, 21);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(148, 409);
            this.ConfirmButton.TabIndex = 18;
            this.ConfirmButton.Text = "В\r\nн\r\nе\r\nс\r\nт\r\nи\r\n\r\nД\r\nа\r\nн\r\nн\r\nы\r\nе";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AuthorO
            // 
            this.AuthorO.Location = new System.Drawing.Point(21, 40);
            this.AuthorO.Name = "AuthorO";
            this.AuthorO.Size = new System.Drawing.Size(160, 20);
            this.AuthorO.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(194, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Введите код автора\r\n";
            // 
            // AUt
            // 
            this.AUt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AUt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.автор_код,
            this.Фамилия,
            this.Имя,
            this.Отчество});
            this.AUt.Location = new System.Drawing.Point(433, 12);
            this.AUt.Name = "AUt";
            this.AUt.Size = new System.Drawing.Size(455, 48);
            this.AUt.TabIndex = 23;
            // 
            // автор_код
            // 
            this.автор_код.HeaderText = "автор_код";
            this.автор_код.Name = "автор_код";
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.Name = "Фамилия";
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Имя";
            this.Имя.Name = "Имя";
            // 
            // Отчество
            // 
            this.Отчество.HeaderText = "Отчество";
            this.Отчество.Name = "Отчество";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DD.Properties.Resources.fantasy_library_concept_art_by_zoolax_d3k4m6s_fullview;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.AUt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AuthorO);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.Numb);
            this.Controls.Add(this.TitleIzd);
            this.Controls.Add(this.VidIz);
            this.Controls.Add(this.BookTi);
            this.Name = "Form3";
            this.Text = "добавление";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove_1);
            ((System.ComponentModel.ISupportInitialize)(this.AUt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BookTi;
        private System.Windows.Forms.TextBox VidIz;
        private System.Windows.Forms.TextBox TitleIzd;
        private System.Windows.Forms.TextBox Numb;
        private System.Windows.Forms.TextBox Place;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox AuthorO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView AUt;
        private System.Windows.Forms.DataGridViewTextBoxColumn автор_код;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отчество;
    }
}