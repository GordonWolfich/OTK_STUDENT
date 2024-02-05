
namespace Rakov3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            предварительныйПросмотрToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            настройкаПринтераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            настройкаВыходаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            очиститьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            выравниваниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            поЛевомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            поЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            поПравомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            printDialog1 = new System.Windows.Forms.PrintDialog();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            fontDialog1 = new System.Windows.Forms.FontDialog();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(12, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(617, 520);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(635, 28);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(84, 23);
            button1.TabIndex = 1;
            button1.Text = "Вырезать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_cut_1;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(635, 57);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(84, 23);
            button2.TabIndex = 2;
            button2.Text = "Копировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_copy_1;
            // 
            // button
            // 
            button.Location = new System.Drawing.Point(635, 92);
            button.Name = "button";
            button.Size = new System.Drawing.Size(84, 23);
            button.TabIndex = 3;
            button.Text = "Вставить";
            button.UseVisualStyleBackColor = true;
            button.Click += button_paste_1;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(635, 122);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(84, 23);
            button4.TabIndex = 4;
            button4.Text = "Очистить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_clear_1;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(635, 151);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(84, 23);
            button3.TabIndex = 5;
            button3.Text = "Выделить";
            button3.UseVisualStyleBackColor = true;
            button3.BackColorChanged += button3_Click_1;
            button3.Click += button3_Click_1;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(634, 309);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(84, 23);
            button8.TabIndex = 8;
            button8.Text = "Открыть";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button2_Open_Click_1;
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(634, 374);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(84, 23);
            button9.TabIndex = 9;
            button9.Text = "Сохранить";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button2Save_Click_1;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(634, 468);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(84, 23);
            button10.TabIndex = 10;
            button10.Text = "Выход";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_left_1;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, предварительныйПросмотрToolStripMenuItem, настройкаПринтераToolStripMenuItem, выходToolStripMenuItem, настройкаВыходаToolStripMenuItem, toolStripMenuItem1, выходToolStripMenuItem1 });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += button1_Open_Click_1;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += button1Save_Click_1;
            // 
            // предварительныйПросмотрToolStripMenuItem
            // 
            предварительныйПросмотрToolStripMenuItem.Name = "предварительныйПросмотрToolStripMenuItem";
            предварительныйПросмотрToolStripMenuItem.Size = new System.Drawing.Size(230, 6);
            // 
            // настройкаПринтераToolStripMenuItem
            // 
            настройкаПринтераToolStripMenuItem.Name = "настройкаПринтераToolStripMenuItem";
            настройкаПринтераToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            настройкаПринтераToolStripMenuItem.Text = "Печать";
            настройкаПринтераToolStripMenuItem.Click += button_print_1;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            выходToolStripMenuItem.Text = "Предварительный просмотр";
            выходToolStripMenuItem.Click += button_print_preview_1;
            // 
            // настройкаВыходаToolStripMenuItem
            // 
            настройкаВыходаToolStripMenuItem.Name = "настройкаВыходаToolStripMenuItem";
            настройкаВыходаToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            настройкаВыходаToolStripMenuItem.Text = "Настройка принтера";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(230, 6);
            // 
            // выходToolStripMenuItem1
            // 
            выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            выходToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            выходToolStripMenuItem1.Text = "Выход";
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставитьToolStripMenuItem, очиститьToolStripMenuItem, очиститьToolStripMenuItem1 });
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            вырезатьToolStripMenuItem.Text = "Вырезать";
            вырезатьToolStripMenuItem.Click += button_cut_1;
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            копироватьToolStripMenuItem.Text = "Копировать";
            копироватьToolStripMenuItem.Click += button_copy_1;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            вставитьToolStripMenuItem.Text = "Вставить";
            вставитьToolStripMenuItem.Click += button_paste_1;
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new System.Drawing.Size(136, 6);
            // 
            // очиститьToolStripMenuItem1
            // 
            очиститьToolStripMenuItem1.Name = "очиститьToolStripMenuItem1";
            очиститьToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            очиститьToolStripMenuItem1.Text = "Очистить";
            очиститьToolStripMenuItem1.Click += button_clear_1;
            // 
            // сервисToolStripMenuItem
            // 
            сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { цветToolStripMenuItem, шрифтToolStripMenuItem, выравниваниеToolStripMenuItem });
            сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            сервисToolStripMenuItem.Text = "Сервис";
            // 
            // цветToolStripMenuItem
            // 
            цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            цветToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            цветToolStripMenuItem.Text = "Цвет";
            цветToolStripMenuItem.Click += button_color_click1;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += button_font_click1;
            // 
            // выравниваниеToolStripMenuItem
            // 
            выравниваниеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { поЛевомуКраюToolStripMenuItem, поЦентруToolStripMenuItem, поПравомуКраюToolStripMenuItem });
            выравниваниеToolStripMenuItem.Name = "выравниваниеToolStripMenuItem";
            выравниваниеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            выравниваниеToolStripMenuItem.Text = "Выравнивание";
            // 
            // поЛевомуКраюToolStripMenuItem
            // 
            поЛевомуКраюToolStripMenuItem.Name = "поЛевомуКраюToolStripMenuItem";
            поЛевомуКраюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            поЛевомуКраюToolStripMenuItem.Text = "По левому краю";
            поЛевомуКраюToolStripMenuItem.Click += button_LK_click;
            // 
            // поЦентруToolStripMenuItem
            // 
            поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            поЦентруToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            поЦентруToolStripMenuItem.Text = "По центру";
            поЦентруToolStripMenuItem.Click += button_CE_click1;
            // 
            // поПравомуКраюToolStripMenuItem
            // 
            поПравомуКраюToolStripMenuItem.Name = "поПравомуКраюToolStripMenuItem";
            поПравомуКраюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            поПравомуКраюToolStripMenuItem.Text = "По правому краю";
            поПравомуКраюToolStripMenuItem.Click += button_RK_click1;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { оПрограммеToolStripMenuItem1 });
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            оПрограммеToolStripMenuItem1.Text = "О программе";
            оПрограммеToolStripMenuItem1.Click += button_open_about;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { файлToolStripMenuItem, редактироватьToolStripMenuItem, сервисToolStripMenuItem, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(731, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += print_1;
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            // 
            // printDialog1
            // 
            printDialog1.AllowSomePages = true;
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(634, 206);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(84, 23);
            button5.TabIndex = 12;
            button5.Text = "Цвет";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_color_click2;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(634, 257);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(84, 23);
            button6.TabIndex = 13;
            button6.Text = "Шрифт";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_font_click2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(731, 560);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Текстовый редактор";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator предварительныйПросмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаПринтераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаВыходаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выравниваниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem поЛевомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поПравомуКраюToolStripMenuItem;
    }
}

