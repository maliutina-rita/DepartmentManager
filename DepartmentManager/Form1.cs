using DepartmentManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentManager
{
    public partial class Form1 : Form
    {
        Context context = new Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = context.DbDepartments.ToList();

            var list2 = context.DbEmployees.ToList();
        }
    }
}
