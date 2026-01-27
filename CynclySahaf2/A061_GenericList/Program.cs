namespace A061_GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Trainee> trainees = new List<Trainee>();
            Trainee Sahaf = new Trainee()
            {
                TraineeId = 25,
                TraineeName = "Sahaf",
                Points = 50
            };

            trainees.Add(Sahaf);

            foreach (Trainee trainee in trainees)
            {

                Console.WriteLine($"ID :{trainee.TraineeId}, Name: {trainee.TraineeName},Points :{trainee.Points}");
            }
        }
    }
}
