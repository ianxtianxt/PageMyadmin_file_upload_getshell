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
    public partial class Form2 : Form
    {

        //List<adderess> LPA = new List<adderess>();
        public Form2()
        {
            System.Windows.Forms.Application.ExitThread();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adderess TmpPersonAdderess = new adderess();
            TmpPersonAdderess.telephone = textBox1.Text;
            TmpPersonAdderess.adderes = textBox2.Text;
            //LPA.Add(TmpPersonAdderess);
            Form1 form1 = new Form1(TmpPersonAdderess);

        }

        public adderess PassValueToForm1(adderess TmpPersonAdderess)
        {

        }

        abc()
    }
}
