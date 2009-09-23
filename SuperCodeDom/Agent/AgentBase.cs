using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// base type of CodeDom Agent.
    /// </summary>
    /// <typeparam name="Holder">Type of this agent holder.</typeparam>
    public abstract class AgentBase<Holder, TypeOfThis> : MethodChainBase<TypeOfThis>
        where TypeOfThis : AgentBase<Holder, TypeOfThis>
    {
        #region Member Variables
        private Holder _Holder;
        #endregion

        //Constructor
        #region AgentBase
        /// <summary>
        /// Constructor
        /// </summary>
        public AgentBase(Holder holder)
            : base()
        {
            _Holder = holder;
        }
        #endregion

        //Public Property
        #region AgentHolder
        /// <summary>
        /// reference of holder of this.
        /// </summary>
        public Holder AgentHolder
        {
            get { return _Holder; }
        }
        #endregion
    }
}
