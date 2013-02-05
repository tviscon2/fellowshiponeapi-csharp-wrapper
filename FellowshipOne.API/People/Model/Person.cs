using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FellowshipOne.API.Model;
using System.Xml;
using System.Xml.Serialization;

namespace FellowshipOne.API.People.Model {
    [Serializable]
    [XmlRoot("person")]
    public partial class Person : ApiModel {

        #region Constructor
        public Person() {
            Addresses = new List<Address>();
            Communications = new List<Communication>();
            Status = new Status();
            HouseholdMemberType = new ParentNamedObject();

            Title = string.Empty;
            Salutation = string.Empty;
            Prefix = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Suffix = string.Empty;
            MiddleName = string.Empty;
            GoesByName = string.Empty;
            FormerName = string.Empty;
            Gender = string.Empty;
            MaritalStatus = string.Empty;
            FormerChurch = string.Empty;
            BarCode = string.Empty;
            MemberEnvelopeCode = string.Empty;
            DefaultTagComment = string.Empty;
            Employer = string.Empty;
        }
        #endregion Constructor

        #region Public Properties
        [XmlAttribute("imageURI")]
        public string ImageURI {
            get;
            set;
        }

        [XmlAttribute("oldID")]
        public string OldID {
            get;
            set;
        }

        [XmlAttribute("iCode")]
        public string ICode {
            get;
            set;
        }

        [XmlIgnore]
        public int? HouseholdID {
            get {
                int id = int.MinValue;

                if (int.TryParse(this.HouseholdIDString, out id)) {
                    return id;
                }

                return null;
            }
            set {
                if (value.HasValue) {
                    this.HouseholdIDString = value.Value.ToString();
                }
            }
        }

        private string _householID = string.Empty;
        [XmlAttribute("householdID")]
        public string HouseholdIDString {
            get { return _householID; }
            set { _householID = value; }
        }

        [XmlAttribute("oldHouseholdID")]
        public string OldHouseholdID {
            get;
            set;
        }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("salutation")]
        public string Salutation { get; set; }

        [XmlElement("prefix")]
        public string Prefix { get; set; }

        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlElement("suffix")]
        public string Suffix { get; set; }

        [XmlElement("middleName")]
        public string MiddleName { get; set; }

        [XmlElement("goesByName")]
        public string GoesByName { get; set; }

        [XmlElement("formerName")]
        public string FormerName { get; set; }

        [XmlElement("gender")]
        public string Gender { get; set; }

        [XmlElement("dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        [XmlElement("maritalStatus")]
        public string MaritalStatus { get; set; }

        private ParentNamedObject _householdMemberType = new ParentNamedObject();
        [XmlElement("householdMemberType")]
        public ParentNamedObject HouseholdMemberType {
            get { return _householdMemberType; }
            set { _householdMemberType = value; }
        }

        [XmlElement("isAuthorized")]
        public bool? IsAuthorized { get; set; }

        private Status _status = new Status();
        [XmlElement("status")]
        public Status Status {
            get { return _status; }
            set { _status = value; }
        }

        private Occupation _occupation = new Occupation();
        [XmlElement("occupation")]
        public Occupation Occupation {
            get { return _occupation; }
            set { _occupation = value; }
        }

        [XmlElement("employer")]
        public string Employer { get; set; }

        private FellowshipOne.API.Model.ParentNamedObject _school = new FellowshipOne.API.Model.ParentNamedObject();
        [XmlElement("school")]
        public FellowshipOne.API.Model.ParentNamedObject School {
            get { return _school; }
            set { _school = value; }
        }

        private ParentNamedObject _denomination = new ParentNamedObject();
        [XmlElement("denomination")]
        public ParentNamedObject Denomination {
            get { return _denomination; }
            set { _denomination = value; }
        }

        [XmlElement("formerChurch")]
        public string FormerChurch { get; set; }

        [XmlElement("barCode")]
        public string BarCode { get; set; }

        [XmlElement("memberEnvelopeCode")]
        public string MemberEnvelopeCode { get; set; }

        [XmlElement("defaultTagComment")]
        public string DefaultTagComment { get; set; }

        private WeblinkUser _weblink = new WeblinkUser();
        [XmlElement("weblink")]
        public WeblinkUser Weblink {
            get { return _weblink; }
            set { _weblink = value; }
        }

        [XmlElement("solicit")]
        public bool? Solicit { get; set; }

        [XmlElement("thank")]
        public bool? Thank { get; set; }

        [XmlElement("firstRecord")]
        public DateTime? FirstRecord { get; set; }

        [XmlElement("lastMatchDate")]
        public DateTime? LastMatchDate { get; set; }

        [XmlElement("createdDate")]
        public DateTime? CreatedDate { get; set; }

        [XmlElement("lastUpdatedDate")]
        public DateTime? LastUpdatedDate { get; set; }

        [XmlElement("addresses")]
        public List<Address> Addresses { get; set; }

        [XmlElement("communications")]
        public List<Communication> Communications { get; set; }

        #endregion Public Properties
    }

    [Serializable]
    [XmlRoot("results")]
    public class PersonCollection : Collection<Person> {
        public PersonCollection() { }
        public PersonCollection(List<Person> people) {
            if (people != null) {
                this.AddRange(people);
            }
        }
    }
}