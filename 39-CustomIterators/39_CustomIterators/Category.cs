using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace _39_CustomIterators
{
    internal class Category : IEnumerable<Category>
    {
        public string Name { get; set; }
        public List<Category> Subcategories = new List<Category>();
        public Category(string name) => Name = name;
        public void AddSubcategory(string name) => Subcategories.Add(new Category(name));

        public IEnumerator<Category> GetEnumerator()
        {
            if (Subcategories.Count == 0)
            {
                Console.Write("  - ");
                yield return this;
                yield break;
            }
            else
            {
                Console.Write("- ");
                yield return this;
            }

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
            if (Subcategories.Count == 0)
            {
                Console.Write("- ");
                yield return this;
                yield break;
            }

            foreach (Category category in Subcategories)
            {
                foreach (Category leaf in category.Leaves()) yield return leaf;
            }
        }

        public static Category LoadFromTxt(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int i = 0;
            return Parse(lines, ref i, 0);
        }

        private static Category Parse(string[] lines, ref int i, int minIndent)
        {
            int indent = lines[i].Length - lines[i].TrimStart(' ').Length;
            if (indent < minIndent) return null;

            Category node = new Category(lines[i].Trim());
            i++;
            while (i < lines.Length && Parse(lines, ref i, indent + 1) is Category child) node.Subcategories.Add(child);
            return node;
        }

        public void FillSubcategories(int currentLevel, int maxLevels)
        {
            if (currentLevel > maxLevels)
                return;

            string indent = "";
            for (int i = 0; i < (currentLevel - 1) * 2; i++) indent += " ";

            Console.Write($"{indent}Сколько подкатегорий добавить в \"{Name}\"? ");
            int count = Logic.SafeInputInt();

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{indent}Введите название подкатегории в \"{Name}\": ");
                string name = Logic.SafeInputString();

                Category newSubcategory = new Category(name);
                if (Subcategories == null)
                    Subcategories = new List<Category>();

                Subcategories.Add(newSubcategory);

                if (currentLevel < maxLevels)
                {
                    newSubcategory.FillSubcategories(currentLevel + 1, maxLevels);
                }
            }
        }

        public void PrintTree(string indent = "", bool isLast = true)
        {
            Console.Write(indent);

            if (indent.Length > 0)
            {
                Console.Write(isLast ? "└── " : "├── ");
                indent += isLast ? "    " : "│   ";
            }
            else
            {
                indent = " ";
            }
            Console.WriteLine(Name);

            if (Subcategories is null) return;

            for (int i = 0; i < Subcategories.Count; i++)
            {
                bool lastChild = (i == Subcategories.Count - 1);
                Subcategories[i]?.PrintTree(indent, lastChild);
            }
        }
    }
}
