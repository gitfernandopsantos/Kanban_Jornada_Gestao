using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;
using AutoMapper;

namespace ApiKanbanGestao.DataDbContext.MapDTOs
{
    public class MapEntityTo: Profile
    {
        public MapEntityTo()
        {
            CreateMap<Atividade, AtividadeDTO>().ReverseMap();
        }
    }
}
