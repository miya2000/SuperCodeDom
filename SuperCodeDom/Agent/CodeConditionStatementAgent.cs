using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// Creator for CodeConditionStatementAgent.
    /// </summary>
    public static class CodeConditionStatementAgentCreator
    {
        //Public Method
        #region CreateInstance
        /// <summary>
        /// Creator CodeConditionStatementAgent instance.
        /// </summary>
        public static CodeConditionStatementAgent<CodeConditionStatement> CreateInstance(CodeConditionStatement condition)
        {
            return new CodeConditionStatementAgent<CodeConditionStatement>(condition, condition);
        }
        /// <summary>
        /// Creator CodeConditionStatementAgent instance.
        /// </summary>
        public static CodeConditionStatementAgent<Holder> CreateInstance<Holder>(Holder holder, CodeConditionStatement condition)
        {
            return new CodeConditionStatementAgent<Holder>(holder, condition);
        }
        #endregion
    }

    /// <summary>
    /// Agent for CodeConditionStatement.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    public class CodeConditionStatementAgent<Holder> : CodeStatementAgentBase<Holder, CodeConditionStatementAgent<Holder>>
    {
        #region Member Variables
        CodeConditionStatement _Statement;
        #endregion

        //Constructor
        #region CodeConditionStatementAgent
        /// <summary>
        /// Constructor.
        /// This class cannot be instanciate directly. Please use CodeConditionStatementAgentCreator.
        /// </summary>
        /// <param name="condition">if statement.</param>
        protected internal CodeConditionStatementAgent(Holder holder, CodeConditionStatement statement)
            : base(holder, statement.TrueStatements)
        {
            _Statement = statement;
        }
        #endregion

        //Public Property
        #region Statement
        /// <summary>
        /// if statement.
        /// </summary>
        public CodeConditionStatement Statement
        {
            get { return _Statement; }
        }
        #endregion
    }

}
