using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [TestFixture]
    public class test
    {
        [Test]
        public void Test1()
        {
            StringReader input = new StringReader("Tomc\t12345678\t2年");
            StringReader input2 = new StringReader("${中文姓名}先生(身份证字号${身份证字号})为本校专任教师，聘期${年数}。");
            StringWriter output = new StringWriter();

            MergeDataAndDoc.Program.funciton(input, input2, output);
            Assert.That(output.ToString(), Is.EqualTo("Tomc先生(身份证字号12345678)为本校专任教师，聘期2年。\r\n\r\n\r\n"));
        }
    }
}