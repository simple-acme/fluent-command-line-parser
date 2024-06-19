﻿#region License
// ParserEngineResult.cs
// Copyright (c) 2013, Simon Williams
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provide
// d that the following conditions are met:
// 
// Redistributions of source code must retain the above copyright notice, this list of conditions and the
// following disclaimer.
// 
// Redistributions in binary form must reproduce the above copyright notice, this list of conditions and
// the following disclaimer in the documentation and/or other materials provided with the distribution.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED 
// WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED
// TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE.
#endregion

using Fclp.Internals.Extensions;
using System.Collections.Generic;

namespace Fclp.Internals.Parsing
{
    /// <summary>
    /// Contains the results of the parse operation
    /// </summary>
    /// <remarks>
    /// Initialises a new instance of the <see cref="ParserEngineResult"/> class;
    /// </remarks>
    /// <param name="parsedOptions">The parsed options.</param>
    /// <param name="additionalValues">Any additional values that could not be translated into options.</param>
    /// <param name="command">The command found during parsing.</param>
    public class ParserEngineResult(IEnumerable<ParsedOption> parsedOptions, IEnumerable<string> additionalValues, string command)
    {

        /// <summary>
        /// Gets the command used.
        /// </summary>
        public string Command { get; private set; } = command;

        /// <summary>
        /// Gets whether the results contained a command
        /// </summary>
        public bool HasCommand => Command.IsNullOrWhiteSpace() == false;

        /// <summary>
        /// Gets the parsed options.
        /// </summary>
        public IEnumerable<ParsedOption> ParsedOptions { get; private set; } = parsedOptions ?? [];

        /// <summary>
        /// Gets any additional values that could not be translated into options.
        /// </summary>
        public IEnumerable<string> AdditionalValues { get; private set; } = additionalValues ?? [];
    }
}