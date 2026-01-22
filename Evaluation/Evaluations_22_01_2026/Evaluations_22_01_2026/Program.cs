using MockTest1;

namespace Evaluations_22_01_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainee trainee = new Trainee()
            {
                TraineeName = "Sahaf",
                TraineeId = 8,
                Points = 50
            };

            Console.WriteLine($"The Details are : Name : {trainee.TraineeName},id : {trainee.TraineeId}, Points :{trainee.Points}" );
        }
    }
}
