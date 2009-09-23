using System;
using System.CodeDom;

namespace SuperCodeDom
{
    /// <summary>
    /// create expressions.
    /// </summary>
    public class ExpressionCreator
    {
        //Public Method
        #region Null
        /// <summary>
        /// create "null" expression.
        /// </summary>
        public CodePrimitiveExpression Null()
        {
            return new CodePrimitiveExpression(null);
        }
        #endregion
        #region This
        /// <summary>
        /// create "this" expression.
        /// </summary>
        public CodeThisReferenceExpression This()
        {
            return new CodeThisReferenceExpression();
        }
        #endregion
        #region Base
        /// <summary>
        /// create "base" expression.
        /// </summary>
        public CodeBaseReferenceExpression Base()
        {
            return new CodeBaseReferenceExpression();
        }
        #endregion
        #region Value
        /// <summary>
        /// create "value" expression.
        /// </summary>
        public CodePropertySetValueReferenceExpression Value()
        {
            return new CodePropertySetValueReferenceExpression();
        }
        #endregion
        #region Cast
        /// <summary>
        /// create cast expression.
        /// </summary>
        public CodeCastExpression Cast()
        {
            return new CodeCastExpression();
        }
        /// <summary>
        /// create cast expression.
        /// </summary>
        public CodeCastExpression Cast(string type, CodeExpression expression)
        {
            return new CodeCastExpression(type, expression);
        }
        /// <summary>
        /// create cast expression.
        /// </summary>
        public CodeCastExpression Cast<T>(CodeExpression expression)
        {
            return new CodeCastExpression(typeof(T), expression);
        }
        #endregion
        #region Type
        /// <summary>
        /// create type reference expression.
        /// </summary>
        public CodeTypeReferenceExpression Type(string type)
        {
            return new CodeTypeReferenceExpression(type);
        }
        /// <summary>
        /// create type reference expression.
        /// </summary>
        public CodeTypeReferenceExpression Type<T>()
        {
            return new CodeTypeReferenceExpression(typeof(T));
        }
        /// <summary>
        /// create type reference expression.
        /// </summary>
        public CodeTypeReferenceExpression Type(Type type)
        {
            return new CodeTypeReferenceExpression(type);
        }
        #endregion
        #region New
        /// <summary>
        /// create "new" expression.
        /// </summary>
        public CodeObjectCreateExpression New(string type, params CodeExpression[] parameters)
        {
            return new CodeObjectCreateExpression(type, parameters);
        }
        /// <summary>
        /// create "new" expression.
        /// </summary>
        public CodeObjectCreateExpression New<T>(params CodeExpression[] parameters)
        {
            return new CodeObjectCreateExpression(typeof(T), parameters);
        }
        #endregion
        #region Method
        /// <summary>
        /// create method reference expression.
        /// </summary>
        public CodeMethodReferenceExpression Method(string methodName)
        {
            return new CodeMethodReferenceExpression(null, methodName);
        }
        /// <summary>
        /// create method reference expression.
        /// </summary>
        public CodeMethodReferenceExpression Method(CodeExpression targetObject, string methodName)
        {
            return new CodeMethodReferenceExpression(targetObject, methodName);
        }
        #endregion
        #region Invoke
        /// <summary>
        /// create method invoke reference expression.
        /// </summary>
        public CodeMethodInvokeExpression Invoke(string methodName, params CodeExpression[] parameters)
        {
            return new CodeMethodInvokeExpression(null, methodName, parameters);
        }
        /// <summary>
        /// create method invoke reference expression.
        /// </summary>
        public CodeMethodInvokeExpression Invoke(CodeExpression targetObject, string methodName, params CodeExpression[] parameters)
        {
            return new CodeMethodInvokeExpression(targetObject, methodName, parameters);
        }
        /// <summary>
        /// create method invoke reference expression.
        /// </summary>
        public CodeMethodInvokeExpression Invoke(CodeMethodReferenceExpression method, params CodeExpression[] parameters)
        {
            return new CodeMethodInvokeExpression(method, parameters);
        }
        #endregion
        #region Property
        /// <summary>
        /// create property reference expression.
        /// </summary>
        public CodePropertyReferenceExpression Property(CodeExpression targetObject, string propertyName)
        {
            return new CodePropertyReferenceExpression(targetObject, propertyName);
        }
        #endregion
        #region Field
        /// <summary>
        /// create field reference expression.
        /// </summary>
        public CodeFieldReferenceExpression Field(CodeExpression targetObject, string propertyName)
        {
            return new CodeFieldReferenceExpression(targetObject, propertyName);
        }
        #endregion
        #region Event
        /// <summary>
        /// create event reference expression.
        /// </summary>
        public CodeEventReferenceExpression Event(CodeExpression targetObject, string eventName)
        {
            return new CodeEventReferenceExpression(targetObject, eventName);
        }
        #endregion
        #region Arg
        /// <summary>
        /// create argument reference expression.
        /// </summary>
        public CodeArgumentReferenceExpression Arg(string argumentName)
        {
            return new CodeArgumentReferenceExpression(argumentName);
        }
        #endregion
        #region Var
        /// <summary>
        /// create variable reference expression.
        /// </summary>
        public CodeVariableReferenceExpression Var(string variableName)
        {
            return new CodeVariableReferenceExpression(variableName);
        }
        #endregion
        #region Val
        /// <summary>
        /// create primitive value reference expression.
        /// </summary>
        public CodePrimitiveExpression Val(object value)
        {
            return new CodePrimitiveExpression(value);
        }
        #endregion
        #region Snippet
        /// <summary>
        /// create snippet expression.
        /// </summary>
        public CodeSnippetExpression Snippet(string text)
        {
            return new CodeSnippetExpression(text);
        }
        #endregion
    }
}
