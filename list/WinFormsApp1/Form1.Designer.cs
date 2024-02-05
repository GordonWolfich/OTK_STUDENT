namespace WinFormsApp1
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            добавитьСтрокуToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            изменитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            очиститьСписокToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            button8 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 304);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(171, 23);
            label1.TabIndex = 1;
            label1.Text = "Список студентов";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 48);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Поле ввода";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(278, 95);
            button1.Name = "button1";
            button1.Size = new Size(120, 26);
            button1.TabIndex = 4;
            button1.Text = "Добавить строку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_click_1;
            // 
            // button2
            // 
            button2.Location = new Point(278, 133);
            button2.Name = "button2";
            button2.Size = new Size(120, 26);
            button2.TabIndex = 5;
            button2.Text = "Вставить строку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_insert_click1;
            // 
            // button3
            // 
            button3.Location = new Point(278, 165);
            button3.Name = "button3";
            button3.Size = new Size(120, 26);
            button3.TabIndex = 6;
            button3.Text = "Изменить строку";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_edit_click1;
            // 
            // button4
            // 
            button4.Location = new Point(278, 197);
            button4.Name = "button4";
            button4.Size = new Size(120, 26);
            button4.TabIndex = 7;
            button4.Text = "Удалить из списка";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_delete_click1;
            // 
            // button5
            // 
            button5.Location = new Point(278, 229);
            button5.Name = "button5";
            button5.Size = new Size(120, 26);
            button5.TabIndex = 8;
            button5.Text = "Очистить список";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_clear_click1;
            // 
            // button6
            // 
            button6.Location = new Point(278, 294);
            button6.Name = "button6";
            button6.Size = new Size(120, 26);
            button6.TabIndex = 9;
            button6.Text = "Открыть";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_open_click1;
            // 
            // button7
            // 
            button7.Location = new Point(278, 326);
            button7.Name = "button7";
            button7.Size = new Size(120, 26);
            button7.TabIndex = 10;
            button7.Text = "Сохранить";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_save_click1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, редактироватьToolStripMenuItem, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(459, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += button_open_click2;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += button_save_click2;
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьСтрокуToolStripMenuItem, вставитьToolStripMenuItem, изменитьToolStripMenuItem, удалитьToolStripMenuItem, очиститьСписокToolStripMenuItem });
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(99, 20);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьСтрокуToolStripMenuItem
            // 
            добавитьСтрокуToolStripMenuItem.Name = "добавитьСтрокуToolStripMenuItem";
            добавитьСтрокуToolStripMenuItem.Size = new Size(180, 22);
            добавитьСтрокуToolStripMenuItem.Text = "Добавить";
            добавитьСтрокуToolStripMenuItem.Click += button_add_click1;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(180, 22);
            вставитьToolStripMenuItem.Text = "Вставить";
            вставитьToolStripMenuItem.Click += button_insert_click2;
            // 
            // изменитьToolStripMenuItem
            // 
            изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            изменитьToolStripMenuItem.Size = new Size(180, 22);
            изменитьToolStripMenuItem.Text = "Изменить";
            изменитьToolStripMenuItem.Click += button_edit_click2;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(180, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += button_delete_click2;
            // 
            // очиститьСписокToolStripMenuItem
            // 
            очиститьСписокToolStripMenuItem.Name = "очиститьСписокToolStripMenuItem";
            очиститьСписокToolStripMenuItem.Size = new Size(180, 22);
            очиститьСписокToolStripMenuItem.Text = "Очистить список";
            очиститьСписокToolStripMenuItem.Click += button_clear_click2;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(94, 20);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += button_O_click1;
            // 
            // button8
            // 
            button8.Location = new Point(278, 375);
            button8.Name = "button8";
            button8.Size = new Size(120, 26);
            button8.TabIndex = 12;
            button8.Text = "Выход";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_exit_click1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Обработка строк";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem добавитьСтрокуToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem очиститьСписокToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Button button8;
    }
}
