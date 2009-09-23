using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// Agent for CodeMemberMethod.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    public class CodeMemberMethodAgent<Holder> : CodeTypeMemberAgentBase<CodeMemberMethod, Holder, CodeMemberMethodAgent<Holder>>
    {
        //Constructor
        #region CodeMemberMethodAgent
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holder">holder of this agent.</param>
        /// <param name="method">method.</param>
        public CodeMemberMethodAgent(Holder holder, CodeTypeDeclaration declaringType, CodeMemberMethod method)
            : base(holder, declaringType, method)
        {
        }
        #endregion
    }
}
