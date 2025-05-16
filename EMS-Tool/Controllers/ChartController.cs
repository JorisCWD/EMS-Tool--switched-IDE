using EMS_Tool.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Reflection;

[Authorize(Roles = "Admin, User")]
public class ChartController : Controller
{
    private readonly TchW0814080Context _context;

    public ChartController(TchW0814080Context context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var tables = _context.Model.GetEntityTypes()
            .Select(e => e.ClrType.Name)
            .ToList();

        return View(tables); // Pass list of table names to view
    }

    [HttpGet]
    public IActionResult GetColumns(string tableName)
    {
        var entityType = _context.Model.GetEntityTypes()
            .FirstOrDefault(e => e.ClrType.Name == tableName);
        if (entityType == null) return NotFound();

        var properties = entityType
            .GetProperties()
            .Select(p => p.Name)
            .ToList();

        return Json(properties);
    }

    [HttpGet]
    public IActionResult GetValues(string tableName, string columnName)
    {
        var entityType = _context.Model.GetEntityTypes()
            .FirstOrDefault(e => e.ClrType.Name == tableName);
        if (entityType == null) return NotFound();

        var clrType = entityType.ClrType;
        var queryable = GetQueryable(clrType);

        var list = queryable
            .Select($"{columnName}")
            .Distinct()
            .ToDynamicList();

        var values = list.Select(x => x?.ToString()).ToList();

        return Json(values);
    }

    [HttpGet]
    public IActionResult GetChartData(string tableName, string columnName, string filterValue)
    {
        var entityType = _context.Model.GetEntityTypes()
            .FirstOrDefault(e => e.ClrType.Name == tableName);
        if (entityType == null) return NotFound();

        var clrType = entityType.ClrType;
        var queryable = GetQueryable(clrType);

        var filtered = queryable.Where($"{columnName} == @0", filterValue);

        var grouped = filtered
            .GroupBy("Date") // Assumes a Date column exists, change if needed
            .Select("new (Key as Date, Sum(Value) as Total)") // Assumes Value column
            .ToDynamicList();

        return Json(grouped);
    }

    [HttpGet]
    public IActionResult GetAggregatedChartData(string tableName, string groupByField, string valueField)
    {
        var entityType = _context.Model.GetEntityTypes().FirstOrDefault(e => e.ClrType.Name == tableName);
        if (entityType == null) return Json(new { error = "Table not found" });

        var clrType = entityType.ClrType;
        var queryable = GetQueryable(clrType);

        // Build dynamic select expression depending on whether valueField is null
        string selectExpression = string.IsNullOrEmpty(valueField)
            ? "new (Key as group, Count() as value)"
            : $"new (Key as group, Sum({valueField}) as value)";

        try
        {
            var grouped = queryable
                .GroupBy(groupByField)
                .Select(selectExpression)
                .ToDynamicList();

            return Json(grouped);
        }
        catch (Exception ex)
        {
            return Json(new { error = ex.Message });
        }
    }

    // Helper method to get the queryable DbSet based on the entity type
    private IQueryable<object> GetQueryable(Type clrType)
    {
        var setMethod = typeof(DbContext).GetMethod("Set", Type.EmptyTypes);
        var genericSetMethod = setMethod?.MakeGenericMethod(clrType);
        return (IQueryable<object>?)genericSetMethod?.Invoke(_context, null) ?? Enumerable.Empty<object>().AsQueryable();
    }
}

