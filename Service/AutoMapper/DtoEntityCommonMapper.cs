﻿namespace Service.AutoMapper
{
    using Data;
    using DTO;
    using global::AutoMapper;

    public class DtoEntityCommonMapper : Profile
    {
        public DtoEntityCommonMapper()
        {
            #region Enity To Dto

            CreateMap<user, UserDTO>();
            CreateMap<DonVi, DonViDTO>();

            #endregion

            #region Dto to Entity

            CreateMap<UserDTO, user>();
            CreateMap<DonViDTO, DonVi>();

            #endregion
        }
    }
}
