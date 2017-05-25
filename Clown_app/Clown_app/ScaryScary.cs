using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clown_app
{
    class ScaryScary:FunnyFunny, IScaryClown
    {
        public ScaryScary (string funnyThingIHave, int numberOfScaryThings): base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        private int numberOfScaryThings;

        private string scaryThingIHave;
        public string ScaryThingIHave
        {
            get
            {
                return ScaryThingIHave + " spiders";
            }
        }
        
        public void ScareLittleChildren()
        {
            MessageBox.Show("Huh! Got you!");
        }

    }
}
