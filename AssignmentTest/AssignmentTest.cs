using System;

namespace Namespace
{

    /// <summary>
    /// Represents a robot with navigation capabilities.
    /// </summary>
    public class Robot
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Robot"/> class with the default number of commands (6).
        /// </summary>
        public Robot()
        {
            NumCommands = 6;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Robot"/> class with the specified number of commands.
        /// </summary>
        /// <param name="numCommands">The number of commands the robot can execute.</param>
        public Robot(int numCommands)
        {
            NumCommands = numCommands;
        }

        /// <summary>
        /// Gets or sets the number of commands the robot can execute.
        /// </summary>
        public int NumCommands { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the robot is powered on or off.
        /// </summary>
        public bool IsPowered { get; set; }

        /// <summary>
        /// Gets or sets the X-coordinate of the robot's position.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y-coordinate of the robot's position.
        /// </summary>
        public int Y { get; set; }
    }
}