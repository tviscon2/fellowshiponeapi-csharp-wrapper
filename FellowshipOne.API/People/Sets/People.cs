using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using Restify;

namespace FellowshipOne.API.People.Sets {
    public class People : ApiSet<FellowshipOne.API.People.Model.Person> {

        #region Constructor
        public People(F1OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }
        #endregion Constructor

        #region Properties
        protected override string GetUrl {
            get {
                return "/v1/People/{0}";
            }
        }

        protected override string GetChildUrl {
            get {
                return base.GetChildUrl;
            }
            set {
                base.GetChildUrl = value;
            }
        }

        protected override string CreateUrl {
            get { return "/v1/People"; }
        }

        protected override string EditUrl {
            get { return "/v1/People/{0}"; }
        }

        protected override string SearchUrl {
            get {
                return "/v1/People/Search";
            }
            set {
                base.SearchUrl = value;
            }
        }

        private string _childListUrl = "/v1/Households/{0}/People";
        protected override string GetChildListUrl {
            get {
                return _childListUrl;
            }
            set {
                _childListUrl = value;
            }
        }
        #endregion Properties
    }
}
