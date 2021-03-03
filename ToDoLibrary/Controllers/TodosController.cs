using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoLibrary.Models;

namespace ToDoLibrary.Controllers {
	public class TodosController {
		private readonly TodoDbContext _context;

		public async Task<IEnumerable<Todo>> ListAllToDos() {
			return await _context.Todos.ToListAsync();
		}

		public async Task<Todo> GetByPK(int id) {
			return await _context.Todos.FindAsync(id);
		}

		public async Task<Todo> Create(Todo todo) {
			if (todo == null) {
				throw new Exception("ERROR: todo cannot be null!");
			}
			if (todo.Id != 0) {
				throw new Exception("ERROR: todo.Id must be 0!");
			}
			_context.Todos.Add(todo);
			var rowAffected = await _context.SaveChangesAsync();
			if (rowAffected != 1) {
				throw new Exception("ERROR: todo not created");
			}
			return todo;
		}

		public async Task Update(Todo todo) {
			if (todo == null) {
				throw new Exception("ERROR: todo cannot be null!");
			}
			if (todo.Id <= 0) {
				throw new Exception("ERROR: todo.Id must be greater than 0!");
			}
			_context.Entry(todo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			var rowAffected = await _context.SaveChangesAsync();
			if (rowAffected != 1) {
				throw new Exception("ERROR: change failed!");
			}
			return;
		}

		public async Task<Todo> Delete(int id) {
			var todo = _context.Todos.Find(id);
			if (todo == null) {
				return null;
			}
			_context.Todos.Remove(todo);
			var rowsAffected = await _context.SaveChangesAsync();
			if (rowsAffected != 1) {
				throw new Exception("ERROR: Remove Failed");
			}
			Console.WriteLine($"ToDo DELETED!");
			return todo;
		}

		public TodosController() {
			_context = new TodoDbContext();
		}

	}
}
