using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolListingAdmin.DomainModels.Models.School
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string AffiliationCode { get; set; }
        public string EstablishedCode { get; set; }
        public string SchoolTagLine { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string BoardName { get; set; }
        public string Medium { get; set; }
        public string BusinessType { get; set; }
        public string BoardingType { get; set; }
        public string CoedType { get; set; }
        public string SchoolBrochure { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int Status { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string AdmissionDetails { get; set; }
        public string FeeDetails { get; set; }
        public string Aboutus { get; set; }
        public string AcademicDetails { get; set; }
        public string Keywords { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Infrastructure { get; set; }
        public string SchoolCode { get; set; }
        public string SchoolLogo { get; set; }
        public string SchoolLogoUrl { get; set; }
        public string ScheduleVisit { get; set; }
        public string RegistrationLink { get; set; }
        public string Youtube { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string GoogleBusinessPage { get; set; }
        public string BlogPage { get; set; }
        public string Website { get; set; }
        public string SchoolBanner { get; set; }
    }
}
