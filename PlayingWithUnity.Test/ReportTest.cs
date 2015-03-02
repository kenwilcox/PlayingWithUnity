using System;
using System.Collections.Generic;
using PlayingWithUnity.Interface;
using PlayingWithUnity.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace PlayingWithUnity.Test
{
  [TestClass]
  public class ReportTest
  {
    [TestMethod]
    public void ExecuteTest()
    {
      var fetcher = new Mock<IDataFetcher>(MockBehavior.Strict);
      var transformer = new Mock<ITransformer>(MockBehavior.Strict);

      var testData = new List<string> {"This", "Is", "Another", "Test"};

      fetcher.Setup(s => s.Fetch()).Returns(() => { return testData; });
      transformer.Setup(s => s.Transform(It.IsAny <IEnumerable<string>>())).Returns(It.IsAny<string>());

      var report = new Report(fetcher.Object, transformer.Object);
      report.Execute();

      fetcher.Verify(v => v.Fetch(), Times.Once);
      transformer.Verify(v => v.Transform(It.Is<IEnumerable<string>>(i => i == testData)), Times.Once);
    }
  }
}
