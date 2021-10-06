using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;

namespace TasksList.Models
{
    class TodoModel: INotifyPropertyChanged
    {
        private bool _isDone;
        private string _textTodo;

        //[JsonProperty(PropertyName)]   допилить имена полей в файлем camelcase

        public event PropertyChangedEventHandler PropertyChanged;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        


        public bool IsDone
        {
            get { return _isDone; }
            set
                {
                    if (_isDone == value)
                        return;
                    _isDone = value;
                    OnPropertyChanged("IsDone");
                }
        }
        public string TextTodo
        {
            get { return _textTodo; }
            set
                {
                    if (_textTodo == value)
                        return;
                    _textTodo = value;
                    OnPropertyChanged("TextTodo");
                }

        }
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
