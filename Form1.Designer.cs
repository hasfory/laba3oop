namespace laba3oop
{
    partial class Form1
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
            buttonOpen = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonAbout = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(158, 32);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1010, 442);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = Color.LightPink;
            buttonOpen.Location = new Point(104, 505);
            buttonOpen.Margin = new Padding(5);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(350, 76);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Select JSON file";
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.LightPink;
            buttonEdit.Location = new Point(920, 505);
            buttonEdit.Margin = new Padding(5);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(358, 76);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit object";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.LightPink;
            buttonAdd.Location = new Point(511, 505);
            buttonAdd.Margin = new Padding(5);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(359, 76);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add object";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.LightPink;
            buttonDelete.Location = new Point(511, 609);
            buttonDelete.Margin = new Padding(5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(359, 80);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete object";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = Color.LightPink;
            buttonAbout.Location = new Point(104, 609);
            buttonAbout.Margin = new Padding(5);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(350, 80);
            buttonAbout.TabIndex = 5;
            buttonAbout.Text = "Info";
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightPink;
            buttonSave.Location = new Point(920, 609);
            buttonSave.Margin = new Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(358, 80);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save file";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1300, 720);
            Controls.Add(buttonSave);
            Controls.Add(buttonAbout);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(buttonOpen);
            Controls.Add(dataGridView1);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonOpen;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonAbout;
        private Button buttonSave;
    }
}