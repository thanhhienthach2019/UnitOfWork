namespace Service.AutoMapper
{
    using global::AutoMapper;
    using global::AutoMapper.Extensions.ExpressionMapping;

    public static class AutoMapperConfiguration
    {
        public static void Config()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddExpressionMapping();
                cfg.AddProfile(new MappingProfile());
            });
        }
    }
}