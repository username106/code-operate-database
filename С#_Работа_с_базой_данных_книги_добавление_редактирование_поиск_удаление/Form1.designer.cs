namespace DD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.Edi = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Srch = new System.Windows.Forms.Button();
            this.ShowDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Image = global::DD.Properties.Resources._1;
            this.Add.Location = new System.Drawing.Point(12, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(271, 73);
            this.Add.TabIndex = 0;
            this.Add.Text = "Добавить книгу";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            this.Add.MouseEnter += new System.EventHandler(this.Add_MouseEnter);
            this.Add.MouseLeave += new System.EventHandler(this.Add_MouseLeave);
            // 
            // Edi
            // 
            this.Edi.Image = global::DD.Properties.Resources._1;
            this.Edi.Location = new System.Drawing.Point(12, 102);
            this.Edi.Name = "Edi";
            this.Edi.Size = new System.Drawing.Size(271, 73);
            this.Edi.TabIndex = 1;
            this.Edi.Text = "Редактировать книгу";
            this.Edi.UseVisualStyleBackColor = true;
            this.Edi.Click += new System.EventHandler(this.Edi_Click);
            this.Edi.MouseEnter += new System.EventHandler(this.Edi_MouseEnter);
            this.Edi.MouseLeave += new System.EventHandler(this.Edi_MouseLeave);
            // 
            // Del
            // 
            this.Del.Image = global::DD.Properties.Resources._1;
            this.Del.Location = new System.Drawing.Point(12, 193);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(271, 73);
            this.Del.TabIndex = 2;
            this.Del.Text = "Удалить книгу";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            this.Del.MouseEnter += new System.EventHandler(this.Del_MouseEnter);
            this.Del.MouseLeave += new System.EventHandler(this.Del_MouseLeave);
            // 
            // Srch
            // 
            this.Srch.Image = global::DD.Properties.Resources._1;
            this.Srch.Location = new System.Drawing.Point(12, 286);
            this.Srch.Name = "Srch";
            this.Srch.Size = new System.Drawing.Size(271, 73);
            this.Srch.TabIndex = 3;
            this.Srch.Text = "Поиск книги";
            this.Srch.UseVisualStyleBackColor = true;
            this.Srch.Click += new System.EventHandler(this.Srch_Click);
            this.Srch.MouseEnter += new System.EventHandler(this.Srch_MouseEnter);
            this.Srch.MouseLeave += new System.EventHandler(this.Srch_MouseLeave);
            // 
            // ShowDB
            // 
            this.ShowDB.Image = global::DD.Properties.Resources._1;
            this.ShowDB.Location = new System.Drawing.Point(11, 371);
            this.ShowDB.Name = "ShowDB";
            this.ShowDB.Size = new System.Drawing.Size(271, 72);
            this.ShowDB.TabIndex = 4;
            this.ShowDB.Text = "Архив";
            this.ShowDB.UseVisualStyleBackColor = true;
            this.ShowDB.Click += new System.EventHandler(this.ShowDB_Click);
            this.ShowDB.MouseEnter += new System.EventHandler(this.ShowDB_MouseEnter);
            this.ShowDB.MouseLeave += new System.EventHandler(this.ShowDB_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DD.Properties.Resources.fantasy_library_concept_art_by_zoolax_d3k4m6s_fullview;
            this.ClientSize = new System.Drawing.Size(1012, 466);
            this.Controls.Add(this.ShowDB);
            this.Controls.Add(this.Srch);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Edi);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edi;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Srch;
        private System.Windows.Forms.Button ShowDB;
    }
}

