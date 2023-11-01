using Api.model;

namespace Api.Serivce
{
    public class TodoService
    {
            public TodoService()
            {
            }
        public IEnumerable<Missile>GetData()
        {
            return DB.mssile;
        }

        public IEnumerable<Missile> GetData(string place)
        {
            return DB.mssile.Where(t=>t.Place==place).ToList();
        }

        public  bool add(Missile missile)
        {
            DB.mssile.Add(missile);
            return true;
        }
        

    }
}
