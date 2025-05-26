// src/DTOs/AutoMapperProfile.cs
using AutoMapper;
using API_AdocaoPets.src.Models;
using API_AdocaoPets.src.DTOs;

namespace API_AdocaoPets.src.DTOs
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Pet, PetDTO>();
            CreateMap<PetDTO, Pet>();
        }
    }
}