using Microsoft.EntityFrameworkCore;
using Net7.WebApi.Persistencia;

namespace Net7.WebApi.Repositorios
{
    // Interfaz del repositorio genérico que define los métodos CRUD básicos
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll(); // Obtiene todas las entidades del tipo especificado
        T GetById(int id); // Obtiene una entidad por su ID
        void Insert(T entity); // Inserta una nueva entidad
        void Update(T entity); // Actualiza una entidad existente
        bool Delete(int id); // Elimina una entidad existente
        void SaveChanges(); // Guarda los cambios en la base de datos
    }

    // Implementación del repositorio genérico que utiliza el contexto de Entity Framework
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly Context _context; // Contexto de Entities Framework
        private DbSet<T> _dbSet; // Conjunto de entidades de la tabla específica

        public GenericRepository(Context context)
        {
            _context = context;
            _dbSet = context.Set<T>(); // Inicializa el conjunto de entidades
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

        public bool Delete(int id)
        {
            var result = GetById(id);
            if (result != null)
            {
                _dbSet.Remove(result);
                return true;    
            }

            return false;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

}
