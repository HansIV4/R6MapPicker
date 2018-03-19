using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R6MapPicker
{
    class ProgramController
    {
        Map[] tabCartes = new Map[9];
        #region Ctor
        public ProgramController()
        {
            tabCartes[0] = new Map("Banque", true);
            tabCartes[1] = new Map("Clubhouse", true);
            tabCartes[2] = new Map("Oregon", true);
            tabCartes[3] = new Map("Café", true);
            tabCartes[4] = new Map("Consulat", true);
            tabCartes[5] = new Map("Chalet", true);
            tabCartes[6] = new Map("Frontière", true);
            tabCartes[7] = new Map("Littoral", true);
            tabCartes[8] = new Map("Gratte-ciel", true);
        }
        #endregion

        public void EnableMap(int i)
        {
            tabCartes[i].Active = true;
        }

        public void DisableMap(int i)
        {
            tabCartes[i].Active = false;
        }

        public string SelectRandomMap()
        {
            int random;
            if (checkAllDisabled())
            {
                do
                {
                    Random rndGenerator = new Random();
                    random = rndGenerator.Next(0, 9);
                }
                while (tabCartes[random].Active == false);
                return tabCartes[random].NomCarte;

            }
            else
            {
                return "-1";
            }

        }

        private bool checkAllDisabled()
        {
            bool atLeastOneActive = false;
            for (int i = 0; i < 9; i++)
            {
                if (tabCartes[i].Active)
                {
                    atLeastOneActive = true;
                }
            }

            return atLeastOneActive;
        }
    }
}
