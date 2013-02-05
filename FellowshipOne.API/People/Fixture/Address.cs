﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipOne.API.People.Fixture {
    public class AddressBuilder : FellowshipOne.API.IBuilder<FellowshipOne.API.People.Model.Address> {
        private int _id = 1;
        private int _addressTypeID = 1;
        private string _address1 = "One Microsoft Way";
        private string _city = "Redmond";
        private string _state = "WA";
        private string _postalCode = "98025";

        public static AddressBuilder Address() {
            return new AddressBuilder();
        }


        public AddressBuilder WithID(int id) {
            _id = id;
            return this;
        }

        public AddressBuilder WithAddressTypeID(int id) {
            _addressTypeID = id;
            return this;
        }

        public AddressBuilder WithAddress1(string address1) {
            _address1 = address1;
            return this;
        }

        public AddressBuilder WithCity(string city) {
            _city = city;
            return this;
        }

        public AddressBuilder WithStProvince(string state) {
            _state = state;
            return this;
        }

        public AddressBuilder WithPostalCode(string postalCode) {
            _postalCode = postalCode;
            return this;
        }

        public FellowshipOne.API.People.Model.Address Build() {
            return new FellowshipOne.API.People.Model.Address {
                ID = _id,
                AddressType = new API.Model.ParentNamedObject { Name = "", ID = _addressTypeID },
                Address1 = _address1,
                City = _city,
                StProvince = _state,
                PostalCode = _postalCode
            };
        }
    }
}
