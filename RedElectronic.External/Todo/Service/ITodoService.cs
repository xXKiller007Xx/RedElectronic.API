namespace RedElectronic.External.Todo.Service
{
    public interface ITodoService
    {
        /// <summary>
        /// Get all todo
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Model.Todo>> GetAllTodos();
    }
}
