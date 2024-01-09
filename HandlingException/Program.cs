//Console.WriteLine("Hello, OS");

namespace HandlingException
{
    class Program
    {
        static void Main(string[] args)
        {
            //runtime error
            //Always Code Defensively
            try
            {
                string content = File.ReadAllText(@"C:\OS\example.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem. Check file name.");
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem. Check directory name.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(ex.Message);
                //throw;
            }
            finally 
            {
                // Code to finalize
                // setting object to null
                // closing database connection
                Console.WriteLine("Closing Application....");
            }
        }
    }
}
