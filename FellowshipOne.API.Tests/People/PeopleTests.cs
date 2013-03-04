﻿using MbUnit.Framework;
using Shouldly;
using FellowshipOne.API.People.QueryObject;

namespace FellowshipOne.API.Tests.People {
    [TestFixture]
    public class PeopleTests : Base {

        [Test]
        public void people_get_by_url() {
            var person = Client.PeopleRealm.People.GetByUrl(Ticket.PersonURL);
            person.ShouldNotBe(null);
        }

        [Test]
        public void people_search() {
            var qo = new PeopleQO();
            qo.Name = "sm";
            qo.RecordsPerPage = 5;

            var people = Client.PeopleRealm.People.Search<FellowshipOne.API.People.Model.PersonCollection>(qo);
            people.ShouldNotBe(null);
            people.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void people_create_get_xml_does_not_save() {
            var person = new FellowshipOne.API.People.Model.Person();
            person.FirstName = "chad";

            string requestXml = string.Empty;

            try {
                person = Client.PeopleRealm.People.Create(person, out requestXml);
            }
            catch (System.Exception e) {
            }

            requestXml.ShouldNotBeEmpty();

        }

        [Test]
        public void people_update_get_xml_does_save() {
            var qo = new PeopleQO();
            qo.Name = "chad meyer";
            qo.RecordsPerPage = 5;

            var people = Client.PeopleRealm.People.Search<FellowshipOne.API.People.Model.PersonCollection>(qo);
            var person = people[0];
            person.Status.SubStatuses = null;
            person.Addresses = null;
            person.Communications = null;

            Client.PeopleRealm.People.Update(person, person.ID.ToString());
        }
    }
}
