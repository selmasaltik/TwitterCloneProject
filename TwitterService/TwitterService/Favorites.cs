//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwitterService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Favorites
    {
        public int favoriteID { get; set; }
        public int tweetID { get; set; }
        public int userID { get; set; }
    
        public virtual Tweets Tweets { get; set; }
    }
}
