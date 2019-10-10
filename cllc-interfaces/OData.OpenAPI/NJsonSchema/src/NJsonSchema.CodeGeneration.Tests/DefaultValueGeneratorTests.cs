﻿using NJsonSchema.CodeGeneration.CSharp;
using NJsonSchema.CodeGeneration.TypeScript;
using Xunit;

namespace NJsonSchema.CodeGeneration.Tests
{
    public class DefaultValueGeneratorTests
    {
        private readonly CSharpValueGenerator _csharpGenerator;
        private readonly CSharpTypeResolver _csharpTypeResolver;

        private readonly TypeScriptValueGenerator _typescriptGenerator;
        private readonly TypeScriptGeneratorSettings _typescriptSettings;

        public DefaultValueGeneratorTests()
        {
            var csharpSettings = new CSharpGeneratorSettings();
            _csharpTypeResolver = new CSharpTypeResolver(csharpSettings);
            _csharpGenerator = new CSharpValueGenerator(csharpSettings);

            _typescriptSettings = new TypeScriptGeneratorSettings();
            _typescriptGenerator = new TypeScriptValueGenerator(_typescriptSettings);
        }

        [Fact]
        public void When_schema_has_default_value_of_int_it_is_generated_in_CSharp_and_TypeScript_correctly()
        {
            //// Arrange

            //// Act
            var schema = new JsonSchema4()
            {
                Type = JsonObjectType.Integer,
                Default = (int)6
            };

            var typescriptTypeResolver = new TypeScriptTypeResolver(_typescriptSettings);

            var csharpValue = _csharpGenerator.GetDefaultValue(schema, true, "int", "int", true, _csharpTypeResolver);
            var typescriptValue = _typescriptGenerator.GetDefaultValue(schema, true, "int", "int", true, typescriptTypeResolver);

            //// Assert
            Assert.Equal("6", csharpValue);
            Assert.Equal("6", typescriptValue);
        }

        [Fact]
        public void When_schema_has_default_value_of_long_it_is_generated_in_CSharp_and_TypeScript_correctly()
        {
            //// Arrange

            //// Act
            var schema = new JsonSchema4()
            {
                Type = JsonObjectType.Integer,
                Format = JsonFormatStrings.Long,
                Default = 6000000000L
            };

            var typescriptTypeResolver = new TypeScriptTypeResolver(_typescriptSettings);

            var csharpValue = _csharpGenerator.GetDefaultValue(schema, true, "long", "long", true, _csharpTypeResolver);
            var typescriptValue = _typescriptGenerator.GetDefaultValue(schema, true, "long", "long", true, typescriptTypeResolver);

            //// Assert
            Assert.Equal("6000000000L", csharpValue);
            Assert.Equal("6000000000", typescriptValue);
        }

        [Fact]
        public void When_schema_has_default_value_of_double_it_is_generated_in_CSharp_and_TypeScript_correctly()
        {
            //// Arrange

            //// Act
            var schema = new JsonSchema4()
            {
                Type = JsonObjectType.Number,
                Format = JsonFormatStrings.Double,
                Default = 1234.567F
            };

            var typescriptTypeResolver = new TypeScriptTypeResolver(_typescriptSettings);

            var csharpValue = _csharpGenerator.GetDefaultValue(schema, true, "double", "double", true, _csharpTypeResolver);
            var typescriptValue = _typescriptGenerator.GetDefaultValue(schema, true, "double", "double", true, typescriptTypeResolver);

            //// Assert
            Assert.Equal("1234.567D", csharpValue);
            Assert.Equal("1234.567", typescriptValue);
        }

        [Fact]
        public void When_schema_has_default_value_of_double_without_format_it_is_generated_in_CSharp_and_TypeScript_correctly()
        {
            //// Arrange

            //// Act
            var schema = new JsonSchema4()
            {
                Type = JsonObjectType.Number,
                Default = 1234.567F
            };

            var typescriptTypeResolver = new TypeScriptTypeResolver(_typescriptSettings);

            var csharpValue = _csharpGenerator.GetDefaultValue(schema, true, "double", "double", true, _csharpTypeResolver);
            var typescriptValue = _typescriptGenerator.GetDefaultValue(schema, true, "double", "double", true, typescriptTypeResolver);

            //// Assert
            Assert.Equal("1234.567D", csharpValue);
            Assert.Equal("1234.567", typescriptValue);
        }

        [Fact]
        public void When_schema_has_default_value_of_float_it_is_generated_in_CSharp_and_TypeScript_correctly()
        {
            //// Arrange

            //// Act
            var schema = new JsonSchema4()
            {
                Type = JsonObjectType.Number,
                Format = JsonFormatStrings.Float,
                Default = 1234.567F
            };

            var typescriptTypeResolver = new TypeScriptTypeResolver(_typescriptSettings);

            var csharpValue = _csharpGenerator.GetDefaultValue(schema, true, "float", "float", true, _csharpTypeResolver);
            var typescriptValue = _typescriptGenerator.GetDefaultValue(schema, true, "float", "float", true, typescriptTypeResolver);

            //// Assert
            Assert.Equal("1234.567F", csharpValue);
            Assert.Equal("1234.567", typescriptValue);
        }

        [Fact]
        public void When_schema_has_default_value_of_bool_it_is_generated_in_CSharp_and_TypeScript_correctly()
        {
            //// Arrange

            //// Act
            var schema = new JsonSchema4()
            {
                Type = JsonObjectType.Boolean,
                Default = true
            };

            var typescriptTypeResolver = new TypeScriptTypeResolver(_typescriptSettings);

            var csharpValue = _csharpGenerator.GetDefaultValue(schema, true, "bool", "bool", true, _csharpTypeResolver);
            var typescriptValue = _typescriptGenerator.GetDefaultValue(schema, true, "bool", "bool", true, typescriptTypeResolver);

            //// Assert
            Assert.Equal("true", csharpValue);
            Assert.Equal("true", typescriptValue);
        }

        [Fact]
        public void When_schema_has_default_value_of_string_it_is_generated_in_CSharp_and_TypeScript_correctly()
        {
            //// Arrange

            //// Act
            var schema = new JsonSchema4()
            {
                Type = JsonObjectType.String,
                Default = "test\\test\"test\r\ntest"
            };

            var typescriptTypeResolver = new TypeScriptTypeResolver(_typescriptSettings);

            var csharpValue = _csharpGenerator.GetDefaultValue(schema, true, "string", "string", true, _csharpTypeResolver);
            var typescriptValue = _typescriptGenerator.GetDefaultValue(schema, true, "string", "string", true, typescriptTypeResolver);

            //// Assert
            Assert.Equal("\"test\\\\test\\\"test\\r\\ntest\"", csharpValue);
            Assert.Equal("\"test\\\\test\\\"test\\r\\ntest\"", typescriptValue);
        }

        public class MyEnumNameGenerator : IEnumNameGenerator
        {
            public string Generate(int index, string name, object value, JsonSchema4 schema)
            {
                return name.ToLowerInvariant();
            }
        }

        [Fact]
        public void When_schema_has_default_value_of_enum_it_is_generated_in_CSharp_and_TypeScript_correctly()
        {
            //// Arrange
            var csharpSettings = new CSharpGeneratorSettings { EnumNameGenerator = new MyEnumNameGenerator(), Namespace = "Ns" };
            var csharpGenerator = new CSharpValueGenerator(csharpSettings);
            var csharpTypeResolver = new CSharpTypeResolver(csharpSettings);

            //// Act
            var schema = new JsonSchema4()
            {
                Type = JsonObjectType.String,
                Enumeration =
                {
                    "Foo",
                    "Bar"
                },
                Default = "Bar"
            };

            var typescriptSettings = new TypeScriptGeneratorSettings { EnumNameGenerator = new MyEnumNameGenerator() };
            var typescriptGenerator = new TypeScriptValueGenerator(typescriptSettings);
            var typescriptTypeResolver = new TypeScriptTypeResolver(typescriptSettings);

            var csharpValue = csharpGenerator.GetDefaultValue(schema, true, "MyEnum", "MyEnum", true, csharpTypeResolver);
            var typescriptValue = typescriptGenerator.GetDefaultValue(schema, true, "MyEnum", "MyEnum", true, typescriptTypeResolver);

            //// Assert
            Assert.Equal("Ns.MyEnum.bar", csharpValue);
            Assert.Equal("MyEnum.bar", typescriptValue);
        }
    }
}