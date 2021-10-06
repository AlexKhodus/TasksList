using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace TasksList.Models
{
    class TodoModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        private bool _isDone;
        private string _textTodo;


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
