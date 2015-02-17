namespace ApartmentBox
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows;

    using ApartmentBox.Annotations;

    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Apartment> apartments = new ObservableCollection<Apartment>();

        private Apartment selectedApartment;

        public ViewModel()
        {
            apartments.Add(new Apartment(1, "Kool place", new DateTime(2015, 05, 17), 860, new Point(150, 200)));
            apartments.Add(new Apartment(1, "Expensive place", new DateTime(2015, 05, 16), 1100, new Point(00, 400)));
            apartments.Add(new Apartment(1, "Tent", new DateTime(2015, 05, 14), 260, new Point(350, 00)));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Apartment> Apartments
        {
            get
            {
                return this.apartments;
            }
            set
            {
                this.apartments = value;
            }
        }

        public Apartment SelectedApartment
        {
            get
            {
                return this.selectedApartment;
            }
            set
            {
                if (Equals(value, this.selectedApartment))
                {
                    return;
                }
                this.selectedApartment = value;
                this.OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
