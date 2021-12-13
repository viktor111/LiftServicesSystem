namespace Common.Application.Mapping
{
    using AutoMapper;

    internal interface IMapFrom<T>
    {
        void Mapping(Profile mapper) => mapper.CreateMap(typeof(T), this.GetType());
    }
}
