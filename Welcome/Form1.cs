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
    public partial class Form1 : Form
    {
        private Dictionary<string, Person> personMap;

        public void updateFrom(String indexNo)
        {
            if (personMap.ContainsKey(indexNo))
            {
                Person person = personMap[indexNo];
                lblName.Text = person.name;
                lblTeam.Text = person.team;
            }
            this.BackgroundImage = Properties.Resources.bg_red;
        }

        public void showPopup()
        {
            Dialog dialog = new Dialog(this);
            dialog.Show(this);
        }
        public Form1()
        {
            InitializeComponent();

            buildMap();
        }


        private void buildMap()
        {
            personMap = new Dictionary<string, Person>();
            personMap.Add("160451M", new Person("Heshan", "Team1", "160451M"));
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            showPopup();
        }

        private void lblTeam_Click(object sender, EventArgs e)
        {

        }
    }
}
