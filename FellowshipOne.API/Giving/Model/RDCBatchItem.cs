using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.ObjectModel;

namespace FellowshipOne.API.Giving.Model
{
    [XmlRoot("rdcBatchItem")]
    public class RDCBatchItem : ApiModel
    {
        public RDCBatchItem() {
            Batch = new ParentNamedObject();
            OriginalHousehold = new ParentObject();
            OriginalIndividual = new ParentObject();
            Household = new ParentObject();
            Individual = new ParentObject();
            ReferenceImage = new ParentObject();
            CreatedByPerson = new ParentObject();
            LastUpdatedByPerson = new ParentObject();
            RDCBatchItemDetails = new List<object>(){new object()};
        }

        #region Properties

        [XmlElement("batch")]
        public ParentNamedObject Batch { get; set; }

        [XmlElement("originalHousehold")]
        public ParentObject OriginalHousehold { get; set; }

        [XmlElement("originalIndividual")]
        public ParentObject OriginalIndividual { get; set; }

        [XmlElement("household")]
        public ParentObject Household { get; set; }

        [XmlElement("individual")]
        public ParentObject Individual { get; set; }

        [XmlElement("itemCreatedDate")]
        public DateTime? ItemCreatedDate { get; set; }

        [XmlElement("accountNumber")]
        public string AccountNumber { get; set; }

        [XmlElement("routingNumber")]
        public string RoutingNumber { get; set; }

        [XmlElement("amount")]
        public decimal Amount { get; set; }

        [XmlElement("nameOnAccount")]
        public string NameOnAccount { get; set; }

        [XmlElement("itemDescription")]
        public string ItemDescription { get; set; }

        [XmlElement("customField1")]
        public string customField1 { get; set; }

        [XmlElement("customField2")]
        public string customField2 { get; set; }

        [XmlElement("customField3")]
        public string customField3 { get; set; }

        [XmlElement("referenceNumber")]
        public string ReferenceNumber { get; set; }

        [XmlElement("checkNumber")]
        public string CheckNumber { get; set; }

        [XmlElement("transactionNumber")]
        public string TransactionNumber { get; set; }

        [XmlElement("referenceImage")]
        public ParentObject ReferenceImage { get; set; }

        [XmlElement("returnDate")]
        public DateTime? ReturnDate { get; set; }

        [XmlElement("isSharedAccount")]
        public bool? IsSharedAccount { get; set; }

        [XmlElement("createdDate")]
        public DateTime? CreatedDate { get; set; }

        [XmlElement("createdByPerson")]
        public ParentObject CreatedByPerson { get; set; }

        [XmlElement("lastUpdatedDate")]
        public DateTime? LastUpdatedDate { get; set; }

        [XmlElement("lastUpdatedByPerson")]
        public ParentObject LastUpdatedByPerson { get; set; }

        [XmlIgnore]
        public int? PPMerchantAccountID
        {
            get
            {
                int id = int.MinValue;

                if (int.TryParse(this.ppMerchantAccountIDString, out id))
                {
                    return id;
                }

                return null;
            }
            set
            {
                if (value.HasValue)
                {
                    this.ppMerchantAccountIDString = value.Value.ToString();
                }
            }
        }

        private string _ppMerchantAccountID = string.Empty;
        [XmlAttribute("ppMerchantAccountID")]
        public string ppMerchantAccountIDString
        {
            get { return _ppMerchantAccountID; }
            set { _ppMerchantAccountID = value; }
        }

        //TODO: Implement. Not implemented, because not needed, yet. (First party resource anyway)
        [XmlElement("rdcBatchItemDetails")]
        public List<object> RDCBatchItemDetails { get; set; }

        [XmlIgnore]
        public int? LocationID {
            get {
                int id = int.MinValue;

                if (int.TryParse(this.locationIDIDString, out id)) {
                    return id;
                }

                return null;
            }
            set {
                if (value.HasValue) {
                    this.locationIDIDString = value.Value.ToString();
                }
            }
        }

        private string _locationID = string.Empty;
        [XmlAttribute("locationID")]
        public string locationIDIDString {
            get { return _locationID; }
            set { _locationID = value; }
        }

        //[XmlIgnore]
        //public byte[] ReferenceImage { get; set; }

        #endregion Properties
    }
}

