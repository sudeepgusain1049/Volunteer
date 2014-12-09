using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Globalization;

namespace Volunteer.UI.Web.Models
{
    /// <summary>
    /// Defines the site session.
    /// </summary>
    /// <remarks>
    /// Used to cache only the needed data for the current user!
    /// </remarks>
    public class SiteSession
    {
        /* User Session 
        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Gets or sets the user role.
        /// </summary>
        public UserRoles UserRole { get; set; }
        /// <summary>
        /// Gets or sets the current UI culture.
        /// </summary>
        /// <remarks>
        /// Values meaning: 0 = InvariantCulture (en-US), 1 = nl-NL
        /// </remarks>
        /// 
        */
        public static int CurrentUICulture
        {
            get
            {
               
                if (Thread.CurrentThread.CurrentUICulture.Name == "nl-NL")
                    return 1;
                else
                    return 0;
            }
            set
            {
                //
                // Set the thread's CurrentUICulture.
                //
                if (value == 1)
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("nl-NL");
                else
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
                //
                // Set the thread's CurrentCulture the same as CurrentUICulture.
                //
                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
            }
        }

        /* for later purposes
        /// <summary>
        /// Initializes a new instance of the SiteSession class.
        /// </summary>
        /// <param name="db">The data context.</param>
        /// <param name="user">The current user.</param>
        public SiteSession(MvcBasicSiteEntities db, User user)
        {
            this.UserID = user.ID;
            this.Username = user.Username;
            this.UserRole = user.UserRole;
            //
            // TO DO: Cache other user settings!
            //
        }
        */

    }
}