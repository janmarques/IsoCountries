## Synopsis
List of ISO country codes, with their 2-character, 3 character and numeric code. Includes English country name, demonym and adjective.

## Code Example
Add reference to namespace ``ExtendedIsoCountries``.
Entry point is the ``Country`` class. 
Get all countries via ``Country.Countries``, or search through them via:
* ``Country.GetBy2CharacterCode()``
* ``Country.GetBy3CharacterCode()``
* ``Country.GetByNumericCode()``

''
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
''

## Motivation
No nuget package of countries with respective demonyms and adjectives existed so far. 

## Installation
Install via nuget, the package is named ``ExtendedIsoCountries``. Currently prerelease
