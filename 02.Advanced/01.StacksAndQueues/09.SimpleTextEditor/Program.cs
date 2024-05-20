using System;
using System.Text;
using System.Collections.Generic;

var operationCount = int.Parse(Console.ReadLine());
Stack<string> previousTextState = new();
StringBuilder text = new();
for (int i = 0; i < operationCount; i++)
{
    var tokens = Console.ReadLine().Split(' ');
	switch (tokens[0])
	{
		case "1":
            previousTextState.Push(text.ToString());
            text.Append(tokens[1]);
            break;  
        case "2":
            previousTextState.Push(text.ToString());
            var count = int.Parse(tokens[1]);
            text.Remove(text.Length - count, count);
            break;
        case "3":
            Console.WriteLine(text[int.Parse(tokens[1]) - 1]);
            break;
        case "4":
            text.Clear();
            text.Append(previousTextState.Pop());
			break;
		default:
			break;
	}
}