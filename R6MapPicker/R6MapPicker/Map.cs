using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R6MapPicker
{
    class Map
    {
        private string nomCarte;
        private bool active;
        public Map(string NomCarte, bool Active)
        {
            nomCarte = NomCarte;
            active = Active;
        }

        public string NomCarte
        {
            get { return nomCarte; }
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
    }
}
