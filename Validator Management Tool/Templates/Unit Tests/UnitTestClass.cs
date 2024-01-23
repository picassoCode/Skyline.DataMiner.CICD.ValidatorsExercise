﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Validator_Management_Tool.Templates.Unit_Tests
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class UnitTestClass : UnitTestClassBase
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("namespace ProtocolTests.");
            this.Write(this.ToStringHelper.ToStringWithCulture(@namespace));
            this.Write(@"
{
    using System;
    using System.Collections.Generic;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Protocol.Tests.");
            this.Write(this.ToStringHelper.ToStringWithCulture(@namespace));
            this.Write(";\r\n\r\n");
 if(validateChecks.Count > 0){ 
            this.Write("    [TestClass]\r\n    public class Validate\r\n    {\r\n        private readonly IVali" +
                    "date check = new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write("();\r\n\r\n        #region Valid Checks\r\n\r\n        [TestMethod]\r\n        [Ignore]\r\n  " +
                    "      public void ");
            this.Write(this.ToStringHelper.ToStringWithCulture(validateChecks[0].check.Category));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write(@"_Valid()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Valid,
                FileName = ""Valid"",
                ExpectedResults = new List<IValidationResult>()
            };

            Generic.Validate(check, data);
        }

        #endregion

        #region Invalid Checks
");
 foreach (var (hasArgs, args, _, check) in validateChecks) { 
            this.Write("\r\n        [TestMethod]\r\n        [Ignore]\r\n        public void ");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Category));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("()\r\n        {\r\n            Generic.ValidateData data = new Generic.ValidateData\r\n" +
                    "            {\r\n                TestType = Generic.TestType.Invalid,\r\n           " +
                    "     FileName = \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("\",\r\n                ExpectedResults = new List<IValidationResult>\r\n              " +
                    "  {\r\n");
 if (hasArgs) {
            this.Write("                    //Error.");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("(null, null, null, ");
            this.Write(this.ToStringHelper.ToStringWithCulture(args));
            this.Write("),\r\n");
 } else { 
            this.Write("                    //Error.");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("(null, null, null),\r\n");
 } 
            this.Write("                }\r\n            };\r\n\r\n            Generic.Validate(check, data);\r\n" +
                    "        }\r\n");
 } 
            this.Write("\r\n        #endregion\r\n    }\r\n\r\n");
 } 
 if(compareChecks.Count > 0){ 
            this.Write("    [TestClass]\r\n    public class Compare\r\n    {\r\n        private readonly ICompa" +
                    "re check = new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write("();\r\n        \r\n        #region Valid Checks\r\n\r\n        [TestMethod]\r\n        [Ign" +
                    "ore]\r\n        public void ");
            this.Write(this.ToStringHelper.ToStringWithCulture(compareChecks[0].check.Category));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write(@"_Valid()
        {
            Generic.CompareData data = new Generic.CompareData
            {
                TestType = Generic.TestType.Valid,
                FileNameBase = ""Valid"",
                ExpectedResults = new List<IValidationResult>()
            };

            Generic.Compare(check, data);
        }

        #endregion

        #region Invalid Checks
");
 foreach (var (hasArgs, args, _, check) in compareChecks) { 
            this.Write("\r\n        [TestMethod]\r\n        [Ignore]\r\n        public void ");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Category));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("()\r\n        {\r\n            Generic.CompareData data = new Generic.CompareData\r\n  " +
                    "          {\r\n                TestType = Generic.TestType.Invalid,\r\n             " +
                    "   FileNameBase = \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("\",\r\n                ExpectedResults = new List<IValidationResult>\r\n              " +
                    "  {\r\n");
 if (hasArgs) {
            this.Write("                    //ErrorCompare.");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("(null, null, ");
            this.Write(this.ToStringHelper.ToStringWithCulture(args));
            this.Write("),\r\n");
 } else { 
            this.Write("                    //ErrorCompare.");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("(null, null),\r\n");
 } 
            this.Write("                }\r\n            };\r\n\r\n            Generic.Compare(check, data);\r\n " +
                    "       }\r\n");
 } 
            this.Write("\r\n        #endregion\r\n    }\r\n\r\n");
 } 
 if(codefixes.Count > 0){ 
            this.Write("    [TestClass]\r\n    public class CodeFix\r\n    {\r\n        private readonly ICodeF" +
                    "ix check = new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write("();\r\n");
 foreach (var check in codefixes) { 
            this.Write("\r\n        [TestMethod]\r\n        [Ignore]\r\n        public void ");
            this.Write(this.ToStringHelper.ToStringWithCulture(codefixes[0].Category));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("()\r\n        {\r\n            Generic.FixData data = new Generic.FixData\r\n          " +
                    "  {\r\n                FileNameBase = \"");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("\",\r\n            };\r\n\r\n            Generic.Fix(check, data);\r\n        }\r\n");
 } 
            this.Write("    }\r\n\r\n");
 } 
 if(allChecks.Count > 0){ 
            this.Write("    [TestClass]\r\n    public class ErrorMessages\r\n    {\r\n");
 for (int i = 0; i < validateChecks.Count;i++) {
var (hasArgs, args, props, check) = validateChecks[i];
if (i != 0){

            this.Write("\r\n");

}

            this.Write("        [TestMethod]\r\n        [Ignore]\r\n        public void ");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Category));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("()\r\n        {\r\n            // Create ErrorMessage\r\n            ");
 if (hasArgs) {
            this.Write("var message = Error.");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("(null, null, null, ");
            this.Write(this.ToStringHelper.ToStringWithCulture(args));
            this.Write(");\r\n            ");
 } else { 
            this.Write("var message = Error.");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("(null, null, null);\r\n            ");
 } 
            this.Write("            \r\n            var expected = new ValidationResult\r\n            {\r\n");
 foreach(var property in props)
{
    if (ExcludedProperties.Contains(property.Key)) continue;

            this.Write("                ");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Key));
            this.Write(" = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Value));
            this.Write(",\r\n");
 } 
            this.Write("            };\r\n\r\n            // Assert\r\n            message.Should().BeEquivalen" +
                    "tTo(expected, Generic.ExcludePropertiesForErrorMessages);\r\n        }\r\n");
 } 
 for (int i = 0; i < compareChecks.Count;i++) {
var (hasArgs, args, props, check) = compareChecks[i];
if (i != 0 || validateChecks.Count > 0){

            this.Write("\r\n");

}

            this.Write("        [TestMethod]\r\n        [Ignore]\r\n        public void ");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Category));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("()\r\n        {\r\n            // Create ErrorMessage\r\n            ");
 if (hasArgs) {
            this.Write("var message = ErrorCompare.");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("(null, null, ");
            this.Write(this.ToStringHelper.ToStringWithCulture(args));
            this.Write(");\r\n            ");
 } else { 
            this.Write("var message = ErrorCompare.");
            this.Write(this.ToStringHelper.ToStringWithCulture(check.Name));
            this.Write("(null, null);\r\n            ");
 } 
            this.Write("            \r\n            var expected = new ValidationResult()\r\n            {\r\n");
 foreach(var property in props)
{ 
            this.Write("                ");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Key));
            this.Write(" = ");
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Value));
            this.Write(",\r\n");
 } 
            this.Write("            };\r\n\r\n            // Assert\r\n            message.Should().BeEquivalen" +
                    "tTo(expected, Generic.ExcludePropertiesForErrorMessages);\r\n        }\r\n");
 } 
            this.Write("    }\r\n\r\n");
 } 
 if(allChecks.Count > 0){ 
            this.Write("    [TestClass]\r\n    [Ignore]\r\n    public class Attribute\r\n    {\r\n        private" +
                    " readonly IRoot check = new ");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write("();\r\n\r\n        [TestMethod]\r\n        public void ");
            this.Write(this.ToStringHelper.ToStringWithCulture(allChecks[0].Category));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write("_CheckCategory() => Generic.CheckCategory(check, Category.");
            this.Write(this.ToStringHelper.ToStringWithCulture(allChecks[0].Category));
            this.Write(");\r\n\r\n        [TestMethod]\r\n        public void ");
            this.Write(this.ToStringHelper.ToStringWithCulture(allChecks[0].Category));
            this.Write("_");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write("_CheckId() => Generic.CheckId(check, CheckId.");
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            this.Write(");\r\n    }\r\n");
 } 
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
    }
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class UnitTestClassBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        public System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
