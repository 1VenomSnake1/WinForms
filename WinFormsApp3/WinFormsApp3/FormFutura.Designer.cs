namespace WinFormsApp3
{
    partial class FormFutura
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            menuStrip1 = new MenuStrip();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            наклоднаяToolStripMenuItem = new ToolStripMenuItem();
            товарToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            наклоднаяToolStripMenuItem1 = new ToolStripMenuItem();
            товарToolStripMenuItem1 = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(378, 244);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(412, 101);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(376, 243);
            dataGridView2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, удалитьToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { наклоднаяToolStripMenuItem, товарToolStripMenuItem });
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(71, 20);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // наклоднаяToolStripMenuItem
            // 
            наклоднаяToolStripMenuItem.Name = "наклоднаяToolStripMenuItem";
            наклоднаяToolStripMenuItem.Size = new Size(180, 22);
            наклоднаяToolStripMenuItem.Text = "Наклодная";
            наклоднаяToolStripMenuItem.Click += наклоднаяToolStripMenuItem_Click;
            // 
            // товарToolStripMenuItem
            // 
            товарToolStripMenuItem.Name = "товарToolStripMenuItem";
            товарToolStripMenuItem.Size = new Size(180, 22);
            товарToolStripMenuItem.Text = "Товар";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { наклоднаяToolStripMenuItem1, товарToolStripMenuItem1 });
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(63, 20);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // наклоднаяToolStripMenuItem1
            // 
            наклоднаяToolStripMenuItem1.Name = "наклоднаяToolStripMenuItem1";
            наклоднаяToolStripMenuItem1.Size = new Size(134, 22);
            наклоднаяToolStripMenuItem1.Text = "Наклодная";
            // 
            // товарToolStripMenuItem1
            // 
            товарToolStripMenuItem1.Name = "товарToolStripMenuItem1";
            товарToolStripMenuItem1.Size = new Size(134, 22);
            товарToolStripMenuItem1.Text = "Товар";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(54, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // FormFutura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormFutura";
            Text = "FormFutura";
            Load += FormFutura_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem наклоднаяToolStripMenuItem;
        private ToolStripMenuItem товарToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem наклоднаяToolStripMenuItem1;
        private ToolStripMenuItem товарToolStripMenuItem1;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}