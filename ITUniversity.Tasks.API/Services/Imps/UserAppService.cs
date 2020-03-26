using AutoMapper;

using ITUniversity.Tasks.API.Services.Dto;
using ITUniversity.Tasks.Entities;
using ITUniversity.Tasks.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ITUniversity.Tasks.API.Services.Imps
{
    /// <summary>
    /// Сервис для работы с пользователями
    /// </summary>
    public class UserAppService : IUserAppService
    {
        private readonly IUserRepository userRepository;

        private readonly IMapper mapper;

        /// <summary>
        /// Инициализировать экземпляр <see cref="UserAppService"/>
        /// </summary>
        /// <param name="userRepository">Репозиторий пользователей</param>
        /// <param name="mapper">Маппер</param>
        public UserAppService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public void Block(int id)
        {
            var entity = userRepository.Get(id);
            entity.IsBlocked = true;
            userRepository.Update(entity);
        }

        /// <inheritdoc/>
        public UserDto Create(CreateUserDto dto)
        {
            var entity = mapper.Map<User>(dto);
            userRepository.Save(entity);
            return mapper.Map<UserDto>(entity);
        }

        /// <inheritdoc/>
        public UserDto Get(string login, bool isBlocked = true)
        {
            var entity = isBlocked ? userRepository.FirstOrDefault(e => e.Login == login) : userRepository.FirstOrDefault(e => e.Login == login && e.IsBlocked == false);
            return mapper.Map<UserDto>(entity);
        }

        /// <inheritdoc/>
        public UserDto Get(string login, string password, bool isBlocked = true)
        {
            var entity = isBlocked ? userRepository.FirstOrDefault(e => e.Login == login && e.Password == password): 
                userRepository.FirstOrDefault(e => e.Login == login && e.Password == password && e.IsBlocked == false);
            return mapper.Map<UserDto>(entity);
        }

        public ICollection<UserDto> GetAll()
        {
            var entities = userRepository.GetAll().Where(e=>!e.IsBlocked).ToList();
            return mapper.Map<ICollection<UserDto>>(entities);
        }

        /// <inheritdoc/>
        public bool IsValidPassword(UserDto dto, string password)
        {
            var entity = userRepository.Get(dto.Id);
            return entity.Password == password;
        }
    }
}