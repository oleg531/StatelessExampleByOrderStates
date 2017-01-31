namespace StatelessExampleByOrderStates.Models.Base
{
    using System.ComponentModel.DataAnnotations;

    public enum UserRole
    {
        [Display(Name = "Regional user")]
        RegionalUser = 10,
        [Display(Name = "Main")]
        MainUser = 20
    }
}
