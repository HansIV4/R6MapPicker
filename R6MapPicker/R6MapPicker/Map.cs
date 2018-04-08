//-----------------------------------------------------------------------
// <copyright file="Map.cs" company = "HansIV4" >
//     Copyright (c) HansIV4. All rights reserved.
//      Name: HansIV4
//      Goal: The data model behind an app that will randomly select one of the enabled elements in the UI
//      Date: 01/04/2018
// </copyright>
//-----------------------------------------------------------------------

namespace R6MapPicker
{
    /// <summary>
    /// This class has no logic and serves as a data model
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Map" /> class.
        /// </summary>
        /// <param name="nomCarte">The name of the map</param>
        /// <param name="active">the active boolean property</param>
        public Map(string nomCarte, bool active)
        {
            this.NomCarte = nomCarte;
            this.Active = active;
        }

        /// <summary>
        /// Gets the name of the map
        /// </summary>
        public string NomCarte { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the map is active or not
        /// </summary>
        public bool Active { get; set; }
    }
}
