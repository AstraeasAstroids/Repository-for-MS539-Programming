namespace A_first_program
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
            panel1 = new Panel();
            monthCalendar1 = new MonthCalendar();
            menuStrip1 = new MenuStrip();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            incomeToolStripMenuItem = new ToolStripMenuItem();
            childSupportToolStripMenuItem = new ToolStripMenuItem();
            empoloymentToolStripMenuItem = new ToolStripMenuItem();
            foodToolStripMenuItem = new ToolStripMenuItem();
            periodicExpensesToolStripMenuItem = new ToolStripMenuItem();
            periodicIncomeToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            label1 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            checkedListBox1 = new CheckedListBox();
            textBox1 = new TextBox();
            vScrollBar1 = new VScrollBar();
            checkBox1 = new CheckBox();
            toolStrip1 = new ToolStrip();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(67, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 367);
            panel1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(147, 111);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { categoryToolStripMenuItem, foodToolStripMenuItem, periodicExpensesToolStripMenuItem, periodicIncomeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(549, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { incomeToolStripMenuItem, childSupportToolStripMenuItem, empoloymentToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(73, 25);
            categoryToolStripMenuItem.Text = "Income";
            categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
            // 
            // incomeToolStripMenuItem
            // 
            incomeToolStripMenuItem.Name = "incomeToolStripMenuItem";
            incomeToolStripMenuItem.Size = new Size(177, 26);
            incomeToolStripMenuItem.Text = "Income";
            // 
            // childSupportToolStripMenuItem
            // 
            childSupportToolStripMenuItem.Name = "childSupportToolStripMenuItem";
            childSupportToolStripMenuItem.Size = new Size(177, 26);
            childSupportToolStripMenuItem.Text = "Child support";
            // 
            // empoloymentToolStripMenuItem
            // 
            empoloymentToolStripMenuItem.Name = "empoloymentToolStripMenuItem";
            empoloymentToolStripMenuItem.Size = new Size(177, 26);
            empoloymentToolStripMenuItem.Text = "Empoloyment";
            // 
            // foodToolStripMenuItem
            // 
            foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            foodToolStripMenuItem.Size = new Size(157, 25);
            foodToolStripMenuItem.Text = "Recurring Expenses";
            // 
            // periodicExpensesToolStripMenuItem
            // 
            periodicExpensesToolStripMenuItem.Name = "periodicExpensesToolStripMenuItem";
            periodicExpensesToolStripMenuItem.Size = new Size(144, 25);
            periodicExpensesToolStripMenuItem.Text = "Periodic Expenses";
            // 
            // periodicIncomeToolStripMenuItem
            // 
            periodicIncomeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            periodicIncomeToolStripMenuItem.Name = "periodicIncomeToolStripMenuItem";
            periodicIncomeToolStripMenuItem.Size = new Size(132, 25);
            periodicIncomeToolStripMenuItem.Text = "Periodic Income";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 468);
            label1.Name = "label1";
            label1.Size = new Size(199, 34);
            label1.TabIndex = 1;
            label1.Text = "Monthly Budget";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Location = new Point(276, 536);
            button1.Name = "button1";
            button1.Size = new Size(138, 41);
            button1.TabIndex = 2;
            button1.Text = "New Worksheet\r\n";
            button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(516, 481);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.IndianRed;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(44, 466);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 5;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 622);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(597, 63);
            textBox1.TabIndex = 6;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(644, 605);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 80);
            vScrollBar1.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(67, 512);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(867, 25);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 714);
            Controls.Add(toolStrip1);
            Controls.Add(checkBox1);
            Controls.Add(vScrollBar1);
            Controls.Add(textBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private Button button1;
        private RichTextBox richTextBox1;
        private CheckedListBox checkedListBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem incomeToolStripMenuItem;
        private ToolStripMenuItem childSupportToolStripMenuItem;
        private ToolStripMenuItem empoloymentToolStripMenuItem;
        private ToolStripMenuItem foodToolStripMenuItem;
        private ToolStripMenuItem periodicExpensesToolStripMenuItem;
        private ToolStripMenuItem periodicIncomeToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private TextBox textBox1;
        private VScrollBar vScrollBar1;
        private CheckBox checkBox1;
        private ToolStrip toolStrip1;
    }
}
