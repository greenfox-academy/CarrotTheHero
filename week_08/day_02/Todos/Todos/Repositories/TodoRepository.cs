﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todos.Entities;
using Todos.Models;

namespace Todos.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public List<Todo> GetAll()
        {
            return TodoContext.Todoes.ToList();
        }

        public void DeleteTodo(int id)
        {
            Todo deletedTodo = TodoContext.Todoes.FirstOrDefault(x => x.Id == id);
            TodoContext.Todoes.Remove(deletedTodo);
            TodoContext.SaveChanges();
        }

        public void AddTodo(string title)
        {
            var todo = new Todo()
            {
                Title = title,
                IsDone = false,
                IsUrgent = false,
            };

            TodoContext.Todoes.Add(todo);
            TodoContext.SaveChanges();
        }

        public Todo Updating(int id)
        {
            return TodoContext.Todoes.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateTodo(Todo todo)
        {
            TodoContext.Todoes.Update(todo);
            TodoContext.SaveChanges();

        }
    }
}
