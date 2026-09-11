namespace ItAssetManagement.Domain.Assets.ValueObjects
{
    public class SerialNumber
    {
        public string Value { get; }

        public SerialNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
            {
                throw new ArgumentException("Serial number must be at least 3 characters long.", nameof(value));
            }

            var serialNumber = $"{value.Substring(0, 3).ToUpper()}-{Guid.NewGuid().ToString().Substring(0, 3).ToUpper()}";
            Value = serialNumber;
        }

        public override string ToString() => Value;
    }
}
