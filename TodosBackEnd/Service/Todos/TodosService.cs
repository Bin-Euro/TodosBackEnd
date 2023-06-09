using TodosBackEnd.Data;
using TodosBackEnd.Models;

namespace TodosBackEnd.Service.Todos
{
    public class TodosService : ITodosService
    {
        private readonly TodosDbContext _dbContext;

        public TodosService(TodosDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool AddTodo(Todo todo)
        {
            _dbContext.Todos.Add(todo);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DelTodo(int id)
        {
            Todo todo = _dbContext.Todos.Find(id);
            _dbContext.Todos.Remove(todo);
            _dbContext.SaveChanges();
            return true;
            
        }

        public List<Todo> GetTodos()
        {
            return _dbContext.Todos.OrderByDescending(x=>x.Id).ToList();
        }

        public bool UpdateTodo(Todo todo)
        {
            _dbContext.Todos.Update(todo);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
