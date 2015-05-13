﻿// 
// Copyright (c) Microsoft.  All rights reserved. 
// 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
//   http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License. 
// 

namespace Microsoft.Azure.Search.Models
{
    /// <summary>
    /// Abstract base class for a result containing a document found by a suggestion query, plus associated metadata.
    /// </summary>
    /// <typeparam name="T">
    /// The CLR type that maps to the index schema. Instances of this type can be stored as documents in the index.
    /// </typeparam>
    public abstract class SuggestResultBase<T> where T : class
    {
        /// <summary>
        /// Initializes a new instance of the SuggestResultBase class.
        /// </summary>
        protected SuggestResultBase()
        {
            // Do nothing.
        }

        /// <summary>
        /// Gets the text of the suggestion result.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets the document on which the suggested text is based.
        /// </summary>
        public T Document { get; set; }
    }
}
