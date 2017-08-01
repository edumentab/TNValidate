/* *********************************************************************************
 * TNValidate Fluent Validation Library
 * https://github.com/edumentab/TNValidate
 * Copyright (C) Edument AB 2010
 * http://www.edument.se
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 * *********************************************************************************/

using System;

namespace TNValidate
{
    /// <summary>
    /// Enumeration of the built-in supported languages.
    /// </summary>
    public enum ValidationLanguageEnum
    {
        /// <summary>
        /// Use default error messages in English
        /// </summary>
        [LanguageResourceFile("TNValidate.Languages.Languages-en.xml")]
        English = 0,
        
        /// <summary>
        /// Use default error messages in Swedish
        /// </summary>
        [LanguageResourceFile("TNValidate.Languages.Languages-sv.xml")]
        Swedish = 1,

        /// <summary>
        /// User default error messages in Brazillian Portuguese
        /// </summary>
        [LanguageResourceFile("TNValidate.Languages.Languages-pt-BR.xml")]
        Portuguese = 2
    }

    /// <summary>
    /// Enumeration for setting whether we want one or many errors per field
    /// to be collected.
    /// </summary>
    public enum ErrorMode
    {
        /// <summary>
        /// Maximum one error per field 
        /// </summary>
        OneErrorPerField,

        /// <summary>
        /// Return all errors found for each field.
        /// </summary>
        AllErrors
    }

    /// <summary>
    /// The various levels of validation failure we can have.
    /// </summary>
    public enum ValidatorResultLevel
    {
        Error,
        Warning
    }

    /// <summary>
    /// Attribute class for setting the language resource file for a langauge.
    /// </summary>
    internal class LanguageResourceFile : Attribute
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="resourceFile"></param>
        public LanguageResourceFile(string resourceFile)
        {
            ResourceFile = resourceFile;
        }
        
        /// <summary>
        /// The name of the langauge resource file
        /// </summary>
        public string ResourceFile { get; private set; }
    }
}