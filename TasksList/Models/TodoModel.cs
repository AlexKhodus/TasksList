using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksList.Models
{
    class TodoModel
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;
        private bool _isDone;
        private string _textTodo;

        public string TextTodo
        {
            get { return _textTodo; }
            set { _textTodo = value; }
        }

        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }
    }
}
