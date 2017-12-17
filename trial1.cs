using System;

public class Class1
{

    private void qq(EmployeeEntity emp)
    {
        StringBuilder sb = new StringBuilder();

        //#FutureCode - Make this method generic like taking length of columns from sql
        if(txt_firstName.Text.Length <= 30)
        emp.Firstname = txt_firstName.Text.Length <= 30 ? txt_firstName.Text : txt_firstName.Text.Substring(0, 30);
        emp.Lastname = txt_lastName.Text.Length <= 30 ? txt_lastName.Text : txt_lastName.Text.Substring(0, 30);
        emp.Petname = txt_petName.Text.Length <= 30 ? txt_petName.Text : txt_petName.Text.Substring(0, 10);
        emp.Empaddress = txt_address.Text.Length <= 30 ? txt_address.Text : txt_address.Text.Substring(0, 1000);
        emp.Pincode = txt_pinCode.Text.Length <= 30 ? txt_pinCode.Text : txt_pinCode.Text.Substring(0, 6);
        emp.Homephone = txt_homePhone.Text.Length <= 30 ? txt_homePhone.Text : txt_homePhone.Text.Substring(0, 15);
        emp.Mobile = txt_mobileNo.Text.Length <= 30 ? txt_mobileNo.Text : txt_mobileNo.Text.Substring(0, 10);
        emp.Emailid = txt_email.Text.Length <= 30 ? txt_email.Text : txt_email.Text.Substring(0, 30);
        emp.Education = txt_education.Text.Length <= 30 ? txt_education.Text : txt_education.Text.Substring(0, 20);
        emp.Aadhaarno = txt_aadhaar.Text.Length <= 30 ? txt_aadhaar.Text : txt_aadhaar.Text.Substring(0, 12);
        emp.Addressproof = txt_addressProof.Text.Length <= 30 ? txt_addressProof.Text : txt_addressProof.Text.Substring(0, 20);
        emp.Dl_no = txt_dlno.Text.Length <= 30 ? txt_dlno.Text : txt_dlno.Text.Substring(0, 40);
        emp.Dl_rto = txt_rto.Text == String.Empty || txt_dlno.Text.Length <= 30 ? txt_firstName.Text : txt_rto.Text.Substring(0, 30);
        emp.Experience = txt_experience.Text.Length <= 30 ? txt_experience.Text : txt_experience.Text.Substring(0, 300);
        emp.Attributes = txt_attributes.Text.Length <= 30 ? txt_attributes.Text : txt_attributes.Text.Substring(0, 1000);
        emp.Otherdetails = txt_otherDetails.Text.Length <= 30 ? txt_otherDetails.Text : txt_otherDetails.Text.Substring(0, 1000);
    }
}

