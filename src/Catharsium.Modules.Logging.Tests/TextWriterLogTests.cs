using System.IO;
using Xunit;

namespace Catharsium.Modules.Logging.Tests
{
    public class TextWriterLogTests
    {
        #region Fixture

        protected StringWriter MockWriter;

        protected static readonly string Data = "My test data";


        public TextWriterLogTests()
        {
            MockWriter = new StringWriter();
        }

        #endregion


        [Fact]
        public void TextWriterLog_StringAndType_OutputContainsDataAndType()
        {
            var sut = new TextWriterLog(MockWriter);
            sut.Info(Data, GetType());
            var actual = MockWriter.ToString();
            Assert.Contains(Data, actual);
            Assert.Contains(GetType().Name, actual);
        }


        [Fact]
        public void TextWriterLog_ObjectAndObject_OutputContainsDataAndType()
        {
            var sut = new TextWriterLog(MockWriter);
            sut.Info(Data as object, MockWriter.GetType());
            var actual = MockWriter.ToString();
            Assert.Contains(Data, actual);
            Assert.Contains(MockWriter.GetType().Name, actual);
        }
    }
}