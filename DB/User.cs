using System.Collections.Generic;

namespace WinFormsApp.DB
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }
        public bool Admin { get; set; }
        public List<Operation> Operations { get; set; } = new();
    }
}
