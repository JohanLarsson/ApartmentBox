namespace ApartmentBox
{
    using System;
    using System.Windows;

    public class Apartment
    {
        public Apartment(int id, string title, DateTime datePublished, decimal rent, Point coords)
        {
            this.Id = id;
            this.Title = title;
            this.DatePublished = datePublished;
            this.Rent = rent;
            this.Coords = coords;
        }

        public int Id { get; private set; }
       
        public string Title { get; private set; }

        public DateTime DatePublished { get; private set; }

        public decimal Rent { get; private set; }

        public Point Coords { get; private set; }
    }
}