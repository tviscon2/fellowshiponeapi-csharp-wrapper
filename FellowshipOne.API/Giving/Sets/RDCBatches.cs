using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using Restify;

namespace FellowshipOne.API.Giving.Sets {
    public class RDCBatches : ApiSet<FellowshipOne.API.Giving.Model.RDCBatch> {
        #region Constants
        private const string GET_URL = "/giving/v1/rdcbatches/{0}";
        private const string SEARCH_URL = "/v1/Batches/Search";
        private const string CREATE_URL = "/giving/v1/rdcbatches";
        private const string EDIT_URL = "/giving/v1/rdcbatches/{0}";
        #endregion Constants

        #region Constructor
        public RDCBatches(F1OAuthTicket ticket, string baseUrl)
            : base(ticket, baseUrl) {
        }
        #endregion Constructor

        #region Overridden Properties
        protected override string GetUrl {
            get { return GET_URL; }
        }

        protected override string SearchUrl {
            get { return SEARCH_URL; }
        }

        protected override string CreateUrl {
            get { return CREATE_URL; }
        }

        protected override string EditUrl {
            get { return EDIT_URL; }
        }

        #endregion Overridden Properties
    }
}
