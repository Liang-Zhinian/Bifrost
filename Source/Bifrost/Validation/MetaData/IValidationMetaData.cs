﻿#region License
//
// Copyright (c) 2008-2014, Dolittle (http://www.dolittle.com)
//
// Licensed under the MIT License (http://opensource.org/licenses/MIT)
//
// You may not use this file except in compliance with the License.
// You may obtain a copy of the license at 
//
//   http://github.com/dolittle/Bifrost/blob/master/MIT-LICENSE.txt
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion
using System;

namespace Bifrost.Validation.MetaData
{
    /// <summary>
    /// Represents a system for retrieving validation metadata
    /// </summary>
    public interface IValidationMetaData
    {
        /// <summary>
        /// Get metadata for a specific type
        /// </summary>
        /// <param name="typeForValidation">The <see cref="Type"/> that will be validated</param>
        /// <returns>The actual metadata</returns>
        TypeMetaData GetMetaDataFor(Type typeForValidation);
    }
}