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
    /// A Data Lake Analytics catalog U-SQL external datasource item.
    /// </summary>
    public partial class USqlExternalDataSource
    {
        /// <summary>
        /// Initializes a new instance of the USqlExternalDataSource class.
        /// </summary>
        public USqlExternalDataSource() { }

        /// <summary>
        /// Initializes a new instance of the USqlExternalDataSource class.
        /// </summary>
        public USqlExternalDataSource(string databaseName = default(string), string externalDataSourceName = default(string), string provider = default(string), string providerString = default(string), IList<string> pushdownTypes = default(IList<string>), string computeAccountName = default(string), string version = default(string))
        {
            DatabaseName = databaseName;
            ExternalDataSourceName = externalDataSourceName;
            Provider = provider;
            ProviderString = providerString;
            PushdownTypes = pushdownTypes;
            ComputeAccountName = computeAccountName;
            Version = version;
        }

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the external data source.
        /// </summary>
        [JsonProperty(PropertyName = "externalDataSourceName")]
        public string ExternalDataSourceName { get; set; }

        /// <summary>
        /// Gets or sets the name of the provider for the external data source.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the name of the provider string for the external data
        /// source.
        /// </summary>
        [JsonProperty(PropertyName = "providerString")]
        public string ProviderString { get; set; }

        /// <summary>
        /// Gets or sets the list of types to push down from the external data
        /// source.
        /// </summary>
        [JsonProperty(PropertyName = "pushdownTypes")]
        public IList<string> PushdownTypes { get; set; }

        /// <summary>
        /// Gets or sets the name of the Data Lake Analytics account.
        /// </summary>
        [JsonProperty(PropertyName = "computeAccountName")]
        public string ComputeAccountName { get; set; }

        /// <summary>
        /// Gets or sets the version of the catalog item.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
