namespace Infrastructure.Services;
using Infrastructure.Context;
using Domain.Dtos;
using Dapper;
public class CategoryService
{
    private readonly DapperContext _dapperContext;
    public CategoryService(DapperContext dapperContext)
    {
        _dapperContext = dapperContext;
    }
    public async Task<List<CategoriesDto>> GetCategories()
    {
        using (var conn = _dapperContext.CreateConnection())
        {
            var sql = "select id as Id, category_name as CategoryName from categories;";
            var result = await conn.QueryAsync<CategoriesDto>(sql);
            return result.ToList(); 
        }
    }
}
