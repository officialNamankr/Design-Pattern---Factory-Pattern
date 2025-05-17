using FactoryPatternDemo.Factory;
using FactoryPatternDemo.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPatternDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly NotificationFactory _notificationFactory;
        private ResponseDTO _responseDTO;

        public NotificationController(NotificationFactory notificationFactory)
        {
            _notificationFactory = notificationFactory;
            _responseDTO = new ResponseDTO();
        }

        [HttpPost]
        public ResponseDTO SendNotification([FromBody] NotificationRequest request)
        {
            try
            {
                var service = _notificationFactory.CreateNotification(request.Type);
                var res =  service.Send(request.To, request.Message);
                if(res)
                {
                    _responseDTO.IsSuccess = true;
                    _responseDTO.Result = res;
                    _responseDTO.DisplayMessage = "Notification Sent Successfully";
                }
                else
                {
                    _responseDTO.IsSuccess = false;
                    _responseDTO.DisplayMessage = "Failed to send notification";
                }
            }
            catch (Exception ex)
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.ErrorMessages = new List<string> { ex.Message };
                _responseDTO.DisplayMessage = "An error occurred while sending the notification";

            }
            return _responseDTO;
        }
    }
}
