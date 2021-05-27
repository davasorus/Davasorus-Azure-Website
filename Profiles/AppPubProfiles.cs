using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using StreamWebPage.Models;
using WebAPI.DTOs;
using WebAPI.Models;

namespace WebAPI.Profiles
{
    public class AppPubProfiles : Profile
    {
        public AppPubProfiles()
        {
            CreateMap<AppPub, AppPubReadDTO>();
            CreateMap<AppPubCreateDTO, AppPub>();
            CreateMap<AppPubUpdateDTO, AppPub>();
            CreateMap<AppPub, AppPubUpdateDTO>();
        }
    }
}