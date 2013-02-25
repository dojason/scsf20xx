//===============================================================================
// Microsoft patterns & practices
// Smart Client Software Factory 2010
//===============================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================
using System;
using System.Collections.Generic;
using System.Text;
using EnvDTE;

namespace Microsoft.Practices.SmartClientFactory.Actions
{
    public class AddParameterAction : Microsoft.Practices.RecipeFramework.Library.CodeModel.Actions.AddParameterAction
    {
        public override void Execute()
        {
            switch (base.Method.Language)
            {
                case CodeModelLanguageConstants.vsCMLanguageCSharp:
                    base.Execute();

                    break;

                case CodeModelLanguageConstants.vsCMLanguageVB:
                    base.Parameter = base.Method.AddParameter(ParameterName, ParameterType, System.Reflection.Missing.Value);
                    break;
            }
        }
    }
}