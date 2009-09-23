using System;
using System.Linq;
using System.CodeDom;
using System.ComponentModel;
using SuperCodeDom.Agent;

namespace SuperCodeDom.Extension
{
    /// <summary>
    /// extension for statement agent.
    /// </summary>
    public static partial class AgentExtension
    {
        private static StatementCreator S = new StatementCreator();

        //CodeStatementAgentBase
        #region Add
        /// <summary>
        /// add statement.
        /// </summary>
        public static This Add<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeExpression expression)
            where This : CodeStatementAgentBase<Holder, This>
        {
            agent.Statements.Add(expression);
            return agent.This;
        }
        /// <summary>
        /// add statement.
        /// </summary>
        public static This Add<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeStatement statement)
            where This : CodeStatementAgentBase<Holder, This>
        {
            agent.Statements.Add(statement);
            return agent.This;
        }
        /// <summary>
        /// add statements.
        /// </summary>
        public static This Add<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeStatementCollection statements)
            where This : CodeStatementAgentBase<Holder, This>
        {
            agent.Statements.AddRange(statements);
            return agent.This;
        }
        /// <summary>
        /// add statements.
        /// </summary>
        public static This Add<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, params CodeStatement[] statements)
            where This : CodeStatementAgentBase<Holder, This>
        {
            agent.Statements.AddRange(statements);
            return agent.This;
        }
        #endregion
        #region Return
        /// <summary>
        /// add return statement.
        /// </summary>
        public static This Return<Holder, This>(this CodeStatementAgentBase<Holder, This> agent)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Return());
        }
        /// <summary>
        /// add return statement.
        /// </summary>
        public static This Return<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeExpression expression)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Return(expression));
        }
        /// <summary>
        /// add return statement.
        /// </summary>
        public static This Return<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, string variableName)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Return(variableName));
        }
        /// <summary>
        /// add return statement.
        /// </summary>
        public static This Return<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, object value)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Return(value));
        }
        #endregion
        #region Var
        /// <summary>
        /// add variable declaration statement.
        /// </summary>
        public static This Var<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, string type, string variableName)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Var(type, variableName));
        }
        /// <summary>
        /// add variable declaration statement.
        /// </summary>
        public static This Var<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, string type, string variableName, CodeExpression initExpression)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Var(type, variableName, initExpression));
        }
        /// <summary>
        /// add variable declaration statement.
        /// </summary>
        public static This Var<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, string type, string variableName, object value)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Var(type, variableName, value));
        }
        /// <summary>
        /// add variable declaration statement.
        /// </summary>
        public static This Var<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, Type type, string variableName)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Var(type, variableName));
        }
        /// <summary>
        /// add variable declaration statement.
        /// </summary>
        public static This Var<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, Type type, string variableName, CodeExpression initExpression)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Var(type, variableName, initExpression));
        }
        /// <summary>
        /// add variable declaration statement.
        /// </summary>
        public static This Var<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, Type type, string variableName, object value)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Var(type, variableName, value));
        }
        #endregion
        #region Assign
        /// <summary>
        /// add assign statement.
        /// </summary>
        public static This Assign<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeExpression left, CodeExpression right)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Assign(left, right));
        }
        /// <summary>
        /// add assign statement.
        /// </summary>
        public static This Assign<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, string leftVariableName, string rightVariableName)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Assign(leftVariableName, rightVariableName));
        }
        /// <summary>
        /// add assign statement.
        /// </summary>
        public static This Assign<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, string leftVariableName, object value)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Assign(leftVariableName, value));
        }
        #endregion
        #region Snippet
        /// <summary>
        /// add snippet statement.
        /// </summary>
        public static This Snippet<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, string text)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(S.Snippet(text));
        }
        #endregion
        #region Print
        /// <summary>
        /// add Console.WriteLine execution statement.
        /// </summary>
        public static This Print<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, string text)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(new CodeTypeReferenceExpression(typeof(Console)).Method("WriteLine").Invoke((object)text));
        }
        /// <summary>
        /// add Console.WriteLine execution statement.
        /// </summary>
        public static This Print<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeExpression text)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(new CodeTypeReferenceExpression(typeof(Console)).Method("WriteLine").Invoke(text));
        }
        /// <summary>
        /// add WriteLine execution statement.
        /// </summary>
        public static This Print<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeExpression printObject, string text)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(printObject.Method("WriteLine").Invoke((object)text));
        }
        /// <summary>
        /// add WriteLine execution statement.
        /// </summary>
        public static This Print<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeExpression printObject, CodeExpression text)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return agent.Add(printObject.Method("WriteLine").Invoke(text));
        }
        #endregion
        #region If
        /// <summary>
        /// starts nested if statement.
        /// </summary>
        [Description("starts nested if statement.")]
        public static CodeConditionStatementAgent<This> If<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeExpression condition)
            where This : CodeStatementAgentBase<Holder, This>
        {
            var nestAgent = CodeConditionStatementAgentCreator.CreateInstance(agent.This, new CodeConditionStatement(condition));
            agent.Add(nestAgent.Statement);
            return nestAgent.This;
        }
        #endregion
        #region For
        /// <summary>
        /// starts nested for statement.
        /// </summary>
        [Description("starts nested for statement.")]
        public static CodeStatementAgent<This> For<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeStatement initStatement, CodeExpression testExpression, CodeStatement incrementStatement)
            where This : CodeStatementAgentBase<Holder, This>
        {
            var statement = new CodeIterationStatement(initStatement, testExpression, incrementStatement);
            if (statement.InitStatement == null)
            {
                statement.InitStatement = S.Empty();
            }
            if (statement.IncrementStatement == null)
            {
                statement.IncrementStatement = S.Empty();
            }
            var nestAgent = new CodeStatementAgent<This>(agent.This, statement.Statements);
            agent.Add(statement);
            return nestAgent.This;
        }
        #endregion
        #region While
        /// <summary>
        /// starts nested while statement.
        /// </summary>
        [Description("starts nested while compatible for statement.")]
        public static CodeStatementAgent<This> While<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeExpression testExpression)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return For(agent, null, testExpression, null);
        }
        #endregion
        #region DoWhile
        /// <summary>
        /// starts nested do-while statement.
        /// </summary>
        [Description("starts nested do-while compatible for statement.")]
        public static CodeStatementAgent<This> DoWhile<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeExpression testExpression)
            where This : CodeStatementAgentBase<Holder, This>
        {
            return For(agent, S.Var<bool>("do", true), new CodeVariableReferenceExpression("do"), S.Assign("do", testExpression));
        }
        #endregion
        #region Try
        /// <summary>
        /// starts nested try-catch-finally statement.
        /// </summary>
        [Description("starts nested try-catch-finally statement.")]
        public static CodeTryCatchFinallyStatementAgent<This> Try<Holder, This>(this CodeStatementAgentBase<Holder, This> agent)
            where This : CodeStatementAgentBase<Holder, This>
        {
            var nestAgent = CodeTryCatchFinallyStatementAgentCreator.CreateInstance(agent.This, new CodeTryCatchFinallyStatement());
            agent.Add(nestAgent.Statement);
            return nestAgent;
        }
        #endregion
        #region Using
        /// <summary>
        /// starts nested using statement.
        /// </summary>
        [Description("starts nested using compatible try-catch-finally statement.")]
        public static CodeStatementAgent<This> Using<Holder, This>(this CodeStatementAgentBase<Holder, This> agent, CodeVariableDeclarationStatement variable)
            where This : CodeStatementAgentBase<Holder, This>
        {
            CodeConditionStatement wrap = new CodeConditionStatement();
            wrap.Condition = new CodePrimitiveExpression(true);
            wrap.TrueStatements.Add(variable);

            CodeTryCatchFinallyStatement tryCatchFinallyStatement = new CodeTryCatchFinallyStatement();
            CodeConditionStatement finallyCondition = new CodeConditionStatement();
            finallyCondition.Condition = new CodeVariableReferenceExpression(variable.Name).Ne(new CodePrimitiveExpression(null));
            finallyCondition.TrueStatements.Add(
                new CodeCastExpression(typeof(IDisposable), new CodeVariableReferenceExpression(variable.Name)).Method("Dispose").Invoke()
            );
            tryCatchFinallyStatement.FinallyStatements.Add(finallyCondition);

            wrap.TrueStatements.Add(tryCatchFinallyStatement);

            var nestAgent = new CodeStatementAgent<This>(agent.This, tryCatchFinallyStatement.TryStatements);
            agent.Add(wrap);

            return nestAgent;
        }
        #endregion

        //CodeConditionStatementAgent
        #region Else
        /// <summary>
        /// change statements to FalseStatements.
        /// </summary>
        public static CodeConditionStatementAgent<Holder> Else<Holder>(this CodeConditionStatementAgent<Holder> agent)
        {
            agent.Statements = agent.Statement.FalseStatements;
            return agent.This;
        }
        #endregion

        //CodeTryCatchFinallyStatementAgent
        #region Catch
        /// <summary>
        /// change statements to CatchClause.
        /// </summary>
        public static CodeTryCatchFinallyStatementAgent<Holder> Catch<Holder>(this CodeTryCatchFinallyStatementAgent<Holder> agent)
        {
            return agent.Catch((CodeTypeReference)null, null);
        }
        /// <summary>
        /// change statements to CatchClause.
        /// </summary>
        public static CodeTryCatchFinallyStatementAgent<Holder> Catch<Holder>(this CodeTryCatchFinallyStatementAgent<Holder> agent, string type, string localName)
        {
            return agent.Catch(new CodeTypeReference(type), null);
        }
        /// <summary>
        /// change statements to CatchClause.
        /// </summary>
        public static CodeTryCatchFinallyStatementAgent<Holder> Catch<Holder>(this CodeTryCatchFinallyStatementAgent<Holder> agent, Type type)
        {
            return agent.Catch(new CodeTypeReference(type), null);
        }
        /// <summary>
        /// change statements to CatchClause.
        /// </summary>
        public static CodeTryCatchFinallyStatementAgent<Holder> Catch<Holder>(this CodeTryCatchFinallyStatementAgent<Holder> agent, Type type, string localName)
        {
            return agent.Catch(new CodeTypeReference(type), localName);
        }
        /// <summary>
        /// change statements to CatchClause.
        /// </summary>
        public static CodeTryCatchFinallyStatementAgent<Holder> Catch<Holder>(this CodeTryCatchFinallyStatementAgent<Holder> agent, CodeTypeReference type, string localName)
        {
            CodeCatchClause clause = new CodeCatchClause();
            if (type != null) clause.CatchExceptionType = type;
            if (localName != null) clause.LocalName = localName;
            agent.Statement.CatchClauses.Add(clause);
            agent.Statements = clause.Statements;
            return agent.This;
        }
        #endregion
        #region Finally
        /// <summary>
        /// change statements to FinallyStatements.
        /// </summary>
        public static CodeTryCatchFinallyStatementAgent<Holder> Finally<Holder>(this CodeTryCatchFinallyStatementAgent<Holder> agent)
        {
            agent.Statements = agent.Statement.FinallyStatements;
            return agent.This;
        }
        #endregion
    }
}
