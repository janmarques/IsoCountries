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
            Assert.Equal("ES", country.Alpha2Code);
            Assert.Equal("ESP", country.Alpha3Code);
            Assert.Equal(724, country.NumericCode);
            Assert.Equal("Spain", country.Name);
            Assert.Equal("Spanish", country.Adjective); // (a Spanish beer)
            Assert.Equal("Spaniard", country.Demonym); // (a Spaniard living in Barcelona)
            Assert.True(country.HasAdjective);
            Assert.True(country.HasDemonym);
        }
    }
}
