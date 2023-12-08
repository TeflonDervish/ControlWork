string[] FilterStrings(string[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i].Length <= 3){
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < arr.Length; i++){
        if (arr[i].Length <= 3){
            result[index] = arr[i];
            index++;
        }
    }

    return result;
}

string[] originalArray = { "apple", "banana", "cat", "dog", "elephant" };
string[] filteredArray = FilterStrings(originalArray);

Console.WriteLine("Исходный массив строк: {0}", string.Join(", ", originalArray));
Console.WriteLine("Отфильтрованный массив строк (длина <= 3 символов): {0}", string.Join(", ", filteredArray));

