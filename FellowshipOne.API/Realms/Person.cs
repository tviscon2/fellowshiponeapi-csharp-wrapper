using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowshipOne.API.Realms {
    public class Person {
        #region Properties
        F1OAuthTicket _ticket { get; set; }
        string _baseUrl { get; set; }

        private FellowshipOne.API.People.Sets.People _people;
        public FellowshipOne.API.People.Sets.People People {
            get {
                if (_people == null) {
                    _people = new API.People.Sets.People(_ticket, _baseUrl);
                }
                return _people;
            }
        }

        private FellowshipOne.API.People.Sets.Addresses _addresses;
        public FellowshipOne.API.People.Sets.Addresses Addresses {
            get {
                if (_addresses == null) {
                    _addresses = new API.People.Sets.Addresses(_ticket, _baseUrl);
                }
                return _addresses;
            }
        }

        private FellowshipOne.API.People.Sets.Communications _communications;
        public FellowshipOne.API.People.Sets.Communications Communications {
            get {
                if (_communications == null) {
                    _communications = new API.People.Sets.Communications(_ticket, _baseUrl);
                }
                return _communications;
            }
        }

        private FellowshipOne.API.People.Sets.Households _households;
        public FellowshipOne.API.People.Sets.Households Households {
            get {
                if (_households == null) {
                    _households = new API.People.Sets.Households(_ticket, _baseUrl);
                }
                return _households;
            }
        }

        private FellowshipOne.API.People.Sets.AccessRights _accessRights;
        public FellowshipOne.API.People.Sets.AccessRights AccessRights
        {
            get
            {
                if (_accessRights == null)
                {
                    _accessRights = new API.People.Sets.AccessRights(_ticket, _baseUrl);
                }
                return _accessRights;
            }
        }

        private FellowshipOne.API.People.Sets.AttributeGroups _attributeGroups;
        public FellowshipOne.API.People.Sets.AttributeGroups AttributeGroups {
            get {
                if (_attributeGroups == null) {
                    _attributeGroups = new API.People.Sets.AttributeGroups(_ticket, _baseUrl);
                }
                return _attributeGroups;
            }
        }

        private FellowshipOne.API.People.Sets.Attributes _attributes;
        public FellowshipOne.API.People.Sets.Attributes Attributes {
            get {
                if (_attributes == null) {
                    _attributes = new API.People.Sets.Attributes(_ticket, _baseUrl);
                }
                return _attributes;
            }
        }

        private FellowshipOne.API.People.Sets.Statuses _statuses;
        public FellowshipOne.API.People.Sets.Statuses Statuses {
            get {
                if (_statuses == null) {
                    _statuses = new API.People.Sets.Statuses(_ticket, _baseUrl);
                }
                return _statuses;
            }
        }

        #endregion Properties

        #region Constructor
        public Person(F1OAuthTicket ticket, string baseUrl) {
            _ticket = ticket;
            _baseUrl = baseUrl;
        }
        #endregion Constructor
    }
}