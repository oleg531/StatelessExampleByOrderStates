namespace StatelessExampleByOrderStates.Models.ManageViewModels
{
    using System.ComponentModel.DataAnnotations;
    using Base;


    public class ChangeRoleViewModel
    {
        [Required]                
        public UserRole UserRole{ get; set; }        
    }
}
