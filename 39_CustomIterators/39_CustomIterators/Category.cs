using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _39_CustomIterators
{
    internal class Category : IEnumerable<Category>
    {
        public string Name { get; set; }
        public List<Category> Subcategories { get; set; }
        public Category(string name) => Name = name;
        public void AddSubcategory(string name) => Subcategories.Add(new Category(name));

        public IEnumerator<Category> GetEnumerator()
        {
            yield return this;
            if (Subcategories is null || Subcategories.Count == 0) yield break;
            foreach (Category category in Subcategories)
            {                
                foreach (Category item in category)
                {
                    yield return item;                    
                }                
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerable<Category> Leaves()
        {
            if (Subcategories is null || Subcategories.Count == 0)
            {
                yield return this;
                yield break;
            }

            foreach (Category category in Subcategories)
            {
                foreach (Category leaf in category.Leaves())
                {
                    yield return leaf;
                }
            }
        }

        public void AddCategory()
        {
            Console.Write("Введите уровень вложенности: ");
            int maxLevels = Logic.SafeInputInt();
            FillSubcategories(currentLevel: 1, maxLevels: maxLevels);
        }

        private void FillSubcategories(int currentLevel, int maxLevels)
        {
            if (currentLevel > maxLevels)
                return;

            string indent = new string(' ', (currentLevel - 1) * 2);

            Console.Write($"{indent}Сколько подкатегорий добавить в \"{this.Name}\"? ");
            int count = Logic.SafeInputInt();

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{indent}Введите название подкатегории в {this.Name}: ");
                string name = Logic.SafeInputString();

                Category newSubcategory = new Category(name);
                if (this.Subcategories == null)
                    this.Subcategories = new List<Category>();

                this.Subcategories.Add(newSubcategory);

                if (currentLevel < maxLevels)
                {
                    newSubcategory.FillSubcategories(currentLevel + 1, maxLevels);
                }
            }
        }

    }
}
