using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// Agent for CodeMemberEvent.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    public class CodeMemberEventAgent<Holder> : CodeTypeMemberAgentBase<CodeMemberEvent, Holder, CodeMemberEventAgent<Holder>>
    {
        //Constructor
        #region CodeMemberEventAgent
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holder">holder of this agent.</param>
        /// <param name="event">event.</param>
        public CodeMemberEventAgent(Holder holder, CodeTypeDeclaration declaringType, CodeMemberEvent @event)
            : base(holder, declaringType, @event)
        {
        }
        #endregion
    }
}
