﻿using AutoMapper;
using MagicVilla_CouponAPI.Models.DTO;
using MagicVilla_CouponAPI.Models;

namespace MagicVilla_CouponAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Coupon, CouponCreateDTO>().ReverseMap();
            CreateMap<Coupon, CouponDTO>();
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        }
    }
}
