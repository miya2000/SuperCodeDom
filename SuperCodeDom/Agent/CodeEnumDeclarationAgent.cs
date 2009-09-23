using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// Agent for CodeEnumDeclaration.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    public class CodeEnumDeclarationAgent<Holder> : CodeTypeMemberAgentBase<CodeTypeDeclaration, Holder, CodeEnumDeclarationAgent<Holder>>
    {
        #region Member Variables
        private bool _IsFlag = false;
        private long _FlagValue = 0;
        #endregion

        //Constructor
        #region CodeEnumDeclaration
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holder">holder of type.</param>
        /// <param name="type">type declaration</param>
        public CodeEnumDeclarationAgent(Holder holder, CodeTypeDeclaration declaringType, CodeTypeDeclaration type)
            : base(holder, declaringType, type)
        {
        }
        #endregion

        //Public Property
        #region IsFlag
        /// <summary>
        /// whether this enum is flag or not.
        /// </summary>
        public bool IsFlag
        {
            get { return _IsFlag; }
            set {
                if (!value) throw new InvalidOperationException("IsFlag can set true only.");
                _IsFlag = value;
            }
        }
        #endregion
        #region FlagValue
        /// <summary>
        /// current flag value.
        /// </summary>
        public long FlagValue
        {
            get { return _FlagValue; }
            set { _FlagValue = value; }
        }
        #endregion
    }
}
