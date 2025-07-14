using ima_be.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ima_be.Application.Interfaces;

public interface IUserService
{
    Task<LoginResponse?> AuthenticateAsync(LoginRequest request);
}