using System.ComponentModel.DataAnnotations;

namespace WebAppRazorPagesUnique.Model
{
    // table , Name ,email password & gender field
    public class UsersModel
    {
        [Key]  // Key , ID as Pk and autoincement
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
    }
}
