using System.ComponentModel.DataAnnotations;

namespace UserManagementWithIdentity.ViewModels
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}