using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipOne.API.People.Fixture {
    public class PersonBuilder : FellowshipOne.API.IBuilder<FellowshipOne.API.People.Model.Person> {
        private int _id = 1;
        private int _householdID = 1;
        private string _firstName = "Jim";
        private string _lastName = "Bob";

        public static PersonBuilder Person() {
            return new PersonBuilder();
        }

        public FellowshipOne.API.People.Model.Person Build() {
            return new FellowshipOne.API.People.Model.Person() {
                ID = this._id,
                HouseholdID = this._householdID,
                FirstName = this._firstName,
                LastName = this._lastName
            };
        }

        public PersonBuilder WithID(int id) {
            this._id = id;
            return this;
        }

        public PersonBuilder WithFirstName(string firstName) {
            this._firstName = firstName;
            return this;
        }

        public PersonBuilder WithLastName(string lastName) {
            this._lastName = lastName;
            return this;
        }

        public PersonBuilder WithHouseholdID(int householdID) {
            this._householdID = householdID;
            return this;
        }
    }
}
