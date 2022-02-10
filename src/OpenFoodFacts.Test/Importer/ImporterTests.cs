using System;
using Xunit;
using OpenFoodFacts.Importer;

namespace OpenFoodFacts.Test.Importer
{
    public class ImporterTests
    {
        [Fact]
        public void Should_Build3FoodRecords_When_ImportFullRowsWithHeather()
        {
            // Arrange
            StubReader reader = new StubReader(StubReader.ValidData3);
            StubWriter writer = new StubWriter();
            CSVVersion version = new CSVVersion();
            CSVImporter importer = new CSVImporter(reader, writer, version);

            // Act
            var result = importer.ImportAsync().Result;

            // Assert
            Assert.True(result.Successful);
            Assert.Equal(3, result.ImportCount);
            Assert.Equal(3, result.TotalRecords);
            Assert.Equal(0, result.FailedCount);
        }

        [Fact]
        public void Should_Build3FoodRecords_When_ImportedPartialRowsWithHeader()
        {
            // Arrange
            StubReader reader = new StubReader(StubReader.ValidData3Split);
            StubWriter writer = new StubWriter();
            CSVVersion version = new CSVVersion();
            CSVImporter importer = new CSVImporter(reader, writer, version);

            // Act
            var result = importer.ImportAsync().Result;

            // Assert
            Assert.True(result.Successful);
            Assert.Equal(3, result.ImportCount);
            Assert.Equal(3, result.TotalRecords);
            Assert.Equal(0, result.FailedCount);
        }
    }
}
