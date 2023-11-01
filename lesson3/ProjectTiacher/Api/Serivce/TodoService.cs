using Api.model;

namespace Api.Serivce
{
    public class TodoService
    {
        

            public TodoService()
        {

        }
        public IEnumerable<Todo>GetData()
        {
            return DB.data;
        }

        public IEnumerable<Todo> GetData(int id)
        {
            return DB.data.Where(t=>t.Id==id).ToList();
        }

        public  bool add(Todo todo)
        {
            DB.data.Add(todo);
            return true;
        }

    }
}
