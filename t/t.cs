using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using System.IO;
using System.Diagnostics;
using System.CodeDom;

using SuperCodeDom.Extension;
using SuperCodeDom.NestExtention;
using SuperCodeDom;

namespace t
{
    public class t
    {
        private static ExpressionCreator E = new ExpressionCreator();
        private static StatementCreator S = new StatementCreator();
        private static DeclarationCreator D = new DeclarationCreator();

        public static void Test()
        {
            DeclarationTest();
            ExpressionTest();
        }

        public static void Output(string str)
        {
            Debug.WriteLine(str);
        }
        #region OutputCodeObject
        public static void OutputCodeObject(CodeCompileUnit unit)
        {
            OutputCodeObject((p, w, o) => { p.GenerateCodeFromCompileUnit(unit, w, o); });
        }
        public static void OutputCodeObject(CodeNamespace ns)
        {
            OutputCodeObject((p, w, o) => { p.GenerateCodeFromNamespace(ns, w, o); });
        }
        public static void OutputCodeObject(CodeTypeDeclaration type)
        {
            OutputCodeObject((p, w, o) => { p.GenerateCodeFromType(type, w, o); });
        }
        public static void OutputCodeObject(CodeTypeMember member)
        {
            OutputCodeObject((p, w, o) => { p.GenerateCodeFromMember(member, w, o); });
        }
        public static void OutputCodeObject(CodeStatement statement)
        {
            OutputCodeObject((p, w, o) => { p.GenerateCodeFromStatement(statement, w, o); });
        }
        public static void OutputCodeObject(CodeExpression expression)
        {
            OutputCodeObject((p, w, o) => { p.GenerateCodeFromExpression(expression, w, o); });
        }
        private delegate void GenerateCode(CodeDomProvider provider, TextWriter writer, CodeGeneratorOptions ooption);
        private static void OutputCodeObject(GenerateCode generate)
        {
            using (CodeDomProvider provider = CodeDomProvider.CreateProvider("C#"))
            using (StringWriter sw = new StringWriter())
            {
                CodeGeneratorOptions options = new CodeGeneratorOptions();
                options.BlankLinesBetweenMembers = false;
                options.BracingStyle = "C";
                //options.ElseOnClosing = true;
                generate(provider, sw, options);
                Output(sw.ToString());
            }
        }
        #endregion
        #region DeclarationTest
        public static void DeclarationTest()
        {
            var exp = D.Unit();
            var ns = D.Namespace("Aaa");
            exp.Namespaces.Add(ns);
            var type = D.Type("if");
            ns.Types.Add(type);
            var method = D.Method("00aa");
            type.Members.Add(method);

            OutputCodeObject(exp);
        }
        #endregion
        #region ExpressionTest
        public static void ExpressionTest()
        {
            var statement = S
                .If(E.This().Property("IsEasy"))
                    .Print("Good!")
                .Else()
                    .Print("Sorry.")
                    .Return(false)
                .End();
            OutputCodeObject(statement);

            var exp = E.Type("System.String").Method("Format").Invoke();
            var exp2_1 = E.New("System.String").Param((object)"");
            var exp2_2 = E.New<string>().Param((object)"");
            var exp3 = S
            .If(E.Val(true))
                .For(S.Var<int>("i", 0), E.Var("i").Lt(E.Val(10)), E.Var("i").Increment())
                    .For(S.Var<int>("j", 100), E.Val(true), E.Var("i").Decrement())
                        .Add(E.Var("i").Mod(3))
                        .Return()
                    .End()
                .End()
                .For(null, E.Val(true), null)
                    .Return()
                .End()
                .For(null, E.Val(true), null)
                    .Add()
                .End()
                .Snippet("aaa = bbb;")
                .Add(E.New<string>())
                .Add(E.New<string>().Param((object)"aaa"))
                .Var(typeof(string), "hoge")
                .Assign("hoge", (object)"fuga")
                .Var(typeof(int), "num", 100)
                .Return()
                .___Return()
            .Else()
                .Add(E.New<string>())
                .Add(E.New<string>())
                .Return()
                .Add(E.New<string>())
                .Add(E.New<string>())
            .End()
            ;
            OutputCodeObject(exp3);
            var exp4 = S
            .Try()
                .Add(E.New<string>())
                .Add(E.New<string>().Param((object)"aaa"))
                .Return()
            .Catch(typeof(InvalidOperationException), "ex")
                .Add(E.New<string>())
                .Return()
                .Add(E.New<string>())
                .Add(E.New<string>())
                .Add(E.New<string>())
                .Try()
                    .Add(E.New<string>())
                    .Add(E.New<string>())
                    .Add(E.New<string>())
                    .___(E.New<string>())
                    .Add(E.New<string>())
                .Catch("Exception", "exx")
                .Finally()
                    .Return()
                .End()
            .Finally()
                .Add(E.New<string>())
            .End();
            OutputCodeObject(exp4);

            var exp5 = S
            .If(E.Val(true))
                .If(E.Val(true))
                    .Return()
                .End()
            .Else()
                .If(E.Val(false))
                    .Return()
                .Else()
                    .Return()
                .End()
            .End();

            var exp6 = D
            .Method("DoHoge")
            .Body()
                .Var(typeof(int), "aaa", 0)
                .DoWhile(E.Var("aaa").Le(100))
                    .Add(E.Var("aaa").Increment())
                    .Using(S.Var("System.IO.StringWriter", "sw", E.New("System.IO.StringWriter")))
                        .Add(E.Var("sw").Method("WriteLine").Invoke(E.Val("Hello! World!")))
                        .Add(S.Return(), S.Return())
                    .End()
                    .Add(
                        S.Using(S.Var("System.IO.StringWriter", "sw", E.New("System.IO.StringWriter")))
                        .End()
                    )
                .End()
            .End();

            OutputCodeObject(exp6);
        }
        #endregion
    }
}
