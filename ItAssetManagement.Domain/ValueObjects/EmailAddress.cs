using System.Net.Mail;

namespace ItAssetManagement.Domain.ValueObjects;

public record EmailAddress
{
    public string Value { get; }

    public EmailAddress(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Email address is required.", nameof(value));

        var normalizedValue = value.Trim();

        try
        {
            var mailAddress = new MailAddress(normalizedValue);

            if (mailAddress.Address != normalizedValue)
                throw new FormatException();
        }
        catch
        {
            throw new ArgumentException(
                "A valid email address is required.",
                nameof(value));
        }

        Value = normalizedValue;
    }

    public override string ToString() => Value;
}
