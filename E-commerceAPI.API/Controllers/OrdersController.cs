using E_commerceAPI.BL.Dtos.OrderProducts;
using E_commerceAPI.BL.Dtos.Orders;
using E_commerceAPI.BL.Managers.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace E_commerceAPI.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class OrdersController : ControllerBase
    {
        private readonly IOrderManager _orderManager;

        public OrdersController(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }
        [Authorize]
        [HttpPost]
        [Route("AddOrder")]
        public ActionResult AddOrder(List<OrderProductListDTO> orderProductLists)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            if (userId is null)
            {
                return BadRequest("not logged in");
            }
            _orderManager.AddOrder(orderProductLists,userId);

            return Ok("order Added Successfully");    

        }
        [Authorize(Policy = "AdminOnly")]
        [HttpGet]
        [Route("OrderHistory")]

        public ActionResult<IEnumerable<ReadOrderHistoryDTO>> GetOrdersHistory()
        {
          var orderHistoryList=  _orderManager.GetOrderSHistory();
            return orderHistoryList.ToList();

        }





    }
}
