using CalculatorClassExplicitObject.Models;

namespace CalculatorClassExplicitObject.Repositories
{
    public class TraineesRepository
    {
        List<Trainee> trainees = new List<Trainee>()
        { 
            new Trainee
            {
                TraineeName = "Sahaf",
                Location = "Calicut"
            },
            new Trainee
            {
                TraineeName = "Rithin",
                Location = "Pathanamthitta"
            }
};

public List<Trainee> GetTrainees()
        {
            Trainee ashwintrainee = new Trainee();
            ashwintrainee.TraineeName = "Ashwin";
            ashwintrainee.Location = "Kottayam";
            trainees.Add(ashwintrainee);

            Trainee adijithTrainee = new Trainee()
            {
                TraineeName = "Adijith",
                Location = "Adimali"
            };
            trainees.Add(adijithTrainee);

            return trainees;
        }
    }
}
