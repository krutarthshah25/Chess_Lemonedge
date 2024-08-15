// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

//Layout of keyboard can be modified as per the requirement
//Layout1
string[,] keypad = new string[4, 3] {{"1","2","3"},
                                      {"4","5","6"},
                                      {"7","8","9"},
                                      {"*","0","#"} };
//Layout2
//string[,] keypad = new string[3, 4] {{"1","2","3","4"},
//                                  {"5","6","7","8"},
//                                  {"9","*","0","#"} };

string? strNumber;
int number;
Console.WriteLine("YOUR PHONE KEYBOARD");
Console.WriteLine("___________________");
for (int i = 0; i < keypad.GetLength(0); i++)
{
    string printKeyboard = "     ";
    for (int j = 0; j < keypad.GetLength(1); j++)
    {
        printKeyboard += keypad[i, j].ToString() + "  ";
    }
    Console.WriteLine(printKeyboard);
}
Console.WriteLine("___________________");
Console.WriteLine("Enter single number");
strNumber = Console.ReadLine();

try
{
    //this will check the length of the input string and valid number
    if (strNumber == null || strNumber.Length > 1 || !int.TryParse(strNumber, out number))
    {
        Console.WriteLine("Enter valid single number");
        return;
    }
    //number = Convert.ToInt32(strNumber);

    //this will check if number is not 0 or 1
    if (number == 0 || number == 1)
    {
        Console.WriteLine("Number can not start with 0 or 1");
        return;
    }


    int numberCount = 0;
    string finalNumber = string.Empty;
    //logic to get 7 digit number, this can be modified any
    while (numberCount < clsConstants.PhoneNumberLength)
    {
        if (numberCount == clsConstants.CharacterPlaceInPhoneNuber)
        {
            finalNumber += clsConstants.CharacterInPhoneNuber;
        }
        finalNumber += number.ToString();
        numberCount++;
        number = clsNextNumber.getNextNumberRook(number, keypad);

    }
    Console.WriteLine("Your possible " + clsConstants.PhoneNumberLength + " digit number is " + finalNumber);
    Console.WriteLine("Press any key to exit");
    Console.ReadLine();

}
catch (Exception ex)
{

    Console.WriteLine("Error:" + ex.Message);
}