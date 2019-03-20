using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductCatalogAPI.Data;
using ProductCatalogAPI.Domain;
using ProductCatalogAPI.ViewModels;

namespace ProductCatalogAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly CatalogContext _context;
        private readonly IConfiguration _configuration;
        public CatalogController(CatalogContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CatalogTypes()
        {
            var items = await _context.CatalogTypes.ToListAsync();
            return Ok(items);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CatalogBrands()
        {
            var items = await _context.CatalogBrands.ToListAsync();
            return Ok(items);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Items(
            [FromQuery]int pageSize=6, 
            [FromQuery]int pageIndex=0)
        {
            var totalItems = await _context.CatalogItems.LongCountAsync();

            var itemsOnPage = await _context.CatalogItems
                                        .OrderBy(c => c.Name)
                                        .Skip(pageIndex * pageSize)
                                        .Take(pageSize)
                                        .ToListAsync();
            itemsOnPage = ChangePictureUrl(itemsOnPage);

            return Ok(new PaginatedItemsViewModel
            {
                Count = totalItems,
                PageIndex = pageIndex,
                PageSize = pageSize,
                Data = itemsOnPage
            });

        }

        private List<CatalogItem> ChangePictureUrl(List<CatalogItem> items)
        {
            items.ForEach(c => c.PictureUrl = c.PictureUrl
                                    .Replace("http://externalcatalogbaseurltobereplaced",
                                    _configuration["ExternalDomainUrl"]));
            return items;
        }

    }
}