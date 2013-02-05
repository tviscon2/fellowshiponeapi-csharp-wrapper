using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace FellowshipOne.API.Model {
    public class ParentObject : ApiModel {
        public static ParentObject Default {
            get { return new ParentObject(); }
        }
    }

    public class ParentNamedObject : ApiModel {
        private string _name = string.Empty;
        [XmlElement("name")]
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public static ParentNamedObject Default {
            get { return new ParentNamedObject(); }
        }
    }
}