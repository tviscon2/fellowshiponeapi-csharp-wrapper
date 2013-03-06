using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restify;

namespace FellowshipOne.API.People.Sets {
    public class Communications : ApiSet<FellowshipOne.API.People.Model.Communication> {

        #region Constructor
        public Communications(F1OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }
        #endregion Constructor

        #region Properties
        private string _getUrl = "/v1/Communications/{0}";
        protected override string GetUrl {
            get { return _getUrl; }
        }

        protected override string GetChildUrl {
            get {
                return "/v1/People/{0}/Communications{1}";
            }
        }

        protected override string ListUrl {
            get {
                throw new NotImplementedException();
            }
        }

        protected override string GetChildListUrl {
            get {
                return "/v1/People/{0}/Communications";
            }
        }

        private string _createUrl = "/v1/Communications";
        protected override string CreateUrl {
            get { return _createUrl; }
        }

        private string _editUrl = "/v1/Communications/{0}";
        protected override string EditUrl {
            get { return _editUrl; }
        }
        #endregion Properties

        #region Overridden Methods
        public FellowshipOne.API.People.Model.Communication CreateForPerson(int personID, FellowshipOne.API.People.Model.Communication entity) {
            this.CreateUrl = string.Format("/v1/People/{0}/Communications", personID);
            return this.Create(entity);
        }

        public FellowshipOne.API.People.Model.Communication CreateForPerson(int personID, FellowshipOne.API.People.Model.Communication entity, out string requestXml) {
            this.CreateUrl = string.Format("/v1/People/{0}/Communications", personID);
            return this.Create(entity, out requestXml);
        }

        public FellowshipOne.API.People.Model.Communication CreateForHousehold(int householdID, FellowshipOne.API.People.Model.Communication entity) {
            this.CreateUrl = string.Format("/v1/Households/{0}/Communications", householdID);
            return this.Create(entity);
        }

        public FellowshipOne.API.People.Model.Communication CreateForHousehold(int householdID, FellowshipOne.API.People.Model.Communication entity, out string requestXml) {
            this.CreateUrl = string.Format("/v1/Households/{0}/Communications", householdID);
            return this.Create(entity, out requestXml);
        }
        #endregion Overridden Methods
    }
}