using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// Agent for CodeMemberField.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    public class CodeMemberFieldAgent<Holder> : CodeTypeMemberAgentBase<CodeMemberField, Holder, CodeMemberFieldAgent<Holder>>
    {
        //Constructor
        #region CodeMemberFieldAgent
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holder">holder of this agent.</param>
        /// <param name="field">field.</param>
        public CodeMemberFieldAgent(Holder holder, CodeTypeDeclaration declaringType, CodeMemberField field)
            : base(holder, declaringType, field)
        {
        }
        #endregion
    }
}
