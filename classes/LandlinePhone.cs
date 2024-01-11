internal class LandlinePhone : Telephone
{
    public LandlinePhone(string phoneNumber, TelephoneType phoneNumberType = TelephoneType.Home) : base(phoneNumber, phoneNumberType)
    {
    }
    protected override bool Validate(string phoneNumber)
    {
        return phoneNumber.Length == 6;
    }
}
