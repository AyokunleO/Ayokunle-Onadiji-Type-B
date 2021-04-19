namespace Question3
{
    public interface IPayable
    {
         decimal RetrieveAmount();
         decimal AddToAmount();
         string PaymentAddress();
    }
}