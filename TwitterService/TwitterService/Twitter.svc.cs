using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TwitterService
{
    #region ITwitter Members 
    public class Twitter : ITwitter
    {

        public void Sign(string name, string lastname, string nickname, string pass, string mail, Boolean cinsiyet, DateTime birthdate)
        {
            Random rnd = new Random();
            Users sign = new Users {userID=rnd.Next(1,1000), Name = name, lastName = lastname, nickName = nickname, password = pass, email = mail, 
                cinsiyet = cinsiyet, birthDate = birthdate };
            return sign; 
            
        }

        public void Login(string nickname, string pass)
        {
            Users login = new Users { nickName = nickname, password = pass };
            return login;
        }


        public void Follow()
        {
           
        }

        public void SendTweet()
        {
           
        }

        public void DeleteTweet()
        {
           
        }
        public void Favorited(int favoriteID)
        {
            List<Favorites> fav = new List<Favorites> { };
        }

    #endregion
    }
}
