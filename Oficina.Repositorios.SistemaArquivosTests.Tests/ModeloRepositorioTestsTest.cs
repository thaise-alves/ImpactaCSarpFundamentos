// <copyright file="ModeloRepositorioTestsTest.cs">Copyright ©  2019</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos.Tests;

namespace Oficina.Repositorios.SistemaArquivos.Tests.Tests
{
    /// <summary>This class contains parameterized unit tests for ModeloRepositorioTests</summary>
    [PexClass(typeof(ModeloRepositorioTests))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ModeloRepositorioTestsTest
    {
        /// <summary>Test stub for ObterPorIdTest()</summary>
        [PexMethod]
        public void ObterPorIdTestTest([PexAssumeUnderTest]ModeloRepositorioTests target)
        {
            target.ObterPorIdTest();
            // TODO: add assertions to method ModeloRepositorioTestsTest.ObterPorIdTestTest(ModeloRepositorioTests)
        }
    }
}
