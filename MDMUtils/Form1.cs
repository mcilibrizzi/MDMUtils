using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDMUtils;

namespace MDMUtils
{
    public partial class Form1 : Form
    {
        private DBUtils dbutils;
        public Form1()
        {
            InitializeComponent();
            dbutils = new DBUtils();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbutils.searchAccount("test");
        }

    }
}
