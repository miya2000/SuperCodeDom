using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// base type for method chain.
    /// </summary>
    /// <typeparam name="TypeOfThis">Declaring sub class type.</typeparam>
    public abstract class MethodChainBase<TypeOfThis>
        where TypeOfThis : MethodChainBase<TypeOfThis>
    {
        #region Member Variables
        private TypeOfThis _This;
        #endregion

        //Constructor
        #region CodeStatementAgent
        /// <summary>
        /// Constructor
        /// </summary>
        public MethodChainBase()
        {
            _This = (TypeOfThis)this;
        }
        #endregion

        //Public Property
        #region This
        /// <summary>
        /// reference of this instance.
        /// </summary>
        public TypeOfThis This
        {
            get { return _This; }
        }
        #endregion
    }
}
