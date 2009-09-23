using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// base class for CodeStatementAgent.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    /// <typeparam name="TypeOfThis">Declaring sub class type.</typeparam>
    public abstract class CodeStatementAgentBase<Holder, TypeOfThis> : AgentBase<Holder, TypeOfThis>
        where TypeOfThis : CodeStatementAgentBase<Holder, TypeOfThis>
    {
        #region Member Variables
        private CodeStatementCollection _Statements;
        #endregion

        //Constructor
        #region CodeStatementAgent
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="holder"></param>
        /// <param name="statements"></param>
        public CodeStatementAgentBase(Holder holder, CodeStatementCollection statements)
            : base(holder)
        {
            _Statements = statements;
        }
        #endregion

        //Public Property
        #region Statements
        /// <summary>
        /// statements.
        /// </summary>
        public CodeStatementCollection Statements
        {
            get { return _Statements; }
            set { _Statements = value; }
        }
        #endregion
    }
}
