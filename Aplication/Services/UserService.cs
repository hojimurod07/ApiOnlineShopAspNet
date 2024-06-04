using Aplication.Common.Exceptions;
using Aplication.DTOs.UserDtos;
using Aplication.Interfaces;
using Data.Interfaces;
using System.Net;
namespace Aplication.Services
   
{
    public class UserService(IUnitOfWork unitOfWork) : IUserService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        public async Task DeleteAsync(int id)
        {
            var user = await _unitOfWork.UserRepository.GetByIdAsync(id);
            if (user is null)
            {
                throw new StatusCodeExeptions(HttpStatusCode.NotFound,"Not found");
            }
            await _unitOfWork.UserRepository.DeleteAsync(user);
            throw new StatusCodeExeptions(HttpStatusCode.OK, "User has been deleted sucessfully");
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
            var users = await _unitOfWork.UserRepository.GetAllAsync();
            return users.Select(x => (UserDto)x).ToList();
        }

        public async Task<UserDto> GetByIdAsync(int id)
        {
            var user = await _unitOfWork.UserRepository.GetByIdAsync(id);
            if (user is null)
                throw new StatusCodeExeptions(HttpStatusCode.NotFound, "User not found");
            return (UserDto)user;
        }
        public async Task UpdateAsync(int id, UpdateUserDto updateUserDto)
        {
            var user = await _unitOfWork.UserRepository.GetByIdAsync(id);
            if (user is null)
            {
                throw new StatusCodeExeptions(HttpStatusCode.NotFound, "Use not found");

            }

            await _unitOfWork.UserRepository.UpdateAsync(user);
            throw new StatusCodeExeptions(HttpStatusCode.OK, "User has been updated succesfully");


        }
    }
}
