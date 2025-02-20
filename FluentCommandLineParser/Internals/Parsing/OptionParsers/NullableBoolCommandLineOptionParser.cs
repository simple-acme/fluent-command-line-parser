#region License
// NullableBoolCommandLineOptionParser.cs
// Copyright (c) 2016, Simon Williams
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

namespace Fclp.Internals.Parsing.OptionParsers
{
    /// <summary>
    /// Parser used to convert to nullable types
    /// </summary>
    /// <remarks>
    /// Initialises a new instance of the <see cref="NullableCommandLineOptionParser{TType}"/>.
    /// </remarks>
    /// <param name="parserFactory"></param>
    public class NullableBoolCommandLineOptionParser(ICommandLineOptionParserFactory parserFactory) : ICommandLineOptionParser<bool?>
    {

        /// <summary>
        /// Parses the specified <see cref="ParsedOption"/> into a nullable type.
        /// </summary>
        public bool? Parse(ParsedOption parsedOption)
        {
            var parser = parserFactory.CreateParser<bool>();
            if (parser.CanParse(parsedOption) == false)
            {
                return null;
            }

            return parser.Parse(parsedOption);
        }

        /// <summary>
        /// Determines whether the specified <see cref="ParsedOption"/> can be parsed by this <see cref="ICommandLineOptionParser{T}"/>.
        /// </summary>
        public bool CanParse(ParsedOption parsedOption) => true;
    }
}