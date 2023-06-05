using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]

public class CategoryController : ControllerBase
{
    private readonly CategoryService categoryService;

    public CategoryController(CategoryService categoryService)
    {
        this.categoryService = categoryService;
    }
    [HttpGet("GetCategories")]
    public async Task<List<CategoriesDto>> GetCategories()
    {
        return await categoryService.GetCategories();
    }
}
