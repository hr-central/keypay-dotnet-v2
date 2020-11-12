using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class EmployeePartialEditModel
    {
        public int? TitleId { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string PreviousSurname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public string Gender { get; set; }
        public string ExternalId { get; set; }
        public string ResidentialStreetAddress { get; set; }
        public string ResidentialAddressLine2 { get; set; }
        public int? ResidentialSuburbId { get; set; }
        public string ResidentialSuburb { get; set; }
        public string ResidentialState { get; set; }
        public string ResidentialPostcode { get; set; }
        public string ResidentialCountry { get; set; }
        public string ResidentialCountryId { get; set; }
        public string PostalStreetAddress { get; set; }
        public string PostalAddressLine2 { get; set; }
        public int? PostalSuburbId { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalState { get; set; }
        public string PostalPostcode { get; set; }
        public string PostalCountry { get; set; }
        public string PostalCountryId { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int BusinessId { get; set; }
        public string TaxFileNumber { get; set; }
        public string TaxFileNumberMasked { get; set; }
        public bool IsPostalAddressSameAsResidential { get; set; }
        public bool IsOverseasResidentialAddress { get; set; }
        public bool IsOverseasPostalAddress { get; set; }
        public IList<BankAccountEditModel> BankAccounts { get; set; }
        public string ExternalReferenceId { get; set; }
        public string PayrollId { get; set; }
        public EmployeeStarterTypeEnum EmployeeStarterType { get; set; }
        public ExternalService Source { get; set; }
        public string TagsString { get; set; }
        public EmployeeTimesheetSetting TimesheetSetting { get; set; }
        public AddressTypeEnum? ResidentialAddressType { get; set; }
        public AddressTypeEnum? PostalAddressType { get; set; }
        public string ResidentialBlockNumber { get; set; }
        public string PostalBlockNumber { get; set; }
        public string ResidentialLevelNumber { get; set; }
        public string PostalLevelNumber { get; set; }
        public string ResidentialUnitNumber { get; set; }
        public string PostalUnitNumber { get; set; }
        public string ResidentialStreetName { get; set; }
        public string PostalStreetName { get; set; }
        public string ResidentialAddressLine3 { get; set; }
        public string PostalAddressLine3 { get; set; }
    }
}