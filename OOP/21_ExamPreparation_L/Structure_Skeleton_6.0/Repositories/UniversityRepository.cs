﻿using System.Collections.Generic;
using System.Linq;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Repositories;

public class UniversityRepository : IRepository<IUniversity>
{
    private List<IUniversity> models;

    public UniversityRepository()
    {
        models = new List<IUniversity>();
    }

    public IReadOnlyCollection<IUniversity> Models
        => models.AsReadOnly();


    public void AddModel(IUniversity model)
    {
        University university = new University(models.Count + 1, model.Name, model.Category, model.Capacity, model.RequiredSubjects.ToList());
        models.Add(university);
    }

    public IUniversity FindById(int id)
        => models.FirstOrDefault(m => m.Id == id);

    public IUniversity FindByName(string name)
        => models.FirstOrDefault(m => m.Name == name);
}
