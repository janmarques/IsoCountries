using Xunit;
using ExtendedIsoCountries;
namespace CountryTests
{
    public class CountryExtensibilityTests
    {
        [Fact]
        public void AddCustomCountries()
        {
            var originalCount = Country.Countries.Count;

            Country.Countries.Add(new Country("Fantasia land", "fa", "fan", 999, "fantasist", "fantasist"));

            Assert.Equal(originalCount + 1, Country.Countries.Count);
            Assert.Equal("fan", Country.GetBy2CharacterCode("fa").Alpha3Code);
        }
    }
}
