﻿using SwipeIT.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace SwipeIT.ViewModels
{
    [QueryProperty(nameof(DeveloperID), nameof(DeveloperID))]
    public class LikeOverviewDetailViewModel : BaseViewModel
    {
        private Developer selectedDeveloper;

        public Developer SelectedDeveloper
        {
            get { return selectedDeveloper; }
            set
            {
                selectedDeveloper = value;
                OnPropertyChanged(nameof(SelectedDeveloper));
            }
        }

        private int developerID;

        public int DeveloperID
        {
            get { return developerID; }
            set
            {
                developerID = value;
                LoadSelectedDeveloper(value);
            }
        }

        public Command SendMailCommand => new Command(SendMail);

        public LikeOverviewDetailViewModel()
        {
            SelectedDeveloper = new Developer();
        }

        private async void LoadSelectedDeveloper(int id)
        {
            try
            {
                var dev = await DeveloperRepo.GetItemAsync(id);
                SelectedDeveloper = dev;
            }
            catch (Exception)
            {
                //Debug
            }
        }

        private void SendMail()
        {
            Launcher.OpenAsync(new Uri($"mailto:{SelectedDeveloper.Email}?Subject=Hello%20again"));
        }
    }
}