using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using Restify;

namespace FellowshipOne.API.People.Sets {
    public class AttributeGroups : ApiSet<FellowshipOne.API.People.Model.AttributeGroup> {
        #region Constructor
        public AttributeGroups(F1OAuthTicket ticket, string baseUrl) : base(ticket, baseUrl) { }
        #endregion Constructor

        #region Overridden Properties
        private string _getUrl = "/v1/People/AttributeGroups/{0}";
        protected override string GetUrl {
            get { return _getUrl; }
            set { _getUrl = value; }
        }

        private string _listUrl = "/v1/People/AttributeGroups";
        protected override string ListUrl {
            get { return _listUrl; }
            set { _listUrl= value; }
        }
        #endregion Overridden Properties
    }
}