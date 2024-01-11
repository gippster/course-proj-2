using System;

public abstract class Telephone
{
    public string PhoneNumber { get; protected set; }
    public TelephoneType PhoneNumberType { get; protected set; }
    protected Telephone(string phoneNumber, TelephoneType phoneNumberType) 
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
