using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using Restify;

namespace FellowshipOne.API.People.Sets {
    public class Households : ApiSet<FellowshipOne.API.People.Model.Household> {
        #region Constructor
        public Households(F1OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }
        #endregion Constructor

        #region Properties
        protected override string GetUrl {
            get {
                return "/v1/Households/{0}";
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
            get { return "/v1/Households"; }
        }

        protected override string EditUrl {
            get { return "/v1/Households/{0}"; }
        }

        protected override string SearchUrl {
            get {
                return "/v1/Households/Search";
            }
            set {
                base.SearchUrl = value;
            }
        }

        protected override string ListUrl {
            get { throw new NotImplementedException(); }
        }
        #endregion Properties

        #region Overridden Methods
        public override Model.Household Get(string parentID, string id) {
            throw new NotImplementedException();
        }
        #endregion Overriden Methods
    }
}
