using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cv_generator
{
    public partial class formInput : Form
    { 

        public formInput()
        {
            InitializeComponent();
        }
        
        private void formInput_Load(object sender, EventArgs e)
        {
            MemberData data = new MemberData();
            FunctionClass func = new FunctionClass();
            
           // data.name= "Hello";
            lblName.Text = data.name;
        }
    }
}
