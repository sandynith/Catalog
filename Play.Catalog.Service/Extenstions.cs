using Play.Catalog.Service.Entities;
using static Play.Catalog.Service.Dtos;

namespace Play.Catalog.Service
{
    public static class Extenstions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto(item.Id, item.Name, item.Description, item.Price, item.CreatedDate);
        }
    }
}