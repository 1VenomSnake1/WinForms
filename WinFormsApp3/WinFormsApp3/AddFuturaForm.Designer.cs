namespace WinFormsApp3
{
    partial class AddFuturaForm
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
            comboBoxClientName = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            buttonYes = new Button();
            buttonNo = new Button();
            SuspendLayout();
            // 
            // comboBoxClientName
            // 
            comboBoxClientName.FormattingEnabled = true;
            comboBoxClientName.Location = new Point(90, 28);
            comboBoxClientName.Name = "comboBoxClientName";
            comboBoxClientName.Size = new Size(121, 23);
            comboBoxClientName.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(90, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Клиент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 88);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Дата";
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(53, 322);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(89, 23);
            buttonYes.TabIndex = 4;
            buttonYes.Text = "Подтвердить";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.Location = new Point(200, 322);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(90, 23);
            buttonNo.TabIndex = 5;
            buttonNo.Text = "Отмена";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // AddFuturaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxClientName);
            Name = "AddFuturaForm";
            Text = "AddFuturaForm";
            Load += AddFuturaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxClientName;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Button buttonYes;
        private Button buttonNo;
    }
}