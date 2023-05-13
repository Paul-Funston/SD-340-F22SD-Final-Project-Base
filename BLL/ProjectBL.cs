using Microsoft.EntityFrameworkCore;
using SD_340_W22SD_Final_Project_Group6.Data;
using SD_340_W22SD_Final_Project_Group6.Models;

namespace SD_340_W22SD_Final_Project_Group6.BLL
{
    public class ProjectBL : IProjectBL
    {
        private readonly IUserProjectRepository _userProjectRepo;

        public ProjectBL(IUserProjectRepository userProjectRepo) 
        { 
            _userProjectRepo = userProjectRepo;
        }
        
        public void RemoveAssingedUser(string userId, int projectId)
        {
            UserProject currentUserProject = _userProjectRepo.GetUserProject(userId, projectId);
            _userProjectRepo.Delete(currentUserProject);
        }

    }
}
