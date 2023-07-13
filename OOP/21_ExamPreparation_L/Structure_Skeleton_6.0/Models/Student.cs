﻿using System;
using System.Collections.Generic;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Utilities.Messages;

namespace UniversityCompetition.Models;

public class Student : IStudent
{
    public Student(int studentId, string firstName, string lastName)
    {
        Id = studentId;
        FirstName = firstName;
        LastName = lastName;

        coveredExams = new List<int>();
    }
    private int id;

    public int Id
    {
        get { return id; }
        private set { id = value; }
    }



    private string firstName;

    public string FirstName
    {
        get { return firstName; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
            }

            firstName = value;
        }
    }
    private string lastName;

    public string LastName
    {
        get { return lastName; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
            }

            lastName = value;
        }
    }

    private List<int> coveredExams;

    public IReadOnlyCollection<int> CoveredExams
        => coveredExams.AsReadOnly();

    private IUniversity university;

    public IUniversity University
    {
        get { return university; }
        private set { university = value; }
    }


    public void CoverExam(ISubject subject)
        => coveredExams.Add(subject.Id);

    // is that right?
    public void JoinUniversity(IUniversity university)
        => this.university = university;

}
