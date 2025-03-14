using System.Data;

namespace DAL_SOF205
{
    abstract public class SystemDAL<EntityType, KeyType>
    {
        abstract public void insert(EntityType entity);
        abstract public void update(EntityType entity);
        abstract public void delete(KeyType id);
        abstract public EntityType selectById(KeyType id);
        abstract public List<EntityType> selectAll();
        abstract public List<EntityType> selectBySql(String sql, List<Object> args, CommandType cmdType = CommandType.Text);
    }
}
