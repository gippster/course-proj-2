internal class MobilePhone : Telephone
{
    public MobilePhone(string phoneNumber, TelephoneType phoneNumberType = TelephoneType.Mobile) : base(phoneNumber, phoneNumberType) 
    {
    }
    protected override bool Validate(string phoneNumber) 
    {
        return phoneNumber.Length == 11;
    }
}
