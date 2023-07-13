using System.Collections.Generic;
using System.Linq;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories;

public class StudentRepository : IRepository<IStudent>
{
    private List<IStudent> models;

    public StudentRepository()
    {
        models = new List<IStudent>();
    }

    public IReadOnlyCollection<IStudent> Models
        => models.AsReadOnly();


    public void AddModel(IStudent model)
    {
        Student student = new Student(models.Count + 1, model.FirstName, model.LastName);
        models.Add(student);
    }

    public IStudent FindById(int id)
        => models.FirstOrDefault(m => m.Id == id);

    public IStudent FindByName(string name)
    {
        string[] splitted = name.Split(" ");
        string firstName = splitted[0];
        string lastName = splitted[1];

        return models.FirstOrDefault(m => m.FirstName == firstName && m.LastName == lastName);
    }
}
