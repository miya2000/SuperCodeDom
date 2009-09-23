using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.CodeDom;
using SuperCodeDom.Agent;

namespace SuperCodeDom.Extension
{
    /// <summary>
    /// CodeDom Extensions.
    /// </summary>
    public static class BasicExtension
    {
        //CodeExpression
        #region Method
        /// <summary>
        /// create CodeMethodReferenceExpression from target CodeExpression.
        /// </summary>
        public static CodeMethodReferenceExpression Method(this CodeExpression targetObject, string methodName)
        {
            return new CodeMethodReferenceExpression(targetObject, methodName);
        }
        #endregion
        #region Property
        /// <summary>
        /// create PropertyReferenceExpression from target CodeExpression.
        /// </summary>
        public static CodePropertyReferenceExpression Property(this CodeExpression targetObject, string propertyName)
        {
            return new CodePropertyReferenceExpression(targetObject, propertyName);
        }
        #endregion
        #region Field
        /// <summary>
        /// create CodeFieldReferenceExpression from target CodeExpression.
        /// </summary>
        public static CodeFieldReferenceExpression Field(this CodeExpression targetObject, string fieldName)
        {
            return new CodeFieldReferenceExpression(targetObject, fieldName);
        }
        #endregion
        #region Event
        /// <summary>
        /// create CodeEventReferenceExpression from target CodeExpression.
        /// </summary>
        public static CodeEventReferenceExpression Event(this CodeExpression targetObject, string fieldName)
        {
            return new CodeEventReferenceExpression(targetObject, fieldName);
        }
        #endregion
        #region ToStatement
        /// <summary>
        /// Convert expression to statement.
        /// </summary>
        public static CodeExpressionStatement ToStatement(this CodeExpression expression)
        {
            return new CodeExpressionStatement(expression);
        }
        #endregion
        #region Bin
        /// <summary>
        /// create CodeBinaryOperatorExpression.
        /// </summary>
        public static CodeBinaryOperatorExpression Bin(this CodeExpression left, CodeBinaryOperatorType type)
        {
            return new CodeBinaryOperatorExpression().Operator(type).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression.
        /// </summary>
        public static CodeBinaryOperatorExpression Bin(this CodeExpression left, CodeBinaryOperatorType type, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(type).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression.
        /// </summary>
        public static CodeBinaryOperatorExpression Bin(this CodeExpression left, CodeBinaryOperatorType type, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(type).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression.
        /// </summary>
        public static CodeBinaryOperatorExpression Bin(this CodeExpression left, CodeBinaryOperatorType type, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(type).Left(left).Right(value);
        }
        #endregion
        #region Assign
        /// <summary>
        /// create CodeBinaryOperatorExpression (=).
        /// </summary>
        public static CodeBinaryOperatorExpression Assign(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Assign).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (=).
        /// </summary>
        public static CodeBinaryOperatorExpression Assign(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Assign).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (=).
        /// </summary>
        public static CodeBinaryOperatorExpression Assign(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Assign).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (=).
        /// </summary>
        public static CodeBinaryOperatorExpression Assign(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Assign).Left(left).Right(value);
        }
        #endregion
        #region Add
        /// <summary>
        /// create CodeBinaryOperatorExpression (+).
        /// </summary>
        public static CodeBinaryOperatorExpression Add(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Add).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (+).
        /// </summary>
        public static CodeBinaryOperatorExpression Add(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Add).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (+).
        /// </summary>
        public static CodeBinaryOperatorExpression Add(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Add).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (+).
        /// </summary>
        public static CodeBinaryOperatorExpression Add(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Add).Left(left).Right(value);
        }
        #endregion
        #region Sub
        /// <summary>
        /// create CodeBinaryOperatorExpression (-).
        /// </summary>
        public static CodeBinaryOperatorExpression Sub(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Subtract).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (-).
        /// </summary>
        public static CodeBinaryOperatorExpression Sub(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Subtract).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (-).
        /// </summary>
        public static CodeBinaryOperatorExpression Sub(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Subtract).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (-).
        /// </summary>
        public static CodeBinaryOperatorExpression Sub(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Subtract).Left(left).Right(value);
        }
        #endregion
        #region Mul
        /// <summary>
        /// create CodeBinaryOperatorExpression (*).
        /// </summary>
        public static CodeBinaryOperatorExpression Mul(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Multiply).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (*).
        /// </summary>
        public static CodeBinaryOperatorExpression Mul(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Multiply).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (*).
        /// </summary>
        public static CodeBinaryOperatorExpression Mul(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Multiply).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (*).
        /// </summary>
        public static CodeBinaryOperatorExpression Mul(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Multiply).Left(left).Right(value);
        }
        #endregion
        #region Div
        /// <summary>
        /// create CodeBinaryOperatorExpression (/).
        /// </summary>
        public static CodeBinaryOperatorExpression Div(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Divide).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (/).
        /// </summary>
        public static CodeBinaryOperatorExpression Div(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Divide).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (/).
        /// </summary>
        public static CodeBinaryOperatorExpression Div(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Divide).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (/).
        /// </summary>
        public static CodeBinaryOperatorExpression Div(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Divide).Left(left).Right(value);
        }
        #endregion
        #region Mod
        /// <summary>
        /// create CodeBinaryOperatorExpression (%).
        /// </summary>
        public static CodeBinaryOperatorExpression Mod(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Modulus).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (%).
        /// </summary>
        public static CodeBinaryOperatorExpression Mod(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Modulus).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (%).
        /// </summary>
        public static CodeBinaryOperatorExpression Mod(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Modulus).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (%).
        /// </summary>
        public static CodeBinaryOperatorExpression Mod(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.Modulus).Left(left).Right(value);
        }
        #endregion
        #region Eq
        /// <summary>
        /// create CodeBinaryOperatorExpression (==).
        /// </summary>
        public static CodeBinaryOperatorExpression Eq(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.IdentityEquality).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (==).
        /// </summary>
        public static CodeBinaryOperatorExpression Eq(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.IdentityEquality).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (==).
        /// </summary>
        public static CodeBinaryOperatorExpression Eq(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.IdentityEquality).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (==).
        /// </summary>
        public static CodeBinaryOperatorExpression Eq(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.IdentityEquality).Left(left).Right(value);
        }
        #endregion
        #region Ne
        /// <summary>
        /// create CodeBinaryOperatorExpression (!=).
        /// </summary>
        public static CodeBinaryOperatorExpression Ne(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.IdentityInequality).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (!=).
        /// </summary>
        public static CodeBinaryOperatorExpression Ne(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.IdentityInequality).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (!=).
        /// </summary>
        public static CodeBinaryOperatorExpression Ne(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.IdentityInequality).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (!=).
        /// </summary>
        public static CodeBinaryOperatorExpression Ne(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.IdentityInequality).Left(left).Right(value);
        }
        #endregion
        #region Gt
        /// <summary>
        /// create CodeBinaryOperatorExpression (&gt;).
        /// </summary>
        public static CodeBinaryOperatorExpression Gt(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.GreaterThan).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&gt;).
        /// </summary>
        public static CodeBinaryOperatorExpression Gt(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.GreaterThan).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&gt;).
        /// </summary>
        public static CodeBinaryOperatorExpression Gt(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.GreaterThan).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&gt;).
        /// </summary>
        public static CodeBinaryOperatorExpression Gt(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.GreaterThan).Left(left).Right(value);
        }
        #endregion
        #region Ge
        /// <summary>
        /// create CodeBinaryOperatorExpression (&gt;=).
        /// </summary>
        public static CodeBinaryOperatorExpression Ge(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.GreaterThanOrEqual).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&gt;=).
        /// </summary>
        public static CodeBinaryOperatorExpression Ge(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.GreaterThanOrEqual).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&gt;=).
        /// </summary>
        public static CodeBinaryOperatorExpression Ge(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.GreaterThanOrEqual).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&gt;=).
        /// </summary>
        public static CodeBinaryOperatorExpression Ge(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.GreaterThanOrEqual).Left(left).Right(value);
        }
        #endregion
        #region Lt
        /// <summary>
        /// create CodeBinaryOperatorExpression (&lt;).
        /// </summary>
        public static CodeBinaryOperatorExpression Lt(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.LessThan).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&lt;).
        /// </summary>
        public static CodeBinaryOperatorExpression Lt(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.LessThan).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&lt;).
        /// </summary>
        public static CodeBinaryOperatorExpression Lt(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.LessThan).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&lt;).
        /// </summary>
        public static CodeBinaryOperatorExpression Lt(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.LessThan).Left(left).Right(value);
        }
        #endregion
        #region Le
        /// <summary>
        /// create CodeBinaryOperatorExpression (&lt;=).
        /// </summary>
        public static CodeBinaryOperatorExpression Le(this CodeExpression left)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.LessThanOrEqual).Left(left);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&lt;=).
        /// </summary>
        public static CodeBinaryOperatorExpression Le(this CodeExpression left, CodeExpression right)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.LessThanOrEqual).Left(left).Right(right);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&lt;=).
        /// </summary>
        public static CodeBinaryOperatorExpression Le(this CodeExpression left, string variableName)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.LessThanOrEqual).Left(left).Right(variableName);
        }
        /// <summary>
        /// create CodeBinaryOperatorExpression (&lt;=).
        /// </summary>
        public static CodeBinaryOperatorExpression Le(this CodeExpression left, object value)
        {
            return new CodeBinaryOperatorExpression().Operator(CodeBinaryOperatorType.LessThanOrEqual).Left(left).Right(value);
        }
        #endregion
        #region Increment
        /// <summary>
        /// increments target variable.
        /// </summary>
        public static CodeAssignStatement Increment(this CodeExpression var)
        {
            return new CodeAssignStatement(var, var.Add(1));
        }
        #endregion
        #region Decrement
        /// <summary>
        /// decrements target variable.
        /// </summary>
        public static CodeAssignStatement Decrement(this CodeExpression var)
        {
            return new CodeAssignStatement(var, var.Sub(1));
        }
        #endregion

        //CodeBinaryOperatorExpression
        #region Operator
        /// <summary>
        /// set left-hand member.
        /// </summary>
        public static CodeBinaryOperatorExpression Operator(this CodeBinaryOperatorExpression bin, CodeBinaryOperatorType type)
        {
            bin.Operator = type;
            return bin;
        }
        #endregion
        #region Right
        /// <summary>
        /// set right-hand member.
        /// </summary>
        public static CodeBinaryOperatorExpression Right(this CodeBinaryOperatorExpression bin, CodeExpression right)
        {
            bin.Right = right;
            return bin;
        }
        /// <summary>
        /// set right-hand member.
        /// </summary>
        public static CodeBinaryOperatorExpression Right(this CodeBinaryOperatorExpression bin, string variableName)
        {
            bin.Right = new CodeVariableReferenceExpression(variableName);
            return bin;
        }
        /// <summary>
        /// set right-hand member.
        /// In the case to set string value, you should cast value to object.
        /// </summary>
        public static CodeBinaryOperatorExpression Right(this CodeBinaryOperatorExpression bin, object value)
        {
            bin.Right = new CodePrimitiveExpression(value);
            return bin;
        }
        #endregion
        #region Left
        /// <summary>
        /// set left-hand member.
        /// </summary>
        public static CodeBinaryOperatorExpression Left(this CodeBinaryOperatorExpression bin, CodeExpression right)
        {
            bin.Left = right;
            return bin;
        }
        /// <summary>
        /// set left-hand member.
        /// </summary>
        public static CodeBinaryOperatorExpression Left(this CodeBinaryOperatorExpression bin, string variableName)
        {
            bin.Left = new CodeVariableReferenceExpression(variableName);
            return bin;
        }
        /// <summary>
        /// set left-hand member.
        /// In the case to set string value, you should cast value to object.
        /// </summary>
        public static CodeBinaryOperatorExpression Left(this CodeBinaryOperatorExpression bin, object value)
        {
            bin.Left = new CodePrimitiveExpression(value);
            return bin;
        }
        #endregion

        //CodeTypeReferenceExpression
        #region New
        /// <summary>
        /// create CodeObjectCreateExpression from CodeTypeReferenceExpression.
        /// </summary>
        public static CodeObjectCreateExpression New(this CodeTypeReferenceExpression type)
        {
            return new CodeObjectCreateExpression(type.Type);
        }
        /// <summary>
        /// create CodeObjectCreateExpression from CodeTypeReferenceExpression.
        /// </summary>
        public static CodeObjectCreateExpression New(this CodeTypeReferenceExpression type, params CodeExpression[] parameters)
        {
            return new CodeObjectCreateExpression(type.Type, parameters);
        }
        /// <summary>
        /// create CodeObjectCreateExpression from CodeTypeReferenceExpression.
        /// </summary>
        public static CodeObjectCreateExpression New(this CodeTypeReferenceExpression type, params string[] parameter)
        {
            return new CodeObjectCreateExpression(type.Type, parameter.Select<string, CodeExpression>(s => new CodeVariableReferenceExpression(s)).ToArray());
        }
        /// <summary>
        /// create CodeObjectCreateExpression from CodeTypeReferenceExpression.
        /// </summary>
        public static CodeObjectCreateExpression New(this CodeTypeReferenceExpression type, params object[] parameter)
        {
            return new CodeObjectCreateExpression(type.Type, parameter.Select<object, CodeExpression>(s => new CodePrimitiveExpression(s)).ToArray());
        }
        #endregion

        //CodeMethodReferenceExpression
        #region Invoke
        /// <summary>
        /// create CodeMethodInvokeExpression from CodeMethodReferenceExpression.
        /// </summary>
        public static CodeMethodInvokeExpression Invoke(this CodeMethodReferenceExpression method)
        {
            return new CodeMethodInvokeExpression(method);
        }
        /// <summary>
        /// create CodeMethodInvokeExpression from CodeMethodReferenceExpression.
        /// </summary>
        public static CodeMethodInvokeExpression Invoke(this CodeMethodReferenceExpression method, params CodeExpression[] parameter)
        {
            return new CodeMethodInvokeExpression(method, parameter);
        }
        /// <summary>
        /// create CodeMethodInvokeExpression from CodeMethodReferenceExpression.
        /// </summary>
        public static CodeMethodInvokeExpression Invoke(this CodeMethodReferenceExpression method, params string[] parameter)
        {
            return new CodeMethodInvokeExpression(method, parameter.Select<string, CodeExpression>(s => new CodeVariableReferenceExpression(s)).ToArray());
        }
        /// <summary>
        /// create CodeMethodInvokeExpression from CodeMethodReferenceExpression.
        /// In the case to set string value, you should cast value to object.
        /// </summary>
        public static CodeMethodInvokeExpression Invoke(this CodeMethodReferenceExpression method, params object[] parameter)
        {
            return new CodeMethodInvokeExpression(method, parameter.Select<object, CodeExpression>(s => new CodePrimitiveExpression(s)).ToArray());
        }
        #endregion

        //CodeMethodInvokeExpression
        #region Param
        /// <summary>
        /// add param. 
        /// </summary>
        public static CodeMethodInvokeExpression Param(this CodeMethodInvokeExpression invoke, params CodeExpression[] parameter)
        {
            invoke.Parameters.AddRange(parameter);
            return invoke;
        }
        /// <summary>
        /// create CodeMethodInvokeExpression from CodeMethodReferenceExpression.
        /// </summary>
        public static CodeMethodInvokeExpression Param(this CodeMethodInvokeExpression invoke, params string[] parameter)
        {
            invoke.Parameters.AddRange(parameter.Select<string, CodeExpression>(s => new CodeVariableReferenceExpression(s)).ToArray());
            return invoke;
        }
        /// <summary>
        /// create CodeMethodInvokeExpression from CodeMethodReferenceExpression.
        /// In the case to set string value, you should cast value to object.
        /// </summary>
        public static CodeMethodInvokeExpression Param(this CodeMethodInvokeExpression invoke, params object[] parameter)
        {
            invoke.Parameters.AddRange(parameter.Select<object, CodeExpression>(s => new CodePrimitiveExpression(s)).ToArray());
            return invoke;
        }
        #endregion

        //CodeObjectCreateExpression
        #region Param
        /// <summary>
        /// add param. 
        /// </summary>
        public static CodeObjectCreateExpression Param(this CodeObjectCreateExpression _new, params CodeExpression[] parameter)
        {
            _new.Parameters.AddRange(parameter);
            return _new;
        }
        /// <summary>
        /// create CodeMethodInvokeExpression from CodeMethodReferenceExpression.
        /// </summary>
        public static CodeObjectCreateExpression Param(this CodeObjectCreateExpression _new, params string[] parameter)
        {
            _new.Parameters.AddRange(parameter.Select<string, CodeExpression>(s => new CodeVariableReferenceExpression(s)).ToArray());
            return _new;
        }
        /// <summary>
        /// create CodeMethodInvokeExpression from CodeMethodReferenceExpression.
        /// In the case to set string value, you should cast value to object.
        /// </summary>
        public static CodeObjectCreateExpression Param(this CodeObjectCreateExpression _new, params object[] parameter)
        {
            _new.Parameters.AddRange(parameter.Select<object, CodeExpression>(s => new CodePrimitiveExpression(s)).ToArray());
            return _new;
        }
        #endregion

        //CodeConditionStatement
        #region Then
        /// <summary>
        /// starts method declaration.
        /// </summary>
        public static CodeConditionStatementAgent<CodeConditionStatement> Then(this CodeConditionStatement cond)
        {
            return CodeConditionStatementAgentCreator.CreateInstance(cond);
        }
        #endregion

        //CodeCompileUnit
        #region Namespace
        /// <summary>
        /// starts namespace declaration.
        /// </summary>
        public static CodeNamespaceAgent<CodeCompileUnit> Namespace(this CodeCompileUnit unit, string namespaceName)
        {
            CodeNamespace ns = new CodeNamespace(namespaceName);
            unit.Namespaces.Add(ns);
            return new CodeNamespaceAgent<CodeCompileUnit>(unit, ns);
        }
        #endregion
        #region Namespaces
        /// <summary>
        /// starts namespace declaration.
        /// </summary>
        public static CodeCompileUnit Namespaces(this CodeCompileUnit unit, params CodeNamespace[] namespaces)
        {
            unit.Namespaces.AddRange(namespaces);
            return unit;
        }
        #endregion

        //CodeNamespace
        #region Type
        /// <summary>
        /// starts type declaration.
        /// </summary>
        public static CodeTypeDeclarationAgent<CodeNamespace> Type(this CodeNamespace ns, string typeName)
        {
            CodeTypeDeclaration type = new CodeTypeDeclaration(typeName);
            ns.Types.Add(type);
            return new CodeTypeDeclarationAgent<CodeNamespace>(ns, null, type);
        }
        #endregion
        #region Types
        /// <summary>
        /// starts type declaration.
        /// </summary>
        public static CodeNamespace Types(this CodeNamespace ns, params CodeTypeDeclaration[] types)
        {
            ns.Types.AddRange(types);
            return ns;
        }
        #endregion
        #region Enum
        /// <summary>
        /// starts type declaration.
        /// </summary>
        public static CodeEnumDeclarationAgent<CodeNamespace> Enum(this CodeNamespace ns, string enumName)
        {
            return ns.Enum(enumName, null);
        }
        /// <summary>
        /// starts type declaration.
        /// </summary>
        public static CodeEnumDeclarationAgent<CodeNamespace> Enum(this CodeNamespace ns, string enumName, Type enumType)
        {
            CodeTypeDeclaration _enum = new CodeTypeDeclaration(enumName);
            _enum.IsEnum = true;
            if (enumType != null)
            {
                _enum.BaseTypes.Add(enumType);
            }
            ns.Types.Add(_enum);
            return new CodeEnumDeclarationAgent<CodeNamespace>(ns, null, _enum);
        }
        #endregion
        #region Import
        /// <summary>
        /// add import.
        /// </summary>
        public static CodeNamespace Import(this CodeNamespace ns, params string[] namespaces)
        {
            foreach (string nameSpace in namespaces)
            {
                ns.Imports.Add(new CodeNamespaceImport(nameSpace));
            }
            return ns;
        }
        #endregion

        //CodeTypeMember
        #region Attr
        /// <summary>
        /// set member attribute.
        /// </summary>
        public static void Attr(this CodeTypeMember member, MemberAttributes attributes)
        {
            member.Attributes = attributes;
        }
        /// <summary>
        /// set member attribute.
        /// </summary>
        public static CodeTypeDeclaration Attr(this CodeTypeDeclaration member, MemberAttributes attributes)
        {
            Attr((CodeTypeMember)member, attributes);
            return member;
        }
        /// <summary>
        /// set member attribute.
        /// </summary>
        public static CodeMemberMethod Attr(this CodeMemberMethod member, MemberAttributes attributes)
        {
            Attr((CodeTypeMember)member, attributes);
            return member;
        }
        /// <summary>
        /// set member attribute.
        /// </summary>
        public static CodeMemberProperty Attr(this CodeMemberProperty member, MemberAttributes attributes)
        {
            Attr((CodeTypeMember)member, attributes);
            return member;
        }
        /// <summary>
        /// set member attribute.
        /// </summary>
        public static CodeMemberField Attr(this CodeMemberField member, MemberAttributes attributes)
        {
            Attr((CodeTypeMember)member, attributes);
            return member;
        }
        /// <summary>
        /// set member attribute.
        /// </summary>
        public static CodeMemberEvent Attr(this CodeMemberEvent member, MemberAttributes attributes)
        {
            Attr((CodeTypeMember)member, attributes);
            return member;
        }
        /// <summary>
        /// set member attribute.
        /// </summary>
        public static CodeSnippetTypeMember Attr(this CodeSnippetTypeMember member, MemberAttributes attributes)
        {
            Attr((CodeTypeMember)member, attributes);
            return member;
        }
        #endregion
        #region Summary
        /// <summary>
        /// set member summary.
        /// </summary>
        public static void Summary(this CodeTypeMember member, params string[] summaries)
        {
            member.Comments.Add(new CodeCommentStatement("<summary>", true));
            foreach (string comment in summaries)
            {
                member.Comments.Add(new CodeCommentStatement(Utility.EscXml(comment), true));
            }
            member.Comments.Add(new CodeCommentStatement("</summary>", true));
        }
        /// <summary>
        /// set member summary.
        /// </summary>
        public static CodeTypeDeclaration Summary(this CodeTypeDeclaration member, params string[] summaries)
        {
            Summary((CodeTypeMember)member, summaries);
            return member;
        }
        /// <summary>
        /// set member summary.
        /// </summary>
        public static CodeMemberMethod Summary(this CodeMemberMethod member, params string[] summaries)
        {
            Summary((CodeTypeMember)member, summaries);
            return member;
        }
        /// <summary>
        /// set member summary.
        /// </summary>
        public static CodeMemberProperty Summary(this CodeMemberProperty member, params string[] summaries)
        {
            Summary((CodeTypeMember)member, summaries);
            return member;
        }
        /// <summary>
        /// set member summary.
        /// </summary>
        public static CodeMemberField Summary(this CodeMemberField member, params string[] summaries)
        {
            Summary((CodeTypeMember)member, summaries);
            return member;
        }
        /// <summary>
        /// set member summary.
        /// </summary>
        public static CodeMemberEvent Summary(this CodeMemberEvent member, params string[] summaries)
        {
            Summary((CodeTypeMember)member, summaries);
            return member;
        }
        /// <summary>
        /// set member summary.
        /// </summary>
        public static CodeSnippetTypeMember Summary(this CodeSnippetTypeMember member, params string[] summaries)
        {
            Summary((CodeTypeMember)member, summaries);
            return member;
        }
        #endregion
        #region Region
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static void Region(this CodeTypeMember member)
        {
            member.Region(Regex.Replace(member.Name, "^@", ""));
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static void Region(this CodeTypeMember member, string regionText)
        {
            member.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, regionText));
            member.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, regionText));
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeTypeDeclaration Region(this CodeTypeDeclaration member)
        {
            Region((CodeTypeMember)member);
            return member;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeTypeDeclaration Region(this CodeTypeDeclaration member, string regionText)
        {
            Region((CodeTypeMember)member, regionText);
            return member;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeMemberMethod Region(this CodeMemberMethod member)
        {
            Region((CodeTypeMember)member);
            return member;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeMemberMethod Region(this CodeMemberMethod member, string regionText)
        {
            Region((CodeTypeMember)member, regionText);
            return member;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeMemberProperty Region(this CodeMemberProperty member)
        {
            Region((CodeTypeMember)member);
            return member;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeMemberProperty Region(this CodeMemberProperty member, string regionText)
        {
            Region((CodeTypeMember)member, regionText);
            return member;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeMemberField Region(this CodeMemberField member)
        {
            Region((CodeTypeMember)member);
            return member;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeMemberField Region(this CodeMemberField member, string regionText)
        {
            Region((CodeTypeMember)member, regionText);
            return member;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeMemberEvent Region(this CodeMemberEvent member)
        {
            Region((CodeTypeMember)member);
            return member;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeMemberEvent Region(this CodeMemberEvent member, string regionText)
        {
            Region((CodeTypeMember)member, regionText);
            return member;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeSnippetTypeMember Region(this CodeSnippetTypeMember member)
        {
            Region((CodeTypeMember)member);
            return member;
        }
        /// <summary>
        /// surrounds by region.
        /// </summary>
        public static CodeSnippetTypeMember Region(this CodeSnippetTypeMember member, string regionText)
        {
            Region((CodeTypeMember)member, regionText);
            return member;
        }
        #endregion
        #region CustomAttr
        /// <summary>
        /// add custom attributes.
        /// </summary>
        public static void CustomAttr(this CodeTypeMember member, params CodeAttributeDeclaration[] attributes)
        {
            foreach (CodeAttributeDeclaration attribute in attributes)
            {
                member.CustomAttributes.Add(attribute);
            }
        }
        /// <summary>
        /// add custom attributes.
        /// </summary>
        public static CodeTypeDeclaration CustomAttr(this CodeTypeDeclaration member, params CodeAttributeDeclaration[] attributes)
        {
            CustomAttr((CodeTypeMember)member, attributes);
            return member;
        }
        /// <summary>
        /// add custom attributes.
        /// </summary>
        public static CodeMemberMethod CustomAttr(this CodeMemberMethod member, params CodeAttributeDeclaration[] attributes)
        {
            CustomAttr((CodeTypeMember)member, attributes);
            return member;
        }
        /// <summary>
        /// add custom attributes.
        /// </summary>
        public static CodeMemberProperty CustomAttr(this CodeMemberProperty member, params CodeAttributeDeclaration[] attributes)
        {
            CustomAttr((CodeTypeMember)member, attributes);
            return member;
        }
        /// <summary>
        /// add custom attributes.
        /// </summary>
        public static CodeMemberField CustomAttr(this CodeMemberField member, params CodeAttributeDeclaration[] attributes)
        {
            CustomAttr((CodeTypeMember)member, attributes);
            return member;
        }
        /// <summary>
        /// add custom attributes.
        /// </summary>
        public static CodeMemberEvent CustomAttr(this CodeMemberEvent member, params CodeAttributeDeclaration[] attributes)
        {
            CustomAttr((CodeTypeMember)member, attributes);
            return member;
        }
        /// <summary>
        /// add custom attributes.
        /// </summary>
        public static CodeSnippetTypeMember CustomAttr(this CodeSnippetTypeMember member, params CodeAttributeDeclaration[] attributes)
        {
            CustomAttr((CodeTypeMember)member, attributes);
            return member;
        }
        #endregion

        //CodeTypeDeclaration
        #region Partial
        /// <summary>
        /// set IsPartial flag true.
        /// </summary>
        public static CodeTypeDeclaration Partial(this CodeTypeDeclaration type)
        {
            type.IsPartial = true;
            return type;
        }
        #endregion
        #region Interface
        /// <summary>
        /// set IsInterface flag true.
        /// </summary>
        public static CodeTypeDeclaration Interface(this CodeTypeDeclaration type)
        {
            type.IsInterface = true;
            return type;
        }
        #endregion
        #region Struct
        /// <summary>
        /// set IsStruct flag true.
        /// </summary>
        public static CodeTypeDeclaration Struct(this CodeTypeDeclaration type)
        {
            type.IsStruct = true;
            return type;
        }
        #endregion
        #region Base
        /// <summary>
        /// add base type.
        /// </summary>
        public static CodeTypeDeclaration Base(this CodeTypeDeclaration type, string baseType)
        {
            return type.Base(new CodeTypeReference(baseType));
        }
        /// <summary>
        /// add base type.
        /// </summary>
        public static CodeTypeDeclaration Base(this CodeTypeDeclaration type, Type baseType)
        {
            return type.Base(new CodeTypeReference(baseType));
        }
        /// <summary>
        /// add base type.
        /// </summary>
        public static CodeTypeDeclaration Base(this CodeTypeDeclaration type, CodeTypeReference baseType)
        {
            type.BaseTypes.Add(baseType);
            return type;
        }
        #endregion
        #region Members
        /// <summary>
        /// add members.
        /// </summary>
        public static CodeTypeDeclaration Members(this CodeTypeDeclaration type, params CodeTypeMember[] members)
        {
            type.Members.AddRange(members);
            return type;
        }
        #endregion
        #region Type
        /// <summary>
        /// starts type declaration.
        /// </summary>
        public static CodeTypeDeclaration Type(this CodeTypeDeclaration type, string typeName)
        {
            CodeTypeDeclaration subtype = new CodeTypeDeclaration(typeName);
            type.Members.Add(subtype);
            return type;
        }
        #endregion
        #region Enum
        /// <summary>
        /// starts enum type declaration.
        /// </summary>
        public static CodeEnumDeclarationAgent<CodeTypeDeclaration> Enum(this CodeTypeDeclaration type, string enumName)
        {
            return type.Enum(enumName, null);
        }
        /// <summary>
        /// starts enum type declaration.
        /// </summary>
        public static CodeEnumDeclarationAgent<CodeTypeDeclaration> Enum(this CodeTypeDeclaration type, string enumName, Type enumType)
        {
            CodeTypeDeclaration _enum = new CodeTypeDeclaration(enumName);
            _enum.IsEnum = true;
            if (enumType != null)
            {
                _enum.BaseTypes.Add(enumType);
            }
            type.Members.Add(type);
            return new CodeEnumDeclarationAgent<CodeTypeDeclaration>(type, type, _enum);
        }
        #endregion
        #region Method
        /// <summary>
        /// starts method declaration.
        /// </summary>
        public static CodeMemberMethodAgent<CodeTypeDeclaration> Method(this CodeTypeDeclaration type, string methodName)
        {
            CodeMemberMethod method = new CodeMemberMethod();
            method.Name = methodName;
            type.Members.Add(method);
            return new CodeMemberMethodAgent<CodeTypeDeclaration>(type, type, method);
        }
        #endregion
        #region Property
        /// <summary>
        /// starts property declaration.
        /// </summary>
        public static CodeMemberPropertyAgent<CodeTypeDeclaration> Property(this CodeTypeDeclaration type, string propertyType, string propertyName)
        {
            return type.Property(new CodeTypeReference(propertyType), propertyName);
        }
        /// <summary>
        /// starts property declaration.
        /// </summary>
        public static CodeMemberPropertyAgent<CodeTypeDeclaration> Property(this CodeTypeDeclaration type, Type propertyType, string propertyName)
        {
            return type.Property(new CodeTypeReference(propertyType), propertyName);
        }
        /// <summary>
        /// starts property declaration.
        /// </summary>
        public static CodeMemberPropertyAgent<CodeTypeDeclaration> Property<T>(this CodeTypeDeclaration type, string propertyName)
        {
            return type.Property(new CodeTypeReference(typeof(T)), propertyName);
        }
        /// <summary>
        /// starts property declaration.
        /// </summary>
        public static CodeMemberPropertyAgent<CodeTypeDeclaration> Property(this CodeTypeDeclaration type, CodeTypeReference propertyType, string propertyName)
        {
            CodeMemberProperty property = new CodeMemberProperty();
            property.Name = propertyName;
            property.Type = propertyType;
            type.Members.Add(property);
            return new CodeMemberPropertyAgent<CodeTypeDeclaration>(type, type, property);
        }
        #endregion
        #region Field
        /// <summary>
        /// starts field declaration.
        /// </summary>
        public static CodeMemberFieldAgent<CodeTypeDeclaration> Field(this CodeTypeDeclaration type, string fieldType, string fieldName)
        {
            return type.Field(new CodeTypeReference(fieldType), fieldName);
        }
        /// <summary>
        /// starts field declaration.
        /// </summary>
        public static CodeMemberFieldAgent<CodeTypeDeclaration> Field(this CodeTypeDeclaration type, Type fieldType, string fieldName)
        {
            return type.Field(new CodeTypeReference(fieldType), fieldName);
        }
        /// <summary>
        /// starts field declaration.
        /// </summary>
        public static CodeMemberFieldAgent<CodeTypeDeclaration> Field<T>(this CodeTypeDeclaration type, string fieldName)
        {
            return type.Field(new CodeTypeReference(typeof(T)), fieldName);
        }
        /// <summary>
        /// starts field declaration.
        /// </summary>
        public static CodeMemberFieldAgent<CodeTypeDeclaration> Field(this CodeTypeDeclaration type, CodeTypeReference fieldType, string fieldName)
        {
            CodeMemberField field = new CodeMemberField(fieldType, fieldName);
            type.Members.Add(field);
            return new CodeMemberFieldAgent<CodeTypeDeclaration>(type, type, field);
        }
        #endregion
        #region Event
        /// <summary>
        /// starts event declaration.
        /// </summary>
        public static CodeMemberEventAgent<CodeTypeDeclaration> Event(this CodeTypeDeclaration type, string eventType, string eventName)
        {
            return type.Event(new CodeTypeReference(eventType), eventName);
        }
        /// <summary>
        /// starts event declaration.
        /// </summary>
        public static CodeMemberEventAgent<CodeTypeDeclaration> Event(this CodeTypeDeclaration type, Type eventType, string eventName)
        {
            return type.Event(new CodeTypeReference(eventType), eventName);
        }
        /// <summary>
        /// starts event declaration.
        /// </summary>
        public static CodeMemberEventAgent<CodeTypeDeclaration> Event<T>(this CodeTypeDeclaration type, string eventName)
        {
            return type.Event(new CodeTypeReference(typeof(T)), eventName);
        }
        /// <summary>
        /// starts event declaration.
        /// </summary>
        public static CodeMemberEventAgent<CodeTypeDeclaration> Event(this CodeTypeDeclaration type, CodeTypeReference eventType, string eventName)
        {
            CodeMemberEvent _event = new CodeMemberEvent();
            _event.Name = eventName;
            _event.Type = eventType;
            type.Members.Add(_event);
            return new CodeMemberEventAgent<CodeTypeDeclaration>(type, type, _event);
        }
        #endregion
        #region Snippet
        /// <summary>
        /// starts snippet member declaration.
        /// </summary>
        public static CodeSnippetTypeMemberAgent<CodeTypeDeclaration> Snippet(this CodeTypeDeclaration type, string memberName)
        {
            CodeSnippetTypeMember snippet = new CodeSnippetTypeMember();
            snippet.Name = memberName;
            type.Members.Add(snippet);
            return new CodeSnippetTypeMemberAgent<CodeTypeDeclaration>(type, type, snippet);
        }
        #endregion

        //CodeMemberMethod
        #region Returns
        /// <summary>
        /// set return type.
        /// </summary>
        public static CodeMemberMethod Returns(this CodeMemberMethod method, string type, string comment)
        {
            return method.Returns(new CodeTypeReference(type), comment);
        }
        /// <summary>
        /// set return type.
        /// </summary>
        public static CodeMemberMethod Returns(this CodeMemberMethod method, Type type, string comment)
        {
            return method.Returns(new CodeTypeReference(type), comment);
        }
        /// <summary>
        /// set return type.
        /// </summary>
        public static CodeMemberMethod Returns(this CodeMemberMethod method, CodeTypeReference type, string comment)
        {
            method.ReturnType = type;
            if (!string.IsNullOrEmpty(comment))
            {
                method.Comments.Add(new CodeCommentStatement(string.Format("<returns>{0}</returns>", Utility.EscXml(comment)), true));
            }
            return method;
        }
        #endregion
        #region Param
        /// <summary>
        /// add parameter
        /// </summary>
        public static CodeMemberMethod Param<T>(this CodeMemberMethod method, string name, string comment)
        {
            method.Param(new CodeParameterDeclarationExpression(typeof(T), name), comment);
            return method;
        }
        /// <summary>
        /// add parameter
        /// </summary>
        public static CodeMemberMethod Param(this CodeMemberMethod method, Type type, string name, string comment)
        {
            method.Param(new CodeParameterDeclarationExpression(type, name), comment);
            return method;
        }
        /// <summary>
        /// add parameter
        /// </summary>
        public static CodeMemberMethod Param(this CodeMemberMethod method, string type, string name, string comment)
        {
            method.Param(new CodeParameterDeclarationExpression(type, name), comment);
            return method;
        }
        /// <summary>
        /// add parameter
        /// </summary>
        public static CodeMemberMethod Param(this CodeMemberMethod method, CodeParameterDeclarationExpression param, string comment)
        {
            method.Parameters.Add(param);
            if (comment != null)
            {
                method.Comments.Add(new CodeCommentStatement(string.Format("<param name=\"{0}\">{1}</param>", param.Name, Utility.EscXml(comment)), true));
            }
            return method;
        }
        #endregion
        #region Body
        /// <summary>
        /// starts method body statements.
        /// </summary>
        public static CodeStatementAgent<CodeMemberMethod> Body(this CodeMemberMethod method)
        {
            return new CodeStatementAgent<CodeMemberMethod>(method, method.Statements);
        }
        #endregion

        //CodeMemberProperty
        #region Getter
        /// <summary>
        /// starts property getter statements.
        /// </summary>
        public static CodeStatementAgent<CodeMemberProperty> Getter(this CodeMemberProperty property)
        {
            return new CodeStatementAgent<CodeMemberProperty>(property, property.GetStatements);
        }
        #endregion
        #region Setter
        /// <summary>
        /// starts property setter statements.
        /// </summary>
        public static CodeStatementAgent<CodeMemberProperty> Setter(this CodeMemberProperty property)
        {
            return new CodeStatementAgent<CodeMemberProperty>(property, property.SetStatements);
        }
        #endregion

        //CodeMemberField
        #region Init
        /// <summary>
        /// set initialize expression.
        /// </summary>
        public static CodeMemberField Init(this CodeMemberField field, CodeExpression initExpression)
        {
            field.InitExpression = initExpression;
            return field;
        }
        /// <summary>
        /// set initialize variable name.
        /// </summary>
        public static CodeMemberField Init(this CodeMemberField field, string variableName)
        {
            field.InitExpression = new CodeVariableReferenceExpression(variableName);
            return field;
        }
        /// <summary>
        /// set initialize value.
        /// In the case to set string value, you should cast value to object.
        /// </summary>
        public static CodeMemberField Init(this CodeMemberField field, object value)
        {
            field.InitExpression = new CodePrimitiveExpression(value);
            return field;
        }
        #endregion

        //CodeMemberEvent

        //CodeSnippetTypeMember
        #region Text
        /// <summary>
        /// set code snippet text.
        /// </summary>
        public static CodeSnippetTypeMember Text(this CodeSnippetTypeMember snippet, string text)
        {
            snippet.Text = (text == null ? text : (text.Trim() + Environment.NewLine));
            return snippet;
        }
        #endregion
    }
}
