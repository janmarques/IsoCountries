using Xunit;
using ExtendedIsoCountries;

namespace CountryTests
{
    public class ReadmeSample
    {
        [Fact]
        public void ReadmeExample_Spain()
        {
            var country = Country.GetBy2CharacterCode("ES");
            Assert.Equal(country.Alpha2Code, "ES");
            Assert.Equal(country.Alpha3Code, "ESP");
            Assert.Equal(country.NumericCode, 724);
            Assert.Equal(country.Name, "Spain");
            Assert.Equal(country.Adjective, "Spanish"); // (a Spanish beer)
            Assert.Equal(country.Demonym, "Spaniard"); // (a Spaniard living in Barcelona)
            Assert.Equal(country.HasAdjective, true);
            Assert.Equal(country.HasDemonym, true);
        }
    }
}
