//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Core.Entities;
//using Core.Interfaces;

//namespace Core.Services
//{
//    public async Task RegisterUserAsync(UserDto userDto)
//    {
//        // Check if email already exists
//        bool emailExists = await _userRepository.IsEmailExistsAsync(userDto.EmailID);
//        if (emailExists)
//        {
//            throw new Exception("Email already registered. Please use another email.");
//        }

//        // Proceed with user registration
//        var user = new User
//        {
//            Name = userDto.Name,
//            EmailID = userDto.EmailID,
//            PhoneNo = userDto.PhoneNo,
//            Dob = userDto.Dob,
//            Address = userDto.Address,
//            PasswordHash = HashPassword(userDto.Password),
//        };

//        await _userRepository.AddAsync(user);
//    }

//}
