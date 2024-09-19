using MyBlogRazorPage.DTO;
using MyBlogRazorPage.Model;

namespace MyBlogRazorPage.Mappers;

public static class BlogMappers
{
    public static BlogDTO ToBlogDto(this Blog blog) =>
        new()
        {
            Title = blog.Title,
            Content = blog.Content,
            Author = blog.Author
        };

    public static Blog ToCreateBlog(this BlogDTO blogDto)
    {
        return new Blog
        {
            Title = blogDto.Title,
            Content = blogDto.Content,
            Author = blogDto.Author
        };
    }
}