// <auto-generated>This is auto-generated code by Validator Management Tool. Do not modify.</auto-generated>
namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Interprete.DefaultValue.CheckDefaultValueTag
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        public static IValidationResult UnsupportedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDefaultValueTag,
                ErrorId = ErrorIds.UnsupportedTag,
                FullId = "2.68.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported tag '{0}' in {1} '{2}'.", "DefaultValue", "Param", paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Interprete/DefaultValue tag allows to give a default value to a parameter." + Environment.NewLine + "This is currently only supported on standalone read parameters and the given value should be compatible with the Inteprete/Type.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NotYetSupportedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string columnPid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDefaultValueTag,
                ErrorId = ErrorIds.NotYetSupportedTag,
                FullId = "2.68.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Unsupported tag '{0}' in {1} '{2}'.", "DefaultValue", "Column", columnPid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Interprete/DefaultValue tag allows to give a default value to a parameter." + Environment.NewLine + "This is currently only supported on standalone read parameters and the given value should be compatible with the Inteprete/Type.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult ValueIncompatibleWithInterpreteType(IValidate test, IReadable referenceNode, IReadable positionNode, string defaultValue, string interpreteType, string pid)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDefaultValueTag,
                ErrorId = ErrorIds.ValueIncompatibleWithInterpreteType,
                FullId = "2.68.3",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Interprete/DefaultValue '{0}' is incompatible with Interprete/Type '{1}'. Param ID '{2}'.", defaultValue, interpreteType, pid),
                HowToFix = "",
                ExampleCode = "",
                Details = "Interprete/DefaultValue tag allows to give a default value to a parameter." + Environment.NewLine + "This is currently only supported on standalone read parameters and the given value should be compatible with the Inteprete/Type.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint UnsupportedTag = 1;
        public const uint NotYetSupportedTag = 2;
        public const uint ValueIncompatibleWithInterpreteType = 3;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckDefaultValueTag = 68;
    }
}