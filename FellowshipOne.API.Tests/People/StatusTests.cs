using MbUnit.Framework;
using Shouldly;
using FellowshipOne.API.People.QueryObject;
using System.Collections.Generic;
using System.Linq;

namespace FellowshipOne.API.Tests.People {
    public class StatusTests : Base {

        [TestMethod]
        public void status_list_all() {
            var statuses = Client.PeopleRealm.Statuses.List();
            statuses.Count.ShouldBeGreaterThan(0);
        }

        [TestMethod]
        public void status_list_get_sub_statuses() {
            var statuses = Client.PeopleRealm.Statuses.List();
            var subStatuses = statuses.First().SubStatuses;

            subStatuses.Count.ShouldBeGreaterThan(0);
        }
    }
}
