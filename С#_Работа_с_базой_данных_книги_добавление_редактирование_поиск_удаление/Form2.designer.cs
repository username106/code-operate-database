namespace DD
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
            this.Archiv = new System.Windows.Forms.DataGridView();
            this.книга_код = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Наименование = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НаименованиеИ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Кол_во_Страниц = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Место = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_издания = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Archiv)).BeginInit();
            this.SuspendLayout();
            // 
            // Archiv
            // 
            this.Archiv.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.Archiv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Archiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Archiv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.книга_код,
            this.Фамилия,
            this.Название,
            this.Наименование,
            this.НаименованиеИ,
            this.Кол_во_Страниц,
            this.Место,
            this.Дата_издания});
            this.Archiv.Location = new System.Drawing.Point(-1, 1);
            this.Archiv.Name = "Archiv";
            this.Archiv.Size = new System.Drawing.Size(845, 508);
            this.Archiv.TabIndex = 0;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DD.Properties.Resources.fantasy_library_concept_art_by_zoolax_d3k4m6s_fullview;
            this.ClientSize = new System.Drawing.Size(1010, 503);
            this.Controls.Add(this.Archiv);
            this.Name = "Form2";
            this.Text = "Архив";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Archiv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Archiv;
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