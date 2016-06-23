using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// This class contains methods to modify text strings.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// This method computes the MD5 hash of a string.
    /// </summary>
    /// <param name="input">The string to which should generate hash.</param>
    /// <returns>MD5 hashed string.</returns>
    public static string ToMd5Hash(this string input)
    {
        var md5Hash = MD5.Create();
        var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        var builder = new StringBuilder();

        for (int i = 0; i < data.Length; i++)
        {
            builder.Append(data[i].ToString("x2"));
        }

        return builder.ToString();
    }

    /// <summary>
    /// This method checks whether a string contains one of these values: "true", "ok", "yes", "1", "да".
    /// </summary>
    /// <param name="input">The string that have to be checked.</param>
    /// <returns>True if the input contains one of the specified values. Otherwise, false.</returns>
    public static bool ToBoolean(this string input)
    {
        var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
        return stringTrueValues.Contains(input.ToLower());
    }

    /// <summary>
    /// This method parses given string to short type.
    /// </summary>
    /// <param name="input">The string that should be parsed.</param>
    /// <returns>
    /// Parsed to short value.
    /// If the value cannot be parsed, the result will be 0.
    /// </returns>
    public static short ToShort(this string input)
    {
        short shortValue;
        short.TryParse(input, out shortValue);
        return shortValue;
    }

    /// <summary>
    /// This method parses given string to integer type.
    /// </summary>
    /// <param name="input">The string that should be parsed.</param>
    /// <returns>
    /// Parsed to integer value.
    /// If the value cannot be parsed, the result will be 0.
    /// </returns>
    public static int ToInteger(this string input)
    {
        int integerValue;
        int.TryParse(input, out integerValue);
        return integerValue;
    }

    /// <summary>
    /// This method parses given string to long type.
    /// </summary>
    /// <param name="input">The string that should be parsed.</param>
    /// <returns>
    /// Parsed to long value.
    /// If the value cannot be parsed, the result will be 0.
    /// </returns>
    public static long ToLong(this string input)
    {
        long longValue;
        long.TryParse(input, out longValue);
        return longValue;
    }

    /// <summary>
    /// This method parses given string to date type.
    /// </summary>
    /// <param name="input">The string that should be parsed.</param>
    /// <returns>
    /// Parsed to date value.
    /// If the value cannot be parsed, the result will be 0.
    /// </returns>
    public static DateTime ToDateTime(this string input)
    {
        DateTime dateTimeValue;
        DateTime.TryParse(input, out dateTimeValue);
        return dateTimeValue;
    }

    /// <summary>
    /// This method capitalizes the first letter in a given string.
    /// </summary>
    /// <param name="input">The string which first letter should be capitalized.</param>
    /// <returns>
    /// The string with capitalized first letter.
    /// If the input string is null or empty, result will be null or empty string.
    /// </returns>
    public static string CapitalizeFirstLetter(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        return
            input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) +
            input.Substring(1, input.Length - 1);
    }

    /// <summary>
    /// This method gets a substring from a given string between start and end string by given position.
    /// </summary>
    /// <param name="input">The string containing the characters should be extracted.</param>
    /// <param name="startString">String after which substring should be taken.</param>
    /// <param name="endString">String before which substring should be taken.</param>
    /// <param name="startFrom">
    /// Specifies the character position at which to start the search. 
    /// If it is omitted, it is assumed to be 0.
    /// </param>
    /// <returns>
    /// The substring between start and endString.
    /// </returns>
    public static string GetStringBetween(
        this string input, string startString, string endString, int startFrom = 0)
    {
        input = input.Substring(startFrom);
        startFrom = 0;
        if (!input.Contains(startString) || !input.Contains(endString))
        {
            return string.Empty;
        }

        var startPosition =
            input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
        if (startPosition == -1)
        {
            return string.Empty;
        }

        var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
        if (endPosition == -1)
        {
            return string.Empty;
        }

        return input.Substring(startPosition, endPosition - startPosition);
    }

    /// <summary>
    /// This method converts cyrillic letters from a given string to latin letters.
    /// </summary>
    /// <param name="input">The string containing cyrillic letters that should be converted to latin.</param>
    /// <returns>Converted string.</returns>
    public static string ConvertCyrillicToLatinLetters(this string input)
    {
        var bulgarianLetters = new[]
        {
            "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о",
            "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
        };
        var latinRepresentationsOfBulgarianLetters = new[]
        {
            "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
            "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
            "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
        };
        for (var i = 0; i < bulgarianLetters.Length; i++)
        {
            input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
            input = input.Replace(bulgarianLetters[i].ToUpper(),
                latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
        }

        return input;
    }

    /// <summary>
    /// This method converts latin letters from a given string to cyrillic letters.
    /// </summary>
    /// <param name="input">The string containing latin letters that should be converted to cyrillic.</param>
    /// <returns>Converted string.</returns>
    public static string ConvertLatinToCyrillicKeyboard(this string input)
    {
        var latinLetters = new[]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
            "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        var bulgarianRepresentationOfLatinKeyboard = new[]
        {
            "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
            "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
            "в", "ь", "ъ", "з"
        };

        for (int i = 0; i < latinLetters.Length; i++)
        {
            input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
            input = input.Replace(latinLetters[i].ToUpper(),
                bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
        }

        return input;
    }

    /// <summary>
    /// This method converts a given string to valid username.
    /// </summary>
    /// <param name="input">The string should be converted to valid username.</param>
    /// <returns>Valid username.</returns>
    public static string ToValidUsername(this string input)
    {
        input = input.ConvertCyrillicToLatinLetters();
        return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
    }

    /// <summary>
    /// This method converts a given string to a valid filename.
    /// </summary>
    /// <param name="input">The string should be converted to valid filename.</param>
    /// <returns>Valid filename.</returns>
    public static string ToValidLatinFileName(this string input)
    {
        input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
        return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
    }

    /// <summary>
    /// This method returns a number of characters from the beginning of a given string, 
    /// based on the specific number.
    /// </summary>
    /// <param name="input">The string containing the characters should be extracted.</param>
    /// <param name="charsCount">Number of characters should be returned.</param>
    /// <returns>The substring from the given input.</returns>
    public static string GetFirstCharacters(this string input, int charsCount)
    {
        return input.Substring(0, Math.Min(input.Length, charsCount));
    }

    /// <summary>
    /// This method gets the extension of a given filename.
    /// </summary>
    /// <param name="fileName">The filename which extension should be extracted.</param>
    /// <returns>The extension.</returns>
    public static string GetFileExtension(this string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            return string.Empty;
        }

        string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
        if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
        {
            return string.Empty;
        }

        return fileParts.Last().Trim().ToLower();
    }

    /// <summary>
    /// This method returns file content type by given extension.
    /// </summary>
    /// <param name="fileExtension">Given file extension.</param>
    /// <returns>File content type.</returns>
    public static string ToContentType(this string fileExtension)
    {
        var fileExtensionToContentType = new Dictionary<string, string>
        {
            { "jpg", "image/jpeg" },
            { "jpeg", "image/jpeg" },
            { "png", "image/x-png" },
            { "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
            { "doc", "application/msword" },
            { "pdf", "application/pdf" },
            { "txt", "text/plain" },
            { "rtf", "application/rtf" }
        };
        if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
        {
            return fileExtensionToContentType[fileExtension.Trim()];
        }

        return "application/octet-stream";
    }

    /// <summary>
    /// This method converts given string to byte array.
    /// </summary>
    /// <param name="input">The string should be converted to byte array.</param>
    /// <returns>Byte array.</returns>
    public static byte[] ToByteArray(this string input)
    {
        var bytesArray = new byte[input.Length * sizeof(char)];
        Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
        return bytesArray;
    }
}
