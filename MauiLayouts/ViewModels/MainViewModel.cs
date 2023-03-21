using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiLayouts.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public DateTime AppPublished { get; set; } = new DateTime(2022, 4, 20);

        private string surName;

        public string SurName
        {
            get => surName;
            set
            {
                if (surName == value)
                    return;

                surName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        private string lastName;

        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName == value)
                    return;

                lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayName));
            }
        }

        public string DisplayName => $"Name: {surName} {lastName}";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
