using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

using SuperCodeDom.Agent;
using SuperCodeDom.Extension;

namespace SuperCodeDom.NestExtention
{
    /// <summary>
    /// .___
    /// </summary>
    public static class NestExtention
    {
        #region Add
        /// <summary>
        /// nest expression of add.
        /// </summary>
        public static This ___<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeExpression expression)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(expression);
        }
        /// <summary>
        /// nest expression of add.
        /// </summary>
        public static This ___<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeStatement statement)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(statement);
        }
        #endregion
        #region Return
        /// <summary>
        /// nest expression of return.
        /// </summary>
        public static This ___Return<Holder, This>(this CodeStatementAgentBase<Holder, This> agent)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Return();
        }
        /// <summary>
        /// nest expression of return.
        /// </summary>
        public static This ___Return<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeExpression expression)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Return(expression);
        }
        #endregion
    }
}
