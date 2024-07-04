using DarkFront_Server.DTOs;
using DarkFront_Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace DarkFront_Server.Controllers
{
    [ApiController]
    [Route("player")]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerMotionService _playerMotionService;
        public PlayerController(PlayerMotionService playerMotionService)
        {
            _playerMotionService = playerMotionService;
        }

        [HttpPost("update-motion")]
        public ActionResult<PlayerMotionList> UpdatePlayerLocation([FromBody] PlayerMotion playerMotionRequest)
        {
            if (playerMotionRequest is null)
            {
                return BadRequest("Invalid request");
            }

            _playerMotionService.UpdatePlayerState(playerMotionRequest);
            return Ok(_playerMotionService.GetPlayersNearMe(playerMotionRequest.PlayerName));
        }
    }
}
