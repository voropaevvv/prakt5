using System;
class MainClass
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть рядок: ");
        string word = Console.ReadLine(); // зчитуємо рядок з клавіатури
        int pos1 = -1, pos2 = -1; // початкові значення позицій

        // перебираємо всі пари символів у рядку
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                if (word[i] == word[j])
                {
                    pos1 = i;
                    pos2 = j;
                    break; // якщо знайдено однакові символи, виходимо з циклів
                }
            }
            if (pos1 != -1 && pos2 != -1)
            { // якщо знайдено однакові символи, виходимо з циклів
                break;
            }
        }

        // виводимо результат
        if (pos1 != -1 && pos2 != -1)
        {
            Console.WriteLine($"У слові '{word}' знайдені однакові літери '{word[pos1]}' на позиції {pos1 + 1} та '{word[pos2]}' на позиції {pos2 + 1}.");
        }
        else
        {
            Console.WriteLine($"У слові '{word}' немає двох однакових літер.");
        }
    }
}

