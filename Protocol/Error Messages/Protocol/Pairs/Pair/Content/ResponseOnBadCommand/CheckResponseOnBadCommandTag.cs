// <auto-generated>This is auto-generated code by Validator Management Tool. Do not modify.</auto-generated>
namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Pairs.Pair.Content.ResponseOnBadCommand.CheckResponseOnBadCommandTag
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
        public static IValidationResult EmptyTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pairId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckResponseOnBadCommandTag,
                ErrorId = ErrorIds.EmptyTag,
                FullId = "9.6.2",
                Category = Category.Pair,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Empty tag '{0}' in {1} '{2}'.", "Content/ResponseOnBadCommand", "Pair", pairId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of a pairs can contain maximum one ResponseOnBadCommand tag." + Environment.NewLine + "It should have as value an unsigned number and refer to the id of an existing Response." + Environment.NewLine + "A given pair can't refer to the same Response more than once (including both Response and ResponseOnBadCommand tags)." + Environment.NewLine + "" + Environment.NewLine + "Also note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UntrimmedTag(IValidate test, IReadable referenceNode, IReadable positionNode, string pairId, string untrimmedValue)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckResponseOnBadCommandTag,
                ErrorId = ErrorIds.UntrimmedTag,
                FullId = "9.6.3",
                Category = Category.Pair,
                Severity = Severity.Warning,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Untrimmed tag '{0}' in {1} '{2}'. Current value '{3}'.", "Content/ResponseOnBadCommand", "Pair", pairId, untrimmedValue),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of a pairs can contain maximum one ResponseOnBadCommand tag." + Environment.NewLine + "It should have as value an unsigned number and refer to the id of an existing Response." + Environment.NewLine + "A given pair can't refer to the same Response more than once (including both Response and ResponseOnBadCommand tags)." + Environment.NewLine + "" + Environment.NewLine + "Also note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = true,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult InvalidValue(IValidate test, IReadable referenceNode, IReadable positionNode, string tagValue, string pairId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckResponseOnBadCommandTag,
                ErrorId = ErrorIds.InvalidValue,
                FullId = "9.6.4",
                Category = Category.Pair,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Invalid value '{0}' in tag '{1}'. {2} {4} '{3}'.", tagValue, "Content/ResponseOnBadCommand", "Pair", pairId, "ID"),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of a pairs can contain maximum one ResponseOnBadCommand tag." + Environment.NewLine + "It should have as value an unsigned number and refer to the id of an existing Response." + Environment.NewLine + "A given pair can't refer to the same Response more than once (including both Response and ResponseOnBadCommand tags)." + Environment.NewLine + "" + Environment.NewLine + "Also note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string responseId, string pairId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckResponseOnBadCommandTag,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "9.6.5",
                Category = Category.Pair,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Tag '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "Content/ResponseOnBadCommand", "Response", "ID", responseId, "Pair", "ID", pairId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The Content tag of a pairs can contain maximum one ResponseOnBadCommand tag." + Environment.NewLine + "It should have as value an unsigned number and refer to the id of an existing Response." + Environment.NewLine + "A given pair can't refer to the same Response more than once (including both Response and ResponseOnBadCommand tags)." + Environment.NewLine + "" + Environment.NewLine + "Also note that only plain numbers are allowed (no leading signs, no leading zeros, no scientific notation, etc).",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint EmptyTag = 2;
        public const uint UntrimmedTag = 3;
        public const uint InvalidValue = 4;
        public const uint NonExistingId = 5;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckResponseOnBadCommandTag = 6;
    }
}