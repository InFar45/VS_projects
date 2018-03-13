using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallGuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        interface IClown
        {
            string FunnyThingIHave { get; }
            void Honk();
        }

        class TallGuy : IClown 
        {
            public string Name;
            public int Height;

            public void TalkAboutYourself()
            {
                MessageBox.Show("My name is " + Name + " my height is " + Height + " sm.");
            }

            public string FunnyThingIHave
            {
                get { return "Big boots"; }
            }

            public void Honk()
            {
                MessageBox.Show("bi!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TallGuy tallGuy = new TallGuy() { Height = 190, Name = "Jimm" };
            tallGuy.TalkAboutYourself();
        }
    }
}
