using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        //Add additional inline data. Refer to your CSV file.
        [InlineData("30.459515, -84.35516, Taco Bell Tallahassee...", -84.35516)]
        [InlineData("33.889469,-84.057706,Taco Bell Lawrenceville...", -84.057706)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line).Location.Longitude;     //** returns ITrackable **
            //Assert
            Assert.Equal(expected, actual);  // *? Is this right??  expected was a double 
        }                                                          // actual was an ITrackable   
                                                                   // **?  Should we be parsing to strings?? *

        //TODO: Create a test called ShouldParseLatitude
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line).Location.Latitude;
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
