using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoLibrary.Models;

namespace ToDoLibrary.Controllers {
	public class TodosController {
		private readonly TodoDbContext _context;

		public async Task<IEnumerable<Todo>> GetAll() {
			return await _context.Todos.ToListAsync();
		}

		public async Task<Todo> GetByPK(int id) {
			return await _context.Todos.FindAsync(id);
		}

		public TodosController() {
			_context = new TodoDbContext();
		}
	}
}
