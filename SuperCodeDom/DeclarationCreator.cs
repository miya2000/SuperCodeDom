using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;
using SuperCodeDom.Agent;

namespace SuperCodeDom
{
    /// <summary>
    /// create declarations.
    /// </summary>
    public class DeclarationCreator
    {
        //Public Method
        #region Unit
        /// <summary>
        /// create compile unit declaration.
        /// </summary>
        public CodeCompileUnit Unit()
        {
            return new CodeCompileUnit();
        }
        #endregion
        #region Namespace
        /// <summary>
        /// create namespace declaration.
        /// </summary>
        public CodeNamespace Namespace(string name)
        {
            return new CodeNamespace(name);
        }
        #endregion
        #region Type
        /// <summary>
        /// create type declaration.
        /// </summary>
        public CodeTypeDeclaration Type(string name)
        {
            return new CodeTypeDeclaration(name);
        }
        #endregion
        #region Method
        /// <summary>
        ///  create method declaration.
        /// </summary>
        public CodeMemberMethod Method(string name)
        {
            CodeMemberMethod method = new CodeMemberMethod();
            method.Name = name;
            return method;
        }
        #endregion
        #region Property
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberProperty Property(string type, string name)
        {
            return Property(new CodeTypeReference(type), name);
        }
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberProperty Property(Type type, string name)
        {
            return Property(new CodeTypeReference(type), name);
        }
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberProperty Property<T>(string name)
        {
            return Property(new CodeTypeReference(typeof(T)), name);
        }
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberProperty Property(CodeTypeReference type, string name)
        {
            CodeMemberProperty property = new CodeMemberProperty();
            property.Name = name;
            property.Type = type;
            return property;
        }
        #endregion
        #region Field
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberField Field(string type, string name)
        {
            return Field(new CodeTypeReference(type), name);
        }
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberField Field(Type type, string name)
        {
            return Field(new CodeTypeReference(type), name);
        }
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberField Field<T>(string name)
        {
            return Field(new CodeTypeReference(typeof(T)), name);
        }
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberField Field(CodeTypeReference type, string name)
        {
            return new CodeMemberField(type, name);
        }
        #endregion
        #region Event
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberEvent Event(string type, string name)
        {
            return Event(new CodeTypeReference(type), name);
        }
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberEvent Event(Type type, string name)
        {
            return Event(new CodeTypeReference(type), name);
        }
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberEvent Event<T>(string name)
        {
            return Event(new CodeTypeReference(typeof(T)), name);
        }
        /// <summary>
        /// create property declaration.
        /// </summary>
        public CodeMemberEvent Event(CodeTypeReference type, string name)
        {
            CodeMemberEvent _event = new CodeMemberEvent();
            _event.Name = name;
            _event.Type = type;
            return _event;
        }
        #endregion
        #region Snippet
        /// <summary>
        /// create snippet member declaration.
        /// </summary>
        public CodeSnippetTypeMember Snippet(string name)
        {
            CodeSnippetTypeMember snippet = new CodeSnippetTypeMember();
            snippet.Name = name;
            return snippet;
        }
        #endregion
    }
}
