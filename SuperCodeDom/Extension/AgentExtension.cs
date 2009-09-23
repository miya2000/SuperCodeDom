using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperCodeDom.Agent;

namespace SuperCodeDom.Extension
{
    /// <summary>
    /// Extension for Agent.
    /// </summary>
    public static partial class AgentExtension
    {
        //Public Method
        #region End
        /// <summary>
        /// returns agent holder and it ends of agent method chain.
        /// </summary>
        public static Holder End<Holder, TypeOfThis>(this AgentBase<Holder, TypeOfThis> agent)
            where TypeOfThis : AgentBase<Holder, TypeOfThis>
        {
            return agent.AgentHolder;
        }
        #endregion
        #region Any
        /// <summary>
        /// any process
        /// </summary>
        public static TypeOfThis Any<Holder, TypeOfThis>(this AgentBase<Holder, TypeOfThis> agent, Action<TypeOfThis> action)
            where TypeOfThis : AgentBase<Holder, TypeOfThis>
        {
            if (action != null)
            {
                action(agent.This);
            }
            return agent.This;
        }
        #endregion
    }
}
