namespace DD
{
    partial class Form6
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
            this.text123 = new System.Windows.Forms.Label();
            this.Srchbar = new System.Windows.Forms.TextBox();
            this.srchbut = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.Archiv1 = new System.Windows.Forms.DataGridView();
            this.книга_код = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Наименование = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НаименованиеИ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Кол_во_Страниц = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Место = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_издания = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Archiv1)).BeginInit();
            this.SuspendLayout();
            // 
            // text123
            // 
            this.text123.AutoSize = true;
            this.text123.BackColor = System.Drawing.Color.Transparent;
            this.text123.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.text123.ForeColor = System.Drawing.SystemColors.Control;
            this.text123.Location = new System.Drawing.Point(0, 35);
            this.text123.Name = "text123";
            this.text123.Size = new System.Drawing.Size(294, 60);
            this.text123.TabIndex = 5;
            this.text123.Text = "Введите название искомой книги\r\n для последующего удаления\r\n ";
            // 
            // Srchbar
            // 
            this.Srchbar.BackColor = System.Drawing.Color.PowderBlue;
            this.Srchbar.Location = new System.Drawing.Point(3, 12);
            this.Srchbar.Name = "Srchbar";
            this.Srchbar.Size = new System.Drawing.Size(273, 20);
            this.Srchbar.TabIndex = 4;
            // 
            // srchbut
            // 
            this.srchbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.srchbut.Image = global::DD.Properties.Resources._1;
            this.srchbut.Location = new System.Drawing.Point(371, 11);
            this.srchbut.Name = "srchbut";
            this.srchbut.Size = new System.Drawing.Size(475, 57);
            this.srchbut.TabIndex = 7;
            this.srchbut.Text = "поиск";
            this.srchbut.UseVisualStyleBackColor = true;
            this.srchbut.Click += new System.EventHandler(this.srchbut_Click);
            // 
            // DelButton
            // 
            this.DelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.DelButton.Image = global::DD.Properties.Resources._1;
            this.DelButton.Location = new System.Drawing.Point(1, 150);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(841, 74);
            this.DelButton.TabIndex = 8;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // Archiv1
            // 
            this.Archiv1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.Archiv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Archiv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Archiv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.книга_код,
            this.Фамилия,
            this.Название,
            this.Наименование,
            this.НаименованиеИ,
            this.Кол_во_Страниц,
            this.Место,
            this.Дата_издания});
            this.Archiv1.Location = new System.Drawing.Point(-1, 78);
            this.Archiv1.Name = "Archiv1";
            this.Archiv1.Size = new System.Drawing.Size(849, 56);
            this.Archiv1.TabIndex = 9;
            // 
            // книга_код
            // 
            this.книга_код.HeaderText = "книга_код";
            this.книга_код.Name = "книга_код";
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.Name = "Фамилия";
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.Name = "Название";
            // 
            // Наименование
            // 
            this.Наименование.HeaderText = "Наименование";
            this.Наименование.Name = "Наименование";
            // 
            // НаименованиеИ
            // 
            this.НаименованиеИ.HeaderText = "НаименованиеИ";
            this.НаименованиеИ.Name = "НаименованиеИ";
            // 
            // Кол_во_Страниц
            // 
            this.Кол_во_Страниц.HeaderText = "Кол_во_Страниц";
            this.Кол_во_Страниц.Name = "Кол_во_Страниц";
            // 
            // Место
            // 
            this.Место.HeaderText = "Место";
            this.Место.Name = "Место";
            // 
            // Дата_издания
            // 
            this.Дата_издания.HeaderText = "Дата_издания";
            this.Дата_издания.Name = "Дата_издания";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DD.Properties.Resources.fantasy_library_concept_art_by_zoolax_d3k4m6s_fullview;
            this.ClientSize = new System.Drawing.Size(846, 226);
            this.Controls.Add(this.Archiv1);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.srchbut);
            this.Controls.Add(this.text123);
            this.Controls.Add(this.Srchbar);
            this.Name = "Form6";
            this.Text = "Удаление";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form6_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form6_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Archiv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button srchbut;
        private System.Windows.Forms.Label text123;
        private System.Windows.Forms.TextBox Srchbar;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.DataGridView Archiv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn книга_код;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Наименование;
        private System.Windows.Forms.DataGridViewTextBoxColumn НаименованиеИ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Кол_во_Страниц;
        private System.Windows.Forms.DataGridViewTextBoxColumn Место;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_издания;
    }
}