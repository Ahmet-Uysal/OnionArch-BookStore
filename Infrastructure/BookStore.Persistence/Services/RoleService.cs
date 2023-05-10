using Microsoft.AspNetCore.Identity;
using BookStore.Application.Services;
using BookStore.Domain.Entities.Identity;

namespace BookStore.Persistence.Services
{
    public class RoleService : IRoleService
    {
        readonly RoleManager<Role> _roleManager;

        public RoleService(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<bool> CreateRole(string name)
        {
            IdentityResult result = await _roleManager.CreateAsync(new() { Id = Guid.NewGuid(), Name = name });

            return result.Succeeded;
        }

        public async Task<bool> DeleteRole(Guid id)
        {
            Role appRole = await _roleManager.FindByIdAsync(id.ToString());
            IdentityResult result = await _roleManager.DeleteAsync(appRole);
            return result.Succeeded;
        }

        public (object, int) GetAllRoles(int page, int size)
        {
            var query = _roleManager.Roles;

            return (query.Skip(page * size).Take(size).Select(r => new { r.Id, r.Name }), query.Count());
        }

        public async Task<(Guid id, string name)> GetRoleById(Guid id)
        {
            string role = await _roleManager.GetRoleIdAsync(new() { Id = id });
            return (id, role);
        }

        public async Task<bool> UpdateRole(Guid id, string name)
        {
            Role role = await _roleManager.FindByIdAsync(id.ToString());
            role.Name = name;
            IdentityResult result = await _roleManager.UpdateAsync(role);
            return result.Succeeded;
        }
    }
}