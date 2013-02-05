using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using Restify;

namespace FellowshipOne.API.People.Sets {
    public class AccessRights : ApiSet<FellowshipOne.API.People.Model.AccessRight> {
        #region Constructor
        public AccessRights(F1OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }
        #endregion Constructor

        #region Properties
        protected override string GetUrl {
            get {
                return "/v1/AccessRights/{0}";
            }
        }

        protected override string GetChildUrl {
            get {
                return "/v1/People/{0}/AccessRights/{1}";
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
                return "/v1/People/{0}/AccessRights";
            }
            set {
                base.GetChildListUrl = value;
            }
        }

        private string _createUrl = "/v1/AccessRights";
        protected override string CreateUrl {
            get { return this._createUrl; }
            set { this._createUrl = value; }
        }

        protected override string EditUrl {
            get { return "/v1/AccessRights/{0}"; }
        }
        #endregion Properties

    }
}
