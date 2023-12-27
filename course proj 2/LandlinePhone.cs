using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_proj_2;

internal class LandlinePhone : TelephoneBase
{
    public LandlinePhone(string phoneNumber, TelephoneType phoneNumberType = TelephoneType.Home) : base(phoneNumber, phoneNumberType)
    {
    }
    protected override bool Validate(string phoneNumber)
    {
        return phoneNumber.Length == 6;
    }
}
