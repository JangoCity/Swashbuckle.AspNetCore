﻿using System;
using System.Collections.Generic;
using Swashbuckle.Swagger.Model;

namespace Swashbuckle.SwaggerGen.Generator
{
    public class SchemaRegistryOptions
    {
        public SchemaRegistryOptions()
        {
            CustomTypeMappings = new Dictionary<Type, Func<Schema>>();
            SchemaIdSelector = (type) => type.FriendlyId(false);
            SchemaFilters = new List<ISchemaFilter>();
        }

        public IDictionary<Type, Func<Schema>> CustomTypeMappings { get; private set; }

        public bool DescribeAllEnumsAsStrings { get; set; }

        public bool DescribeStringEnumsInCamelCase { get; set; }

        public Func<Type, string> SchemaIdSelector { get; set; }

        public bool IgnoreObsoleteProperties { get; set; }

        public IList<ISchemaFilter> SchemaFilters { get; private set; }

        internal SchemaRegistryOptions Clone()
        {
            return new SchemaRegistryOptions
            {
                CustomTypeMappings = CustomTypeMappings,
                DescribeAllEnumsAsStrings = DescribeAllEnumsAsStrings,
                DescribeStringEnumsInCamelCase = DescribeStringEnumsInCamelCase,
                IgnoreObsoleteProperties = IgnoreObsoleteProperties,
                SchemaIdSelector = SchemaIdSelector,
                SchemaFilters = SchemaFilters
            };
        }
    }
}