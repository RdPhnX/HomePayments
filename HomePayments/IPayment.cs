namespace HomePayments
{
    public interface IPayment
    {
        string Type { get; set; }

        void SubmitReadings(int currentReadings);
    }
}