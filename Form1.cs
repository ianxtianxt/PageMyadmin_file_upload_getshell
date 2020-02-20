using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp12
{   
    public partial class Form1 : Form
    {

        List<person> LP = new List<person>();


        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            person TmpPerson = new person();
            TmpPerson.name = textBox3.Text;
            LP.Add(TmpPerson);
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            adderess TmpPersonAdderess = new adderess();
            Form2 form2 = new Form2();
            form2.Show();
            
        }
    }
}
