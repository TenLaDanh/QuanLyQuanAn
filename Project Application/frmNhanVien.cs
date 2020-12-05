using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Application
{
    public partial class frmNhanVien : Form
    {
        private List<Button> a;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            a = new List<Button>();
            for(int i=1;i<=20;i++)
            {
                Button b = new Button();
                b.Text = "Ban " + i;
                b.Width = 109;
                b.Height = 57;
                b.Click += new EventHandler(button_Click);
                flowLayoutPanel1.Controls.Add(b);
            }
        }
        private static void button_Click(Object sender,EventArgs e)
        {
            
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {

        }

       
    }
}
