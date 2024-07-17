// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом,
//    как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Печатает массив:
void PrintStringArray(string[] Array)
{
    for (int i = 0; i < Array.Length; ++i)
    {
        if (i == Array.Length - 1)
        {
            System.Console.Write($"{Array[i]}\n");
            return;
        }
        System.Console.Write($"{Array[i]}, ");
    }
}

// Заполняет массив, исходя из его размера, согласно пользовательскому вводу:
void FeelArray(string[] Array)
{
    System.Console.WriteLine("Введите слова для заполнения:");
    for (int i = 0; i < Array.Length; ++i)
    {
        string input = Console.ReadLine();
        Array[i] = input;
        System.Console.WriteLine($"Вы ввели {i + 1} слов(о)(а)");
    }
}

//Выясняет сколько слов с тремя символами и меньше, возвращает массив слов:
string[] ThreeOrLess(string[] Array)
{
    int resArraySizeCount = 0;

    for (int i = 0; i < Array.Length; ++i)
    {
        if (Array[i].Length <= 3)
        {
            ++resArraySizeCount;
        }
    }
    string[] ResultArray = new string[resArraySizeCount];
    int resIndex = 0;
    for (int i = 0; i < Array.Length; ++i)
    {
        if (Array[i].Length <= 3)
        {
            ResultArray[resIndex] = Array[i];
            ++resIndex;
        }
    }

    return ResultArray;
}

System.Console.Write("Введите, сколько слов вы хотите обработать: ");
string input = Console.ReadLine();
int WordsNumber = Convert.ToInt32(input);
while (WordsNumber <= 0)
{
    System.Console.WriteLine("Введите число больше нуля(0):");
    input = Console.ReadLine();
    WordsNumber = Convert.ToInt32(input);
};

string[] SourceArray = new string[WordsNumber];

FeelArray(SourceArray);
System.Console.WriteLine("Введённые вами слова:");
PrintStringArray(SourceArray);
System.Console.WriteLine($"Из них с тремя и менее букв, {(ThreeOrLess(SourceArray)).Length}:");
PrintStringArray(ThreeOrLess(SourceArray));