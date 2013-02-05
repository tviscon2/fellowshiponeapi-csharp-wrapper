using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using Restify;

namespace FellowshipOne.API.People.Sets {
    public class Addresses : ApiSet<FellowshipOne.API.People.Model.Address> {
        #region Constructor
        public Addresses(F1OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }
        #endregion Constructor

        #region Properties
        protected override string GetUrl {
            get {
                return "/v1/Addresses/{0}";
            }
        }

        protected override string GetChildUrl {
            get {
                return "/v1/People/{0}/Addresses{1}";
            }
            set {
                base.GetChildUrl = value;
            }
        }

        protected override string ListUrl {
            get {
                throw new NotImplementedException();
            }
        }

        protected override string GetChildListUrl {
            get {
                return "/v1/People/{0}/Addresses";
            }
            set {
                base.GetChildListUrl = value;
            }
        }

        private string _createUrl = "/v1/Addresses";
        protected override string CreateUrl {
            get { return this._createUrl; }
            set { this._createUrl = value; }
        }

        protected override string EditUrl {
            get { return "/v1/Addresses/{0}"; }
        }
        #endregion Properties

        #region Methods

        public FellowshipOne.API.People.Model.Address CreateForPerson(int personID, FellowshipOne.API.People.Model.Address entity) {
            this.CreateUrl = string.Format("/v1/People/{0}/Addresses", personID);
            return this.Create(entity);
        }

        public FellowshipOne.API.People.Model.Address CreateForHousehold(int householdID, FellowshipOne.API.People.Model.Address entity) {
            this.CreateUrl = string.Format("/v1/Households/{0}/Addresses", householdID);
            return this.Create(entity);
        }
        #endregion Methods
    }
}
