﻿using Example.Persistence.UnitOfWork;
using System;
using System.Windows.Forms;

namespace Example.WinformNETFramework
{
    public partial class Form1 : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public Form1(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private async void BtnGetAllDeveloper_Click(object sender, EventArgs e)
        {
            var res = await _unitOfWork.Developers.GetAllAsync();
            DGVDeveloper.DataSource = res;
        }

        private async void BtnGetAllProject_Click(object sender, EventArgs e)
        {
            var res = await _unitOfWork.Projects.GetAllAsync();
            DGVProject.DataSource = res;
        }

        private void BtnWithoutDI_Click(object sender, EventArgs e)
        {
            var form = new FormWithoutDI();
            form.ShowDialog();
        }
    }
}
