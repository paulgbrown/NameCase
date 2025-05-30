﻿using PgbNameCase;

namespace UnitTests.NameCaseFormatterShould;

public class GivenANameThatStartsWithO
{
	[Theory]
	[InlineData("Alex O'Loughlin")]
	[InlineData("Alexis Ohanian")]
	[InlineData("Ana Ortiz")]
	[InlineData("Ashley Olsen")]
	[InlineData("Aubrey O'Day")]
	[InlineData("Barack Obama")]
	[InlineData("Beth Ostrosky Stern")]
	[InlineData("Chad Ochocinco")]
	[InlineData("Charlie O'Connell")]
	[InlineData("Chord Overstreet")]
	[InlineData("Clive Owen")]
	[InlineData("Conan O'Brien")]
	[InlineData("Corinne Olympios")]
	[InlineData("Daphne Oz")]
	[InlineData("Elizabeth Olsen")]
	[InlineData("Emily Osment")]
	[InlineData("Frank Ocean")]
	[InlineData("Gary Oldman")]
	[InlineData("Jamie Otis")]
	[InlineData("Jerry O'Connell")]
	[InlineData("Jonathan Owens")]
	[InlineData("Kelly Osbourne")]
	[InlineData("Lamar Odom")]
	[InlineData("Mary-Kate Olsen")]
	[InlineData("Michelle Obama")]
	[InlineData("Neri Oxman")]
	[InlineData("Nick Offerman")]
	[InlineData("Ozzy Osbourne")]
	[InlineData("Rita Ora")]
	[InlineData("Ronnie Ortiz-Magro")]
	[InlineData("Rosie O'Donnell")]
	[InlineData("Sandra Oh")]
	[InlineData("Shaquille O'Neal")]
	[InlineData("Sharon Osbourne")]
	[InlineData("Shohei Ohtani")]
	[InlineData("Tatum O'Neal")]
	public void CorrectlyFormatAName(string expectedName)
	{
		var nameToBeFormatted = expectedName.ToLower();

		var actualName = NameCaseFormatter.Format(nameToBeFormatted);

		Assert.Equal(expectedName, actualName);
	}
}
