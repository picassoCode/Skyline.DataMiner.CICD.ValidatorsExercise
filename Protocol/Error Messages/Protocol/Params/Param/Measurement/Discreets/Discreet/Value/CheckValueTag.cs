// <auto-generated>This is auto-generated code by Validator Management Tool. Do not modify.</auto-generated>
namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Measurement.Discreets.Discreet.Value.CheckValueTag
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;


    internal static class ErrorCompare
    {
        public static IValidationResult UpdatedValue(IReadable referenceNode, IReadable positionNode, string displayValue, string paramId, string previousValue, string newValue)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckValueTag,
                ErrorId = ErrorIds.UpdatedValue,
                FullId = "2.12.1",
                Category = Category.Param,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Discreet value tag with display '{0}' on Param '{1}' was changed from '{2}' into '{3}'.", displayValue, paramId, previousValue, newValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult RemovedItem(IReadable referenceNode, IReadable positionNode, string discreetValue, string paramId)
        {
            return new ValidationResult
            {
                Test = null,
                CheckId = CheckId.CheckValueTag,
                ErrorId = ErrorIds.RemovedItem,
                FullId = "2.12.2",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.MajorChangeChecker,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Discreet tag with value '{0}' on Param '{1}' was removed.", discreetValue, paramId),
                HowToFix = "",
                ExampleCode = "",
                Details = "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint UpdatedValue = 1;
        public const uint RemovedItem = 2;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckValueTag = 12;
    }
}