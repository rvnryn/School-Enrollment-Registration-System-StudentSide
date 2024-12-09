namespace School_Student_FrontPage
{
    public class New_Student_Application_Information
    {
        public string AdmitType {get; set;}
        public string YearLevel {get; set;}
        public string Course {get; set;}
        public string SchoolYear {get; set;}
        public string Term {get; set;}
        public string Student_FirstName {get; set;}
        public string Student_MiddleName {get; set;}
        public string Student_LastName {get; set;}
        public string Student_SuffixName {get; set;}
        public string Student_Gender {get; set;}
        public string Student_Status {get; set;}
        public string Student_Citizenship {get; set;}
        public string Student_BirthPlace {get; set;}
        public string Student_Religion {get; set;}
        public string Student_CurrentAddress {get; set;}
        public string Student_DateOfBirth  {get; set;}
        public string Student_TelephoneNumber {get; set;}
        public long Student_MobileNumber {get; set;}
        public string Student_EmailAddress {get; set;}

        public string Father_Name {get; set;}
        public string Father_Email {get; set;}
        public string Father_Occupation {get; set;}
        public long Father_Mobile  {get; set;}

        public string Mother_Name {get; set;}
        public string Mother_Email {get; set;}
        public string Mother_Occupation {get; set;}
        public long Mother_Mobile {get; set;}

        public string Guardian_Name {get; set;}
        public string Guardian_Email {get; set;}
        public string Guardian_Occupation {get; set;}
        public string Guardian_Relationship {get; set;}
        public long Guardian_Mobile { get; set; }



        public New_Student_Application_Information(string admitType, string yearLevel, string schoolYear, string term, string studentFirstName, string studentMiddleName, string studentLastName, string studentSuffixName,
        string studentGender, string studentStatus, string studentCitizenship, string studentBirthPlace, string studentReligion, string studentCurrentAddress, string studentDateOfBirth,
        string studentTelephoneNumber, long studentMobileNumber, string studentEmailAddress)
        {
            this.AdmitType = admitType;
            this.YearLevel = yearLevel;
            this.SchoolYear = schoolYear;
            this.Term = term;

            this.Student_FirstName = studentFirstName;
            this.Student_MiddleName = studentMiddleName;
            this.Student_LastName = studentLastName;
            this.Student_SuffixName = studentSuffixName;
            this.Student_Gender = studentGender;
            this.Student_Status = studentStatus;
            this.Student_Citizenship = studentCitizenship;
            this.Student_BirthPlace = studentBirthPlace;
            this.Student_Religion = studentReligion;
            this.Student_CurrentAddress = studentCurrentAddress;
            this.Student_DateOfBirth = studentDateOfBirth;
            this.Student_TelephoneNumber = studentTelephoneNumber;
            this.Student_MobileNumber = studentMobileNumber;
            this.Student_EmailAddress = studentEmailAddress;

        }
        public New_Student_Application_Information(string course)
        {
            this.Course = course;
        }

        public New_Student_Application_Information( string fatherName, string fatherEmail, long fatherMobileNo, string fatherOccupation, string motherName, string motherEmail, long motherMobileNo, string motherOccupation)
        {
            this.Father_Name = fatherName;
            this.Father_Email = fatherEmail;
            this.Father_Mobile = fatherMobileNo;
            this.Father_Occupation = fatherOccupation;

            this.Mother_Name = motherName;
            this.Mother_Email = motherEmail;
            this.Mother_Mobile = motherMobileNo;
            this.Mother_Occupation = motherOccupation;
        }

        public New_Student_Application_Information(string guardianName, string guardianEmail, long guardianMobileNo, string guardianOccupation, string guardianRelationship)
        {
            this.Guardian_Name = guardianName;
            this.Guardian_Email = guardianEmail;
            this.Guardian_Mobile = guardianMobileNo;
            this.Guardian_Occupation = guardianOccupation;
            this.Guardian_Relationship = guardianRelationship;
        }

        New_Student_Application_Information()
        {
            this.AdmitType = "";
            this.YearLevel = "";
            this.Course = "";
            this.SchoolYear = "";
            this.Term = "";

            this.Student_FirstName = "";
            this.Student_MiddleName = "";
            this.Student_LastName = "";
            this.Student_SuffixName = "";
            this.Student_Gender = "";
            this.Student_Status = "";
            this.Student_Citizenship = "";
            this.Student_BirthPlace = "";
            this.Student_Religion = "";
            this.Student_CurrentAddress = "";
            this.Student_DateOfBirth = "";
            this.Student_TelephoneNumber = "";
            this.Student_MobileNumber = 0;
            this.Student_EmailAddress = "";

            this.Father_Name = "";
            this.Father_Email = "";
            this.Father_Mobile = 0;
            this.Father_Occupation = "";
            

            this.Mother_Name = "";
            this.Mother_Email = "";
            this.Mother_Mobile = 0;
            this.Mother_Occupation = "";
            

            this.Guardian_Name = "";
            this.Guardian_Email = "";
            this.Guardian_Mobile = 0;
            this.Guardian_Occupation = "";
            this.Guardian_Relationship = "";
        }
    }
}
