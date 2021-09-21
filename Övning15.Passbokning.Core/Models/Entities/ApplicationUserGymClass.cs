namespace Övning15Passbokning.Core.Models.Entities
{
    public class ApplicationUserGymClass
    {
        //Foreign Keys
        public int GymClassId { get; internal set; }
        public string ApplicationUserId { get; internal set; }

        //Navigation properties
        public GymClass GymClass { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}