string text = "Сегодня мы углубимся в тему и выделим 4"
            + " основных группы методов, а также будем"
            + " использовать их на практике. И познакомимся"
            + " с новыми языковыми конструкциями, в"
            + " частности,  циклом.";

// string s = "qwerty"
//             0123
//s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
Console.WriteLine();

