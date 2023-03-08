Console.WriteLine("Введите числа через запятую: ");
string? input = Console.ReadLine();
int[] numbers = FillArray(input);

int Condition(int[] Numbers)
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if(Numbers[i] > 0 ) count ++; 
  }
  return count;
}
Console.WriteLine($"Введено чисел больше нуля:{Condition(numbers)}");

int[] FillArray(string input)
{
    int countNumbers = GetCountNumbers(input);
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            substring += input[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;
        }
    }
    if(input[input.Length - 1] != ',')
        numbers[indexNumber] = Convert.ToInt32(substring);
    return numbers;
}
int GetCountNumbers(string input) 
{
    int count;
    if(input[input.Length - 1] == ',')
        count = 0;
    else
        count = 1;

    for(int i = 0; i < input.Length; i++)
    {
        if(input[i] == ',')
            count++;
    }
    return count;
}
