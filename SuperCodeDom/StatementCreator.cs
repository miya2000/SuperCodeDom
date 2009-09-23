using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.CodeDom;
using SuperCodeDom.Agent;

namespace SuperCodeDom
{
    /// <summary>
    /// create statements.
    /// </summary>
    public class StatementCreator
    {
        //Public Method
        #region Empty
        /// <summary>
        /// create empty statement.
        /// </summary>
        public CodeExpressionStatement Empty()
        {
            return Snippet("");
        }
        #endregion
        #region Statement
        /// <summary>
        /// create statement from expression.
        /// </summary>
        public CodeExpressionStatement Statement(CodeExpression expression)
        {
            return new CodeExpressionStatement(expression);
        }
        #endregion
        #region If
        /// <summary>
        /// create if statement.
        /// </summary>
        public CodeConditionStatement If()
        {
            return new CodeConditionStatement();
        }
        /// <summary>
        /// create if statement agent.
        /// </summary>
        public CodeConditionStatementAgent<CodeConditionStatement> If(CodeExpression condition)
        {
            return CodeConditionStatementAgentCreator.CreateInstance(new CodeConditionStatement(condition));
        }
        #endregion
        #region For
        /// <summary>
        /// create for statement.
        /// </summary>
        public CodeIterationStatement For()
        {
            var statement = new CodeIterationStatement();
            statement.InitStatement = Empty();
            statement.IncrementStatement = Empty();
            return statement;
        }
        /// <summary>
        /// create if statement agent.
        /// </summary>
        public CodeStatementAgent<CodeIterationStatement> For(CodeStatement initStatement, CodeExpression testExpression, CodeStatement incrementStatement)
        {
            var statement = new CodeIterationStatement(initStatement, testExpression, incrementStatement);
            if (statement.InitStatement == null)
            {
                statement.InitStatement = Empty();
            }
            if (statement.IncrementStatement == null)
            {
                statement.IncrementStatement = Empty();
            }
            return new CodeStatementAgent<CodeIterationStatement>(statement, statement.Statements);
        }
        #endregion
        #region While
        /// <summary>
        /// create agent of for statement which equivalent while statement.
        /// </summary>
        public CodeStatementAgent<CodeIterationStatement> While(CodeExpression testExpression)
        {
            return For(null, testExpression, null);
        }
        #endregion
        #region DoWhile
        /// <summary>
        /// create agent of for statement which equivalent do-while statement.
        /// </summary>
        public CodeStatementAgent<CodeIterationStatement> DoWhile(CodeExpression testExpression)
        {
            return For(Var<bool>("do", true), new CodeVariableReferenceExpression("do"), Assign("do", testExpression));
        }
        #endregion
        #region Try
        /// <summary>
        /// create try-catch-finally statement.
        /// </summary>
        public CodeTryCatchFinallyStatementAgent<CodeTryCatchFinallyStatement> Try()
        {
            return CodeTryCatchFinallyStatementAgentCreator.CreateInstance(new CodeTryCatchFinallyStatement());
        }
        #endregion
        #region Using
        /// <summary>
        /// create agent of try-catch-finally statement which equivalent using statement.
        /// </summary>
        public CodeStatementAgent<CodeConditionStatement> Using(CodeVariableDeclarationStatement variable)
        {
            CodeConditionStatement wrap = new CodeConditionStatement();
            wrap.Condition = new CodePrimitiveExpression(true);
            wrap.TrueStatements.Add(variable);

            CodeTryCatchFinallyStatement tryCatchFinallyStatement = new CodeTryCatchFinallyStatement();
            CodeConditionStatement finallyCondition = new CodeConditionStatement();
            finallyCondition.Condition = new CodeBinaryOperatorExpression(
                new CodeVariableReferenceExpression(variable.Name), 
                CodeBinaryOperatorType.IdentityInequality, 
                new CodePrimitiveExpression(null)
            );
            finallyCondition.TrueStatements.Add(
                new CodeMethodInvokeExpression(
                    new CodeCastExpression(typeof(IDisposable), new CodeVariableReferenceExpression(variable.Name)),
                    "Dispose"
                )
            );
            tryCatchFinallyStatement.FinallyStatements.Add(finallyCondition);

            var nestAgent = new CodeStatementAgent<CodeConditionStatement>(wrap, tryCatchFinallyStatement.TryStatements);
            wrap.TrueStatements.Add(tryCatchFinallyStatement);

            return nestAgent;
        }
        #endregion
        #region Throw
        /// <summary>
        /// create throw statement.
        /// </summary>
        public CodeThrowExceptionStatement Throw<E>()
            where E : Exception
        {
            return new CodeThrowExceptionStatement(new CodeObjectCreateExpression(typeof(E)));
        }
        /// <summary>
        /// create throw statement.
        /// </summary>
        public CodeThrowExceptionStatement Throw<E>(string message)
            where E : Exception
        {
            return new CodeThrowExceptionStatement(new CodeObjectCreateExpression(typeof(E), new CodePrimitiveExpression(message)));
        }
        /// <summary>
        /// create throw statement.
        /// </summary>
        public CodeThrowExceptionStatement Throw(string type, string message)
        {
            return new CodeThrowExceptionStatement(new CodeObjectCreateExpression(type, new CodePrimitiveExpression(message)));
        }
        /// <summary>
        /// create throw statement.
        /// </summary>
        public CodeThrowExceptionStatement Throw(CodeExpression toThrow)
        {
            return new CodeThrowExceptionStatement(toThrow);
        }
        #endregion
        #region Return
        /// <summary>
        /// create return statement.
        /// </summary>
        public CodeMethodReturnStatement Return()
        {
            return new CodeMethodReturnStatement();
        }
        /// <summary>
        /// create return statement.
        /// </summary>
        public CodeMethodReturnStatement Return(CodeExpression expression)
        {
            return new CodeMethodReturnStatement(expression);
        }
        /// <summary>
        /// create return statement.
        /// </summary>
        public CodeMethodReturnStatement Return(string variableName)
        {
            return new CodeMethodReturnStatement(new CodeVariableReferenceExpression(variableName));
        }
        /// <summary>
        /// create return statement.
        /// </summary>
        public CodeMethodReturnStatement Return(object value)
        {
            return new CodeMethodReturnStatement(new CodePrimitiveExpression(value));
        }
        #endregion
        #region Var
        /// <summary>
        /// create variable declaration statement.
        /// </summary>
        public CodeVariableDeclarationStatement Var(string type, string name)
        {
            return new CodeVariableDeclarationStatement(type, name);
        }
        /// <summary>
        /// create variable declaration statement.
        /// </summary>
        public CodeVariableDeclarationStatement Var(string type, string name, CodeExpression initExpression)
        {
            return new CodeVariableDeclarationStatement(type, name, initExpression);
        }
        /// <summary>
        /// create variable declaration statement.
        /// </summary>
        public CodeVariableDeclarationStatement Var(string type, string name, object value)
        {
            return new CodeVariableDeclarationStatement(type, name, new CodePrimitiveExpression(value));
        }
        /// <summary>
        /// create variable declaration statement.
        /// </summary>
        public CodeVariableDeclarationStatement Var<T>(string name)
        {
            return new CodeVariableDeclarationStatement(typeof(T), name);
        }
        /// <summary>
        /// create variable declaration statement.
        /// </summary>
        public CodeVariableDeclarationStatement Var<T>(string name, CodeExpression initExpression)
        {
            return new CodeVariableDeclarationStatement(typeof(T), name, initExpression);
        }
        /// <summary>
        /// create variable declaration statement.
        /// </summary>
        public CodeVariableDeclarationStatement Var<T>(string name, T value)
        {
            return new CodeVariableDeclarationStatement(typeof(T), name, new CodePrimitiveExpression(value));
        }
        /// <summary>
        /// create variable declaration statement.
        /// </summary>
        public CodeVariableDeclarationStatement Var(Type type, string name)
        {
            return new CodeVariableDeclarationStatement(type, name);
        }
        /// <summary>
        /// create variable declaration statement.
        /// </summary>
        public CodeVariableDeclarationStatement Var(Type type, string name, CodeExpression initExpression)
        {
            return new CodeVariableDeclarationStatement(type, name, initExpression);
        }
        /// <summary>
        /// create variable declaration statement.
        /// </summary>
        public CodeVariableDeclarationStatement Var(Type type, string name, object value)
        {
            return new CodeVariableDeclarationStatement(type, name, new CodePrimitiveExpression(value));
        }
        #endregion
        #region Assign
        /// <summary>
        /// create assign statement.
        /// </summary>
        public CodeAssignStatement Assign(CodeExpression left, CodeExpression right)
        {
            return new CodeAssignStatement(left, right);
        }
        /// <summary>
        /// create assign statement.
        /// </summary>
        public CodeAssignStatement Assign(string leftVariableName, string rightVariableName)
        {
            return new CodeAssignStatement(new CodeVariableReferenceExpression(leftVariableName), new CodeVariableReferenceExpression(rightVariableName));
        }
        /// <summary>
        /// create assign statement.
        /// </summary>
        public CodeAssignStatement Assign(CodeExpression left, string rightVariableName)
        {
            return new CodeAssignStatement(left, new CodeVariableReferenceExpression(rightVariableName));
        }
        /// <summary>
        /// create assign statement.
        /// </summary>
        public CodeAssignStatement Assign(string leftVariableName, CodeExpression right)
        {
            return new CodeAssignStatement(new CodeVariableReferenceExpression(leftVariableName), right);
        }
        /// <summary>
        /// create assign statement.
        /// </summary>
        public CodeAssignStatement Assign(CodeExpression left, object value)
        {
            return new CodeAssignStatement(left, new CodePrimitiveExpression(value));
        }
        /// <summary>
        /// create assign statement.
        /// </summary>
        public CodeAssignStatement Assign(string leftVariableName, object value)
        {
            return new CodeAssignStatement(new CodeVariableReferenceExpression(leftVariableName), new CodePrimitiveExpression(value));
        }
        #endregion
        #region AttachEvent
        /// <summary>
        /// create attach event statement.
        /// </summary>
        public CodeAttachEventStatement AttachEvent(CodeExpression targetObject, string eventName, CodeExpression listener)
        {
            return new CodeAttachEventStatement(targetObject, eventName, listener);
        }
        /// <summary>
        /// create attach event statement.
        /// </summary>
        public CodeAttachEventStatement AttachEvent(CodeEventReferenceExpression @event, CodeExpression listener)
        {
            return new CodeAttachEventStatement(@event, listener);
        }
        #endregion
        #region DetachEvent
        /// <summary>
        /// create detach event statement.
        /// </summary>
        public CodeRemoveEventStatement DetachEvent(CodeExpression targetObject, string eventName, CodeExpression listener)
        {
            return new CodeRemoveEventStatement(targetObject, eventName, listener);
        }
        /// <summary>
        /// create detach event statement.
        /// </summary>
        public CodeRemoveEventStatement DetachEvent(CodeEventReferenceExpression @event, CodeExpression listener)
        {
            return new CodeRemoveEventStatement(@event, listener);
        }
        #endregion
        #region Comment
        /// <summary>
        /// create comment statement.
        /// </summary>
        public CodeCommentStatement Comment(string text)
        {
            return new CodeCommentStatement(text);
        }
        /// <summary>
        /// create comment statement.
        /// </summary>
        public CodeCommentStatement Comment(string text, bool docComment)
        {
            return new CodeCommentStatement(text, docComment);
        }
        #endregion
        #region Label
        /// <summary>
        /// create label statement.
        /// </summary>
        public CodeLabeledStatement Label(string label)
        {
            return new CodeLabeledStatement(label);
        }
        #endregion
        #region Goto
        /// <summary>
        /// create goto statement.
        /// </summary>
        public CodeGotoStatement Goto(string label)
        {
            return new CodeGotoStatement(label);
        }
        #endregion
        #region Snippet
        /// <summary>
        /// create snippet statement.
        /// </summary>
        public CodeExpressionStatement Snippet(string text)
        {
            return new CodeExpressionStatement(new CodeSnippetExpression(Regex.Replace(text, @";\s*", "")));
        }
        #endregion
    }
}
