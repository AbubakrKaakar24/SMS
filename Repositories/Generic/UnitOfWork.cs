﻿using Entities.Data;
using RepositoryContracts;
using RepositoryContracts.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Generic
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        //private readonly ISurveyRepository SurveyRepository;
        // private IPatientTypeRepository _patientTypeRepository;


        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            SurveyRepository = new SurveyRepository(db);
            LanguageRepository = new LanguageRepository(db);
            SurveyTranslationRepository = new SurveyTranslationRepository(db);

            // ProvinceRepository = new ProvinceRepository(db);
        }

        public ISurveyRepository SurveyRepository {get; private set;}
        public ILanguageRepository LanguageRepository {get; private set;}
        public ISurveyTranslationRepository SurveyTranslationRepository { get; }

        public async Task SaveChanges(CancellationToken cancellationToken)
        {
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
