using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp12
{
    public class person
    {
        public string name;
        public List<adderess> LPA = new List<adderess>();
        public string Name    // property
        {
            get { return name; }
            set { name = value; }
        }
        private void GotoNextStep()
        {
            // pass the existing instance to the next form
            Form2 form2 = new Form2(tempSoldier);

            // display form 2 ...
        }

    }
}
