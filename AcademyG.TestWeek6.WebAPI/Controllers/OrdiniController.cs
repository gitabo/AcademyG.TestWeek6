using AcademyG.TestWeek6.Core.Interfaces;
using AcademyG.TestWeek6.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.TestWeek6.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdiniController : ControllerBase
    {
        private IMainBusinessLayer mainBL;

        public OrdiniController(IMainBusinessLayer businessLayer)
        {
            this.mainBL = businessLayer;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var result = this.mainBL.FetchOrders();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid Order Id.");

            var order = this.mainBL.FetchOrderById(id);

            if (order == null)
                return NotFound($"Order with Id = {id} is missing.");

            return Ok(order);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Ordine newOrder)
        {
            if (newOrder == null)
                return BadRequest("Invalid Book data.");


            if (!this.mainBL.CreateOrder(newOrder))
                return BadRequest("Cannot complete the operation");

            return CreatedAtAction(nameof(GetOrderById), new { id = newOrder.Id }, newOrder);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Ordine editedOrder)
        {
            if (editedOrder == null)
                return BadRequest("Invalid Order data.");

            if (id != editedOrder.Id)
                return BadRequest("Order IDs don't match.");

            if (!this.mainBL.EditOrder(editedOrder))
                return BadRequest("Cannot complete the operation");

            return Ok(editedOrder);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid Order ID.");

            var result = this.mainBL.DeleteOrderById(id);

            if (!result)
                return StatusCode(500, "Cannot complete the operation.");

            return Ok();
        }
    }
}
