using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;

namespace SuperCodeDom.Agent
{
    /// <summary>
    /// Agent for CodeMemberProperty.
    /// </summary>
    /// <typeparam name="Holder">Type of holding this agent.</typeparam>
    public class CodeMemberPropertyAgent<Holder> : CodeTypeMemberAgentBase<CodeMemberProperty, Holder, CodeMemberPropertyAgent<Holder>>
    {
        #region Member Variables
        private string _FieldName;
        #endregion

        //Constructor
        #region CodeMemberMethodAgent
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="holder">holder of property.</param>
        /// <param name="property">property.</param>
        public CodeMemberPropertyAgent(Holder holder, CodeTypeDeclaration declaringType, CodeMemberProperty property)
            : base(holder, declaringType, property)
        {
        }
        #endregion

        //Public Property
        #region FieldName
        /// <summary>
        /// field name of this property.
        /// </summary>
        public string FieldName
        {
            get { return _FieldName; }
            set { _FieldName = value; }
        }
        #endregion
    }
}
