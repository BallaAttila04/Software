using StudiesDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudiesDB
{
    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from i in context.Instructors
                                   where i.Name.Contains(textBox1.Text)
                                   select i).ToList();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            var eredmeny = from x in context.Instructors
                           select x;
            listBox1.DataSource = eredmeny.ToList();


            var oktatoszam = context.Instructors.Count();
            var statusz = (from x in context.Instructors
                           select x.StatusFk).Max();

            var legrangosabb = from x in context.Instructors
                               where x.StatusFk == statusz
                               select x.Name;

            MessageBox.Show($"{string.Join(',', legrangosabb)}");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;

            }

            var instructor = (Instructor)listBox1.SelectedItem;

            var orak = from x in context.Lessons
                       where x.InstructorFk == instructor.InstructorSk
                       select new
                       {
                           x.CourseFkNavigation.Name,
                           x.CourseFkNavigation.Code,
                           Nap = x.DayFkNavigation.Name,
                           Sav = x.TimeFkNavigation.Name,
                           Terem = x.RoomFkNavigation.Name
                       };

            dataGridView1.DataSource = orak.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }
    }
}
