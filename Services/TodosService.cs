namespace ToDoList.Services;

public class TodosService
{
  private readonly TodosRepository _repo;

  public TodosService(TodosRepository repo)
  {
    _repo = repo;
  }

  public List<Todo> GetAllTodos()
  {
  List<Todo> todos = _repo.GetAllTodos();
  return todos;
  }

  internal Todo CreateTodo(Todo todoData)
  {
    Todo todo = _repo.CreateTodo(todoData);
    return todo;
  }

  internal string RemoveTodo(int todoId)
  {
    Todo todo = _repo.getById(todoId);
    if (todo == null) throw new Exception($"No todo at id:{todoId}");
    _repo.RemoveTodo(todoId);

    return $"the todo was deleted";
  }

  internal Todo UpdateTodo(Todo updateData)
  {
    Todo original = _repo.getById(updateData.Id);
    if (original == null) throw new Exception($"No todo at id:{updateData.Id}");

    original.Name = updateData.Name != null ? updateData.Name : original.Name;
    original.Description = updateData.Description != null ? updateData.Description : original.Description;
    original.Completed = updateData.Completed != null ? updateData.Completed : original.Completed;

    _repo.UpdateTodo(updateData);
    return updateData;
  }
}