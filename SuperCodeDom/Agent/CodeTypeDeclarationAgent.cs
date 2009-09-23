using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// Agent for CodeTypeDeclaration.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    public class CodeTypeDeclarationAgent<Holder> : CodeTypeMemberAgentBase<CodeTypeDeclaration, Holder, CodeTypeDeclarationAgent<Holder>>
    {
        //Constructor
        #region CodeTypeDeclarationAgent
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holder">holder of type.</param>
        /// <param name="type">type declaration</param>
        public CodeTypeDeclarationAgent(Holder holder, CodeTypeDeclaration declaringType, CodeTypeDeclaration type)
            : base(holder, declaringType, type)
        {
        }
        #endregion
    }
}
