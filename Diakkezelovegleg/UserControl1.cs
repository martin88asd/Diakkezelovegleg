
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Diakkezelovegleg
{
    public partial class UserControl1 : UserControl
    {
        private Diak diak;
        public bool Checked => checkBox1.Checked;
        public Diak Diak => diak;

        public UserControl1(Diak diak)
        {
            InitializeComponent();
            this.diak = diak;
            checkBox1.Text = diak.Neve + ' ' + diak.Kodos;

        }


        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
