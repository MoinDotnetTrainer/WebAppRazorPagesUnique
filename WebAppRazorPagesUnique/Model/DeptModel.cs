using System.ComponentModel.DataAnnotations;

namespace WebAppRazorPagesUnique.Model
{
    public class DeptModel
    {
        [Key]
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string DeptLoc { get; set; }
    }
}
