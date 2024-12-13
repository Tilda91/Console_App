
using System;
using Xunit;

namespace MainApp.Tests
{
    public class IdGeneratorTests
    {
        [Fact]
        public void GenerateGuidId_ShouldReturnNewGuid()
        {

            var result = IdGenerator.GenerateGuidId();

            Assert.NotNull(result);

            Assert.IsType<Guid>(result);

            var result2 = IdGenerator.GenerateGuidId();
            Assert.NotEqual(result, result2);
        }
    }
}