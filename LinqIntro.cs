using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class LinqIntro
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Scores { get; set; }
        public void execute()
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(
                new LinqIntro
                {
                    FirstName = "Svetlana",
                    LastName = "Omelchenko",
                    Scores = new int[] { 98, 92, 81, 60 }
                });
            arrList.Add(
                new LinqIntro
                {
                    FirstName = "Claire",
                    LastName = "O’Donnell",
                    Scores = new int[] { 75, 84, 91, 39 }
                });
            arrList.Add(
                new LinqIntro
                {
                    FirstName = "Sven",
                    LastName = "Mortensen",
                    Scores = new int[] { 88, 94, 65, 91 }
                });
            arrList.Add(
                new LinqIntro
                {
                    FirstName = "Cesar",
                    LastName = "Garcia",
                    Scores = new int[] { 97, 89, 85, 82 }
                });

            var query = from LinqIntro student in arrList
                        where (student.Scores.Sum()/ student.Scores.Count())> 80
                        select student;
            
            Console.WriteLine("Students who got above 80% scores are - ");
            foreach (LinqIntro s in query)
                Console.WriteLine(s.LastName + ": " + s.Scores.Sum()/s.Scores.Length);
        }
    }
}
