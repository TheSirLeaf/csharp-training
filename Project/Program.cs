//make a simple loop that reads something and writes a mathematical operation
int readThis = 0;

for (int i = 1; i <= 10; i++)
{
    readThis = int.TryParse(Console.ReadLine(), out readThis) ? readThis : 0;
    Console.WriteLine(readThis * readThis);
}