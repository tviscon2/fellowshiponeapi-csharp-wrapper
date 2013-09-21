using FellowshipOne.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FellowshipOne.API.People.Model {
    [Serializable]
    public class TimeZone : ParentNamedObject {
        private string _bias = string.Empty;
        [XmlElement("bias")]
        public string Bias {
            get { return _bias; }
            set { _bias = value; }
        }
    }
}
