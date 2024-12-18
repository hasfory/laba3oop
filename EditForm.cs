﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3oop
{
    public partial class EditForm : Form
    {
        public MyData Data { get; private set; }
        public EditForm(MyData data = null)
        {
            InitializeComponent();
            if (data != null)
            {
                //textBoxID.Text = data.ID.ToString();
                textBoxName.Text = data.Name;
                textBoxDescription.Text = data.Description;
                Data = data;
            }
            else
            {
                Data = new MyData();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //Data.ID = int.Parse(textBoxID.Text);
            Data.Name = textBoxName.Text;
            Data.Description = textBoxDescription.Text;
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void EditForm_Load(object sender, EventArgs e)
        {

        }
        
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
