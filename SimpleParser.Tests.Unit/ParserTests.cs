using FluentAssertions;
using System;
using TestExercise_SimpleParser;
using Xunit;

namespace SimpleParser.Tests.Unit
{
	public class ParserTests
	{
		[Fact]
		public void Parse_Should_Throw_Argument_Exception_When_Separator_Is_Null_Or_Empty()
		{
			var input = "Red, Green, Blue";
			var separator = "";

			var parserClass = () => Parser.Parse(input, separator);

			parserClass.Should().Throw<ArgumentException>();
		}

		[Fact]
		public void Parse_Should_Return_Empty_When_Input_Is_Null_Or_Empty()
		{
			string input = null;
			string separator = ",";

			var result = Parser.Parse(input, separator);

			result.Should().BeEmpty();
		}

		[Fact]
		public void Parse_Should_Return_String_Array_With_Valid_Parameters()
		{
			var input = "Red, Green, Blue";
			var seperator = ", ";

			var result = Parser.Parse(input, seperator);

			result.Should().BeOfType<string[]>();
		}
	}
}