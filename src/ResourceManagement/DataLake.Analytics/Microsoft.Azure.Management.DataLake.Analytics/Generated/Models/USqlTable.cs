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
    /// A Data Lake Analytics catalog U-SQL table item.
    /// </summary>
    public partial class USqlTable
    {
        /// <summary>
        /// Initializes a new instance of the USqlTable class.
        /// </summary>
        public USqlTable() { }

        /// <summary>
        /// Initializes a new instance of the USqlTable class.
        /// </summary>
        public USqlTable(string databaseName = default(string), string schemaName = default(string), string tableName = default(string), IList<USqlTableColumn> columnList = default(IList<USqlTableColumn>), IList<USqlIndex> indexList = default(IList<USqlIndex>), IList<string> partitionKeyList = default(IList<string>), ExternalTable externalTable = default(ExternalTable), string computeAccountName = default(string), string version = default(string))
        {
            DatabaseName = databaseName;
            SchemaName = schemaName;
            TableName = tableName;
            ColumnList = columnList;
            IndexList = indexList;
            PartitionKeyList = partitionKeyList;
            ExternalTable = externalTable;
            ComputeAccountName = computeAccountName;
            Version = version;
        }

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the schema associated with this table and
        /// database.
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        [JsonProperty(PropertyName = "tableName")]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the list of columns in this table
        /// </summary>
        [JsonProperty(PropertyName = "columnList")]
        public IList<USqlTableColumn> ColumnList { get; set; }

        /// <summary>
        /// Gets or sets the list of indices in this table
        /// </summary>
        [JsonProperty(PropertyName = "indexList")]
        public IList<USqlIndex> IndexList { get; set; }

        /// <summary>
        /// Gets or sets the list of partition keys in the table
        /// </summary>
        [JsonProperty(PropertyName = "partitionKeyList")]
        public IList<string> PartitionKeyList { get; set; }

        /// <summary>
        /// Gets or sets the external table associated with the table.
        /// </summary>
        [JsonProperty(PropertyName = "externalTable")]
        public ExternalTable ExternalTable { get; set; }

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
