// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Data Lake Store account information.
    /// </summary>
    public partial class DataLakeStoreAccountInfo
    {
        /// <summary>
        /// Initializes a new instance of the DataLakeStoreAccountInfo class.
        /// </summary>
        public DataLakeStoreAccountInfo() { }

        /// <summary>
        /// Initializes a new instance of the DataLakeStoreAccountInfo class.
        /// </summary>
        public DataLakeStoreAccountInfo(string name = default(string), DataLakeStoreAccountInfoProperties properties = default(DataLakeStoreAccountInfoProperties))
        {
            Name = name;
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the account name of the Data Lake Store account.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the properties associated with this Data Lake Store
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DataLakeStoreAccountInfoProperties Properties { get; set; }

    }
}
