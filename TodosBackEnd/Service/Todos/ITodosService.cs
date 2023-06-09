using TodosBackEnd.Models;

namespace TodosBackEnd.Service.Todos
{
    public interface ITodosService
    {
        List<Todo> GetTodos();
        Boolean AddTodo(Todo todo);
        Boolean DelTodo(int id);
        Boolean UpdateTodo(Todo todo);
    }
}
