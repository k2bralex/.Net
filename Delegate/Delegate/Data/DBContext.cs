using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDelegate.Data.Entity;

namespace MyDelegate.Data
{
    delegate void OnAnyRead();

    delegate Student ChangeStudent(Student s);

    class DBContext
    {
        private List<Student> students = new List<Student>();

        public OnAnyRead onAnyRead;

        public void ChangeAllStudent(ChangeStudent doThis)
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i] = doThis(students[i]);
            }
        }

        #region SingleTon

        private static DBContext Instance;

        public static DBContext GetInstance()
        {
            return Instance ?? (Instance = new DBContext());
        }

        private void Seed()
        {
            students.Add(new Student() { Name = "Nikitin" });
            students.Add(new Student() { Name = "Ivanov" });
            students.Add(new Student() { Name = "Petrov" });
        }

        private DBContext()
        {
            Seed();
        }

        #endregion

        #region Manipulation with DB (CRUD)

        public IEnumerable<Student> ReadAll()
        {
            if (onAnyRead!=null) onAnyRead();
            return students;
        }

        public IEnumerable<Student> FindByName(string Name)
        {
            if (onAnyRead != null) onAnyRead();
            return students.Where(s => s.Name.StartsWith(Name, StringComparison.OrdinalIgnoreCase));
        }

        #endregion

    }
}
