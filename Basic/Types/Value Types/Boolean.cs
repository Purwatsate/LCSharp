using static System.Console;
/**
    an alias for the .NET System.Boolean structure type
*/

class BooleanExample{
    public static void MainExample(){
        // Boolean values are used to represent true or false
        bool isActive = true;
        bool isFinished = false;

        WriteLine(isActive); // True
        WriteLine(isFinished); // False

        // Nullable bool:
        bool? isAvailable = null;
        WriteLine(isAvailable); // null
    }
}
