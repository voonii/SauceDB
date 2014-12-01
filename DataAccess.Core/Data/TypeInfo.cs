﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DataAccess.Core.Data
{
    /// <summary>
    /// Resolved type information
    /// </summary>
    [Serializable]
    public class TypeInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeInfo" /> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public TypeInfo(Type type)
        {
            DataType = type;
        }


        private List<DataFieldInfo> _pKeys;

        /// <summary>
        /// The type this is for
        /// </summary>
        public Type DataType { get; private set; }

        /// <summary>
        /// The Table name
        /// </summary>
        public string UnescapedTableName { get; set; }

        /// <summary>
        /// The resolved table name (escaped)
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Should this type be validated against the data store
        /// </summary>
        public bool BypassValidation { get; set; }

        /// <summary>
        /// The schema this table belongs to (escaped)
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// The schema this table belongs to
        /// </summary>
        public string UnEscapedSchema { get; set; }

        /// <summary>
        /// The fields on this type (non ignored only)
        /// </summary>
        public List<DataFieldInfo> DataFields { get; set; }

        /// <summary>
        /// Additional init functions
        /// </summary>
        public List<AdditionalInitFunction> AdditionalInit { get; set; }

        /// <summary>
        /// These functions will be called when a table is created
        /// </summary>
        public List<AdditionalInitFunction> OnTableCreate { get; set; }

        /// <summary>
        /// These functions should be called when a query is ran
        /// </summary>
        public QueryPredicateFunction QueryPredicate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance represents a view.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is view; otherwise, <c>false</c>.
        /// </value>
        public bool IsView { get; set; }

        /// <summary>
        /// True if the type was generated by the compiler
        /// </summary>
        public bool IsCompilerGenerated { get; set; }

        /// <summary>
        /// The primary keys for this type
        /// </summary>
        public List<DataFieldInfo> PrimaryKeys
        {
            get
            {
                if (_pKeys == null)
                    _pKeys = DataFields.Where(R => R.PrimaryKey).ToList();

                return _pKeys;
            }
        }

        /// <summary>
        /// The SQL select list, a performance enhancement
        /// </summary>
        public string SelectString { get; set; }

        /// <summary>
        /// Represents a dynamic type
        /// </summary>
        public bool IsDynamic { get; set; }
    }
}
