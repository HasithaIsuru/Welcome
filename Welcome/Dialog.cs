using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Welcome
{
    public partial class Dialog : Form
    {
        Form1 baseForm;
        public Dialog(Form1 form)
        {
            this.baseForm = form;
            InitializeComponent();
            this.btn_submit.Click += new EventHandler(btnSubmit_Click);
        }

        private void btnSubmit_Click(object sender,System.EventArgs args)
        {
            baseForm.playAnimation(txtIndex.Text);
            baseForm.updateFrom(txtIndex.Text);
        }
    }
}
