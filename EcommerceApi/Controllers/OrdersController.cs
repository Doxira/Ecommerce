using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Eccomerce.Models;

namespace Eccomerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly EccomerceContext context;

        public OrdersController(EccomerceContext context)
        {
            this.context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orders>>> GetOrders()
        {
            return await context.Orders.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Orders>>> GetUserOrders(int id)
        {
            var user = await context.Users.FindAsync(id);
            var ordersOfUser = user.Orders;

            if (user == null)
            {
                return NotFound();
            }
            return ordersOfUser.ToList();
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Orders order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            context.Entry(order).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Orders>> PostOrder(NewOrder newOrder)
        {
            var order = new Orders
            {
                CreatedAt = newOrder.Order.CreatedAt,
                StatusCodes= newOrder.Order.StatusCodes,
                User= newOrder.Order.User,
                UserId= newOrder.Order.UserId,
            };
            var products = context.Products.Where(p => newOrder.ProductsIds.Contains(p.Id));
            order.TotalPrice = products.Sum(p=>p.Price);
            foreach (var product in products)
            {
                order.OrderProducts.Add(new OrderProducts {Order=order,Product=product});
            }
            context.Orders.Add(order);
            await context.SaveChangesAsync();
            return CreatedAtAction("GetUserOrders", new { id = newOrder.Order.Id }, newOrder.Order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Orders>> DeleteOrder(int id)
        {
            var order = await context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            context.Orders.Remove(order);
            await context.SaveChangesAsync();

            return order;
        }

        private bool OrderExists(int id)
        {
            return context.Orders.Any(e => e.Id == id);
        }
    }
}
