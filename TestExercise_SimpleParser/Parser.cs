namespace TestExercise_SimpleParser
{
	public class Parser
	{
		public static string[] Parse(string input, string separator)
		{
			if (string.IsNullOrEmpty(input))
				return Array.Empty<string>();

			if (string.IsNullOrEmpty(separator))
				throw new ArgumentException($"'{nameof(separator)}' cannot be null or empty.");

			var splitedInput = input.Split(separator);
			return splitedInput;
		}
	}
}