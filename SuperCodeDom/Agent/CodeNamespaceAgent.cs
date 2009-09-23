using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// Agent for CodeNamespace.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    public class CodeNamespaceAgent<Holder> : AgentBase<Holder, CodeNamespaceAgent<Holder>>
    {
        #region Member Variables
        private CodeNamespace _Namespace;
        #endregion

        //Constructor
        #region CodeNamespaceAgent
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holder">holder of this agent.</param>
        /// <param name="ns">CodeNamespace object.</param>
        public CodeNamespaceAgent(Holder holder, CodeNamespace ns)
            : base(holder)
        {
            _Namespace = ns;
        }
        #endregion

        //Public Property
        #region Namespace
        /// <summary>
        /// Namespace.
        /// </summary>
        public CodeNamespace Namespace
        {
            get { return _Namespace; }
        }
        #endregion
    }
}
