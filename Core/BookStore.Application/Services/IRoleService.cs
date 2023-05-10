namespace BookStore.Application.Services
{
    public interface IRoleService
    {
        (object, int) GetAllRoles(int page, int size);
        Task<(Guid id, string name)> GetRoleById(Guid id);
        Task<bool> CreateRole(string name);
        Task<bool> DeleteRole(Guid id);
        Task<bool> UpdateRole(Guid id, string name);
    }
}