﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RandBox.Server.Repositories.Contracts;
using RandBox.Shared.Domain;

namespace RandBox.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)

        {
            _unitOfWork = unitOfWork;
        }

        // Get all Order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrder()

        {
            var Order = await _unitOfWork.OrderRepository.GetAll();
            if (Order == null)
            {
                return NotFound();
            }

            return Ok(Order);

        }

        // Get Order by id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder(int id)
        {
            var Order = await _unitOfWork.OrderRepository.GetById(id);

            if (Order == null)
            {
                return NotFound();
            }

            return Ok(Order);
        }


        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order Order)
        {
            await _unitOfWork.OrderRepository.Insert(Order);
            await _unitOfWork.Save();
            return CreatedAtAction("GetOrder", new { id = Order.OrderID }, Order);
        }
        protected async Task<bool> OrderExists(int id)
        {
            return await _unitOfWork.OrderRepository.GetById(id) != null;
        }
    }
}

