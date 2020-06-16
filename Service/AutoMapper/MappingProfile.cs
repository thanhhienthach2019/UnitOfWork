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
            CreateMap<loaitailieu, LoaiTaiLieuDTO>();
            CreateMap<tailieu, TaiLieuDTO>();
            CreateMap<Get_LoaiTaiLieu_Result, GetLoaiTaiLieuDTO>();
            CreateMap<Banhanhvb, BanhanhvbDTO>();
            CreateMap<theloai, TheLoaiDTO>();
            CreateMap<loaitin, LoaiTinDTO>();

            #endregion Enity To Dto

            #region Dto to Entity

            CreateMap<UserDTO, user>();
            CreateMap<DonViDTO, DonVi>();
            CreateMap<LoaiVanBanDTO, loaivanban>();
            CreateMap<VanBanDTO, vanban>();
            CreateMap<LoaiTaiLieuDTO, loaitailieu>();
            CreateMap<TaiLieuDTO, tailieu>();
            CreateMap<GetLoaiTaiLieuDTO, Get_LoaiTaiLieu_Result>();
            CreateMap<BanhanhvbDTO, Banhanhvb>();
            CreateMap<TheLoaiDTO, theloai>();
            CreateMap<LoaiTinDTO, loaitin>();

            #endregion Dto to Entity
        }
    }
}