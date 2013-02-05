using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FellowshipOne.API.Model {
    public class ApiModel {
        [XmlIgnore]
        public int? ID {
            get {
                int id = int.MinValue;

                if (int.TryParse(this.ApiModelID, out id)) {
                    return id;
                }

                return null;
            }
            set {
                if (value.HasValue) {
                    this.ApiModelID = value.Value.ToString();
                }
            }
        }

        private string _apiModelID = string.Empty;
        [XmlAttribute("id")]
        public string ApiModelID {
            get { return _apiModelID; }
            set { _apiModelID = value; }
        }

        private string _uri = string.Empty;
        [XmlAttribute("uri")]
        public string uri {
            get { return _uri; }
            set { _uri = value; }
        }
    }
}
