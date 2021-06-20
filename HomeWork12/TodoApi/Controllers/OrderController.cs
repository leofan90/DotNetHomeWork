using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using TodoApi;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly OrderContext orderDb;

        public TodoController(OrderContext context)
        {
            this.orderDb = context;
        }

        //GET: api/Order
        [HttpGet]
        public ActionResult<List<Order>> GetOrder(){
            IQueryable<Order> query = orderDb.Orders;
            return query.ToList();
        }

        //POST: api/AddOrder
        [HttpPost]
        public ActionResult<Order> AddOrder(Order order){
            try
            {
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        //POST: api/AddOrderDetail
        [HttpPost]
        public ActionResult<OrderDetails> AddOrderDetail(OrderDetails orderDetail){
            try
            {
                orderDb.OrderDetails.Add(orderDetail);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return orderDetail;
        }

        // PUT: api/Order/{id}
        [HttpPut("{id}")]
        public ActionResult<Order> Edit(string id, Order order)
        {
            if (id != order.OrderID)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                orderDb.Entry(order).State = EntityState.Modified;
                orderDb.SaveChanges();
            }catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/Order/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                var order = orderDb.Orders.FirstOrDefault(o => o.OrderID == id);
                if (order != null){
                    orderDb.Remove(order);
                    orderDb.SaveChanges();
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
