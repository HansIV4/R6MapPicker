//-----------------------------------------------------------------------
// <copyright file="ProgramController.cs" company = "HansIV4" >
//     Copyright (c) HansIV4. All rights reserved.
//      Name: HansIV4
//      Goal: The data model behind an app that will randomly select one of the enabled elements in the UI
//      Date: 01/04/2018
// </copyright>
//-----------------------------------------------------------------------

namespace R6MapPicker
{
    using System;

    /// <summary>
    /// This class holds all of the logic behind the program
    /// </summary>
    public class ProgramController
    {
        /// <summary>
        /// An array containing all the maps
        /// </summary>
        private Map[] tabCartes = new Map[9];
        #region Ctor

        /// <summary>
        /// Initializes a new instance of the ProgramController class
        /// </summary>
        public ProgramController()
        {
            this.tabCartes[0] = new Map("Banque", true);
            this.tabCartes[1] = new Map("Clubhouse", true);
            this.tabCartes[2] = new Map("Oregon", true);
            this.tabCartes[3] = new Map("Café", true);
            this.tabCartes[4] = new Map("Consulat", true);
            this.tabCartes[5] = new Map("Chalet", true);
            this.tabCartes[6] = new Map("Frontière", true);
            this.tabCartes[7] = new Map("Littoral", true);
            this.tabCartes[8] = new Map("Gratte-ciel", true);
        }
        #endregion

        /// <summary>
        /// enables the selected map
        /// </summary>
        /// <param name="i">The index of the map in the array</param>
        public void EnableMap(int i)
        {
            this.tabCartes[i].Active = true;
        }

        /// <summary>
        /// disables the selected map
        /// </summary>
        /// <param name="i">The index of the map in the array</param>
        public void DisableMap(int i)
        {
            this.tabCartes[i].Active = false;
        }

        /// <summary>
        /// selects a random map within the array as long as the selected map is enabled
        /// </summary>
        /// <returns>returns the map name</returns>
        public string SelectRandomMap()
        {
            int random;
            if (this.CheckAllDisabled())
            {
                do
                {
                    Random rndGenerator = new Random();
                    random = rndGenerator.Next(0, 9);
                }
                while (this.tabCartes[random].Active == false);
                return this.tabCartes[random].NomCarte;
            }
            else
            {
                return "-1";
            }
        }

        /// <summary>
        /// checks that at least one item is still enabled
        /// </summary>
        /// <returns>returns an indicator telling if at least an item is still enabled</returns>
        private bool CheckAllDisabled()
        {
            bool oneItemOrMoreActive = false;
            for (int i = 0; i < 9; i++)
            {
                if (this.tabCartes[i].Active)
                {
                    oneItemOrMoreActive = true;
                }
            }

            return oneItemOrMoreActive;
        }
    }
}
