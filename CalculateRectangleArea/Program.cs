class Program
{
    static void Main()
    {
        
        int width = int.Parse(Console.ReadLine());

       
        int length = int.Parse(Console.ReadLine());

        int area = width * length;
        Console.WriteLine(area);
    }

    static int CalculateRectangleArea(int width, int length)
    {
        return width * length;
    }
}