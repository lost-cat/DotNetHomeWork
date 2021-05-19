using System;
using System.Threading.Tasks;
using AutoMapper;
using HomeWorkWebAPI.entities;
using HomeWorkWebAPI.models;
using HomeWorkWebAPI.services;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkWebAPI.Controllers
{
    [ApiController]
    [Route("api/Order/{orderId:guid}/Details")]
    public class DetailController : ControllerBase
    {
        private readonly DetailRepository repository;
        private readonly IMapper mapper;

        public DetailController(DetailRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet("{detailId:guid}", Name = nameof(GetDetail))]
        public async Task<ActionResult<OrderDetailDto>> GetDetail(Guid orderId, Guid detailId)
        {
            var detail = await repository.GetDetail(orderId, detailId);
            if (detail == null)
            {
                return NotFound();
            }

            var detailDto = mapper.Map<OrderDetailDto>(detail);
            return Ok(detailDto);
        }

        [HttpPost]
        public async Task<ActionResult<OrderDetailDto>> CreateDetail(Guid orderId, OrderDetailAddDto addDto)
        {
            if (addDto == null)
            {
                return BadRequest();
            }

            var detail = mapper.Map<OrderDetail>(addDto);
            repository.AddDetail(orderId, detail);
            await repository.Save();
            
            var addDetailDto = mapper.Map<OrderDetailDto>(detail);
            return CreatedAtRoute(nameof(GetDetail),
                new {orderId, detailId = addDetailDto.Id},
                addDetailDto);
        }
    }
}