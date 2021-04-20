﻿using SwipeIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwipeIT.Services
{
    public class RecruiterRepo : IDataStore<Recruiter>
    {
        private static RecruiterRepo instance;

        private List<Recruiter> recruiters { get; set; }

        private RecruiterRepo()
        {
            AddDummyData();
        }

        public static RecruiterRepo GetSingleton()
        {
            if (instance == null)
            {
                instance = new RecruiterRepo();
            }
            return instance;
        }

        public List<Recruiter> GetRecruiter()
        {
            return recruiters;
        }

        public async Task<bool> AddItemAsync(Recruiter item)
        {
            recruiters.Add(item);
            return await Task.FromResult(true);
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Recruiter> GetItemAsync(int id)
        {
            return await Task.FromResult(recruiters.FirstOrDefault(s => s.ID == id));
        }

        public Task<IEnumerable<Recruiter>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Recruiter item)
        {
            throw new NotImplementedException();
        }

        private void AddDummyData()
        {
            recruiters = new List<Recruiter>
            {
                new Recruiter
                {
                    ID = 1,
                    Name = "Jef",
                    Surname = "Besos",
                    Company = "Bamazon",
                },
                new Recruiter
                {
                    ID = 2,
                    Name = "Billy",
                    Surname = "Gates",
                    Company = "Licrosoft",
                },
                new Recruiter
                {
                    ID = 3,
                    Name = "Stefaan",
                    Surname = "Jops",
                    Company = "Bapple",
                },
                new Recruiter
                {
                    ID = 4,
                    Name = "Meloen",
                    Surname = "Musk",
                    Company = "Teslaa",
                },
            };
        }

        public Task<Recruiter> GetAllItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}