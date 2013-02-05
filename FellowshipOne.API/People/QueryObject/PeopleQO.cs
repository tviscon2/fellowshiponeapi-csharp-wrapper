using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.QueryObject;
using Restify.Attributes;

namespace FellowshipOne.API.People.QueryObject {
    public class PeopleQO : BaseQO {
        [QO("searchFor")]
        public string Name { get; set; }

        [QO("address")]
        public string Address { get; set; }

        [QO("include")]
        public string IncludeString {
            get {
                var sb = new StringBuilder();
                if (this.IncludeAddress) {
                    sb.Append("addresses ");
                }
                if (this.IncludeCommunications) {
                    sb.Append("communications ");
                }
                if (this.IncludeAttributes) {
                    sb.Append("attributes ");
                }
                return sb.ToString().Trim().Replace(' ', ',');
            }
        }

        [QOIgnoreAttribute]
        public bool IncludeAddress { get; set; }

        [QOIgnoreAttribute]
        public bool IncludeCommunications { get; set; }

        [QOIgnoreAttribute]
        public bool IncludeAttributes { get; set; }

        [QO("includeDeceased")]
        public bool IncludeDeceased { get; set; }

        [QO("includeInactive")]
        public bool IncludeInactive { get; set; }

        [QO("communication")]
        public string Communication { get; set; }
    }
}
