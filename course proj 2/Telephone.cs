using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_proj_2;

public abstract class Telephone
{
    public string PhoneNumber { get; protected set; }
    public TelephoneType PhoneNumberType { get; protected set; }
    protected Telephone(string phoneNumber, TelephoneType phoneNumberType = TelephoneType.Mobile) 
    {
        UpdatePhoneNumber(phoneNumber);
        PhoneNumberType = phoneNumberType;
    }
    protected abstract bool Validate(string phoneNumber);
    public void UpdatePhoneNumber(string phoneNumber) 
    {
        if (Validate(phoneNumber)) 
        { 
            PhoneNumber = phoneNumber; 
        }
        else 
        {
            throw new ArgumentException("Номер не соответствует формату");
        }
    }
}
