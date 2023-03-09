namespace WinFormsApp.DB
{
    public class Operation
    {
        public int Id { get; set; }
        public User Sender { get; set; }
        public string Payee { get; set; }
        public int Sum { get; set; }
    }
}
