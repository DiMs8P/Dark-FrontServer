using System.Collections;
using DarkFront_Server.DTOs;

namespace DarkFront_Server.Services
{
    public class PlayerMotionService
    {
        private readonly Dictionary<string, PlayerMotion> _playerMotions = new ();

        public void UpdatePlayerState(PlayerMotion request)
        {
            string playerName = request.PlayerName;
            if (!_playerMotions.TryAdd(playerName, request))
            {
                _playerMotions[playerName].Motion = request.Motion;
            }
        }

        public PlayerMotionList GetPlayersNearMe(string playerName)
        {
            PlayerMotionList playerMotionList = new PlayerMotionList();
            List<PlayerMotion> playersNearMe = new List<PlayerMotion>();

            foreach (KeyValuePair<string, PlayerMotion> playerMotion in _playerMotions)
            {
                if (playerMotion.Key != playerName)
                {
                    playersNearMe.Add(playerMotion.Value);
                }
            }

            playerMotionList.PlayerMotions = playersNearMe.ToArray();
            return playerMotionList;
        }
    }
}
