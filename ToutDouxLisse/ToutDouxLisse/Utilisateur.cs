using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ToutDouxLisse
{
    public class Utilisateur : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _photo;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
            }
        }
        
        public string Name 
        {
            get => _name;
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            } 
        }

        public string Photo
        {
            get => _photo;
            set
            {
                _photo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Photo)));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
