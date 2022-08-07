
string [] array = {"hello", "2", "world", ":-)"};
string [] ShowArrayOfShortWords (string [] array){

     string[] newArray = new string[array.Length];
     for (int i=0; i<array.Length; i++)
     {      
        if(array[i].Length<=3)
        {
            newArray[i]=array[i];
        }
     }
     return newArray;
}

void Print(string [] array){
    for (int i=0; i<array.Length; i++){
        Console.WriteLine(array[i]);
    }
    Console.WriteLine();
}



Print(ShowArrayOfShortWords(array));
// Print(array);