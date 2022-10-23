using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.BL.BE
{
    public class Patient
    {
        public int Id { set; get; }
        [DisplayName("שם פרטי")]
        public string FirstName { set; get; }
        [DisplayName("שם משפחה")]
        public string LastName { set; get; }
        [DisplayName("כתובת")]
        public string Addres { set; get; }
        [DisplayName("תאריך לידה")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthday { set; get; }
        [DisplayName("טלפון")]
        [DataType(DataType.PhoneNumber)]
        public int Telephone { set; get; }

        [DisplayName("פלאפון")]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:n}")]
        public int PhoneNumber { set; get; }
        [DisplayName("רשימת חיסונים")]
        public List<Vaccine> VaccineDates { get; set; }

        [DisplayName("תוצאה חיובית")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime PositiveDate { set; get; }

        [DisplayName("החלמה")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime RecoveryDate { set; get; }
        public List<String> Maker { set; get; }
        //public Patient(int id, string firstName, string lastName, string addres, DateTime birthday, int telephone,
        //               int phoneNumber, List<Vaccine> vaccineDates, DateTime positive, DateTime recovery, List<String> maker)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Addres = addres;
        //    Birthday = birthday;
        //    Telephone = telephone;
        //    PhoneNumber = phoneNumber;
        //    VaccineDates = vaccineDates;
        //    PositiveDate = positive;
        //    RecoveryDate = recovery;

        //}
        //public Patient()
        //{

        //}
    }
}
