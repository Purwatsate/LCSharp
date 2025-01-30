

class ConversionExample
{

    //  Implicit Conversions (Safe & Lossless)
    // Smaller → Larger (No risk of overflow)
    static void ImplicitConversionsExample()
    {
        int a = 100;
        long b = a;  // Implicit conversion (int → long)
        float c = a; // Implicit conversion (int → float)
    }


    // Explicit Conversions (Casting Required)
    // may cause data loss and require a cast
    static void ExplicitConversionsExample()
    {
        double x = 9.7;
        int y = (int)x; // Explicit conversion (double → int) truncates decimals
    }

}
