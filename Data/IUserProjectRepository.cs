using SD_340_W22SD_Final_Project_Group6.Data.Migrations;
using SD_340_W22SD_Final_Project_Group6.Models;

namespace SD_340_W22SD_Final_Project_Group6.Data
{
    public interface IUserProjectRepository: IRepository<UserProject>
    {
        UserProject GetUserProject(string userId, int projectId); 
    }
}
