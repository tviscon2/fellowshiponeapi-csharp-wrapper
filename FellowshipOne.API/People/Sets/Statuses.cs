using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using Restify;

namespace FellowshipOne.API.People.Sets {
    public class Statuses : ApiSet<FellowshipOne.API.People.Model.Status> {
        #region Constructor
        public Statuses(F1OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }
        #endregion Constructor

        #region Properties
        protected override string GetUrl {
            get {
                return "/v1/People/Statuses/{0}";
            }
        }

        private string _listUrl = "/v1/People/Statuses";
        protected override string ListUrl {
            get {
                return _listUrl;
            }
            set {
                _listUrl = value;
            }
        }

        protected override string CreateUrl {
            get { throw new NotImplementedException(); }
        }

        protected override string EditUrl {
            get { throw new NotImplementedException(); }
        }

        #endregion Properties

        #region Overridden Methods
        public override Model.Status Get(string parentID, string id) {
            throw new NotImplementedException(); 
        }
        #endregion Overriden Methods
    }
}
