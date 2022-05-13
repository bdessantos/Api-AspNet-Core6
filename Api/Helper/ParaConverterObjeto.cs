using AutoMapper;

namespace Api.Helper
{
    public class ParaConverterObjeto<TSource, TDestination>
    {
        public static TDestination ConverterObjeto(object objeto)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSource, TDestination>();
            });

            var mapper = configuration.CreateMapper();
            TDestination objetoDestino = mapper.Map<TDestination>(objeto);

            return objetoDestino;
        }
    }
}
