using Xunit;
using ExtendedIsoCountries;
using System.Linq;
namespace CountryTests
{
    public class CountryTests
    {
        [Fact]
        public void AllCountriesPresent() => Assert.Equal(249, Country.Countries.Count);

        [Fact]
        public void AllHaveAlpha2Code() => Assert.True(Country.Countries.All(x => !string.IsNullOrEmpty(x.Alpha2Code)));

        [Fact]
        public void AllHaveAlpha3Code() => Assert.True(Country.Countries.All(x => !string.IsNullOrEmpty(x.Alpha3Code)));

        [Fact]
        public void AllHaveNumeric() => Assert.True(Country.Countries.All(x => default(int) != x.NumericCode));

        [Fact]
        public void AllHaveName() => Assert.True(Country.Countries.All(x => !string.IsNullOrEmpty(x.Name)));

        [Theory]
        [InlineData("BE", 56)]
        [InlineData("KI", 296)]
        public void GetBy2Letter(string _2letterCode, int numericCode)
        {
            Assert.Equal(numericCode, Country.GetBy2CharacterCode(_2letterCode).NumericCode);
        }

        [Theory]
        [InlineData("BEL", 56)]
        [InlineData("KIR", 296)]
        public void GetBy3Letter(string _3letterCode, int numericCode)
        {
            Assert.Equal(numericCode, Country.GetBy3CharacterCode(_3letterCode).NumericCode);
        }

        [Theory]
        [InlineData(56, "BEL")]
        [InlineData(296, "KIR")]
        public void GetByNumeric(int numericCode, string _3letterCode)
        {
            Assert.Equal(_3letterCode, Country.GetByNumericCode(numericCode).Alpha3Code);
        }

        [Theory]
        [InlineData(56, true, "Belgian")]
        [InlineData(724, true, "Spaniard")]
        [InlineData(10, false, "Antarticatician is not a real word")]
        [InlineData(74, false, "Bouvet islander is not a real word")]
        public void CheckDemonym(int numericCode, bool hasDemonym, string demonym)
        {
            var country = Country.GetByNumericCode(numericCode);
            Assert.Equal(hasDemonym, country.HasDemonym);
            if (hasDemonym)
            {
                Assert.Equal(demonym, country.Demonym);
            }
            else
            {
                Assert.Null(country.Demonym);
            }
        }

        [Theory]
        [InlineData(56, true, "Belgian")]
        [InlineData(724, true, "Spanish")]
        [InlineData(10, true, "Antarctic")]
        [InlineData(74, false, "Bouvet islander is not a real word")]
        public void CheckAdjective(int numericCode, bool hasAdjective, string adjective)
        {
            var country = Country.GetByNumericCode(numericCode);
            Assert.Equal(hasAdjective, country.HasAdjective);
            if (hasAdjective)
            {
                Assert.Equal(adjective, country.Adjective);
            }
            else
            {
                Assert.Null(country.Adjective);
            }
        }
    }
}
