namespace laba3oop
{
    partial class EditForm
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
            buttonOK = new Button();
            buttonCancel = new Button();
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GreenYellow;
            label1.Location = new Point(399, 149);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.GreenYellow;
            label2.Location = new Point(756, 149);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 6;
            label2.Text = "Description";
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.LightPink;
            buttonOK.Location = new Point(682, 357);
            buttonOK.Margin = new Padding(5);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(209, 94);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "Save";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightPink;
            buttonCancel.Location = new Point(399, 357);
            buttonCancel.Margin = new Padding(5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(209, 94);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(280, 239);
            textBoxName.Margin = new Padding(5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(328, 39);
            textBoxName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(682, 239);
            textBoxDescription.Margin = new Padding(5);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(328, 39);
            textBoxDescription.TabIndex = 1;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1203, 611);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Margin = new Padding(5);
            Name = "EditForm";
            Text = "Edit";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonOK;
        private Button buttonCancel;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
    }
}