using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;
using SuperCodeDom.Agent;
using System.Text.RegularExpressions;

namespace SuperCodeDom.Extension
{
    /// <summary>
    /// extension for declaration agent.
    /// </summary>
    public static partial class AgentExtension
    {
        //Public Method
        //CodeNamespaceAgent
        #region Type
        /// <summary>
        /// starts type declaration.
        /// </summary>
        public static CodeTypeDeclarationAgent<CodeNamespaceAgent<Holder>> Type<Holder>(this CodeNamespaceAgent<Holder> agent, string typeName)
        {
            CodeTypeDeclaration type = new CodeTypeDeclaration(typeName);
            agent.Namespace.Types.Add(type);
            return new CodeTypeDeclarationAgent<CodeNamespaceAgent<Holder>>(agent, null, type);
        }
        #endregion
        #region Enum
        /// <summary>
        /// starts type declaration.
        /// </summary>
        public static CodeEnumDeclarationAgent<CodeNamespaceAgent<Holder>> Enum<Holder>(this CodeNamespaceAgent<Holder> agent, string enumName)
        {
            return agent.Enum(enumName, null);
        }
        /// <summary>
        /// starts type declaration.
        /// </summary>
        public static CodeEnumDeclarationAgent<CodeNamespaceAgent<Holder>> Enum<Holder>(this CodeNamespaceAgent<Holder> agent, string enumName, Type enumType)
        {
            CodeTypeDeclaration _enum = new CodeTypeDeclaration(enumName);
            _enum.IsEnum = true;
            if (enumType != null)
            {
                _enum.BaseTypes.Add(enumType);
            }
            agent.Namespace.Types.Add(_enum);
            return new CodeEnumDeclarationAgent<CodeNamespaceAgent<Holder>>(agent, null, _enum);
        }
        #endregion
        #region Import
        /// <summary>
        /// add import.
        /// </summary>
        public static CodeNamespaceAgent<Holder> Import<Holder>(this CodeNamespaceAgent<Holder> agent, params string[] namespaces)
        {
            foreach (string nameSpace in namespaces)
            {
                agent.Namespace.Imports.Add(new CodeNamespaceImport(nameSpace));
            }
            return agent.This;
        }
        #endregion

        //CodeTypeMemberAgentBase
        #region Attr
        public static T Attr<M, H, T>(this CodeTypeMemberAgentBase<M, H, T> agent, MemberAttributes attributes)
            where T : CodeTypeMemberAgentBase<M, H, T>
            where M : CodeTypeMember
        {
            agent.Member.Attributes = attributes;
            return agent.This;
        }
        #endregion
        #region Summary
        /// <summary>
        /// set member summary.
        /// </summary>
        public static T Summary<M, H, T>(this CodeTypeMemberAgentBase<M, H, T> agent, params string[] summaries)
            where T : CodeTypeMemberAgentBase<M, H, T>
            where M : CodeTypeMember
        {
            agent.Member.Summary(summaries);
            return agent.This;
        }
        #endregion
        #region Region
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static T Region<M, H, T>(this CodeTypeMemberAgentBase<M, H, T> agent)
            where T : CodeTypeMemberAgentBase<M, H, T>
            where M : CodeTypeMember
        {
            agent.Member.Region();
            return agent.This;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static T Region<M, H, T>(this CodeTypeMemberAgentBase<M, H, T> agent, string regionText)
            where T : CodeTypeMemberAgentBase<M, H, T>
            where M : CodeTypeMember
        {
            agent.Member.Region(regionText);
            return agent.This;
        }
        #endregion
        #region CustomAttr
        /// <summary>
        /// add custom attributes.
        /// </summary>
        public static T CustomAttr<M, H, T>(this CodeTypeMemberAgentBase<M, H, T> agent, params CodeAttributeDeclaration[] attributes)
            where T : CodeTypeMemberAgentBase<M, H, T>
            where M : CodeTypeMember
        {
            agent.Member.CustomAttr(attributes);
            return agent.This;
        }
        #endregion

        //CodeTypeDeclarationAgent
        #region Partial
        /// <summary>
        /// set IsEnum flag true.
        /// </summary>
        public static CodeTypeDeclarationAgent<H> Partial<H>(this CodeTypeDeclarationAgent<H> agent)
        {
            agent.Member.IsPartial = true;
            return agent.This;
        }
        #endregion
        #region Interface
        /// <summary>
        /// set IsInterface flag true.
        /// </summary>
        public static CodeTypeDeclarationAgent<H> Interface<H>(this CodeTypeDeclarationAgent<H> agent)
        {
            agent.Member.IsInterface = true;
            return agent.This;
        }
        #endregion
        #region Struct
        /// <summary>
        /// set IsStruct flag true.
        /// </summary>
        public static CodeTypeDeclarationAgent<H> Struct<H>(this CodeTypeDeclarationAgent<H> agent)
        {
            agent.Member.IsStruct = true;
            return agent.This;
        }
        #endregion
        #region Base
        /// <summary>
        /// add base type.
        /// </summary>
        public static CodeTypeDeclarationAgent<H> Base<H>(this CodeTypeDeclarationAgent<H> agent, string baseType)
        {
            return agent.Base(new CodeTypeReference(baseType));
        }
        /// <summary>
        /// add base type.
        /// </summary>
        public static CodeTypeDeclarationAgent<H> Base<H>(this CodeTypeDeclarationAgent<H> agent, Type baseType)
        {
            return agent.Base(new CodeTypeReference(baseType));
        }
        /// <summary>
        /// add base type.
        /// </summary>
        public static CodeTypeDeclarationAgent<H> Base<H>(this CodeTypeDeclarationAgent<H> agent, CodeTypeReference baseType)
        {
            agent.Member.BaseTypes.Add(baseType);
            return agent.This;
        }
        #endregion
        #region Members
        /// <summary>
        /// add members.
        /// </summary>
        public static CodeTypeDeclarationAgent<H> Members<H>(this CodeTypeDeclarationAgent<H> agent, params CodeTypeMember[] members)
        {
            agent.Member.Members.AddRange(members);
            return agent.This;
        }
        #endregion
        #region Type
        /// <summary>
        /// starts type declaration.
        /// </summary>
        public static CodeTypeDeclarationAgent<CodeTypeDeclarationAgent<H>> Type<H>(this CodeTypeDeclarationAgent<H> agent, string typeName)
        {
            CodeTypeDeclaration type = new CodeTypeDeclaration(typeName);
            agent.Member.Members.Add(type);
            return new CodeTypeDeclarationAgent<CodeTypeDeclarationAgent<H>>(agent, agent.Member, type);
        }
        #endregion
        #region Enum
        /// <summary>
        /// starts enum type declaration.
        /// </summary>
        public static CodeEnumDeclarationAgent<CodeTypeDeclarationAgent<Holder>> Enum<Holder>(this CodeTypeDeclarationAgent<Holder> agent, string enumName)
        {
            return agent.Enum(enumName, null);
        }
        /// <summary>
        /// starts enum type declaration.
        /// </summary>
        public static CodeEnumDeclarationAgent<CodeTypeDeclarationAgent<Holder>> Enum<Holder>(this CodeTypeDeclarationAgent<Holder> agent, string enumName, Type enumType)
        {
            CodeTypeDeclaration _enum = new CodeTypeDeclaration(enumName);
            _enum.IsEnum = true;
            if (enumType != null)
            {
                _enum.BaseTypes.Add(enumType);
            }
            agent.Member.Members.Add(_enum);
            return new CodeEnumDeclarationAgent<CodeTypeDeclarationAgent<Holder>>(agent, agent.Member, _enum);
        }
        #endregion
        #region Method
        /// <summary>
        /// starts method declaration.
        /// </summary>
        public static CodeMemberMethodAgent<CodeTypeDeclarationAgent<H>> Method<H>(this CodeTypeDeclarationAgent<H> agent, string methodName)
        {
            CodeMemberMethod method = new CodeMemberMethod();
            method.Name = methodName;
            agent.Member.Members.Add(method);
            return new CodeMemberMethodAgent<CodeTypeDeclarationAgent<H>>(agent, agent.Member, method);
        }
        #endregion
        #region Property
        /// <summary>
        /// starts property declaration.
        /// </summary>
        public static CodeMemberPropertyAgent<CodeTypeDeclarationAgent<H>> Property<H>(this CodeTypeDeclarationAgent<H> agent, string propertyType, string propertyName)
        {
            return agent.Property(new CodeTypeReference(propertyType), propertyName);
        }
        /// <summary>
        /// starts property declaration.
        /// </summary>
        public static CodeMemberPropertyAgent<CodeTypeDeclarationAgent<H>> Property<H>(this CodeTypeDeclarationAgent<H> agent, Type propertyType, string propertyName)
        {
            return agent.Property(new CodeTypeReference(propertyType), propertyName);
        }
        /// <summary>
        /// starts property declaration.
        /// </summary>
        public static CodeMemberPropertyAgent<CodeTypeDeclarationAgent<H>> Property<H>(this CodeTypeDeclarationAgent<H> agent, CodeTypeReference propertyType, string propertyName)
        {
            CodeMemberProperty property = new CodeMemberProperty();
            property.Name = propertyName;
            property.Type = propertyType;
            agent.Member.Members.Add(property);
            return new CodeMemberPropertyAgent<CodeTypeDeclarationAgent<H>>(agent, agent.Member, property);
        }
        #endregion
        #region Field
        /// <summary>
        /// starts field declaration.
        /// </summary>
        public static CodeMemberFieldAgent<CodeTypeDeclarationAgent<H>> Field<H>(this CodeTypeDeclarationAgent<H> agent, string fieldType, string fieldName)
        {
            return agent.Field(new CodeTypeReference(fieldType), fieldName);
        }
        /// <summary>
        /// starts field declaration.
        /// </summary>
        public static CodeMemberFieldAgent<CodeTypeDeclarationAgent<H>> Field<H>(this CodeTypeDeclarationAgent<H> agent, Type fieldType, string fieldName)
        {
            return agent.Field(new CodeTypeReference(fieldType), fieldName);
        }
        /// <summary>
        /// starts field declaration.
        /// </summary>
        public static CodeMemberFieldAgent<CodeTypeDeclarationAgent<H>> Field<H>(this CodeTypeDeclarationAgent<H> agent, CodeTypeReference fieldType, string fieldName)
        {
            CodeMemberField field = new CodeMemberField();
            field.Name = fieldName;
            field.Type = fieldType;
            agent.Member.Members.Add(field);
            return new CodeMemberFieldAgent<CodeTypeDeclarationAgent<H>>(agent, agent.Member, field);
        }
        #endregion
        #region Event
        /// <summary>
        /// starts field declaration.
        /// </summary>
        public static CodeMemberEventAgent<CodeTypeDeclarationAgent<H>> Event<H>(this CodeTypeDeclarationAgent<H> agent, string eventType, string eventName)
        {
            return agent.Event(new CodeTypeReference(eventType), eventName);
        }
        /// <summary>
        /// starts field declaration.
        /// </summary>
        public static CodeMemberEventAgent<CodeTypeDeclarationAgent<H>> Event<H>(this CodeTypeDeclarationAgent<H> agent, Type eventType, string eventName)
        {
            return agent.Event(new CodeTypeReference(eventType), eventName);
        }
        /// <summary>
        /// starts field declaration.
        /// </summary>
        public static CodeMemberEventAgent<CodeTypeDeclarationAgent<H>> Event<H>(this CodeTypeDeclarationAgent<H> agent, CodeTypeReference eventType, string eventName)
        {
            CodeMemberEvent _event = new CodeMemberEvent();
            _event.Name = eventName;
            _event.Type = eventType;
            agent.Member.Members.Add(_event);
            return new CodeMemberEventAgent<CodeTypeDeclarationAgent<H>>(agent, agent.Member, _event);
        }
        #endregion
        #region Snippet
        /// <summary>
        /// starts snippet member declaration.
        /// </summary>
        public static CodeSnippetTypeMemberAgent<CodeTypeDeclarationAgent<H>> Snippet<H>(this CodeTypeDeclarationAgent<H> agent, string memberName)
        {
            CodeSnippetTypeMember snippet = new CodeSnippetTypeMember();
            snippet.Name = memberName;
            agent.Member.Members.Add(snippet);
            return new CodeSnippetTypeMemberAgent<CodeTypeDeclarationAgent<H>>(agent, agent.Member, snippet);
        }
        #endregion

        //CodeEnumDeclarationAgent
        #region Flag
        /// <summary>
        /// add enum members.
        /// </summary>
        public static CodeEnumDeclarationAgent<H> Flag<H>(this CodeEnumDeclarationAgent<H> agent)
        {
            if (!agent.IsFlag)
            {
                agent.IsFlag = true;
                agent.Member.CustomAttr(new CodeAttributeDeclaration(new CodeTypeReference(typeof(FlagsAttribute))));
            }
            return agent.This;
        }
        #endregion
        #region Add
        /// <summary>
        /// add enum member.
        /// </summary>
        public static CodeEnumDeclarationAgent<H> Add<H>(this CodeEnumDeclarationAgent<H> agent, string name)
        {
            return agent.Add(name, null);
        }
        /// <summary>
        /// add enum member.
        /// </summary>
        public static CodeEnumDeclarationAgent<H> Add<H>(this CodeEnumDeclarationAgent<H> agent, string name, object value)
        {
            CodeMemberField field = new CodeMemberField((string)null, name);
            if (value != null)
            {
                field.Init(value);
            }
            else if (agent.IsFlag)
            {
                field.Init(agent.FlagValue);
                agent.FlagValue = (agent.FlagValue == 0 ? 1 : (agent.FlagValue << 1));
            }
            agent.Member.Members.Add(field);
            return agent.This;
        }
        #endregion
        #region Members
        /// <summary>
        /// add enum members.
        /// </summary>
        public static CodeEnumDeclarationAgent<H> Members<H>(this CodeEnumDeclarationAgent<H> agent, params string[] members)
        {
            foreach (string member in members)
            {
                agent.Add(member);
            }
            return agent.This;
        }
        #endregion

        //CodeMemberMethodAgent
        #region Returns
        /// <summary>
        /// set return type.
        /// </summary>
        public static CodeMemberMethodAgent<H> Returns<H>(this CodeMemberMethodAgent<H> agent, string type, string comment)
        {
            agent.Member.Returns(type, comment);
            return agent;
        }
        /// <summary>
        /// set return type.
        /// </summary>
        public static CodeMemberMethodAgent<H> Returns<H>(this CodeMemberMethodAgent<H> agent, Type type, string comment)
        {
            agent.Member.Returns(type, comment);
            return agent;
        }
        /// <summary>
        /// set return type.
        /// </summary>
        public static CodeMemberMethodAgent<H> Returns<H>(this CodeMemberMethodAgent<H> agent, CodeTypeReference type, string comment)
        {
            agent.Member.Returns(type, comment);
            return agent;
        }
        #endregion
        #region Param
        /// <summary>
        /// add parameter
        /// </summary>
        public static CodeMemberMethodAgent<H> Param<H>(this CodeMemberMethodAgent<H> agent, Type type, string name, string comment)
        {
            agent.Member.Param(type, name, comment);
            return agent;
        }
        /// <summary>
        /// add parameter
        /// </summary>
        public static CodeMemberMethodAgent<H> Param<H>(this CodeMemberMethodAgent<H> agent, string type, string name, string comment)
        {
            agent.Member.Param(type, name, comment);
            return agent;
        }
        /// <summary>
        /// add parameter
        /// </summary>
        public static CodeMemberMethodAgent<H> Param<H>(this CodeMemberMethodAgent<H> agent, CodeParameterDeclarationExpression param, string comment)
        {
            agent.Member.Param(param, comment);
            return agent;
        }
        #endregion
        #region Body
        /// <summary>
        /// starts method body statements.
        /// </summary>
        public static CodeStatementAgent<CodeMemberMethodAgent<H>> Body<H>(this CodeMemberMethodAgent<H> agent)
        {
            return new CodeStatementAgent<CodeMemberMethodAgent<H>>(agent, agent.Member.Statements);
        }
        #endregion

        //CodeMemberPropertyAgent
        #region Getter
        /// <summary>
        /// starts property getter statements.
        /// </summary>
        public static CodeStatementAgent<CodeMemberPropertyAgent<H>> Getter<H>(this CodeMemberPropertyAgent<H> agent)
        {
            return new CodeStatementAgent<CodeMemberPropertyAgent<H>>(agent, agent.Member.GetStatements);
        }
        #endregion
        #region Setter
        /// <summary>
        /// starts property setter statements.
        /// </summary>
        public static CodeStatementAgent<CodeMemberPropertyAgent<H>> Setter<H>(this CodeMemberPropertyAgent<H> agent)
        {
            return new CodeStatementAgent<CodeMemberPropertyAgent<H>>(agent, agent.Member.SetStatements);
        }
        #endregion
        #region GenerateField
        /// <summary>
        /// Generate Field Member to set property value.
        /// </summary>
        public static CodeMemberPropertyAgent<H> GenerateField<H>(this CodeMemberPropertyAgent<H> agent)
        {
            return agent.GenerateField("_" + Regex.Replace(agent.Member.Name, "^@", ""));
        }
        /// <summary>
        /// Generate Field Member to set property value.
        /// </summary>
        public static CodeMemberPropertyAgent<H> GenerateField<H>(this CodeMemberPropertyAgent<H> agent, string fieldName)
        {
            if (agent.FieldName != null)
            {
                if (Regex.Replace(agent.FieldName, "^@", "") != Regex.Replace(fieldName, "^@", ""))
                {
                    throw new InvalidOperationException("FieldName is already set.");
                }
                else
                {
                    return agent.This;
                }
            }
            CodeMemberField field = new CodeMemberField(agent.Member.Type, fieldName);
            agent.DeclaringType.Members.Add(field);
            agent.FieldName = fieldName;
            return agent.This;
        }
        #endregion
        #region Get
        /// <summary>
        /// generate getter.
        /// </summary>
        public static CodeMemberPropertyAgent<H> Get<H>(this CodeMemberPropertyAgent<H> agent)
        {
            if (agent.FieldName == null) agent.GenerateField();
            agent.Getter()
                .Return(new CodeFieldReferenceExpression(null, agent.FieldName))
            .End();
            return agent.This;
        }
        /// <summary>
        /// generate getter.
        /// </summary>
        public static CodeMemberPropertyAgent<H> Get<H>(this CodeMemberPropertyAgent<H> agent, string fieldName)
        {
            agent.GenerateField(fieldName);
            return agent.Get();
        }
        #endregion
        #region Set
        /// <summary>
        /// generate setter.
        /// </summary>
        public static CodeMemberPropertyAgent<H> Set<H>(this CodeMemberPropertyAgent<H> agent)
        {
            if (agent.FieldName == null) agent.GenerateField();
            agent.Setter()
                .Assign(new CodeFieldReferenceExpression(null, agent.FieldName), new CodePropertySetValueReferenceExpression())
            .End();
            return agent.This;
        }
        /// <summary>
        /// generate setter.
        /// </summary>
        public static CodeMemberPropertyAgent<H> Set<H>(this CodeMemberPropertyAgent<H> agent, string fieldName)
        {
            agent.GenerateField(fieldName);
            return agent.Set();
        }
        #endregion
        #region GetSet
        /// <summary>
        /// generate getter.
        /// </summary>
        public static CodeMemberPropertyAgent<H> GetSet<H>(this CodeMemberPropertyAgent<H> agent)
        {
            return agent.Get().Set();
        }
        /// <summary>
        /// generate getter.
        /// </summary>
        public static CodeMemberPropertyAgent<H> GetSet<H>(this CodeMemberPropertyAgent<H> agent, string fieldName)
        {
            agent.GenerateField(fieldName);
            return agent.Get().Set();
        }
        #endregion

        //CodeMemberFieldAgent
        #region Init
        /// <summary>
        /// set initialize expression.
        /// </summary>
        public static CodeMemberFieldAgent<H> Init<H>(this CodeMemberFieldAgent<H> agent, CodeExpression initExpression)
        {
            agent.Member.Init(initExpression);
            return agent;
        }
        /// <summary>
        /// set initialize variable name.
        /// </summary>
        public static CodeMemberFieldAgent<H> Init<H>(this CodeMemberFieldAgent<H> agent, string variableName)
        {
            agent.Member.Init(variableName);
            return agent;
        }
        /// <summary>
        /// set initialize value.
        /// In the case to set string value, you should cast value to object.
        /// </summary>
        public static CodeMemberFieldAgent<H> Init<H>(this CodeMemberFieldAgent<H> agent, object value)
        {
            agent.Member.Init(value);
            return agent;
        }
        #endregion

        //CodeMemberEventAgent

        //CodeSnippetTypeMemberAgent
        #region Text
        /// <summary>
        /// set code snippet text.
        /// </summary>
        public static CodeSnippetTypeMemberAgent<H> Text<H>(this CodeSnippetTypeMemberAgent<H> agent, string text)
        {
            agent.Member.Text(text);
            return agent;
        }
        #endregion
    }
}
