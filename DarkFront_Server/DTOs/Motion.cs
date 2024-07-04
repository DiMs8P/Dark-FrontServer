using System.ComponentModel.DataAnnotations;

namespace DarkFront_Server.DTOs
{
    public class Motion
    {
        // Position
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        // Rotation
        public int Pitch { get; set; }

        public int Roll { get; set; }

        public int Yaw { get; set; }

        // Velocity
        public int Vx { get; set; }

        public int Vy { get; set; }

        public int Vz { get; set; }
    }
}
