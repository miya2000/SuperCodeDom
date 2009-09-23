using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// Creator for CodeTryCatchFinallyStatementAgent.
    /// </summary>
    public class CodeTryCatchFinallyStatementAgentCreator
    {
        //Public Method
        #region CreateInstance
        /// <summary>
        /// Creator CodeTryCatchFinallyStatementAgent instance.
        /// </summary>
        public static CodeTryCatchFinallyStatementAgent<CodeTryCatchFinallyStatement> CreateInstance(CodeTryCatchFinallyStatement condition)
        {
            return new CodeTryCatchFinallyStatementAgent<CodeTryCatchFinallyStatement>(condition, condition);
        }
        /// <summary>
        /// Creator CodeTryCatchFinallyStatementAgent instance.
        /// </summary>
        public static CodeTryCatchFinallyStatementAgent<Holder> CreateInstance<Holder>(Holder holder, CodeTryCatchFinallyStatement condition)
        {
            return new CodeTryCatchFinallyStatementAgent<Holder>(holder, condition);
        }
        #endregion
    }

    /// <summary>
    /// Agent for CodeTryCatchFinallyStatement.
    /// </summary>
    public class CodeTryCatchFinallyStatementAgent<Holder> : CodeStatementAgentBase<Holder, CodeTryCatchFinallyStatementAgent<Holder>>
    {
        #region Member Variables
        CodeTryCatchFinallyStatement _Statement;
        #endregion

        //Constructor
        #region CodeTryCatchFinallyStatementAgent
        /// <summary>
        /// Constructor.
        /// This class cannot be instanciate directly. Please use CodeTryCatchFinallyStatementAgentCreator.
        /// </summary>
        /// <param name="statement"></param>
        protected internal CodeTryCatchFinallyStatementAgent(Holder holder, CodeTryCatchFinallyStatement statement)
            : base(holder, statement.TryStatements)
        {
            _Statement = statement;
        }
        #endregion

        //Public Property
        #region Statement
        /// <summary>
        /// try-catch-finally statement.
        /// </summary>
        public CodeTryCatchFinallyStatement Statement
        {
            get { return _Statement; }
        }
        #endregion
    }
}
