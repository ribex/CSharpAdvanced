using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
//            try
//            {
//                var calculator = new Calculator();
//                var result = calculator.Divide(5, 0);
//            }
//
//            catch (DivideByZeroException ex)
//            {
//
//            }
//
//            catch (ArithmeticException ex)
//            {
//
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Sorry, an unexpected error occurred.");
//            }
//            finally
//            {
//                IDisposable
//            }

//            StreamReader streamReader = null;
//
//            try
//            {
//                streamReader = new StreamReader(@"C:\file.zip");
//                var content = streamReader.ReadToEnd();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Sorry, an unexpected error occurred.");
//            }
//            finally
//            {
//                if (streamReader != null)
//                {
//                    streamReader.Dispose();
//
//                }
//            }



//            try
//            {
//                using (var streamReader = new StreamReader(@"C:\file.zip"))
//                {
//                var content = streamReader.ReadToEnd();
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Sorry, an unexpected error occurred.");
//            }

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("user");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
