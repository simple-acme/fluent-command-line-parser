﻿using System;

namespace Fclp
{
    /// <summary>
    /// Represents an error that has occurred because a matching Command already exists in the parser.
    /// </summary>
    [Serializable]
    public class CommandAlreadyExistsException : Exception
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="OptionAlreadyExistsException"/> class.
        /// </summary>
        public CommandAlreadyExistsException() { }

        /// <summary>
        /// Initialises a new instance of the <see cref="OptionAlreadyExistsException"/> class.
        /// </summary>
        /// <param name="commandName"></param>
        public CommandAlreadyExistsException(string commandName) : base(commandName) { }

        /// <summary>
        /// Initialises a new instance of the <see cref="OptionAlreadyExistsException"/> class.
        /// </summary>
        /// <param name="commandName"></param>
        /// <param name="innerException"></param>
        public CommandAlreadyExistsException(string commandName, Exception innerException)
            : base(commandName, innerException) { }
    }
}