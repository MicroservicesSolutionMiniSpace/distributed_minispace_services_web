using Convey.CQRS.Commands;

namespace MiniSpace.Services.Students.Application.Commands
{
    public class UpdateStudent : ICommand
    {
        public Guid StudentId { get; }
        public string ProfileImage { get; private set; }
        public string Description { get; private set; }
        public bool EmailNotifications { get; private set; }
        
        public UpdateStudent(Guid studentId, string profileImage, string description, bool emailNotifications)
        {
            StudentId = studentId;
            ProfileImage = profileImage;
            Description = description;
            EmailNotifications = emailNotifications;
        }
    }    
}
