using RedElectronic.Util.Util;

namespace RedElectronic.External.Todo.Service
{
    public class TodoService : ITodoService
    {
        public async Task<IEnumerable<Model.Todo>> GetAllTodos()
        {
            var res = await HttpClientHelper.GetAsync<IEnumerable<Model.Todo>>("https://jsonplaceholder.typicode.com/todos");
            return res;
        }
    }
}
