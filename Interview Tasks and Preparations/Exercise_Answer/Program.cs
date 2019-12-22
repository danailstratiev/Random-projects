using System;

namespace ExerciseAnswer
{
    public class Answer
    {
        /// Executes the service with the given​​​​​​‌​​​‌​‌​​​‌‌‌​‌‌‌‌‌‌​​​‌‌ connection.
        public void Run(Service s, Connection c)
        {
            s.SetConnection(c);
            try
            {
                s.Execute();

            }
            catch (Exception)
            {

                c.Rollback();
            }
            finally
            {
                c.Commit();
            }
        }
    }

    /// Definition of a service
    public interface Service
    {
        void Execute();
        void SetConnection(Connection c);
    }

    /// Definition of a connection
    public interface Connection
    {
        void Commit();
        void Rollback();
        void Close();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
