using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoLibrary.Models;

namespace ToDoLibrary.Controllers {
	class CategoriesController {
		private readonly TodoDbContext _context;

		public async Task<IEnumerable<Category>> GetAll() {
			return await _context.Categories.ToListAsync();
		}

		public async Task<Category> GetByPK(int id) {
			return await _context.Categories.FindAsync(id);
		}

		public CategoriesController() {
			_context = new TodoDbContext();
		}

	}
}
