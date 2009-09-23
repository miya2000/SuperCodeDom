using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// base class of CodeTypeMemberAgent.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    /// <typeparam name="TypeOfThis">Declaring sub class type.</typeparam>
    public abstract class CodeTypeMemberAgentBase<TypeOfMember, Holder, TypeOfThis> : AgentBase<Holder, TypeOfThis>
        where TypeOfThis : CodeTypeMemberAgentBase<TypeOfMember, Holder, TypeOfThis>
        where TypeOfMember : CodeTypeMember
    {
        #region Member Variables
        private CodeTypeDeclaration _DeclaringType;
        private TypeOfMember _Member;
        #endregion

        //Constructor
        #region CodeTypeMemberAgentBase
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holder"></param>
        public CodeTypeMemberAgentBase(Holder holder, CodeTypeDeclaration declaringType, TypeOfMember member)
            : base(holder)
        {
            _DeclaringType = declaringType;
            _Member = member;
        }
        #endregion

        //Public Property
        #region DeclaringType
        /// <summary>
        /// reference of type which declaring this member.
        /// </summary>
        public CodeTypeDeclaration DeclaringType
        {
            get { return _DeclaringType; }
        }
        #endregion
        #region Member
        /// <summary>
        /// reference of type member instance.
        /// </summary>
        public TypeOfMember Member
        {
            get { return _Member; }
        }
        #endregion
    }
}
