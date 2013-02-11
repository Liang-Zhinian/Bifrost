﻿#region License
//
// Copyright (c) 2008-2012, DoLittle Studios AS and Komplett ASA
//
// Licensed under the Microsoft Permissive License (Ms-PL), Version 1.1 (the "License")
// With one exception :
//   Commercial libraries that is based partly or fully on Bifrost and is sold commercially, 
//   must obtain a commercial license.
//
// You may not use this file except in compliance with the License.
// You may obtain a copy of the license at 
//
//   http://bifrost.codeplex.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion
using System.Collections.Generic;
using System.IO;

namespace Bifrost.CodeGeneration
{
    /// <summary>
    /// Represents an abstract of a <see cref="ILanguageElement"/>
    /// </summary>
    public abstract class LanguageElement : ILanguageElement
    {
        /// <summary>
        /// Gets the <see cref="ILanguageElement">children</see>
        /// </summary>
        protected List<ILanguageElement> Children { get; private set; }

        /// <summary>
        /// Initializes a new instance of <see cref="LanguageElement"/>
        /// </summary>
        protected LanguageElement()
        {
            Children = new List<ILanguageElement>();
        }

#pragma warning disable 1591
        public ILanguageElement Parent { get; set; }
        public abstract void Write(ICodeWriter writer);

        public void AddChild(ILanguageElement element)
        {
            element.Parent = this;
            Children.Add(element);
        }

#pragma warning restore 1591

        /// <summary>
        /// Write all children to the given <see cref="ICodeWriter"/>
        /// </summary>
        /// <param name="writer"><see cref="ICodeWriter"/> to use for writing the children</param>
        protected void WriteChildren(ICodeWriter writer)
        {
            foreach (var child in Children)
                child.Write(writer);
        }

    }
}