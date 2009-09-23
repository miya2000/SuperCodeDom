using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// Agent for CodeStatement.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    public class CodeStatementAgent<Holder> : CodeStatementAgentBase<Holder, CodeStatementAgent<Holder>>
    {
        //Constructor
        #region CodeStatementAgent
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holder"></param>
        /// <param name="statements"></param>
        public CodeStatementAgent(Holder holder, CodeStatementCollection statements)
            : base(holder, statements)
        {
        }
        #endregion
    }
}
