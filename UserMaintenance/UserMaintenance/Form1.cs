﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = Resource1.LastName; // label1
            label2.Text = Resource1.FirstName; // label2
            button1.Text = Resource1.Add; // button1
        }
        listUsers.DataSource = users;
        listUsers.ValueMember = "ID";
        listUsers.DisplayMember = "FullName";

        private void Button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                LastName = label1.Text,
                FirstName = label2.Text
            };
            users.Add(u);
        }
    }
}
