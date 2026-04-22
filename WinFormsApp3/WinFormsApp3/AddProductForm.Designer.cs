namespace WinFormsApp3
{
    partial class AddProductForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxEd = new TextBox();
            buttonYes = new Button();
            buttonNO = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 46);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 0;
            label1.Text = "Наименование товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 88);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Ед. измерения";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(186, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxEd
            // 
            textBoxEd.Location = new Point(186, 80);
            textBoxEd.Name = "textBoxEd";
            textBoxEd.Size = new Size(100, 23);
            textBoxEd.TabIndex = 3;
            // 
            // buttonYes
            // 
            buttonYes.Location = new Point(50, 203);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(85, 23);
            buttonYes.TabIndex = 4;
            buttonYes.Text = "Подтвердить";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonNO
            // 
            buttonNO.Location = new Point(186, 203);
            buttonNO.Name = "buttonNO";
            buttonNO.Size = new Size(90, 23);
            buttonNO.TabIndex = 5;
            buttonNO.Text = "Отмена";
            buttonNO.UseVisualStyleBackColor = true;
            buttonNO.Click += buttonNO_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonNO);
            Controls.Add(buttonYes);
            Controls.Add(textBoxEd);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxEd;
        private Button buttonYes;
        private Button buttonNO;
    }
}