using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipOne.API.People.Fixture {
    public class PersonCollectionBuilder : FellowshipOne.API.ICollectionBuilder<List<FellowshipOne.API.People.Model.Person>> {
        private string[] _names;

        public static PersonCollectionBuilder PersonCollection() {
            return new PersonCollectionBuilder();
        }

        public List<FellowshipOne.API.People.Model.Person> Build(int count) {
            var personCollection = new List<FellowshipOne.API.People.Model.Person>();
            for (var i = 1; i <= count; i++) {
                string name = string.Empty;
                string[] nameSplit = null;


                if (this._names.Length > 0) {
                    name = this._names[i % this._names.Length];
                    nameSplit = name.Split(' ');
                }
                personCollection.Add(PersonBuilder.Person().WithID(i).WithHouseholdID(i).WithFirstName(nameSplit[0]).WithLastName(nameSplit[1]).Build());
            }
            return personCollection;
        }

        public PersonCollectionBuilder WithNames(params string[] names) {
            this._names = names;
            return this;
        }
    }
}
