using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TwitterService
{

    [ServiceContract]
    public interface ITwitter
    {
        [OperationContract]
        void Sign(string name, string lastname, string nickname, string pass, string mail, Boolean cinsiyet, DateTime birthdate);

        [OperationContract]
        void Login(string nickname, string pass);

        [OperationContract]
        void Follow();

        [OperationContract]
        void SendTweet();

        [OperationContract]
        void DeleteTweet();

        [OperationContract]
        void Favorited(int favoriteID);


    }
}
