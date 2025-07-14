using ima_be.Application.Interfaces;
using ima_be.DTOs;
using ima_be.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ima_be.Application.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<LoginResponse?> AuthenticateAsync(LoginRequest request)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u =>
                    u.Username == request.Username &&
                    u.Password == request.Password);

            if (user == null)
                return null;

            // TODO: Replace mock token with real JWT in future
            return new LoginResponse
            {
                Token = "mock-jwt-token",
                Username = user.Username
            };
        }
    }
}

