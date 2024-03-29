// <copyright file="PexAssemblyInfo.cs">Copyright ©  2019</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("Oficina.Repositorios.SistemaArquivosTests")]
[assembly: PexInstrumentAssembly("Oficina.Dominio")]
[assembly: PexInstrumentAssembly("Oficina.Repositorios.SistemaArquivos")]
[assembly: PexInstrumentAssembly("Microsoft.VisualStudio.QualityTools.UnitTestFramework")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Oficina.Dominio")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Oficina.Repositorios.SistemaArquivos")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.VisualStudio.QualityTools.UnitTestFramework")]

