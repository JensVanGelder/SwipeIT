﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SwipeIT.Models
{
    public abstract class User : Account
    {
        private string firstName;

        [MaxLength(50)]
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        private string lastName;

        [MaxLength(50)]
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private string image;

        public string Image
        {
            get
            {
                return string.IsNullOrEmpty(image) ? "Icon01.png" : image;
            }
            set
            {
                image = value;
                OnPropertyChanged(nameof(Image));
            }
        }

        private int yearsOfExperience;

        public int YearsOfExperience
        {
            get => yearsOfExperience;
            set
            {
                yearsOfExperience = value;
                OnPropertyChanged(nameof(yearsOfExperience));
            }
        }

        private ObservableCollection<Skill> skills;

        public ObservableCollection<Skill> Skills
        {
            get => skills;
            set
            {
                skills = value;
                OnPropertyChanged(nameof(Skills));
            }
        }

        private ObservableCollection<AvailableLocation> availableLocations;

        public ObservableCollection<AvailableLocation> AvailableLocations
        {
            get => availableLocations;
            set
            {
                availableLocations = value;
                OnPropertyChanged(nameof(AvailableLocations));
            }
        }

        public User()
        {
            Skills = new ObservableCollection<Skill>();
            AvailableLocations = new ObservableCollection<AvailableLocation>();
        }
    }
}