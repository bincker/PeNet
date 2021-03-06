// <copyright file="ImportFunctionTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeNet.Tests
{
    [TestClass]
    [PexClass(typeof(ImportFunction))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ImportFunctionTest
    {
        [PexMethod]
        public ImportFunction Constructor(
            string name,
            string dll,
            ushort hint
            )
        {
            var target = new ImportFunction(name, dll, hint);
            return target;
            // TODO: add assertions to method ImportFunctionTest.Constructor(String, String, UInt16)
        }

        [PexMethod]
        public string ToString01([PexAssumeUnderTest] ImportFunction target)
        {
            var result = target.ToString();
            return result;
            // TODO: add assertions to method ImportFunctionTest.ToString01(ImportFunction)
        }
    }
}