## Synopsis
List of ISO country codes, with their 2-character, 3 character and numeric code. Includes English country name, demonym and adjective.

## Code Example
Add reference to namespace ``ExtendedIsoCountries``.
Entry point is the ``Country`` class. 
Get all countries via ``Country.Countries``, or search through them via:
* ``Country.GetBy2CharacterCode()``
* ``Country.GetBy3CharacterCode()``
* ``Country.GetByNumericCode()``

## Motivation
No nuget package of countries with respective demonyms and adjectives existed so far. 

## Installation
Install via nuget, the package is named ``ExtendedIsoCountries``. Currently prerelease
