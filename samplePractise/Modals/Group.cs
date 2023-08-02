using System.ComponentModel.DataAnnotations;

namespace samplePractise.Modals
{
    public class Group
    {
        [Key] public int GroupId { get; set; }

        public string GroupName { get; set; }

    }
}
