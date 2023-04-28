
try
{
    ClassA.ProcessA();
}
catch (Exception ex)
{
    Console.WriteLine("Some more processing...");
    Console.WriteLine(ex.Message);
}

Console.WriteLine("The end");

internal class ClassA
{
    public static void ProcessA()
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception)
        {
            Console.WriteLine("Processing the exception...");
            throw;
        }
    }
}
