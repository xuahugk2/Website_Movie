//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DACN.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Follow
    {
        public Follow()
        {

        }

        public Follow(string userEmail, int movieId, string followAt)
        {
            UserEmail = userEmail;
            MovieId = movieId;
            FollowAt = DateTime.ParseExact(followAt, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture); ;
        }

        public string UserEmail { get; set; }
        public int MovieId { get; set; }
        public System.DateTime FollowAt { get; set; }
    
        public virtual Movie Movie { get; set; }
        public virtual User User { get; set; }
    }
}
