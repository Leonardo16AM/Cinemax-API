namespace Cinemax.API.Models
{
    public class RoleUser
    {
        public int RoleUserId {get; set;}
        public int RoleId {get; set;}
        public int UserId {get; set;}
        public virtual Role Role {get; set;}
        public virtual User User {get; set;}   
    }
}