# RegexPro Library

RegexPro is a lightweight, developer-friendly C# library designed to simplify working with regular expressions. It provides a collection of prebuilt methods for common regex tasks like matching, validation, replacement, extraction, and splitting, so you can focus on your project instead of wrestling with regex syntax.

## 📦 Installation
You can easily add RegexPro to your project via NuGet.

### Using the Package Manager Console:
Install-Package RegexProLibrary

### Using the .NET CLI:
dotnet add package RegexProLibrary

## 📖 Methods Overview
RegexPro provides the following methods to streamline regex operations:

### 1. `MatchPattern`
- **Description**: Finds all matches for a regex pattern in a given input string and returns them as a list of strings.
- **Parameters**:
  - `string input`: The string to search in.
  - `string pattern`: The regex pattern to match.
- **Returns**: A list of strings containing all matches.

### 2. `IsValid`
- **Description**: Validates whether a given input string matches a regex pattern.
- **Parameters**:
  - `string input`: The string to validate.
  - `string pattern`: The regex pattern to validate against.
- **Returns**: A boolean indicating if the string matches the pattern.

### 3. `ExtractGroups`
- **Description**: Extracts named or indexed groups from the input string based on a regex pattern.
- **Parameters**:
  - `string input`: The string to search in.
  - `string pattern`: The regex pattern with groups to extract.
- **Returns**: A dictionary where the keys are group names (or indices) and the values are the corresponding matches.

### 4. `ReplacePattern`
- **Description**: Replaces all matches of a regex pattern in the input string with a specified replacement string.
- **Parameters**:
  - `string input`: The string to process.
  - `string pattern`: The regex pattern to replace.
  - `string replacement`: The string to replace matches with.
- **Returns**: A new string with the pattern replaced.

### 5. `SplitString`
- **Description**: Splits the input string into parts based on the regex pattern.
- **Parameters**:
  - `string input`: The string to split.
  - `string pattern`: The regex pattern to use as the delimiter.
- **Returns**: A list of strings resulting from the split.

## 🔧 Why Use RegexPro?
- **Simplified API**: RegexPro abstracts complex regex logic into intuitive methods.
- **Time-Saving**: Cuts down development time by providing ready-to-use methods.
- **Error Handling**: Built-in validation ensures regex patterns are processed safely and effectively.
- **Versatile**: Includes a wide range of regex operations, suitable for various use cases.

## ❤️ Support and Contributions
If you find RegexPro helpful, please consider:
- Giving this repository a ⭐ on GitHub.
- Opening issues or feature requests to improve the library.

Contributions are always welcome! Feel free to fork the repository, make changes, and submit a pull request.
