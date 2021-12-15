using BlogJWT.DTO.Abstract;

namespace BlogJWT.DTO.DTOs.CategoryDtos
{
    public class CategoryUpdateDto:IDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
