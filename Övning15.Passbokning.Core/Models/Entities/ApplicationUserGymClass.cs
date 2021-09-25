namespace Övning15Passbokning.Core.Models.Entities
{
    public class ApplicationUserGymClass
    {
        //Foreign Keys
        public int GymClassId { get; set; }
        public string ApplicationUserId { get; set; }

        //Navigation properties
        public GymClass GymClass { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}