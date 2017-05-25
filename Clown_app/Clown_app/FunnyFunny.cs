using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clown_app
{
    class FunnyFunny:IClown
    {
        
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        private string funnyThingIHave;
        public string FunnyThingIHave
        {
            get
            {
                return "Bip-bip! I have a " + funnyThingIHave;
            }
        }

        public void Honk()
        {
            MessageBox.Show(this.FunnyThingIHave);
        }
    }
}
