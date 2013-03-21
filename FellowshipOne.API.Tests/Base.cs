using MbUnit.Framework;
using Shouldly;
using FellowshipOne.API.People.QueryObject;
using System.Configuration;

namespace FellowshipOne.API.Tests {
    [TestFixture]
    public class Base {
        public FellowshipOne.API.RestClient Client;
        public F1OAuthTicket Ticket;

        [FixtureSetUp]
        public void Setup() {
            //Ticket = FellowshipOne.API.RestClient.Authorize(new F1OAuthTicket {
            //    ConsumerKey = ConfigurationManager.AppSettings["Consumer.Key"],
            //    ConsumerSecret = ConfigurationManager.AppSettings["Consumer.Secret"],
            //    ChurchCode = ConfigurationManager.AppSettings["Church.Code"]
            //}, ConfigurationManager.AppSettings["Username"], ConfigurationManager.AppSettings["Password"], LoginType.PortalUser, true);

            //Client = new RestClient(Ticket, false);
        }

        [FixtureTearDown]
        public void TearDown() {
            Ticket = null;
            Client = null;
        }
    }
}