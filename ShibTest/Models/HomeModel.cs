using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShibTest.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class HomeModel
    {
        /// <summary>
        /// Gets or sets the shib URL.
        /// </summary>
        /// <value>
        /// The shib URL.
        /// </value>
        public string ShibUrl { get; set; }
        /// <summary>
        /// Gets or sets the client URL.
        /// </summary>
        /// <value>
        /// The client URL.
        /// </value>
        public string ClientUrl { get; set; }
        /// <summary>
        /// Gets or sets the entity identifier.
        /// </summary>
        /// <value>
        /// The entity identifier.
        /// </value>
        public string EntityId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeModel"/> class.
        /// </summary>
        public HomeModel()
        {

        }
    }
}