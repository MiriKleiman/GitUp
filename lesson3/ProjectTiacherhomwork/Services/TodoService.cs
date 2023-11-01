using model;
//using Services;
namespace Serivce
{
    public class TodoService
    {
        readonly dataList _DB;
      
        public TodoService(dataList data)
        {
            _DB = data;
        }
        public IEnumerable<Missile>GetData()
        {
            return dataList.mssile;
        }

        public IEnumerable<Missile> GetData(string place)
        {
            return dataList.mssile.Where(t=>t.Place==place).ToList();
        }

        public  bool add(Missile missile)
        {
            dataList.mssile.Add(missile);
            return true;
        }
        

    }
}
