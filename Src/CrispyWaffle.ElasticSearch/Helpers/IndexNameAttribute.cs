﻿// ***********************************************************************
// Assembly         : CrispyWaffle.ElasticSearch
// Author           : Guilherme Branco Stracini
// Created          : 10/09/2022
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 10/09/2022
// ***********************************************************************
// <copyright file="IndexNameAttribute.cs" company="Guilherme Branco Stracini ME">
//     © 2022 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace CrispyWaffle.ElasticSearch.Helpers
{
    /// <summary>
    /// The index name attribute.
    /// </summary>
    /// <seealso cref="Attribute" />
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class IndexNameAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexNameAttribute" /> class.
        /// </summary>
        /// <param name="indexName">Name of the index.</param>
        public IndexNameAttribute(string indexName) => IndexName = indexName;

        /// <summary>
        /// Gets the name of the index.
        /// </summary>
        /// <value>The name of the index.</value>
        public string IndexName { get; }
    }
}
