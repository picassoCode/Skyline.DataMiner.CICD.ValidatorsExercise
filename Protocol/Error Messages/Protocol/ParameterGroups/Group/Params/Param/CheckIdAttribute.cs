// <auto-generated>This is auto-generated code by Validator Management Tool. Do not modify.</auto-generated>
namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.ParameterGroups.Group.Params.Param.CheckIdAttribute
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
        public static IValidationResult NonExistingId(IValidate test, IReadable referenceNode, IReadable positionNode, string pid, string parameterGroupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.NonExistingId,
                FullId = "16.6.1",
                Category = Category.ParameterGroup,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Attribute '{0}' references a non-existing '{1}' with {2} '{3}'. {4} {5} '{6}'.", "ParameterGroup/Group/Params/Param@id", "Param", "PID", pid, "ParameterGroup", "ID", parameterGroupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "'ParameterGroups/Group/Params/Param' elements are used to link the alarm status of a DCF interfaces to one of the following types of parameters" + Environment.NewLine + " - Standalone parameter: 'ParameterGroups/Group/Params/Param' element should contain a standalong parameter pid." + Environment.NewLine + " - Table cell: 'ParameterGroups/Group/Params/Param' element should contain a column parameter pid and index attribute should be used to specify the row key.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult DuplicateParamInParameterGroup(IValidate test, IReadable referenceNode, IReadable positionNode, string paramId, string parameterGroupId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckIdAttribute,
                ErrorId = ErrorIds.DuplicateParamInParameterGroup,
                FullId = "16.6.2",
                Category = Category.ParameterGroup,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.Breaking,
                GroupDescription = "",
                Description = String.Format("Duplicate Param '{0}' in ParameterGroup '{1}'.", paramId, parameterGroupId),
                HowToFix = "",
                ExampleCode = "",
                Details = "Make sure the same Param is not added more than once in a ParameterGroup.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint NonExistingId = 1;
        public const uint DuplicateParamInParameterGroup = 2;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckIdAttribute = 6;
    }
}