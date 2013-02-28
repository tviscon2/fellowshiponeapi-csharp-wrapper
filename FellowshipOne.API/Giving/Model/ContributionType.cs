using FellowshipOne.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FellowshipOne.API.Giving.Model {
    public class ContributionType : ApiModel{
        private string _name = string.Empty;
        [XmlElement("name")]
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
    }
}
