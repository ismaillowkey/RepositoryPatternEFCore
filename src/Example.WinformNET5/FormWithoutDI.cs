using Example.Persistence.Contexts;
using Example.Persistence.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace Example.WinformNET5
{
    public partial class FormWithoutDI : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public FormWithoutDI()
        {
            InitializeComponent();
            // see : https://docs.microsoft.com/en-us/ef/core/dbcontext-configuration/
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite("Data Source=dbexample2.db")
                .Options;
            var context = new ApplicationDbContext(contextOptions);
            _unitOfWork = new UnitOfWork(context);
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
    }
}
