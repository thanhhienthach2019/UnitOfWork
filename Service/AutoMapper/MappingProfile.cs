namespace Service.AutoMapper
{
    using Data;
    using DTO;
    using global::AutoMapper;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Enity To Dto

            CreateMap<user, UserDTO>();
            CreateMap<DonVi, DonViDTO>();
            CreateMap<loaivanban, LoaiVanBanDTO>();
            CreateMap<vanban, VanBanDTO>();

            #endregion Enity To Dto

            #region Dto to Entity

            CreateMap<UserDTO, user>();
            CreateMap<DonViDTO, DonVi>();
            CreateMap<LoaiVanBanDTO, loaivanban>();
            CreateMap<VanBanDTO, vanban>();

            #endregion Dto to Entity
        }
    }
}