﻿#region License
// OptionSyntaxParseError.cs
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

using Fclp.Internals.Parsing;
using System;

namespace Fclp.Internals.Errors
{
    /// <summary>
    /// Represents a parse error that has occurred because the syntax was in an unexpected format.
    /// </summary>
    /// <remarks>
    /// Initialises a new instance of the <see cref="CommandLineParserErrorBase"/> class.
    /// </remarks>
    /// <param name="cmdOption">The <see cref="ICommandLineOption"/> this error relates too. This must not be <c>null</c>.</param>
    /// <param name="parsedOption">The parsed option that caused the error.</param>
    /// <exception cref="ArgumentNullException">If <paramref name="cmdOption"/> is <c>null</c>.</exception>
    public class OptionSyntaxParseError(ICommandLineOption cmdOption, ParsedOption parsedOption) : CommandLineParserErrorBase(cmdOption)
    {
        /// <summary>
        /// Gets the parsed option that caused the error.
        /// </summary>
        public ParsedOption ParsedOption { get; private set; } = parsedOption;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Initialises a new instance of the <see cref="CommandLineParserErrorBase"/> class.
    /// </remarks>
    /// <param name="cmdOption">The <see cref="ICommandLineOption"/> this error relates too. This must not be <c>null</c>.</param>
    /// <exception cref="ArgumentNullException">If <paramref name="cmdOption"/> is <c>null</c>.</exception>
    public class UnexpectedValueParseError(ICommandLineOption cmdOption) : CommandLineParserErrorBase(cmdOption)
    {
    }
}
