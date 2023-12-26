using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_proj_2;

internal class MobileTelephone :Telephone
{
    public MobileTelephone(string phoneNumber, TelephoneType phoneNumberType = TelephoneType.Mobile) : base(phoneNumber, phoneNumberType) 
    {
    }
    protected override bool Validate(string phoneNumber) 
    {
        return phoneNumber.Length == 11;
    }
}
