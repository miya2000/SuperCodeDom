using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// Agent for CodeSnippetTypeMember.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    public class CodeSnippetTypeMemberAgent<Holder> : CodeTypeMemberAgentBase<CodeSnippetTypeMember, Holder, CodeSnippetTypeMemberAgent<Holder>>
    {
        //Constructor
        #region CodeSnippetTypeMemberAgent
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holder">holder of this agent.</param>
        /// <param name="snippet">snippet.</param>
        public CodeSnippetTypeMemberAgent(Holder holder, CodeTypeDeclaration declaringType, CodeSnippetTypeMember snippet)
            : base(holder, declaringType, snippet)
        {
        }
        #endregion
    }
}
