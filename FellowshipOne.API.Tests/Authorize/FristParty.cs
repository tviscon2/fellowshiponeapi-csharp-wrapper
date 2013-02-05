using MbUnit.Framework;
using Shouldly;
using FellowshipOne.API.People.QueryObject;
using FellowshipOne.API.Tests;

namespace FellowshipOne.API.Tests.Authorize {
    public class FristParty : Base {

        [Test]
        public void authorize_ticket_has_access_token() {
            Ticket.AccessToken.ShouldNotBeEmpty();
        }
    }
}
