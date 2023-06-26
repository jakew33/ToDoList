namespace ToDoList.Repositories;

public class TodosRepository
{
  private List<Todo> dbTodos;

  public TodosRepository()
  {
    this.dbTodos = new List<Todo> { };
    dbTodos.Add(new Todo(1,"Mow Lawn", "Mow the front yard", false));
    dbTodos.Add(new Todo(2,"Do Dishes", "Warsh the dishes, ya bum", false));
    dbTodos.Add(new Todo(3,"Make Bed", "Stop being lazy, make your damn bed", false));
    dbTodos.Add(new Todo(4, "Get Groceries", "If you don't want to starve, go get groceries", false));
    dbTodos.Add(new Todo(5, "Chill Out", "Congratulations, you did the bare minimum. Go take a break", false));
  }

  internal List<Todo> GetAllTodos()
  {
    return dbTodos;
  }
  internal Todo getById(int todoId)
  {
    Todo todo = dbTodos.Find(t => t.Id == todoId);
    return todo;
  }
  internal Todo CreateTodo(Todo todoData)
  {
    int lastId = dbTodos[dbTodos.Count - 1].Id;
    todoData.Id = lastId + 1;
    dbTodos.Add(todoData);
    return todoData;
  }

  internal void RemoveTodo(int todoId)
  {
    Todo todo = dbTodos.Find(t => t.Id == todoId);
    dbTodos.Remove(todo);
  }

  internal void UpdateTodo(Todo updateData)
  {
    Todo todo = getById(updateData.Id);
    todo = updateData;
  }
}